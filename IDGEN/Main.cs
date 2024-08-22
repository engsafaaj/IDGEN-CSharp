using DocumentFormat.OpenXml.Drawing;
using IDGEN.Code;
using IDGEN.Data.EF;
using IDGEN.Gui.GuiSettings;
using IDGEN.Gui.StudnetGui;
using IDGEN.GUI.GuiAbout;
using IDGEN.GUI.HomeGui;
using IDGEN.GUI.LogsGui;
using IDGEN.GUI.StudnetGui;
using IDGEN.GUI.UsersGui;
using Microsoft.EntityFrameworkCore;
namespace IDGEN
{
    public partial class Main : Form
    {
        // Fields
        private PageManager pageManager;
        private static Main? _Main;

        SettingsForm settingsForm;
        private AboutBox boutBox;
        private DataContext dbContext;

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
            SetRoles();

            // 

            dbContext = new DataContext();

        }



        // Methods

        public static Main Instance()
        {
            return _Main ?? (new Main());
        }

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
            this.Text = text;
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

            Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(HomeUserControl.Instance());
            ChangeTextOfMainPage(buttonHome.Text);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(UsersUserControl.Instance(this));
            ChangeTextOfMainPage(buttonUsers.Text);
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(StudentUserControl.Instance(this));
            ChangeTextOfMainPage(buttonStudents.Text);
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(LogsUserControl.Instance(this));
            ChangeTextOfMainPage(buttonLogs.Text);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            // Open second form only if it dose not open
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new SettingsForm();
                if (!settingsForm.IsDisposed)
                {
                    settingsForm.Show();
                }
            }
            else
            {
                settingsForm.Focus();
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // Open second form only if it dose not open
            if (boutBox == null || boutBox.IsDisposed)
            {
                boutBox = new AboutBox();
                if (!boutBox.IsDisposed)
                {
                    boutBox.Show();
                }
            }
            else
            {
                boutBox.Focus();
            }
        }

        private void SetRoles()
        {
            if (!Code.LoggedUser.IsAdmin)
            {
                buttonUsers.Visible = false;
                buttonLogs.Visible = false;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {

            // No Connection
            var IsConnect = await dbContext.Database.CanConnectAsync();
            if (!IsConnect)
            {
                panelContainer.Enabled = false;
                flowLayoutPanel1.Enabled = false;

                panelConnection.Visible = true;
            }

            if (IsConnect) // Connect
            {


                panelContainer.Enabled = true;
                flowLayoutPanel1.Enabled = true;

                panelConnection.Visible = false;

            }

        }
    }
}
