using cheraasje_epp.UI;
using cheraasje_epp.UI.Branch;
using cheraasje_epp.UI.Fleet;
using System.Security.Principal;

namespace cheraasje_epp
{
    public partial class Home : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;

        public Home()
        {
            InitializeComponent();
        }

        // Change color on hover
        private void LabelMouseEnter(object sender, EventArgs e)
        {
            if (sender is Label button)
                button.ForeColor = Color.Gray;
        }

        private void LabelMouseLeave(object sender, EventArgs e)
        {
            if (sender is Label button)
                button.ForeColor = Color.Black;
        }

        private void fleetButton_Click(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Fleet());
        }

        private void branchButton_Click(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(new Branch());
        }
    }
}
