using cheraasje_epp.Data;
using cheraasje_epp.UI.Admin.Widgets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheraasje_epp.UI.Admin
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
            BuildBranchList();
            BuildUserList();
        }
        private void BuildBranchList()
        {
            DataManager dataManager = new DataManager();
            var branches = dataManager.GetBranches();
            foreach (var branch in branches)
            {
                var branchItem = new BranchItem(branch);
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
    }
}
