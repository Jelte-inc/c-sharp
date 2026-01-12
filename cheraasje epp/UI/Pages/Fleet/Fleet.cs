using CheraasjeEpp.Data;
using CheraasjeEpp.Models.Entities;
using CheraasjeEpp.Models.Filters;
using CheraasjeEpp.UI.Pages.FleetWidgets;

namespace CheraasjeEpp.UI.Pages
{
    public partial class Fleet : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private readonly DataManager dataManager = new();

        private readonly Widgets.SideBarMenu sideBarMenu = new();

        private bool menuOpen = false;

        public Fleet()
        {
            // Initialize components and load initial data
            InitializeComponent();
            InitialLoadCars();

            // Setup sidebar menu
            this.Controls.Add(sideBarMenu);
            sideBarMenu.Visible = false;
            sideBarMenu.BringToFront();
            sideBarMenu.PageChangeRequested += page =>
            {
                PageChangeRequested?.Invoke(page);
            };

            // Load user and branch information
            int userId = Session.UserId;
            User user = dataManager.GetUser(userId);
            string branchName = dataManager.GetBranchById(user.BranchId).Name;
            branchLabel.Text = branchName;

            // Attach event handler for search box text 
            searchBox.TextChanged += SearchBox_TextChanged;
            this.MouseDown += Fleet_MouseDown;
            RegisterMouseDownRecursive(this);
        }

        private void RegisterMouseDownRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.MouseDown += Fleet_MouseDown;

                if (c.HasChildren)
                    RegisterMouseDownRecursive(c);
            }
        }

        private void Fleet_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuOpen)
                return;

            Point clickLocation = PointToClient(Cursor.Position);

            if (!sideBarMenu.Bounds.Contains(clickLocation))
            {
                menuOpen = false;
                sideBarMenu.closeSideBar();
            }
        }

        // Clear existing items and render new car items
        private void RenderCars(List<Car> cars)
        {
            carList.Controls.Clear();

            foreach (Car car in cars)
            {
                var item = new CarResultItem(car);
                item.CarSelected += OnCarSelected;
                carList.Controls.Add(item);
            }
        }

        // Load all cars without filters
        // This is called on initial load of the page
        private void InitialLoadCars()
        {
            carList.Controls.Clear();
            CarFilter filters = new CarFilter();
            Session.CarFilter = filters;
            List<Car> cars = dataManager.GetCars(filters);
            RenderCars(cars);
        }


        // Refresh car list based on applied filters
        // Also updates filter button labels to reflect current filters
        private void RefreshCars(List<Car> cars)
        {
            RenderCars(cars);

            var filter = Session.CarFilter;
            if (filter == null)
                return;

            var defaultFont = new Font(
                "Segoe UI",
                14.25F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );

            var activeFont = new Font(
                "Segoe UI",
                14.25F,
                FontStyle.Bold | FontStyle.Italic,
                GraphicsUnit.Point
            );

            // BRAND
            if (!string.IsNullOrWhiteSpace(filter.Brand))
            {
                brandFilterButton.Text = filter.Brand;
                brandFilterButton.Font = activeFont;
            }
            else
            {
                brandFilterButton.Text = "Brand";
                brandFilterButton.Font = defaultFont;
            }

            // PRICE
            if (filter.PriceRange != null)
            {
                priceFilterButton.Text = filter.PriceRange.ToFilterLabel();
                priceFilterButton.Font = activeFont;
            }
            else
            {
                priceFilterButton.Text = "Price";
                priceFilterButton.Font = defaultFont;
            }

            // COLOR
            if (!string.IsNullOrWhiteSpace(filter.Color))
            {
                colorFilterButton.Text = filter.Color;
                colorFilterButton.Font = activeFont;
            }
            else
            {
                colorFilterButton.Text = "Color";
                colorFilterButton.Font = defaultFont;
            }

            // DOORS
            if (filter.AmountOfDoors != null)
            {
                doorFilterButton.Text = filter.AmountOfDoors + " Doors";
                doorFilterButton.Font = activeFont;
            }
            else
            {
                doorFilterButton.Text = "Doors";
                doorFilterButton.Font = defaultFont;
            }
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
        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarMenu.openSideBar();
            menuOpen = true;
        }

        private void OnCarSelected(Car car)
        {
            PageChangeRequested?.Invoke(new CarView(car));
        }

        private void addNewCarButton_Click(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new AddCar());
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
