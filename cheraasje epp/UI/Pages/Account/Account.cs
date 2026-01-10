using cheraasje_epp.Data;
using cheraasje_epp.Models.Entities;
using cheraasje_epp.UI.Widgets;

namespace cheraasje_epp.UI.Pages
{
    public partial class Account : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private readonly SideBarMenu sideBarMenu = new();

        private bool menuOpen = false;

        public Account()
        {
            InitializeComponent();
            var dataManager = new DataManager();
            int userId = Session.UserId;
            User user = dataManager.GetUser(userId);
            userNameLabel.Text = user.Name;
            UserIdLabel.Text = user.Id.ToString();

            this.Controls.Add(sideBarMenu);
            sideBarMenu.Visible = false;
            sideBarMenu.BringToFront();
            sideBarMenu.PageChangeRequested += page =>
            {
                PageChangeRequested?.Invoke(page);
            };
            this.MouseDown += Account_MouseDown;
            RegisterMouseDownRecursive(this);
        }

        private void RegisterMouseDownRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.MouseDown += Account_MouseDown;

                if (c.HasChildren)
                    RegisterMouseDownRecursive(c);
            }
        }

        private void Account_MouseDown(object sender, MouseEventArgs e)
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

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Session.End();
            PageChangeRequested?.Invoke(new Login());
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarMenu.openSideBar();
            menuOpen = true;
        }
    }
}
