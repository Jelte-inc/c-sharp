using cheraasje_epp.Data;
using cheraasje_epp.UI.Admin.Widgets;
using cheraasje_epp.UI.Widgets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheraasje_epp.UI.Pages
{
    public partial class Admin : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        private readonly SideBarMenu sideBarMenu = new();

        private bool menuOpen = false;
        public Admin(bool safeLogin = false)
        {
            InitializeComponent();
            BuildBranchList();
            BuildUserList();
            if (safeLogin)
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
                branchItem.PageChangeRequested += (newPage) => {
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
                userList.Controls.Add(userItem);
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarMenu.openSideBar();
            menuOpen = true;
        }
    }
}
