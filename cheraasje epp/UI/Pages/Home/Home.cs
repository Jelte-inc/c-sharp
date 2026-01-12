using CheraasjeEpp.Data;
using User = CheraasjeEpp.Models.Entities.User;

namespace CheraasjeEpp.UI.Pages
{
    public partial class Home : UserControl, IPage
    {
        DataManager dataManager = new DataManager();

        public event Action<UserControl> PageChangeRequested;
        public Home()
        {
            InitializeComponent();
            int userId = Session.UserId;
            User user = dataManager.GetUser(userId);
            string branchName = dataManager.GetBranchById(user.BranchId).Name;
            string shortUserInfo = user.Name + " at " + branchName;
            shortUserInfoLabel.Text = shortUserInfo;
            if (!user.IsAdmin)
            {
                adminButton.Visible = false;
            }
        }

        private void PositionUserInfoLabel()
        {
            const int rightMargin = 20;
            const int topMargin = 18;

            shortUserInfoLabel.Location = new Point(
                ClientSize.Width - shortUserInfoLabel.Width - rightMargin,
                topMargin
            );
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PositionUserInfoLabel();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PositionUserInfoLabel();
        }


        private void LabelClick(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Account());
        }

        // Change color on hover
        private void LabelMouseEnter(object sender, EventArgs e)
        {
            // Check if sender is label and change color to gray on mouse enter
            if (sender is Label button)
                button.ForeColor = Color.Gray;
        }

        private void LabelMouseLeave(object sender, EventArgs e)
        {
            // Check if sender is label and change color to black on mouse leave
            if (sender is Label button)
                button.ForeColor = Color.Black;
        }

        private void branchButton_Click(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Branch());
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Account());
        }
        private void fleetButton_Click(Object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Fleet());
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Admin());
        }
    }
}
