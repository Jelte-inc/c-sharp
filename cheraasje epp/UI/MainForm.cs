using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cheraasje_epp.UI;

namespace cheraasje_epp.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var loginPage = new Login();
            loginPage.PageChangeRequested += LoadPage;
            LoadPage(loginPage);
        }
        public void LoadPage(UserControl page)
        {
            pageContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pageContainer.Controls.Add(page);

            // Automatisch event koppelen als de pagina IPage implementeert
            if (page is IPage pageWithEvent)
            {
                pageWithEvent.PageChangeRequested += LoadPage;
            }
        }

    }
}
