using IDGEN.Code;
namespace IDGEN
{
    public partial class Main : Form
    {
        // Fields
        private PageManager pageManager;


        // Constructors
        public Main()
        {
            InitializeComponent();

            // Set Screen State 
            GetScreenState(Properties.Settings.Default.IsMaxScreen);

            // Page Manger
            pageManager = new PageManager(this);

            // Load Home Page
            pageManager.LoadPage(new GUI.HomeGui.HomeUserControl());
            ChangeTextOfMainPage(buttonHome.Text);

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

        // Change Label of Main Page

        private void ChangeTextOfMainPage(string text)
        {
           this. Text= text;
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

        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(new GUI.HomeGui.HomeUserControl());
            ChangeTextOfMainPage(buttonHome.Text);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(new GUI.UsersGui.UsersUserControl());
            ChangeTextOfMainPage(buttonUsers.Text);
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(new GUI.UsersGui.UsersUserControl());
            ChangeTextOfMainPage(buttonStudents.Text);
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(new GUI.UsersGui.UsersUserControl());
            ChangeTextOfMainPage(buttonLogs.Text);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
        }
    }
}
