
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            panel1 = new Panel();
            labelValidation = new Label();
            buttonCancel = new Button();
            buttonSaveAndClose = new Button();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxName = new TextBox();
            groupBox1 = new GroupBox();
            richTextBoxDetails = new RichTextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxEmail = new TextBox();
            textBoxCollegeCode = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            label13 = new Label();
            label10 = new Label();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            label9 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            labelNoData = new Label();
            flowLayoutNavBar = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonDelete = new Button();
            textBoxDepCode = new TextBox();
            textBoxDepName = new TextBox();
            label19 = new Label();
            label21 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            mainDataGridView = new DataGridView();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelValidation);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 610);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 76);
            panel1.TabIndex = 0;
            // 
            // labelValidation
            // 
            labelValidation.ForeColor = Color.Red;
            labelValidation.Location = new Point(235, 16);
            labelValidation.Name = "labelValidation";
            labelValidation.Size = new Size(718, 51);
            labelValidation.TabIndex = 3;
            labelValidation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            buttonCancel.Image = Properties.Resources.icons8_Cancel_32px_1;
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(14, 7);
            buttonCancel.Margin = new Padding(5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(202, 55);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "الغاء الامر";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_32px_1;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(979, 7);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(141, 55);
            buttonSaveAndClose.TabIndex = 9;
            buttonSaveAndClose.Text = "حفظ";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
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
            toolTip1.SetToolTip(textBoxName, "ادخل اسم الكلية الكامل");
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.Enter += textBoxName_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(textBoxPhoneNumber);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxCollegeCode);
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
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(17, 470);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(376, 116);
            richTextBoxDetails.TabIndex = 6;
            richTextBoxDetails.Text = "";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(16, 408);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(376, 45);
            textBoxPhoneNumber.TabIndex = 5;
            textBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
            textBoxPhoneNumber.TextChanged += textBox1_TextChanged;
            textBoxPhoneNumber.Enter += textBox1_Enter;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(16, 342);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(376, 45);
            textBoxEmail.TabIndex = 4;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            textBoxEmail.TextChanged += textBoxPhoneNumber_TextChanged;
            textBoxEmail.Enter += textBoxPhoneNumber_Enter;
            // 
            // textBoxCollegeCode
            // 
            textBoxCollegeCode.Location = new Point(16, 272);
            textBoxCollegeCode.Name = "textBoxCollegeCode";
            textBoxCollegeCode.Size = new Size(376, 45);
            textBoxCollegeCode.TabIndex = 3;
            textBoxCollegeCode.Text = "0000";
            textBoxCollegeCode.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxCollegeCode, "رمز الكلية يتكون من 4 مراتب");
            textBoxCollegeCode.TextChanged += textBoxEmail_TextChanged;
            textBoxCollegeCode.Enter += textBoxEmail_Enter;
            textBoxCollegeCode.MouseLeave += textBoxCollegeCode_MouseLeave;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(16, 199);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(376, 45);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxPassword, "ادخل كلمة سر قوية لا تقل عن 6 احرف");
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            textBoxPassword.Enter += textBoxPassword_Enter;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(16, 125);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(376, 45);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxUserName, "اسم المستخدم الذي يتم التسجيل الدخول من خلاله");
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            textBoxUserName.Enter += textBoxUserName_Enter;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(462, 411);
            label10.Name = "label10";
            label10.Size = new Size(107, 37);
            label10.TabIndex = 0;
            label10.Text = "رقم الهاتف";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(labelNoData);
            groupBox2.Controls.Add(flowLayoutNavBar);
            groupBox2.Controls.Add(textBoxDepCode);
            groupBox2.Controls.Add(textBoxDepName);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(mainDataGridView);
            groupBox2.Location = new Point(618, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 586);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "الاقسام العلمية";
            // 
            // labelNoData
            // 
            labelNoData.Anchor = AnchorStyles.None;
            labelNoData.AutoSize = true;
            labelNoData.BackColor = Color.White;
            labelNoData.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNoData.ForeColor = SystemColors.ActiveBorder;
            labelNoData.Location = new Point(181, 167);
            labelNoData.Name = "labelNoData";
            labelNoData.Size = new Size(132, 37);
            labelNoData.TabIndex = 7;
            labelNoData.Text = "لا يوجد بيانات";
            labelNoData.Visible = false;
            // 
            // flowLayoutNavBar
            // 
            flowLayoutNavBar.AutoScroll = true;
            flowLayoutNavBar.Controls.Add(buttonAdd);
            flowLayoutNavBar.Controls.Add(buttonDelete);
            flowLayoutNavBar.Dock = DockStyle.Bottom;
            flowLayoutNavBar.Location = new Point(3, 511);
            flowLayoutNavBar.Name = "flowLayoutNavBar";
            flowLayoutNavBar.Padding = new Padding(5);
            flowLayoutNavBar.Size = new Size(496, 72);
            flowLayoutNavBar.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Image = Properties.Resources.icons8_add_32px;
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(341, 10);
            buttonAdd.Margin = new Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(140, 50);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "اضافة";
            toolTip1.SetToolTip(buttonAdd, "اضافة قسم جديد");
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Image = Properties.Resources.icons8_Delete_32px;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(191, 10);
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(140, 50);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "حذف";
            toolTip1.SetToolTip(buttonDelete, "حذف القسم المحدد");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxDepCode
            // 
            textBoxDepCode.Location = new Point(15, 446);
            textBoxDepCode.Name = "textBoxDepCode";
            textBoxDepCode.Size = new Size(331, 45);
            textBoxDepCode.TabIndex = 8;
            textBoxDepCode.Text = "00";
            textBoxDepCode.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxDepCode, "رمز القسم متكون من مرتبتين");
            textBoxDepCode.TextChanged += textBox6_TextChanged;
            textBoxDepCode.Enter += textBox6_Enter;
            textBoxDepCode.MouseLeave += textBoxDepCode_MouseLeave;
            // 
            // textBoxDepName
            // 
            textBoxDepName.Location = new Point(15, 376);
            textBoxDepName.Name = "textBoxDepName";
            textBoxDepName.Size = new Size(331, 45);
            textBoxDepName.TabIndex = 7;
            textBoxDepName.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxDepName, "اسم القسم العلمي");
            textBoxDepName.TextChanged += textBox7_TextChanged;
            textBoxDepName.Enter += textBox7_Enter;
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
            label21.Location = new Point(360, 431);
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
            label24.Location = new Point(391, 446);
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
            // mainDataGridView
            // 
            mainDataGridView.AllowUserToAddRows = false;
            mainDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            mainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mainDataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            mainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            mainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            mainDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            mainDataGridView.Location = new Point(15, 44);
            mainDataGridView.Name = "mainDataGridView";
            mainDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            mainDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            mainDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            mainDataGridView.RowTemplate.Height = 29;
            mainDataGridView.Size = new Size(469, 312);
            mainDataGridView.TabIndex = 9;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 686);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل كلية";
            Load += AddUserForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCollegeCode;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private TextBox textBoxPhoneNumber;
        private Label label10;
        private Label label12;
        private RichTextBox richTextBoxDetails;
        private Label label13;
        private GroupBox groupBox2;
        private TextBox textBoxDepCode;
        private TextBox textBoxDepName;
        private Label label19;
        private Label label21;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private FlowLayoutPanel flowLayoutNavBar;
        private Button buttonAdd;
        private Button buttonDelete;
        private ToolTip toolTip1;
        private Label labelNoData;
        private Label labelValidation;
        private DataGridView mainDataGridView;
        public GroupBox groupBox1;
    }
}