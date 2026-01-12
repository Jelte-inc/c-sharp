using CheraasjeEpp.Data;
using CheraasjeEpp.Models.Entities;

namespace CheraasjeEpp.UI.Pages.AddUser
{
    public partial class UserEditor : Form, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        private User User;
        private bool Update;
        public UserEditor(User user, bool update)
        {
            InitializeComponent();
            nameInputField.Text = user.Name;
            User = user;
            Update = update;
            BuildBranchList();
        }
        private void BuildBranchList()
        {
            DataManager dataManager = new DataManager();
            var branches = dataManager.GetBranches();
            branchDropdown.DataSource = branches;
            branchDropdown.DisplayMember = "Name";
            branchDropdown.ValueMember = "Id";
            if (User.BranchId != 0)
            {
                branchDropdown.SelectedValue = User.BranchId;
            }
            if (User.IsAdmin)
            {
                adminCheckBox.Checked = true;
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            var inputs = new[] { nameInputField.Text, passwordInputField.Text, passwordCheckInputField.Text };
            if (inputs.Any(string.IsNullOrWhiteSpace) || branchDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields");
                return;
            }
            if (passwordInputField.Text != passwordCheckInputField.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            DataManager dataManager = new DataManager();
            var user = new User();
            user.Name = nameInputField.Text;
            user.Password = passwordInputField.Text;
            user.BranchId = Convert.ToInt32(branchDropdown.SelectedValue);
            if (User.Id != 0)
            {
                user.Id = User.Id;
            }
            if (adminCheckBox.Checked)
            {
                user.IsAdmin = true;
            }
            if (Update)
            {
                dataManager.UpdateUser(user);
            }
            else
            {
                dataManager.AddUser(user);
            }
            this.Close();
            PageChangeRequested?.Invoke(new Admin());
        }
        private void cancelButton_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
