
using DocumentFormat.OpenXml.Bibliography;
using IDGEN.Core;
using IDGEN.Data;
using IDGEN.Data.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IDGEN
{
    public partial class StartForm : Form
    {
        private readonly IDataHelper<Colleges> dataHelper;
        private int trycon;

        public StartForm()
        {
            InitializeComponent();
            dataHelper = new CollegeEF();
            labelCopyright.Text = "جميع الحقوق محفوظة © " + "2024 - " + DateTime.Now.Year;
            trycon = 1;
            labelState.Text = "جاري الاتصال ... يرجى الانتظار";
        }

        private async void CheckCon()
        {
            trycon++;
            labelState.Text = "جاري الاتصال ... يرجى الانتظار";

            if (await Task.Run(() => dataHelper.IsConAvailable()))
            {
                timer1.Enabled = false;
                // Login Form
                Gui.GuiUsers.UserLoginForm loginForm = new Gui.GuiUsers.UserLoginForm();
                loginForm.Show();
                Hide();

            }
            else
            {
                // No Connection
                labelState.Text = "فقد الاتصال ... سنعاود الاتصال بعد لحظات";
                await Task.Run(() => Thread.Sleep(2000));
                // ShowClose Button
                if (trycon > 2)
                {
                    linkLabelExit.Visible = true;
                    linkLabelSetCon.Visible = true;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckCon();
        }

        private void linkLabelSetCon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.GuiSettings.SettingsForm settingsForm = new Gui.GuiSettings.SettingsForm(); 
            settingsForm.Show();
        }
    }
}
