using cheraasje_epp.UI;

namespace cheraasje_epp
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void branchButton_Click(object sender, EventArgs e)
        {
            //TODO: implement branch page
            // MainForm.LoadPage(new Branch());
        }

        // Change color on hover
        private void branchButton_Mouse_Enter(object sender, EventArgs e)
        {
            branchButton.ForeColor = Color.Gray;
        }

        private void branchButton_Mouse_Leave(object sender, EventArgs e)
        {
            branchButton.ForeColor = Color.Black;
        }
    }
}
