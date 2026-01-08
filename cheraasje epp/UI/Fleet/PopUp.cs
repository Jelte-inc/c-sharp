using cheraasje_epp.Data;
using cheraasje_epp.Models;

namespace cheraasje_epp.UI.Fleet
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
            var items = dataManager.getCarAttributes(filter);
            this.filter = filter;
            foreach (string item in items)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            Dictionary<string, object> filters;
            filters = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase)
            {
                {filter, comboBox1.SelectedItem!}
            };
            List<Car> cars = dataManager.GetCars(filters);
            CarsChanged?.Invoke(cars);
            Close();

        }
    }
}