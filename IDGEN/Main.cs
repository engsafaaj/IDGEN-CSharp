namespace IDGEN
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Set Screen State 
            GetScreenState(Properties.Settings.Default.IsMaxScreen);
        }



        // Methods
        private void GetScreenState(bool state)
        {
            // State==Ture => Maximize
            // State==false => Normal
            if (state)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // Events
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.IsMaxScreen = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.IsMaxScreen = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
