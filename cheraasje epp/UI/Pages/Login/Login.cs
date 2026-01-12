using cheraasje_epp.Data;
using cheraasje_epp.UI;
using cheraasje_epp.UI.Admin;


namespace cheraasje_epp.UI.Pages
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
            string userID = idBox.Text;      // haalt tekst uit idBox
            string password = passwordBox.Text; // haalt tekst uit passwordBox

            // Controleer of de velden niet leeg zijn of standaardtekst bevatten
            if (userID == "Employee ID..." || string.IsNullOrWhiteSpace(userID) ||
               password == "Password..." || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vul beide velden in!");
                return;
            }

            // Hier roep je je DataManager aan om te checken of de gebruiker bestaat
            DataManager dataManager = new DataManager();
            var boolean = dataManager.AuthenticateUser(userID, password);

            if (boolean)
            {
                Session.Start(int.Parse(userID));
                var user = dataManager.GetUser(Convert.ToInt32(idBox.Text));
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
                MessageBox.Show("Ongeldige login!");
            }

        }

    }
}
