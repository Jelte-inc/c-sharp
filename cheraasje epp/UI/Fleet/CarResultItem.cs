using cheraasje_epp.Models;

namespace cheraasje_epp.UI.Fleet
{
    public partial class CarResultItem : UserControl
    {
        public CarResultItem(Car car)
        {
            InitializeComponent();

            titleLabel.Text = $"{car.Name()} {car.BuildYear}";
            priceLabel.Text = car.Price.ToString("C");
            mileageLabel.Text = $"{car.Mileage:N0} km";
        }

    }
}
