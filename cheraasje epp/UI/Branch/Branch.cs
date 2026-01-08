using cheraasje_epp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheraasje_epp.UI.Branch
{
    public partial class Branch : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        public Branch()
        {
            InitializeComponent();
            BuildTimes();
            BuildInfo();
        }
        private void BuildTimes()
        {
            DataManager dataManager = new DataManager();
            var times = dataManager.GetTimes(Session.UserId);
            foreach (var time in times)
            {
                string displayTime = $"{time.OpenTime} - {time.CloseTime}";

                switch (time.Day)
                {
                    case 1: mondayLabel.Text = displayTime; break;
                    case 2: tuesdayLabel.Text = displayTime; break;
                    case 3: wednesdayLabel.Text = displayTime; break;
                    case 4: thursdayLabel.Text = displayTime; break;
                    case 5: fridayLabel.Text = displayTime; break;
                    case 6: saturdayLabel.Text = displayTime; break;
                    case 7: sundayLabel.Text = displayTime; break;
                }
            }
        }
        private void BuildInfo()
        {
            DataManager dataManager = new DataManager();
            var branch = dataManager.GetBranchById(Session.UserId);
            cityLabel.Text = branch.Location;
            adressLabel.Text = $"{branch.Adress} {branch.PostalCode}";
            ownerLabel.Text = branch.Owner;
            phoneLabel.Text = branch.PhoneNumber;
            branchLabel.Text = branch.Id.ToString();
        }
    }
}

