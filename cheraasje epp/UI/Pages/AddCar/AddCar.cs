using cheraasje_epp.Data;
using cheraasje_epp.Models.Entities;

namespace cheraasje_epp.UI.Pages
{
    public partial class AddCar : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private DataManager dataManager = new Data.DataManager();

        private string transmissionType = "Manual";

        public AddCar()
        {
            InitializeComponent();
            branchLabel.Text = dataManager.GetBranchById(Session.UserId).Name;
        }

        private void selectManualButton_Click(object sender, EventArgs e)
        {
            selectManualButton.BackColor = Color.FromArgb(255, 87, 87);
            selectAutomaticButton.BackColor = Color.Silver;
            transmissionType = "Manual";
        }

        private void selectAutomaticButton_Click(object sender, EventArgs e)
        {
            selectAutomaticButton.BackColor = Color.FromArgb(255, 87, 87);
            selectManualButton.BackColor = Color.Silver;
            transmissionType = "Automatic";
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Brand = brandInputField.Text,
                Model = modelInputField.Text,
                Color = colorInputField.Text,
                AmountOfDoors = int.Parse(amountOfDoorInputField.Text),
                Price = decimal.Parse(priceInputField.Text),
                BuildYear = int.Parse(buildYearInputField.Text),
                Mileage = decimal.Parse(mileageInputField.Text),
                TransmissionType = transmissionType
            };
            bool succes = dataManager.AddCar(car);
            if (succes)
            {
                MessageBox.Show("Car added successfully!");
                PageChangeRequested?.Invoke(new Fleet());
            }
            else
            {
                return;
            }
        }
    }
}
