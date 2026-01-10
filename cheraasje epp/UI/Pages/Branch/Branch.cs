using cheraasje_epp.Data;
using cheraasje_epp.Models.Filters;
using cheraasje_epp.Models.ValueObjects;
using cheraasje_epp.UI.Widgets;

namespace cheraasje_epp.UI.Pages
{
    public partial class Branch : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private readonly SideBarMenu sideBarMenu = new();

        private bool menuOpen = false;

        public Branch()
        {
            InitializeComponent();
            BuildTimes();
            BuildInfo();
            BuildPrices();

            this.Controls.Add(sideBarMenu);
            sideBarMenu.Visible = false;
            sideBarMenu.BringToFront();
            sideBarMenu.PageChangeRequested += page =>
            {
                PageChangeRequested?.Invoke(page);
            };

            this.MouseDown += Branch_MouseDown;
            RegisterMouseDownRecursive(this);
        }

        private void RegisterMouseDownRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.MouseDown += Branch_MouseDown;

                if (c.HasChildren)
                    RegisterMouseDownRecursive(c);
            }
        }

        private void Branch_MouseDown(object sender, MouseEventArgs e)
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


        private void BuildTimes()
        {
            DataManager dataManager = new DataManager();
            var times = dataManager.GetTimes(Session.UserId);
            foreach (var time in times)
            {
                string displayTime = $"{time.OpenTime} - {time.CloseTime}";

                switch (time.Day)
                {
                    case 1: mondayLabel.Text = displayTime; break;
                    case 2: tuesdayLabel.Text = displayTime; break;
                    case 3: wednesdayLabel.Text = displayTime; break;
                    case 4: thursdayLabel.Text = displayTime; break;
                    case 5: fridayLabel.Text = displayTime; break;
                    case 6: saturdayLabel.Text = displayTime; break;
                    case 7: sundayLabel.Text = displayTime; break;
                }
            }
        }
        private void BuildInfo()
        {
            DataManager dataManager = new DataManager();
            var branch = dataManager.GetBranchById(Session.UserId);
            cityLabel.Text = branch.Location;
            adressLabel.Text = $"{branch.Adress} {branch.PostalCode}";
            ownerLabel.Text = branch.Owner;
            phoneLabel.Text = branch.PhoneNumber;
            branchLabel.Text = branch.Id.ToString();
        }
        private void BuildPrices()
        {
            DataManager dataManager = new DataManager();
            var cars = dataManager.GetCars(new CarFilter());
            decimal branchWorth = 0;
            foreach (var car in cars)
            {
                branchWorth += car.Price;
            }
            branchWorthLabel.Text = new Money(branchWorth).ToString();
            if (branchWorth != 0)
            {
                branchAveragePriceLabel.Text = new Money(Math.Floor((branchWorth / cars.Count))).ToString();
            }
            branchNameLabel.Text = dataManager.GetBranchById(Session.UserId).ToString();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarMenu.openSideBar();
            menuOpen = true;
        }

        private void fleetButton_Click(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Fleet());
        }
    }
}

