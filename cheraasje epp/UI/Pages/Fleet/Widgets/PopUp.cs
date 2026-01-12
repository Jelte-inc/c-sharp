using CheraasjeEpp.Data;
using CheraasjeEpp.Models.Entities;
using CheraasjeEpp.Models.Filters;
using System.Globalization;

namespace CheraasjeEpp.UI.Pages.FleetWidgets
{
    public partial class PopUp : Form
    {
        private DataManager dataManager = new DataManager();

        private string filter;

        public event Action<List<Car>> CarsChanged;

        public PopUp(string filter)
        {
            InitializeComponent();
            chooseLabel.Text = $"Choose a {filter}";
            var items = dataManager.GetCarAttributes(filter);
            this.filter = filter;
            foreach (string item in items)
            {
                selectionComboBox.Items.Add(item);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (selectionComboBox.SelectedItem == null)
                return;

            if (Session.CarFilter == null)
            {
                Session.CarFilter = new CarFilter();
            }

            var filters = Session.CarFilter;

            if (filter.Equals("Price", StringComparison.OrdinalIgnoreCase))
            {
                var text = selectionComboBox.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(text))
                    return;

                var parts = text.Split('-', StringSplitOptions.TrimEntries);
                if (parts.Length != 2)
                    return;

                var culture = CultureInfo.GetCultureInfo("nl-NL");

                if (!decimal.TryParse(parts[0], NumberStyles.Number, culture, out var min))
                    return;

                if (!decimal.TryParse(parts[1], NumberStyles.Number, culture, out var max))
                    return;

                filters.PriceRange = new PriceRange(min, max);
            }
            else if (filter.Equals("Brand", StringComparison.OrdinalIgnoreCase))
            {
                filters.Brand = selectionComboBox.SelectedItem!.ToString();
            }
            else if (filter.Equals("Model", StringComparison.OrdinalIgnoreCase))
            {
                filters.Model = selectionComboBox.SelectedItem!.ToString();
            }
            else if (filter.Equals("Color", StringComparison.OrdinalIgnoreCase))
            {
                filters.Color = selectionComboBox.SelectedItem!.ToString();
            }
            else if (filter.Equals("Doors", StringComparison.OrdinalIgnoreCase))
            {
                if (int.TryParse(selectionComboBox.SelectedItem!.ToString(), out var amountOfDoors))
                {
                    filters.AmountOfDoors = amountOfDoors;
                }
            }
            List<Car> cars = dataManager.GetCars(filters);
            CarsChanged?.Invoke(cars);
            Close();

        }
    }
}