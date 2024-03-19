
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IDGEN.Gui.GuiUsers
{
    public partial class AddUserForm : Form
    {
        // Fields
        private readonly UsersUserControl pageControl;


        public AddUserForm(UsersUserControl pageControl, int Id)
        {
            InitializeComponent();

            this.pageControl = pageControl; // Inint Page User Control
            labelNoData.Visible = dgvHelper.IsDataGridNull(mainDataGridView);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "اسم الكلية: يمثل الاسم الكامل لها";
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "اسم المستخدم: يستخدم لتسجيل الدخول للكلية";
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "كلمة السر: يفضل ان تكون كلمة السر قوية ولا تقل عن 6 احرف";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            // Validate the text to ensure it represents a non-negative integer
            if (!int.TryParse(textBoxCollegeCode.Text, out int value) || value < 0)
            {
                // If the text is not a valid non-negative integer, reset the text to empty
                textBoxCollegeCode.Text = "0000";
                labelValidation.Text = "رمز الكلية:يتكون رمز الكلية من 4 مراتب ويكون مختلف لكل كلية";
            }
            // Trim the text to a maximum length of 4 characters
            if (textBoxCollegeCode.Text.Length > 4)
            {
                textBoxCollegeCode.Text = textBoxCollegeCode.Text.Substring(0, 4);
            }
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "البريد الالكتروني:يعتبر وسيلة اتصال رسمية";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "رقم الهاتف:ادخل رقم الهاتف بصيغته الكاملة";

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "القسم العلمي:ادخل اسم القسم العلمي حتى لو كانت الكلية ذا قسم واحد";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Validate the text to ensure it represents a non-negative integer
            if (!int.TryParse(textBoxDepCode.Text, out int value) || value < 0)
            {
                // If the text is not a valid non-negative integer, reset the text to empty
                textBoxDepCode.Text = "0";
                labelValidation.Text = "رمز القسم:يتكون رمز القسم من مرتبة واحدة فقط";
            }
            // Trim the text to a maximum length of 4 characters
            if (textBoxDepCode.Text.Length > 1)
            {
                textBoxDepCode.Text = textBoxDepCode.Text.Substring(0, 1);
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "اسم الكلية: يمثل الاسم الكامل لها";

        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "اسم المستخدم: يستخدم لتسجيل الدخول للكلية";
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "كلمة السر: يفضل ان تكون كلمة السر قوية ولا تقل عن 6 احرف";
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "رمز الكلية:يتكون رمز الكلية من 4 مراتب ويكون مختلف لكل كلية";
        }

        private void textBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "البريد الالكتروني:يعتبر وسيلة اتصال رسمية";

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "رقم الهاتف:ادخل رقم الهاتف بصيغته الكاملة";
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "القسم العلمي:ادخل اسم القسم العلمي حتى لو كانت الكلية ذا قسم واحد";

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "رمز القسم:يتكون رمز القسم من مرتبة واحدة فقط";
        }


        private bool IsTextBoxValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxDepCode.Text) ||
                string.IsNullOrWhiteSpace(textBoxDepName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxCollegeCode.Text) ||
                string.IsNullOrWhiteSpace(textBoxUserName.Text)
                )
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
