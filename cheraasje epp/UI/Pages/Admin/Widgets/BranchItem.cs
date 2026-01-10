using cheraasje_epp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BranchModel = cheraasje_epp.Models.Entities;
using AdminPage = cheraasje_epp.UI.Pages.Admin;


namespace cheraasje_epp.UI.Admin.Widgets
{
    public partial class BranchItem : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        private BranchModel.Branch Branch;
        public BranchItem(BranchModel.Branch branch)
        {
            InitializeComponent();
            nameLabel.Text = branch.Name;
            Branch = branch;
        }
        private void binButton_Click(object sender, EventArgs e)
        { 
            var popUp = new PopUp($"Are you sure you want to delete {Branch.Name}?");
            if (popUp.ShowDialog(this) == DialogResult.OK)
            {
                DataManager dataManager = new DataManager();
                dataManager.DeleteBranch(Branch.Id);
                var user = dataManager.GetUser(Session.UserId);
                var noMenu = false;
                if (user.BranchId == Branch.Id)
                {
                    noMenu = true;
                }
                PageChangeRequested?.Invoke(new AdminPage(noMenu));
            }

        }
    }
}
