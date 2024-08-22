
namespace IDGEN.Gui.GuiSettings
{
    partial class SettingsForm
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
            groupBox1 = new GroupBox();
            buttonSaveGeneralSettings = new Button();
            linkLabelImportImage = new LinkLabel();
            pictureBoxLogo = new PictureBox();
            numericUpDownDataRow = new NumericUpDown();
            numericUpDownNotification = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxCompany = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            buttonSaveConString = new Button();
            radioButtonNetworkCon = new RadioButton();
            radioButtonLocalCon = new RadioButton();
            label7 = new Label();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            textBoxDataBase = new TextBox();
            label9 = new Label();
            label8 = new Label();
            numericUpDownTimeout = new NumericUpDown();
            label6 = new Label();
            textBoxServer = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotification).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSaveGeneralSettings);
            groupBox1.Controls.Add(linkLabelImportImage);
            groupBox1.Controls.Add(pictureBoxLogo);
            groupBox1.Controls.Add(numericUpDownDataRow);
            groupBox1.Controls.Add(numericUpDownNotification);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 625);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "الاعدادات العامة";
            // 
            // buttonSaveGeneralSettings
            // 
            buttonSaveGeneralSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveGeneralSettings.Location = new Point(17, 553);
            buttonSaveGeneralSettings.Margin = new Padding(5);
            buttonSaveGeneralSettings.Name = "buttonSaveGeneralSettings";
            buttonSaveGeneralSettings.Size = new Size(471, 55);
            buttonSaveGeneralSettings.TabIndex = 8;
            buttonSaveGeneralSettings.Text = "حفظ الاعدادات";
            buttonSaveGeneralSettings.UseVisualStyleBackColor = true;
            buttonSaveGeneralSettings.Click += buttonSaveGeneralSettings_Click;
            // 
            // linkLabelImportImage
            // 
            linkLabelImportImage.AutoSize = true;
            linkLabelImportImage.Location = new Point(198, 482);
            linkLabelImportImage.Name = "linkLabelImportImage";
            linkLabelImportImage.Size = new Size(68, 37);
            linkLabelImportImage.TabIndex = 4;
            linkLabelImportImage.TabStop = true;
            linkLabelImportImage.Text = "تحميل";
            linkLabelImportImage.LinkClicked += linkLabelImportImage_LinkClicked;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo;
            pictureBoxLogo.Location = new Point(123, 312);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(219, 167);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // numericUpDownDataRow
            // 
            numericUpDownDataRow.Location = new Point(17, 193);
            numericUpDownDataRow.Name = "numericUpDownDataRow";
            numericUpDownDataRow.Size = new Size(150, 45);
            numericUpDownDataRow.TabIndex = 2;
            numericUpDownDataRow.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // numericUpDownNotification
            // 
            numericUpDownNotification.Location = new Point(17, 115);
            numericUpDownNotification.Name = "numericUpDownNotification";
            numericUpDownNotification.Size = new Size(150, 45);
            numericUpDownNotification.TabIndex = 2;
            numericUpDownNotification.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(176, 266);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 0;
            label4.Text = "شعار المؤسسة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(323, 199);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 0;
            label3.Text = "عدد البيانات المعروضة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(277, 121);
            label2.Name = "label2";
            label2.Size = new Size(213, 32);
            label2.TabIndex = 0;
            label2.Text = "فترة عرض الاشعارات (ثواني) ";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new Point(17, 44);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(325, 45);
            textBoxCompany.TabIndex = 1;
            textBoxCompany.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(372, 51);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 0;
            label1.Text = "اسم المؤسسة";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonSaveConString);
            groupBox4.Controls.Add(radioButtonNetworkCon);
            groupBox4.Controls.Add(radioButtonLocalCon);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textBoxPassword);
            groupBox4.Controls.Add(textBoxUserName);
            groupBox4.Controls.Add(textBoxDataBase);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(numericUpDownTimeout);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(textBoxServer);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(540, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(548, 470);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "نص الاتصال";
            // 
            // buttonSaveConString
            // 
            buttonSaveConString.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveConString.Location = new Point(8, 404);
            buttonSaveConString.Margin = new Padding(5);
            buttonSaveConString.Name = "buttonSaveConString";
            buttonSaveConString.Size = new Size(167, 55);
            buttonSaveConString.TabIndex = 8;
            buttonSaveConString.Text = "حفظ ";
            buttonSaveConString.UseVisualStyleBackColor = true;
            buttonSaveConString.Click += buttonSaveConString_Click;
            // 
            // radioButtonNetworkCon
            // 
            radioButtonNetworkCon.AutoSize = true;
            radioButtonNetworkCon.Location = new Point(6, 28);
            radioButtonNetworkCon.Name = "radioButtonNetworkCon";
            radioButtonNetworkCon.Size = new Size(92, 41);
            radioButtonNetworkCon.TabIndex = 0;
            radioButtonNetworkCon.Text = "شبكي";
            radioButtonNetworkCon.UseVisualStyleBackColor = true;
            radioButtonNetworkCon.CheckedChanged += radioButtonNetworkCon_CheckedChanged;
            // 
            // radioButtonLocalCon
            // 
            radioButtonLocalCon.AutoSize = true;
            radioButtonLocalCon.Checked = true;
            radioButtonLocalCon.Location = new Point(122, 28);
            radioButtonLocalCon.Name = "radioButtonLocalCon";
            radioButtonLocalCon.Size = new Size(84, 41);
            radioButtonLocalCon.TabIndex = 0;
            radioButtonLocalCon.TabStop = true;
            radioButtonLocalCon.Text = "محلي";
            radioButtonLocalCon.UseVisualStyleBackColor = true;
            radioButtonLocalCon.CheckedChanged += radioButtonLocalCon_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(402, 202);
            label7.Name = "label7";
            label7.Size = new Size(143, 32);
            label7.TabIndex = 0;
            label7.Text = "فترة الاتصال (ثانية)";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Enabled = false;
            textBoxPassword.Location = new Point(24, 323);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(355, 45);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.Text = "12345";
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Enabled = false;
            textBoxUserName.Location = new Point(24, 261);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(355, 45);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.Text = "sa";
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDataBase
            // 
            textBoxDataBase.Location = new Point(24, 137);
            textBoxDataBase.Name = "textBoxDataBase";
            textBoxDataBase.Size = new Size(355, 45);
            textBoxDataBase.TabIndex = 1;
            textBoxDataBase.Text = "IDGENDataBase";
            textBoxDataBase.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(454, 326);
            label9.Name = "label9";
            label9.Size = new Size(84, 32);
            label9.TabIndex = 0;
            label9.Text = "كلمة السر";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(423, 264);
            label8.Name = "label8";
            label8.Size = new Size(119, 32);
            label8.TabIndex = 0;
            label8.Text = "اسم المستخدم";
            // 
            // numericUpDownTimeout
            // 
            numericUpDownTimeout.Enabled = false;
            numericUpDownTimeout.Location = new Point(24, 199);
            numericUpDownTimeout.Name = "numericUpDownTimeout";
            numericUpDownTimeout.Size = new Size(355, 45);
            numericUpDownTimeout.TabIndex = 2;
            numericUpDownTimeout.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(434, 140);
            label6.Name = "label6";
            label6.Size = new Size(110, 32);
            label6.TabIndex = 0;
            label6.Text = "قاعدة البيانات";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(24, 75);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.RightToLeft = RightToLeft.No;
            textBoxServer.Size = new Size(355, 45);
            textBoxServer.TabIndex = 1;
            textBoxServer.Text = ".\\SQLEXPRESS";
            textBoxServer.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(473, 78);
            label5.Name = "label5";
            label5.Size = new Size(64, 32);
            label5.TabIndex = 0;
            label5.Text = "السيرفر";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 649);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اعدادات النظام";
            TopMost = true;
            Activated += SettingsForm_Activated;
            FormClosing += SettingsForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotification).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelImportImage;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.NumericUpDown numericUpDownDataRow;
        private System.Windows.Forms.NumericUpDown numericUpDownNotification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveGeneralSettings;
        private GroupBox groupBox4;
        private Button buttonSaveConString;
        private RadioButton radioButtonNetworkCon;
        private RadioButton radioButtonLocalCon;
        private Label label7;
        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxDataBase;
        private Label label9;
        private Label label8;
        private NumericUpDown numericUpDownTimeout;
        private Label label6;
        private TextBox textBoxServer;
        private Label label5;
    }
}