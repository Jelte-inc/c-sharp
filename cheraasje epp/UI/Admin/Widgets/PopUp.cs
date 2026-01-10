using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheraasje_epp.UI.Admin.Widgets
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
