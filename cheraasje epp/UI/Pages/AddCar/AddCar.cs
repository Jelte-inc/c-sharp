using cheraasje_epp.Data;
using cheraasje_epp.Models.Entities;

namespace cheraasje_epp.UI.Pages
{
    public partial class AddCar : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private DataManager dataManager = new Data.DataManager();

        private string transmissionType = "Manual";

        private List<string> ImagePaths;

        public AddCar()
        {
            InitializeComponent();
            branchLabel.Text = dataManager.GetBranchById(Session.UserId).Name;
            ImagePaths = new List<string>();
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
            if (filePaths == null || filePaths.Length == 0)
                return;

            string targetFolder = GetImageStorageFolder();

            foreach (string sourcePath in filePaths)
            {
                string fileName = Path.GetFileName(sourcePath);
                string destinationPath = GetUniqueFileName(
                    Path.Combine(targetFolder, fileName)
                );

                try
                {
                    // Copy file
                    File.Copy(sourcePath, destinationPath);
                    using var loadedImage = Image.FromFile(destinationPath);
                    Image previewImage = new Bitmap(loadedImage);
                    ImagePaths.Add(destinationPath);
                    var pictureBox = new PictureBox
                    {
                        Image = previewImage,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 150,
                        Height = 100,
                        Margin = new Padding(5)
                    };

                    uploadedImagesView.Controls.Add(pictureBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Afbeelding kon niet worden toegevoegd:\n{sourcePath}\n\n{ex.Message}",
                        "Image error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
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
            var inputs = new[]
{
                brandInputField.Text,
                modelInputField.Text,
                colorInputField.Text,
                amountOfDoorInputField.Text,
                priceInputField.Text,
                buildYearInputField.Text,
                mileageInputField.Text,
                licensePlateInputField.Text,
            };
            if (inputs.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Fill in all the fields");
                return;
            }
            Car car = new Car
            {
                Brand = brandInputField.Text,
                Model = modelInputField.Text,
                Color = colorInputField.Text,
                AmountOfDoors = int.Parse(amountOfDoorInputField.Text),
                Price = decimal.Parse(priceInputField.Text),
                BuildYear = int.Parse(buildYearInputField.Text),
                Mileage = decimal.Parse(mileageInputField.Text),
                LicensePlate = licensePlateInputField.Text,
                TransmissionType = transmissionType,
                ImagePaths = ImagePaths
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
        private void OnlyAllowNumbers(object sender, KeyPressEventArgs e)
        {
            // Sta alleen cijfers en backspace toe
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnlyAllowDecimal(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null)
                return;

            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == ',' && !textBox.Text.Contains(','))
                return;

            e.Handled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Fleet());
        }
    }

}
