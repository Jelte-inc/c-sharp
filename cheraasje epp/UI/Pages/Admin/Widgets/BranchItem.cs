using CheraasjeEpp.Data;
using CheraasjeEpp.UI.Pages.AddUser;
using CheraasjeEpp.UI.Widgets;
using AdminPage = CheraasjeEpp.UI.Pages.Admin;
using BranchModel = CheraasjeEpp.Models.Entities;

namespace CheraasjeEpp.UI.Admin.Widgets
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
                if (user.BranchId == Branch.Id)
                {
                    Session.SafeLogin = true;
                }
                PageChangeRequested?.Invoke(new AdminPage());
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataManager dataManager = new DataManager();
            var branch = dataManager.GetBranchById(Branch.Id);
            var popUp = new BranchEditor(branch, true);
            popUp.PageChangeRequested += (newPage) =>
            {
                this.PageChangeRequested?.Invoke(newPage);
            };
            popUp.Show(this);
        }
    }
}
