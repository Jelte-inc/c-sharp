using CheraasjeEpp.Data;
using CheraasjeEpp.Models.Entities;
using CheraasjeEpp.Properties;
using CheraasjeEpp.UI.Widgets;

namespace CheraasjeEpp.UI.Pages
{
    public partial class CarView : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private int currentImage = 0;

        private DataManager dataManager = new DataManager();

        private Car car;

        public CarView(Car car)
        {
            InitializeComponent();
            this.car = car;
            carNameLabel.Text = car.Name();
            mileageLabel.Text = $"{car.Mileage} km";
            askingPriceLabel.Text = car.Price.ToString("C");
            buildYearLabel.Text = car.BuildYear.ToString();
            if (string.IsNullOrEmpty(car.LicensePlate) || car.LicensePlate == "0")
            {
                licensePlateLabel.Text = "Not registered yet";
            }
            else
            {
                licensePlateLabel.Text = car.LicensePlate;
            }
            transmissionLabel.Text = car.TransmissionType;
            bool hasImage = car.HasImages() && File.Exists(car.ImagePaths[0]);
            if (hasImage)
            {
                currentCarPicture.Image = Image.FromFile(car.ImagePaths[0]);
                currentCarPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                foreach (string imagePath in car.ImagePaths)
                {
                    carImages.Controls.Add(new PictureBox
                    {
                        Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : Resources.NoImage,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 100,
                        Height = 75,
                        Margin = new Padding(5)
                    });
                }
            }
            else
            {
                currentCarPicture.Image = Properties.Resources.NoImage;
                currentCarPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void backLabel_Click(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Fleet());

        }

        private void LoadImageAtIndex(int index)
        {
            if (car.ImagePaths == null || index < 0 || index >= car.ImagePaths.Count)
                return;

            var path = car.ImagePaths[index].Trim();

            if (!File.Exists(path))
                return;

            currentCarPicture.Image?.Dispose();

            using var img = Image.FromFile(path);
            currentCarPicture.Image = new Bitmap(img);
        }


        private void cycleBackButton_Click(object sender, EventArgs e)
        {
            if (currentImage <= 0)
                return;

            currentImage--;
            LoadImageAtIndex(currentImage);
        }

        private void cycleForwardButton_Click(object sender, EventArgs e)
        {
            if (car.ImagePaths == null || currentImage >= car.ImagePaths.Count - 1)
                return;

            currentImage++;
            LoadImageAtIndex(currentImage);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var popup = new PopUp(message: "Are you sure you want to delete this car?");
            popup.ShowDialog(this);
            if (popup.DialogResult == DialogResult.OK)
            {
                dataManager.DeleteCar(car.Id);
                PageChangeRequested?.Invoke(new Fleet());
            }
        }
    }
}
