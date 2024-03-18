
namespace IDGEN.Gui.GuiUsers
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonSave = new Button();
            buttonSaveAndClose = new Button();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxName = new TextBox();
            groupBox1 = new GroupBox();
            textBoxPhoneNumber = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            label8 = new Label();
            label11 = new Label();
            label9 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label19 = new Label();
            label21 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            flowLayoutNavBar = new FlowLayoutPanel();
            button1 = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            dataGridView1 = new DataGridView();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 610);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 76);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.icons8_save_32px;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(14, 7);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(139, 55);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "حفظ ";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_32px_1;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(907, 7);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(213, 55);
            buttonSaveAndClose.TabIndex = 2;
            buttonSaveAndClose.Text = "حفظ وغلق";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(443, 58);
            label1.Name = "label1";
            label1.Size = new Size(126, 37);
            label1.TabIndex = 0;
            label1.Text = "الاسم الكامل";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(193, 150);
            label5.Name = "label5";
            label5.Size = new Size(0, 37);
            label5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(193, 235);
            label6.Name = "label6";
            label6.Size = new Size(0, 37);
            label6.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(16, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(376, 45);
            textBoxName.TabIndex = 0;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBoxPhoneNumber);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 592);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الكلية";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(16, 342);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(376, 45);
            textBoxPhoneNumber.TabIndex = 4;
            textBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(16, 272);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(376, 45);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(16, 199);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(376, 45);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(16, 125);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(376, 45);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(415, 207);
            label8.Name = "label8";
            label8.Size = new Size(25, 37);
            label8.TabIndex = 0;
            label8.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(424, 345);
            label11.Name = "label11";
            label11.Size = new Size(145, 37);
            label11.TabIndex = 0;
            label11.Text = "البريد الالكتروني";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(476, 275);
            label9.Name = "label9";
            label9.Size = new Size(93, 37);
            label9.TabIndex = 0;
            label9.Text = "رمز الكلية";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(394, 125);
            label3.Name = "label3";
            label3.Size = new Size(25, 37);
            label3.TabIndex = 0;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(469, 202);
            label4.Name = "label4";
            label4.Size = new Size(100, 37);
            label4.TabIndex = 0;
            label4.Text = "كلمة السر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 128);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 0;
            label2.Text = "اسم المستخدم";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(415, 55);
            label7.Name = "label7";
            label7.Size = new Size(25, 37);
            label7.TabIndex = 0;
            label7.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(462, 411);
            label10.Name = "label10";
            label10.Size = new Size(107, 37);
            label10.TabIndex = 0;
            label10.Text = "رقم الهاتف";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 408);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 45);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(437, 272);
            label12.Name = "label12";
            label12.Size = new Size(25, 37);
            label12.TabIndex = 0;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(448, 496);
            label13.Name = "label13";
            label13.Size = new Size(121, 37);
            label13.TabIndex = 0;
            label13.Text = "تفاصيل اخرى";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(17, 470);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(376, 116);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(flowLayoutNavBar);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(label26);
            groupBox2.Location = new Point(618, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 586);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "الاقسام العلمية";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(15, 446);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(331, 45);
            textBox6.TabIndex = 1;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(15, 376);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(331, 45);
            textBox7.TabIndex = 0;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(193, 235);
            label19.Name = "label19";
            label19.Size = new Size(0, 37);
            label19.TabIndex = 0;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Red;
            label21.Location = new Point(352, 431);
            label21.Name = "label21";
            label21.Size = new Size(25, 37);
            label21.TabIndex = 0;
            label21.Text = "*";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Red;
            label23.Location = new Point(193, 150);
            label23.Name = "label23";
            label23.Size = new Size(0, 37);
            label23.TabIndex = 0;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(396, 449);
            label24.Name = "label24";
            label24.Size = new Size(99, 37);
            label24.TabIndex = 0;
            label24.Text = "رمز القسم";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Red;
            label25.Location = new Point(358, 373);
            label25.Name = "label25";
            label25.Size = new Size(25, 37);
            label25.TabIndex = 0;
            label25.Text = "*";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(385, 379);
            label26.Name = "label26";
            label26.Size = new Size(110, 37);
            label26.TabIndex = 0;
            label26.Text = "اسم القسم";
            // 
            // flowLayoutNavBar
            // 
            flowLayoutNavBar.AutoScroll = true;
            flowLayoutNavBar.Controls.Add(button1);
            flowLayoutNavBar.Controls.Add(buttonEdit);
            flowLayoutNavBar.Controls.Add(buttonDelete);
            flowLayoutNavBar.Dock = DockStyle.Bottom;
            flowLayoutNavBar.Location = new Point(3, 511);
            flowLayoutNavBar.Name = "flowLayoutNavBar";
            flowLayoutNavBar.Padding = new Padding(5);
            flowLayoutNavBar.Size = new Size(496, 72);
            flowLayoutNavBar.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.icons8_add_32px;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(341, 10);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(140, 50);
            button1.TabIndex = 0;
            button1.Text = "اضافة";
            toolTip1.SetToolTip(button1, "اضافة قسم جديد");
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Image = Properties.Resources.icons8_edit_32px;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(191, 10);
            buttonEdit.Margin = new Padding(5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(140, 50);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "تعديل";
            toolTip1.SetToolTip(buttonEdit, "انقر دبل كلك ايسر على القسم لتعديله");
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Image = Properties.Resources.icons8_Delete_32px;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(41, 10);
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(140, 50);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "حذف";
            toolTip1.SetToolTip(buttonDelete, "حذف القسم المحدد");
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(15, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(469, 296);
            dataGridView1.TabIndex = 4;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 686);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل مستخدم";
            TopMost = true;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private TextBox textBox1;
        private Label label10;
        private Label label12;
        private RichTextBox richTextBox1;
        private Label label13;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label19;
        private Label label21;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private FlowLayoutPanel flowLayoutNavBar;
        private Button button1;
        private Button buttonEdit;
        private Button buttonDelete;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
    }
}