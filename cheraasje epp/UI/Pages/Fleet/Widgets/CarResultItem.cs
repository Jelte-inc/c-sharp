using CheraasjeEpp.Models.Entities;
using CheraasjeEpp.UI.Widgets;

namespace CheraasjeEpp.UI.Pages.FleetWidgets
{
    public partial class CarResultItem : UserControl
    {
        public event Action<Car> CarSelected;

        private readonly Car car;

        public CarResultItem(Car car)
        {
            InitializeComponent();

            this.car = car;

            // Background
            var background = new RoundedRectangle
            {
                Dock = DockStyle.Fill,
                FillColor = Color.White,
                CornerRadius = 20
            };

            background.Click += OnClick;
            Controls.Add(background);
            background.SendToBack();

            // Wire clicks for this control and all children
            WireClick(this);

            // UI content
            titleLabel.Text = $"{car.Name()} {car.BuildYear}";
            priceLabel.Text = car.Price.ToString("C");
            mileageLabel.Text = $"{car.Mileage:N0} km";

            // Image loading without file lock
            if (car.HasImages() && File.Exists(car.ImagePaths[0]))
            {
                using var img = Image.FromFile(car.ImagePaths[0]);
                carPictureBox.Image = new Bitmap(img);
            }
            else
            {
                carPictureBox.Image = Properties.Resources.NoImage;
            }
        }

        private void WireClick(Control control)
        {
            control.Click += OnClick;

            foreach (Control child in control.Controls)
                WireClick(child);
        }

        private void OnClick(object sender, EventArgs e)
        {
            CarSelected?.Invoke(car);
        }
    }
}
