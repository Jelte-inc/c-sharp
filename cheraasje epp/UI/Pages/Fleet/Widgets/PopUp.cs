using CheraasjeEpp.Data;
using CheraasjeEpp.Models.Entities;
using CheraasjeEpp.Models.Filters;

namespace CheraasjeEpp.UI.Pages.FleetWidgets
{
    public partial class PopUp : Form
    {
        private readonly DataManager dataManager = new();
        private readonly string filter;

        public event Action<List<Car>>? CarsChanged;

        private const string NoFilterText = "<No filter>";
        private const decimal PriceStep = 10000;

        public PopUp(string filter)
        {
            InitializeComponent();

            this.filter = filter;
            chooseLabel.Text = $"Choose a {filter}";

            selectionComboBox.Items.Add(NoFilterText);

            if (filter.Equals("price", StringComparison.OrdinalIgnoreCase))
            {
                var pricesRaw = dataManager.GetCarAttributes("price");
                var prices = pricesRaw
                    .Select(p => Convert.ToDecimal(p))
                    .ToList();

                var ranges = BuildPriceRanges(prices, PriceStep);

                foreach (var range in ranges)
                {
                    selectionComboBox.Items.Add(range);
                }
            }
            else
            {
                var items = dataManager.GetCarAttributes(filter);
                foreach (string item in items)
                {
                    selectionComboBox.Items.Add(item);
                }
            }

            selectionComboBox.SelectedIndex = 0;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (selectionComboBox.SelectedItem == null)
                return;

            Session.CarFilter ??= new CarFilter();
            var filters = Session.CarFilter;

            string selected = selectionComboBox.SelectedItem.ToString()!;
            bool noFilterSelected = selected == NoFilterText;

            if (filter.Equals("price", StringComparison.OrdinalIgnoreCase))
            {
                if (noFilterSelected)
                {
                    filters.PriceRange = null;
                }
                else
                {
                    var parts = selected.Split('-', StringSplitOptions.TrimEntries);
                    if (parts.Length != 2)
                        return;

                    decimal min = Convert.ToDecimal(parts[0]);
                    decimal max = Convert.ToDecimal(parts[1]);

                    filters.PriceRange = new PriceRange(min, max);
                }
            }
            else if (filter.Equals("brand", StringComparison.OrdinalIgnoreCase))
            {
                filters.Brand = noFilterSelected ? null : selected;
            }
            else if (filter.Equals("model", StringComparison.OrdinalIgnoreCase))
            {
                filters.Model = noFilterSelected ? null : selected;
            }
            else if (filter.Equals("color", StringComparison.OrdinalIgnoreCase))
            {
                filters.Color = noFilterSelected ? null : selected;
            }
            else if (filter.Equals("doors", StringComparison.OrdinalIgnoreCase))
            {
                filters.AmountOfDoors = noFilterSelected
                    ? null
                    : int.TryParse(selected, out var doors) ? doors : null;
            }

            var cars = dataManager.GetCars(filters);
            CarsChanged?.Invoke(cars);
            Close();
        }
        private List<string> BuildPriceRanges(List<decimal> prices, decimal step)
        {
            var result = new List<string>();

            if (prices.Count == 0)
                return result;

            decimal min = Math.Floor(prices.Min() / step) * step;
            decimal max = Math.Ceiling(prices.Max() / step) * step;

            for (decimal start = min; start < max; start += step)
            {
                decimal end = start + step;
                result.Add($"{start} - {end}");
            }

            return result;
        }
    }
}
