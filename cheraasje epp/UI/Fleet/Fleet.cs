using cheraasje_epp.Data;
using cheraasje_epp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheraasje_epp.UI.Fleet
{
    public partial class Fleet : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        private DataManager dataManager = new DataManager();
        public Fleet()
        {
            InitializeComponent();
            int userId = Session.UserId;
            User user = dataManager.GetUser(userId);
            string branchName = dataManager.GetBranchById(user.BranchId).Name;
            BranchLabel.Text = branchName;
        }


        private void AddNewButton_Click(object sender, EventArgs e)
        {
        }
    }
}
