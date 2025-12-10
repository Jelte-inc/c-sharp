namespace cheraasje_epp
{
    public partial class Branch : UserControl
    {
        public Branch()
        {
            InitializeComponent();
        }

        private void LabelClick(object sender, EventArgs e)
        {
            // Todo: implement pageswitching
            //if (sender is Label button) 
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

    }
}
