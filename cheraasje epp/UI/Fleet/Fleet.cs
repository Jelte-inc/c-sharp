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
            int userId = Session.UserId;
            User user = dataManager.GetUser(userId);
            Dictionary<string, dynamic> filters = new Dictionary<string, dynamic>();
            filters["BranchId"] = user.BranchId;
            List<Car> cars = dataManager.GetCars(filters);
            foreach (Car car in cars)
            {
                CarResultItem carResultItem = new CarResultItem(car);
                carList.Controls.Add(carResultItem);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
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
                    filters["Brand"] = searchText;
                    cars = dataManager.GetCars(filters);
                }


                carList.Controls.Clear();
                foreach (Car car in cars)
                {
                    CarResultItem carResultItem = new CarResultItem(car);
                    carList.Controls.Add(carResultItem);
                }
            }
            ;
        }
    }
}
