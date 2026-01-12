using CheraasjeEpp.Data;
using CheraasjeEpp.UI.Admin.Widgets;
using CheraasjeEpp.UI.Pages.AddUser;
using CheraasjeEpp.UI.Widgets;
using Model = CheraasjeEpp.Models.Entities;

namespace CheraasjeEpp.UI.Pages
{
    public partial class Admin : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        private readonly SideBarMenu sideBarMenu = new();

        private bool menuOpen = false;
        public Admin()
        {
            InitializeComponent();
            BuildBranchList();
            BuildUserList();
            if (Session.SafeLogin)
            {
                menuButton.Visible = false;
            }
            this.Controls.Add(sideBarMenu);
            sideBarMenu.Visible = false;
            sideBarMenu.BringToFront();
            sideBarMenu.PageChangeRequested += page =>
            {
                PageChangeRequested?.Invoke(page);
            };

            this.MouseDown += Admin_MouseDown;
            RegisterMouseDownRecursive(this);
        }
        private void RegisterMouseDownRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.MouseDown += Admin_MouseDown;

                if (c.HasChildren)
                    RegisterMouseDownRecursive(c);
            }
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
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
        private void BuildBranchList()
        {
            DataManager dataManager = new DataManager();
            var branches = dataManager.GetBranches();
            foreach (var branch in branches)
            {
                var branchItem = new BranchItem(branch);
                branchItem.PageChangeRequested += (newPage) =>
                {
                    this.PageChangeRequested?.Invoke(newPage);
                };
                branchList.Controls.Add(branchItem);
            }
        }
        private void BuildUserList()
        {
            DataManager dataManager = new DataManager();
            var users = dataManager.GetUsers();
            foreach (var user in users)
            {
                var userItem = new UserItem(user);
                userItem.PageChangeRequested += (newPage) =>
                {
                    this.PageChangeRequested?.Invoke(newPage);
                };
                userList.Controls.Add(userItem);
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarMenu.openSideBar();
            menuOpen = true;
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            if (userInputField.Text == "")
            {
                MessageBox.Show("Please input a name");
                return;
            }
            var user = new Model.User();
            user.Name = userInputField.Text;
            var popUp = new UserEditor(user, false);
            popUp.PageChangeRequested += (newPage) =>
            {
                this.PageChangeRequested?.Invoke(newPage);
            };
            popUp.Show(this);
        }

        private void branchButton_Click(object sender, EventArgs e)
        {
            if (branchInputField.Text == "")
            {
                MessageBox.Show("Please input a name");
                return;
            }
            var branch = new Model.Branch();
            branch.Name = branchInputField.Text;
            var popUp = new BranchEditor(branch, false);
            popUp.PageChangeRequested += (newPage) =>
            {
                this.PageChangeRequested?.Invoke(newPage);
            };
            popUp.Show(this);
        }
    }
}
