using cheraasje_epp.UI;
using cheraasje_epp.UI.Pages;
using cheraasje_epp.UI.Branch;

using cheraasje_epp.UI;
using cheraasje_epp.UI.Account;
using cheraasje_epp.UI.Fleet;

namespace cheraasje_epp
{
    public partial class Home : UserControl, IPage
    {
        public event Action<UserControl> PageChangeRequested;
        public Home()
        {
            InitializeComponent();
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
    }
}
