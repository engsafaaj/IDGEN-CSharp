
namespace IDGEN.Gui.StudnetGui
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            panel1 = new Panel();
            labelValidation = new Label();
            buttonSaveAndClose = new Button();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxFullName = new TextBox();
            groupBox1 = new GroupBox();
            comboBoxStudentGender = new ComboBox();
            comboBoxStudyType = new ComboBox();
            comboBoxAdmChannel = new ComboBox();
            comboBoxCollegeName = new ComboBox();
            comboBoxStudySystem = new ComboBox();
            comboBoxDep = new ComboBox();
            pictureBox1 = new PictureBox();
            label16 = new Label();
            textBoxAddYear = new TextBox();
            textBoxStudentID = new TextBox();
            textBoxUniversityName = new TextBox();
            label22 = new Label();
            label20 = new Label();
            label12 = new Label();
            label8 = new Label();
            label15 = new Label();
            label11 = new Label();
            label19 = new Label();
            label14 = new Label();
            label21 = new Label();
            label3 = new Label();
            label18 = new Label();
            label10 = new Label();
            label4 = new Label();
            label13 = new Label();
            label17 = new Label();
            label9 = new Label();
            label2 = new Label();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            buttonPrint = new Button();
            buttonCopy = new Button();
            groupBox2 = new GroupBox();
            textBoxStudentFinalID = new TextBox();
            pictureBox2 = new PictureBox();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            panelPrint = new Panel();
            linkLabelDep = new LinkLabel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelPrint.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelValidation);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 695);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 76);
            panel1.TabIndex = 0;
            // 
            // labelValidation
            // 
            labelValidation.ForeColor = Color.Red;
            labelValidation.Location = new Point(25, 16);
            labelValidation.Name = "labelValidation";
            labelValidation.Size = new Size(928, 51);
            labelValidation.TabIndex = 3;
            labelValidation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_32px_1;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(1036, 12);
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
            label1.Location = new Point(1010, 59);
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
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(553, 56);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(415, 45);
            textBoxFullName.TabIndex = 0;
            textBoxFullName.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxFullName, "الاسم الكامل للطالب");
            textBoxFullName.TextChanged += textBoxName_TextChanged;
            textBoxFullName.Enter += textBoxName_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabelDep);
            groupBox1.Controls.Add(comboBoxStudentGender);
            groupBox1.Controls.Add(comboBoxStudyType);
            groupBox1.Controls.Add(comboBoxAdmChannel);
            groupBox1.Controls.Add(comboBoxCollegeName);
            groupBox1.Controls.Add(comboBoxStudySystem);
            groupBox1.Controls.Add(comboBoxDep);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(textBoxAddYear);
            groupBox1.Controls.Add(textBoxStudentID);
            groupBox1.Controls.Add(textBoxUniversityName);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(textBoxFullName);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1149, 420);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الطالب";
            // 
            // comboBoxStudentGender
            // 
            comboBoxStudentGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStudentGender.FormattingEnabled = true;
            comboBoxStudentGender.Items.AddRange(new object[] { "ذكر", "انثى" });
            comboBoxStudentGender.Location = new Point(249, 351);
            comboBoxStudentGender.Name = "comboBoxStudentGender";
            comboBoxStudentGender.Size = new Size(264, 45);
            comboBoxStudentGender.TabIndex = 8;
            comboBoxStudentGender.SelectedIndexChanged += comboBoxStudentGender_SelectedIndexChanged;
            // 
            // comboBoxStudyType
            // 
            comboBoxStudyType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStudyType.FormattingEnabled = true;
            comboBoxStudyType.Items.AddRange(new object[] { "صباحي", "مسائي" });
            comboBoxStudyType.Location = new Point(249, 277);
            comboBoxStudyType.Name = "comboBoxStudyType";
            comboBoxStudyType.Size = new Size(264, 45);
            comboBoxStudyType.TabIndex = 6;
            comboBoxStudyType.SelectedIndexChanged += comboBoxStudyType_SelectedIndexChanged;
            // 
            // comboBoxAdmChannel
            // 
            comboBoxAdmChannel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAdmChannel.FormattingEnabled = true;
            comboBoxAdmChannel.Items.AddRange(new object[] { "مركزي", "موازي", "نقل", "استضافة" });
            comboBoxAdmChannel.Location = new Point(704, 351);
            comboBoxAdmChannel.Name = "comboBoxAdmChannel";
            comboBoxAdmChannel.Size = new Size(264, 45);
            comboBoxAdmChannel.TabIndex = 7;
            comboBoxAdmChannel.SelectedIndexChanged += comboBoxAdmChannel_SelectedIndexChanged;
            // 
            // comboBoxCollegeName
            // 
            comboBoxCollegeName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCollegeName.FormattingEnabled = true;
            comboBoxCollegeName.Items.AddRange(new object[] { "بكالوريوس", "دبلوم", "ماجستير", "دكتوراه" });
            comboBoxCollegeName.Location = new Point(246, 133);
            comboBoxCollegeName.Name = "comboBoxCollegeName";
            comboBoxCollegeName.Size = new Size(264, 45);
            comboBoxCollegeName.TabIndex = 2;
            comboBoxCollegeName.SelectedIndexChanged += comboBoxCollegeName_SelectedIndexChanged;
            // 
            // comboBoxStudySystem
            // 
            comboBoxStudySystem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStudySystem.FormattingEnabled = true;
            comboBoxStudySystem.Items.AddRange(new object[] { "بكالوريوس", "دبلوم", "ماجستير", "دكتوراه" });
            comboBoxStudySystem.Location = new Point(704, 277);
            comboBoxStudySystem.Name = "comboBoxStudySystem";
            comboBoxStudySystem.Size = new Size(264, 45);
            comboBoxStudySystem.TabIndex = 5;
            comboBoxStudySystem.SelectedIndexChanged += comboBoxStudySystem_SelectedIndexChanged;
            // 
            // comboBoxDep
            // 
            comboBoxDep.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDep.FormattingEnabled = true;
            comboBoxDep.Location = new Point(704, 203);
            comboBoxDep.Name = "comboBoxDep";
            comboBoxDep.Size = new Size(264, 45);
            comboBoxDep.TabIndex = 3;
            comboBoxDep.SelectedIndexChanged += comboBoxDep_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_student_male_480px;
            pictureBox1.Location = new Point(6, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Red;
            label16.Location = new Point(516, 348);
            label16.Name = "label16";
            label16.Size = new Size(25, 37);
            label16.TabIndex = 0;
            label16.Text = "*";
            // 
            // textBoxAddYear
            // 
            textBoxAddYear.Location = new Point(249, 203);
            textBoxAddYear.Name = "textBoxAddYear";
            textBoxAddYear.Size = new Size(261, 45);
            textBoxAddYear.TabIndex = 4;
            textBoxAddYear.Text = "23";
            textBoxAddYear.TextAlign = HorizontalAlignment.Center;
            textBoxAddYear.TextChanged += textBoxAdmYear_TextChanged;
            textBoxAddYear.Enter += textBox1_Enter_1;
            textBoxAddYear.MouseLeave += textBoxAddYear_MouseLeave;
            // 
            // textBoxStudentID
            // 
            textBoxStudentID.Location = new Point(249, 56);
            textBoxStudentID.Name = "textBoxStudentID";
            textBoxStudentID.Size = new Size(171, 45);
            textBoxStudentID.TabIndex = 1;
            textBoxStudentID.Text = "000";
            textBoxStudentID.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxStudentID, "تسلسل الطالب حسب القوائم التسجيل");
            textBoxStudentID.TextChanged += textBoxStudentID_TextChanged;
            textBoxStudentID.Enter += textBoxStudentID_Enter;
            textBoxStudentID.MouseLeave += textBoxStudentID_MouseLeave;
            // 
            // textBoxUniversityName
            // 
            textBoxUniversityName.Location = new Point(704, 129);
            textBoxUniversityName.Name = "textBoxUniversityName";
            textBoxUniversityName.ReadOnly = true;
            textBoxUniversityName.Size = new Size(264, 45);
            textBoxUniversityName.TabIndex = 0;
            textBoxUniversityName.Text = "تكنو U";
            textBoxUniversityName.TextAlign = HorizontalAlignment.Center;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Red;
            label22.Location = new Point(426, 41);
            label22.Name = "label22";
            label22.Size = new Size(25, 37);
            label22.TabIndex = 0;
            label22.Text = "*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Red;
            label20.Location = new Point(516, 129);
            label20.Name = "label20";
            label20.Size = new Size(25, 37);
            label20.TabIndex = 0;
            label20.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(516, 275);
            label12.Name = "label12";
            label12.Size = new Size(25, 37);
            label12.TabIndex = 0;
            label12.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(516, 202);
            label8.Name = "label8";
            label8.Size = new Size(25, 37);
            label8.TabIndex = 0;
            label8.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(988, 349);
            label15.Name = "label15";
            label15.Size = new Size(25, 37);
            label15.TabIndex = 0;
            label15.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(969, 272);
            label11.Name = "label11";
            label11.Size = new Size(25, 37);
            label11.TabIndex = 0;
            label11.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(1024, 118);
            label19.Name = "label19";
            label19.Size = new Size(25, 37);
            label19.TabIndex = 0;
            label19.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(536, 360);
            label14.Name = "label14";
            label14.Size = new Size(117, 37);
            label14.TabIndex = 0;
            label14.Text = "جنس الطالب";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(442, 59);
            label21.Name = "label21";
            label21.Size = new Size(88, 37);
            label21.TabIndex = 0;
            label21.Text = "التسلسل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(1046, 195);
            label3.Name = "label3";
            label3.Size = new Size(25, 37);
            label3.TabIndex = 0;
            label3.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(536, 141);
            label18.Name = "label18";
            label18.Size = new Size(65, 37);
            label18.TabIndex = 0;
            label18.Text = "الكلية";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(536, 287);
            label10.Name = "label10";
            label10.Size = new Size(110, 37);
            label10.TabIndex = 0;
            label10.Text = "نوع الدراسة";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(536, 214);
            label4.Name = "label4";
            label4.Size = new Size(111, 37);
            label4.TabIndex = 0;
            label4.Text = "سنة القبول";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1024, 352);
            label13.Name = "label13";
            label13.Size = new Size(112, 37);
            label13.TabIndex = 0;
            label13.Text = "قناة القبول";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1052, 136);
            label17.Name = "label17";
            label17.Size = new Size(84, 37);
            label17.TabIndex = 0;
            label17.Text = "الجامعة";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(988, 280);
            label9.Name = "label9";
            label9.Size = new Size(148, 37);
            label9.TabIndex = 0;
            label9.Text = "مستوى الدراسة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1065, 208);
            label2.Name = "label2";
            label2.Size = new Size(71, 37);
            label2.TabIndex = 0;
            label2.Text = "القسم";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(990, 56);
            label7.Name = "label7";
            label7.Size = new Size(25, 37);
            label7.TabIndex = 0;
            label7.Text = "*";
            // 
            // buttonPrint
            // 
            buttonPrint.Image = Properties.Resources.icons8_printer_32px;
            buttonPrint.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPrint.Location = new Point(58, 110);
            buttonPrint.Margin = new Padding(5);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(40, 40);
            buttonPrint.TabIndex = 10;
            toolTip1.SetToolTip(buttonPrint, "طباعة");
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.Image = Properties.Resources.icons8_copy_32px;
            buttonCopy.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCopy.Location = new Point(8, 110);
            buttonCopy.Margin = new Padding(5);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(40, 40);
            buttonCopy.TabIndex = 11;
            toolTip1.SetToolTip(buttonCopy, "نسخ");
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStudentFinalID);
            groupBox2.Controls.Add(buttonPrint);
            groupBox2.Controls.Add(buttonCopy);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(label30);
            groupBox2.Controls.Add(label29);
            groupBox2.Controls.Add(label28);
            groupBox2.Controls.Add(label27);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label23);
            groupBox2.Location = new Point(11, 479);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1167, 188);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "معرف الطالب";
            // 
            // textBoxStudentFinalID
            // 
            textBoxStudentFinalID.Font = new Font("Cairo", 28F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxStudentFinalID.Location = new Point(120, 78);
            textBoxStudentFinalID.Name = "textBoxStudentFinalID";
            textBoxStudentFinalID.ReadOnly = true;
            textBoxStudentFinalID.RightToLeft = RightToLeft.No;
            textBoxStudentFinalID.Size = new Size(934, 95);
            textBoxStudentFinalID.TabIndex = 0;
            textBoxStudentFinalID.Text = "28    0001    01    24    1    1    11    1    000";
            textBoxStudentFinalID.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_Video_Id_Verification_480px;
            pictureBox2.Location = new Point(1083, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label31.ForeColor = Color.Gray;
            label31.Location = new Point(917, 46);
            label31.Name = "label31";
            label31.Size = new Size(66, 29);
            label31.TabIndex = 0;
            label31.Text = "التسلسل";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label30.ForeColor = Color.Gray;
            label30.Location = new Point(830, 46);
            label30.Name = "label30";
            label30.Size = new Size(53, 29);
            label30.TabIndex = 0;
            label30.Text = "الجنس";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label29.ForeColor = Color.Gray;
            label29.Location = new Point(755, 46);
            label29.Name = "label29";
            label29.Size = new Size(48, 29);
            label29.TabIndex = 0;
            label29.Text = "القناة";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = Color.Gray;
            label28.Location = new Point(678, 46);
            label28.Name = "label28";
            label28.Size = new Size(42, 29);
            label28.TabIndex = 0;
            label28.Text = "النوع";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label27.ForeColor = Color.Gray;
            label27.Location = new Point(601, 46);
            label27.Name = "label27";
            label27.Size = new Size(70, 29);
            label27.TabIndex = 0;
            label27.Text = "المستوى";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.Gray;
            label26.Location = new Point(529, 46);
            label26.Name = "label26";
            label26.Size = new Size(54, 29);
            label26.TabIndex = 0;
            label26.Text = "القبول";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.Gray;
            label25.Location = new Point(433, 46);
            label25.Name = "label25";
            label25.Size = new Size(54, 29);
            label25.TabIndex = 0;
            label25.Text = "القسم";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.Gray;
            label24.Location = new Point(320, 46);
            label24.Name = "label24";
            label24.Size = new Size(49, 29);
            label24.TabIndex = 0;
            label24.Text = "الكلية";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.Gray;
            label23.Location = new Point(197, 46);
            label23.Name = "label23";
            label23.Size = new Size(63, 29);
            label23.TabIndex = 0;
            label23.Text = "الجامعة";
            // 
            // panelPrint
            // 
            panelPrint.Controls.Add(groupBox2);
            panelPrint.Controls.Add(groupBox1);
            panelPrint.Location = new Point(0, 3);
            panelPrint.Name = "panelPrint";
            panelPrint.Size = new Size(1200, 677);
            panelPrint.TabIndex = 3;
            // 
            // linkLabelDep
            // 
            linkLabelDep.AutoSize = true;
            linkLabelDep.Location = new Point(969, 206);
            linkLabelDep.Name = "linkLabelDep";
            linkLabelDep.Size = new Size(55, 37);
            linkLabelDep.TabIndex = 9;
            linkLabelDep.TabStop = true;
            linkLabelDep.Text = "جديد";
            linkLabelDep.LinkClicked += linkLabelDep_LinkClicked;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 771);
            Controls.Add(panel1);
            Controls.Add(panelPrint);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddStudentForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل طالب";
            Load += AddUserForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelPrint.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFullName;
        private ToolTip toolTip1;
        private Label labelValidation;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox comboBoxDep;
        private Label label8;
        private Label label4;
        private ComboBox comboBoxStudyType;
        private ComboBox comboBoxStudySystem;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label3;
        private Label label7;
        private ComboBox comboBoxStudentGender;
        private ComboBox comboBoxAdmChannel;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox textBoxUniversityName;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private TextBox textBoxStudentID;
        private Label label22;
        private Label label21;
        private TextBox textBoxStudentFinalID;
        private PictureBox pictureBox2;
        private TextBox textBoxAddYear;
        private ComboBox comboBoxCollegeName;
        private Label label23;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        public Button buttonSaveAndClose;
        public GroupBox groupBox1;
        public Panel panel1;
        public Button buttonPrint;
        public Button buttonCopy;
        public GroupBox groupBox2;
        private Panel panelPrint;
        private LinkLabel linkLabelDep;
    }
}