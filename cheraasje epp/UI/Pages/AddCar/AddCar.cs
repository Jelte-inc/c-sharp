using cheraasje_epp.Data;
using cheraasje_epp.Models.Entities;

namespace cheraasje_epp.UI.Pages
{
    public partial class AddCar : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private DataManager dataManager = new Data.DataManager();

        private string transmissionType = "Manual";

        private string ImagePath;

        public AddCar()
        {
            InitializeComponent();
            branchLabel.Text = dataManager.GetBranchById(Session.UserId).Name;
        }

        private void addImagesButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecteer afbeelding(en)";
                ofd.Filter = "Afbeeldingen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CopyImagesToAppData(ofd.FileNames);
                }
            }
        }
        private string GetImageStorageFolder()
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(basePath, "cheraasje epp", "Images");

            Directory.CreateDirectory(appFolder); // veilig, maakt alleen als nodig
            return appFolder;
        }

        private void CopyImagesToAppData(string[] filePaths)
        {
            string targetFolder = GetImageStorageFolder();

            foreach (string sourcePath in filePaths)
            {
                string fileName = Path.GetFileName(sourcePath);
                string destinationPath = GetUniqueFileName(
                    Path.Combine(targetFolder, fileName)
                );

                Image img;
                try
                {
                    using (var original = Image.FromFile(sourcePath))
                    {
                        img = new Bitmap(original);
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(
                        $"Invalid image file:\n{sourcePath}",
                        "Image error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    continue;
                }

                File.Copy(sourcePath, destinationPath);

                ImagePath = destinationPath;

                PictureBox pictureBox = new PictureBox
                {
                    Image = img,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 150,
                    Height = 100,
                    Margin = new Padding(5)
                };

                uploadedImagesView.Controls.Add(pictureBox);
            }
        }



        private string GetUniqueFileName(string path)
        {
            string directory = Path.GetDirectoryName(path);
            string filename = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);

            int counter = 1;
            string newPath = path;

            while (File.Exists(newPath))
            {
                newPath = Path.Combine(directory, $"{filename}_{counter}{extension}");
                counter++;
            }

            return newPath;
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
                TransmissionType = transmissionType,
                ImagePath = ImagePath
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
