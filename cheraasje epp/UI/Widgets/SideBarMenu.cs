using Cheraasje.Epp.UI.Controls;
using cheraasje_epp.UI.Pages;

namespace cheraasje_epp.UI.Widgets
{
    internal class SideBarMenu : Panel
    {
        private Label titleLabel;
        private FlowLayoutPanel menuContainer;
        private RoundedButton homePageButton;
        private RoundedButton branchPageButton;
        private RoundedButton fleetPageButton;
        private RoundedButton accountPageButton;
        public event Action<UserControl> PageChangeRequested;


        public SideBarMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Basic settings for sidebar
            this.Width = 200;
            this.Dock = DockStyle.Left;

            // Titel
            titleLabel = new Label();
            titleLabel.Text = "Menu";
            titleLabel.Font = new Font("Segoe UI", 24.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Height = 50;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;

            homePageButton = new RoundedButton();
            homePageButton.Text = "Home";
            homePageButton.AutoSize = false;
            homePageButton.TextAlign = ContentAlignment.MiddleCenter;
            homePageButton.Width = this.Width;
            homePageButton.BackColor = Color.FromArgb(255, 87, 87);
            homePageButton.Size = new Size(Width - 30, 40);
            homePageButton.Height = 40;
            homePageButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homePageButton.Click += (s, e) => PageChangeRequested?.Invoke(new Home());

            branchPageButton = new RoundedButton();
            branchPageButton.Text = "Branch";
            branchPageButton.AutoSize = false;
            branchPageButton.TextAlign = ContentAlignment.MiddleCenter;
            branchPageButton.Width = this.Width;
            branchPageButton.BackColor = Color.FromArgb(255, 87, 87);
            branchPageButton.Size = new Size(Width - 30, 40);
            branchPageButton.Height = 40;
            branchPageButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            branchPageButton.Click += (s, e) => PageChangeRequested?.Invoke(new Branch());

            fleetPageButton = new RoundedButton();
            fleetPageButton.Text = "Fleet";
            fleetPageButton.AutoSize = false;
            fleetPageButton.TextAlign = ContentAlignment.MiddleCenter;
            fleetPageButton.Width = this.Width;
            fleetPageButton.BackColor = Color.FromArgb(255, 87, 87);
            fleetPageButton.Size = new Size(Width - 30, 40);
            fleetPageButton.Height = 40;
            fleetPageButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fleetPageButton.Click += (s, e) => PageChangeRequested?.Invoke(new Fleet());

            accountPageButton = new RoundedButton();
            accountPageButton.Text = "Account";
            accountPageButton.AutoSize = false;
            accountPageButton.TextAlign = ContentAlignment.MiddleCenter;
            accountPageButton.Width = this.Width;
            accountPageButton.BackColor = Color.FromArgb(255, 87, 87);
            accountPageButton.Size = new Size(Width - 30, 40);
            accountPageButton.Height = 40;
            accountPageButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountPageButton.Click += (s, e) => PageChangeRequested?.Invoke(new Account());

            // Container for menu-items
            menuContainer = new FlowLayoutPanel();
            menuContainer.Dock = DockStyle.Fill;
            menuContainer.FlowDirection = FlowDirection.TopDown;
            menuContainer.WrapContents = false;

            // Add components to sidebar
            this.Controls.Add(menuContainer);
            this.Controls.Add(titleLabel);
            AddMenuItem(homePageButton);
            AddMenuItem(branchPageButton);
            AddMenuItem(fleetPageButton);
            AddMenuItem(accountPageButton);
        }

        public void AddMenuItem(Control item)
        {
            var wrapper = new Panel
            {
                Width = menuContainer.ClientSize.Width,
                Height = item.Height + 10
            };

            item.Left = (wrapper.Width - item.Width) / 2;
            item.Top = 5;

            wrapper.Controls.Add(item);
            menuContainer.Controls.Add(wrapper);

            menuContainer.Resize += (s, e) =>
            {
                wrapper.Width = menuContainer.ClientSize.Width;
                item.Left = (wrapper.Width - item.Width) / 2;
            };
        }


        public void openSideBar()
        {
            this.Visible = true;
        }
        public void closeSideBar()
        {
            this.Visible = false;
        }
    }
}
