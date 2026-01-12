using CheraasjeEpp.Data;
using CheraasjeEpp.Models.Entities;
using CheraasjeEpp.UI.Pages.AddUser;
using CheraasjeEpp.UI.Widgets;


namespace CheraasjeEpp.UI.Admin.Widgets
{
    public partial class UserItem : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        private readonly User User;
        public UserItem(User user)
        {
            InitializeComponent();
            nameLabel.Text = user.Name;
            User = user;
        }

        private void binButton_Click(object sender, EventArgs e)
        {
            if (User.Id == Session.UserId)
            {
                MessageBox.Show("Can't delete yourself");
                return;
            }
            var popUp = new PopUp($"Are you sure you want to delete {User.Name}?");
            if (popUp.ShowDialog(this) == DialogResult.OK)
            {
                DataManager dataManager = new DataManager();
                dataManager.DeleteUser(User.Id);
                this.Parent.Controls.Remove(this);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataManager dataManager = new DataManager();
            var user = dataManager.GetUser(User.Id);
            var popUp = new UserEditor(user, true);
            popUp.PageChangeRequested += (newPage) =>
            {
                this.PageChangeRequested?.Invoke(newPage);
            };
            popUp.Show(this);
        }
    }
}
