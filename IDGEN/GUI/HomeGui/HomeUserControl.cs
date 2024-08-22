using IDGEN.Code;
using IDGEN.GUI.UsersGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDGEN.GUI.HomeGui
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl? _HomeUserControl;

        public HomeUserControl()
        {
            InitializeComponent();
            labelTime.Text = DateTime.Now.ToShortTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();

            SetGeneralSettings();

            SetHello();
        }

        public static HomeUserControl Instance()
        {
            return _HomeUserControl ?? (new HomeUserControl());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void SetGeneralSettings()
        {
            labelCompanyName.Text = Properties.Settings.Default.CompanyName;

            // Set Picture

            if (Properties.Settings.Default.CompanyLogo != string.Empty) // Check if first open
            {
                var ImgaeAsByte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo); // Convert string to byte

                using (MemoryStream ma = new MemoryStream(ImgaeAsByte))
                {
                    pictureBoxLogo.Image = Image.FromStream(ma); // Set picture
                }
            }
        }

        private void SetHello()
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Check if it's morning (before 12:00 PM)
            if (currentTime.Hour < 12)
            {
                labelWellcome.Text = "صباح الخير " + LoggedUser.CollegeName;
            }
            else // It's afternoon
            {
                labelWellcome.Text = "مساء الخير " + LoggedUser.CollegeName;
            }
        }
    }
}
