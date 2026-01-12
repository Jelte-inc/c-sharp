using cheraasje_epp.Data;
using BranchModel = cheraasje_epp.Models.Entities;

namespace cheraasje_epp.UI.Pages.AddUser
{
    public partial class BranchEditor : Form, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        private BranchModel.Branch Branch;
        private bool Update;
        public BranchEditor(BranchModel.Branch branch, bool update)
        {
            InitializeComponent();
            Branch = branch;
            Update = update;
            Build();
        }
        private void Build()
        {
            nameInputField.Text = Branch.Name;
            DataManager dataManager = new DataManager();
            var users = dataManager.GetUsers();
            ownerDropdown.DataSource = users;
            ownerDropdown.DisplayMember = "Name";
            ownerDropdown.ValueMember = "Id";
            if (Update)
            {
                locationInputField.Text = Branch.Location;
                adressInputField.Text = Branch.Adress;
                phoneInputField.Text = Branch.PhoneNumber;
                postalCodeInputField.Text = Branch.PostalCode;
                ownerDropdown.SelectedValue = Branch.Owner;
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            var inputs = new[]
            {
                nameInputField.Text,
                locationInputField.Text,
                adressInputField.Text,
                postalCodeInputField.Text,
                phoneInputField.Text
            };
            if (inputs.Any(string.IsNullOrWhiteSpace) || ownerDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields");
                return;
            }
            DataManager dataManager = new DataManager();
            var branch = new BranchModel.Branch();
            branch.Name = nameInputField.Text;
            branch.Location = locationInputField.Text;
            branch.Adress = adressInputField.Text;
            branch.PostalCode = postalCodeInputField.Text;
            branch.PhoneNumber = phoneInputField.Text;
            branch.Owner = Convert.ToInt32(ownerDropdown.SelectedValue);
            if (Update)
            {
                branch.Id = Branch.Id;
                dataManager.UpdateBranch(branch);
            }
            else
            {
                dataManager.AddBranch(branch);
            }
            PageChangeRequested?.Invoke(new Admin());
            this.Close();
        }
        private void cancelButton_Click(Object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
