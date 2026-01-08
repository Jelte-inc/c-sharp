using cheraasje_epp.Data;
using cheraasje_epp.Models;

namespace cheraasje_epp.UI.Fleet
{
    public partial class Fleet : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private DataManager dataManager = new DataManager();
        public Fleet()
        {
            InitializeComponent();
            int userId = Session.UserId;
            User user = dataManager.GetUser(userId);
            string branchName = dataManager.GetBranchById(user.BranchId).Name;
            branchLabel.Text = branchName;
            searchBox.TextChanged += SearchBox_TextChanged;
            InitialLoadCars();
        }

        private void InitialLoadCars()
        {
            carList.Controls.Clear();
            Dictionary<string, dynamic> filters = new Dictionary<string, dynamic>();
            List<Car> cars = dataManager.GetCars(filters);
            RenderCars(cars);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

            int userId = Session.UserId;
            User user = dataManager.GetUser(userId);
            Dictionary<string, dynamic> filters = new Dictionary<string, dynamic>();
            filters["BranchId"] = user.BranchId;

            string searchText = searchBox.Text;

            if (searchText == searchBox.PlaceholderText)
                searchText = string.Empty;
            List<Car> cars;
            if (searchText == string.Empty)
            {
                cars = dataManager.GetCars(filters);
            }
            else
            {
                string[] words = searchText.Split(' ');
                if (words.Length > 1)
                {
                    filters["Brand"] = words[0];
                    filters["Model"] = words[1];
                }
                else
                    filters["Brand"] = searchText;
                cars = dataManager.GetCars(filters);
            }

            RenderCars(cars);

        }

        private void BrandFilterButton_Click(object sender, EventArgs e)
        {
            var popup = new PopUp("brand");
            popup.CarsChanged += RefreshCars;
            popup.Show(this);
        }

        private void RenderCars(List<Car> cars)
        {
            carList.Controls.Clear();
            foreach (Car car in cars)
            {
                carList.Controls.Add(new CarResultItem(car));
            }
        }

        // TODO: Remove these methods if not needed
        //public void AddCar(Car car)
        //{
        //    CarResultItem carResultItem = new CarResultItem(car);
        //    carList.Controls.Add(carResultItem);
        //}

        //public void AddCars(List<Car> cars)
        //{
        //    foreach (Car car in cars)
        //    {
        //        CarResultItem carResultItem = new CarResultItem(car);
        //        carList.Controls.Add(carResultItem);
        //    }
        //}

        private void RefreshCars(List<Car> cars)
        {
            RenderCars(cars);
            string selectedBrand = cars[0].Brand;
            brandFilterButton.Text = selectedBrand;
            brandFilterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        }
    }
}
