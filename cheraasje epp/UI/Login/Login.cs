using cheraasje_epp.Data;
using cheraasje_epp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheraasje_epp
{
    public partial class Login : UserControl
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
            var user = dataManager.AuthenticateUser(userID, password);

            if (user != null)
            {
                PageChangeRequested?.Invoke(new Home());
            }
            else
            {
                MessageBox.Show("Ongeldige login!");
            }

        }

    }
}
