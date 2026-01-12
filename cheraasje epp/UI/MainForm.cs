using CheraasjeEpp.UI.Pages;

namespace CheraasjeEpp.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var loginPage = new Login();
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
