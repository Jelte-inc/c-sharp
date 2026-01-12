namespace CheraasjeEpp.UI.Widgets
{
    public partial class PopUp : Form
    {
        public PopUp(string message)
        {
            InitializeComponent();
            questionLabel.Text = message;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Of DialogResult.Yes
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Of DialogResult.No
            this.Close();
        }
    }
}
