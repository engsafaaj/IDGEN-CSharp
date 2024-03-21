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
        }

        public static HomeUserControl Instance()
        {
            return _HomeUserControl ?? (new HomeUserControl());
        }
    }
}
