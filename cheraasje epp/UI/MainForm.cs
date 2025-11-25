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
            LoadPage(new Home());
        }
        public void LoadPage(UserControl page)
        {
            pageContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pageContainer.Controls.Add(page);
        }

    }
}
