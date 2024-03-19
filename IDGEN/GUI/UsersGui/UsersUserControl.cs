using IDGEN.Code;
using IDGEN.Gui.GuiUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDGEN.GUI.UsersGui
{
    public partial class UsersUserControl : UserControl
    {
        AddUserForm addForm;
        public UsersUserControl()
        {
            InitializeComponent();

            //Check if data grid view null
            labelNoData.Visible = dgvHelper.IsDataGridNull(mainDataGridView);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Open second form only if it dos not open
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new AddUserForm(this, 0);
                addForm.Show();
            }
            else
            {
                addForm.Focus();
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
