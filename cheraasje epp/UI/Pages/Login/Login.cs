using CheraasjeEpp.Data;
using CheraasjeEpp.UI;
using CheraasjeEpp.UI.Admin;


namespace CheraasjeEpp.UI.Pages
{
    public partial class Login : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userID = userIdTextBox.Text;      // fetches text from userIdTextBox
            string password = passwordTextBox.Text; // fetches text from passwordTextBox

            // Check if fields are not empty or contain placeholder text
            if (userID == "Employee ID..." || string.IsNullOrWhiteSpace(userID) ||
               password == "Password..." || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both fields!");
                return;
            }

            // Call DataManager to check if user exists
            DataManager dataManager = new DataManager();
            var isAuthenticated = dataManager.AuthenticateUser(userID, password);

            if (isAuthenticated)
            {
                Session.Start(int.Parse(userID));
                var user = dataManager.GetUser(Convert.ToInt32(userIdTextBox.Text));
                if (dataManager.GetBranchById(user.BranchId) == null)
                {
                    if (user.IsAdmin)
                    {
                        Session.SafeLogin = true;
                        PageChangeRequested?.Invoke(new Admin());
                        return;
                    }
                    MessageBox.Show("You aren't added to a branch, please contact your admin for help");
                    return;

                }
                PageChangeRequested?.Invoke(new Home());
            }
            else
            {
                MessageBox.Show("Invalid login!");
            }

        }

    }
}
