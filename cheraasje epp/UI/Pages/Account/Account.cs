using cheraasje_epp.Data;
using cheraasje_epp.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheraasje_epp.UI.Account
{
    public partial class Account : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        public Account()
        {
            InitializeComponent();
            var dataManager = new DataManager();
            int userId = Session.UserId;
            User user = dataManager.GetUser(userId);
            userNameLabel.Text = user.Name;
            UserIdLabel.Text = user.Id.ToString();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Session.End();
            PageChangeRequested?.Invoke(new Login());
        }
    }
}
