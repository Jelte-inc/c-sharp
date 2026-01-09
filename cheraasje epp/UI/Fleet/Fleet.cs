using cheraasje_epp.Data;
using cheraasje_epp.Models.Entities;
using cheraasje_epp.Models.Filters;

namespace cheraasje_epp.UI.Fleet
{
    public partial class Fleet : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private DataManager dataManager = new DataManager();
        public Fleet()
        {
            // Initialize components and load initial data
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
            // Load all cars without filters
            carList.Controls.Clear();
            CarFilter filters = new CarFilter();
            Session.CarFilter = filters;
            List<Car> cars = dataManager.GetCars(filters);
            RenderCars(cars);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // Perform search based on the text input
            // This overrides other filters for simplicity
            // It also only filters on brand and model for now

            // TODO: Improve search logic to combine with existing filters
            CarFilter filters = new CarFilter();
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
                    filters.Brand = words[0];
                    filters.Model = words[1];
                }
                else
                    filters.Brand = searchText;
                cars = dataManager.GetCars(filters);
            }

            RenderCars(cars);

        }

        private void RenderCars(List<Car> cars)
        {
            // Clear existing items and render new car items
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

        // Refresh car list based on applied filters
        // Also updates filter button labels to reflect current filters
        private void RefreshCars(List<Car> cars)
        {
            RenderCars(cars);

            var filter = Session.CarFilter;
            if (filter == null)
                return;

            if (!string.IsNullOrWhiteSpace(filter.Brand))
            {
                brandFilterButton.Text = filter.Brand;
                brandFilterButton.Font = new Font(
                    "Segoe UI",
                    14.25F,
                    FontStyle.Bold | FontStyle.Italic,
                    GraphicsUnit.Point
                );
            }

            if (filter.PriceRange != null)
            {
                priceFilterButton.Text = filter.PriceRange.ToFilterLabel();
                priceFilterButton.Font = new Font(
                    "Segoe UI",
                    14.25F,
                    FontStyle.Bold | FontStyle.Italic,
                    GraphicsUnit.Point
                );
            }
            if (filter.Color != null)
            {
                colorFilterButton.Text = filter.Color;
                colorFilterButton.Font = new Font(
                    "Segoe UI",
                    14.25F,
                    FontStyle.Bold | FontStyle.Italic,
                    GraphicsUnit.Point
                );
            }
            if (filter.AmountOfDoors != null)
            {
                doorFilterButton.Text = filter.AmountOfDoors.ToString() + " Doors";
                doorFilterButton.Font = new Font(
                    "Segoe UI",
                    14.25F,
                    FontStyle.Bold | FontStyle.Italic,
                    GraphicsUnit.Point
                );
            }
        }

        // Filter button click handlers
        // These open pop-up windows for filter selection and refresh the car list upon confirmation
        private void BrandFilterButton_Click(object sender, EventArgs e)
        {
            var popup = new PopUp("brand");
            popup.CarsChanged += RefreshCars;
            popup.Show(this);
        }

        private void priceFilterButton_Click(object sender, EventArgs e)
        {
            var popup = new PopUp("price");
            popup.CarsChanged += RefreshCars;
            popup.Show(this);
        }

        private void colorFilterButton_Click(object sender, EventArgs e)
        {
            var popup = new PopUp("color");
            popup.CarsChanged += RefreshCars;
            popup.Show(this);
        }
        private void doorFilterButton_Click(object sender, EventArgs e)
        {
            var popup = new PopUp("doors");
            popup.CarsChanged += RefreshCars;
            popup.Show(this);
        }

        // Resets all filters, car list and filter button labels
        private void removeFiltersButton_Click(object sender, EventArgs e)
        {
            Session.CarFilter = new CarFilter();
            List<Car> cars = dataManager.GetCars(Session.CarFilter);
            RenderCars(cars);
            brandFilterButton.Text = "Brand";
            brandFilterButton.Font = new Font(
                "Segoe UI",
                14.25F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0
            );

            priceFilterButton.Text = "Price";
            priceFilterButton.Font = new Font(
                "Segoe UI",
                14.25F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0
            );

            colorFilterButton.Text = "Color";
            colorFilterButton.Font = new Font(
                "Segoe UI",
                14.25F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0
            );

            doorFilterButton.Text = "Doors";
            doorFilterButton.Font = new Font(
                "Segoe UI",
                14.25F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0
            );

        }

    }
}
