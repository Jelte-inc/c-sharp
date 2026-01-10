using cheraasje_epp.Models.Entities;
using CheraasjeApp.UI.Controls;

namespace cheraasje_epp.UI.Pages.FleetWidgets
{
    public partial class CarResultItem : UserControl
    {
        public CarResultItem(Car car)
        {
            InitializeComponent();

            var background = new RoundedRectangle
            {
                Dock = DockStyle.Fill,
                FillColor = Color.White,
                CornerRadius = 20
            };

            Controls.Add(background);
            background.SendToBack();

            titleLabel.Text = $"{car.Name()} {car.BuildYear}";
            priceLabel.Text = car.Price.ToString("C");
            mileageLabel.Text = $"{car.Mileage:N0} km";
            if (File.Exists(car.ImagePath))
            {
                pictureBox1.Image = Image.FromFile(car.ImagePath);
            }
            else
            {
                MessageBox.Show($"Image path does not exist {car.ImagePath}");
                pictureBox1.Image = Properties.Resources.NoImage;
            }

        }
    }
}
