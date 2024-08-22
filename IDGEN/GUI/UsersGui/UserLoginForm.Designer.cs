
namespace IDGEN.Gui.GuiUsers
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            radioButtonRememberMe = new RadioButton();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Tomato;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogin.Location = new Point(62, 563);
            buttonLogin.Margin = new Padding(5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(403, 55);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "تسجيل الدخول";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonSave_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(62, 437);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.RightToLeft = RightToLeft.Yes;
            textBoxPassword.Size = new Size(403, 45);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(62, 332);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.RightToLeft = RightToLeft.Yes;
            textBoxUserName.Size = new Size(403, 45);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            textBoxUserName.KeyDown += textBoxUserName_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 394);
            label4.Name = "label4";
            label4.Size = new Size(100, 37);
            label4.TabIndex = 0;
            label4.Text = "كلمة السر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 290);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 0;
            label2.Text = "اسم المستخدم";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 248, 235);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(radioButtonRememberMe);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 642);
            panel1.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.password_240px;
            pictureBox4.Location = new Point(460, 437);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.name_480px;
            pictureBox1.Location = new Point(460, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // radioButtonRememberMe
            // 
            radioButtonRememberMe.AutoSize = true;
            radioButtonRememberMe.Location = new Point(392, 497);
            radioButtonRememberMe.Name = "radioButtonRememberMe";
            radioButtonRememberMe.Size = new Size(96, 41);
            radioButtonRememberMe.TabIndex = 4;
            radioButtonRememberMe.TabStop = true;
            radioButtonRememberMe.Text = "تذكرني";
            radioButtonRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.personnage;
            pictureBox2.Location = new Point(86, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(358, 247);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(251, 187, 4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(523, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 642);
            panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo;
            pictureBox3.Location = new Point(94, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(388, 235);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(128, 64, 0);
            label5.Location = new Point(85, 578);
            label5.Name = "label5";
            label5.Size = new Size(371, 29);
            label5.TabIndex = 0;
            label5.Text = "جميع الحقوق محفوظة لــ قناة تكنو يو";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(126, 400);
            label3.Name = "label3";
            label3.Size = new Size(295, 45);
            label3.TabIndex = 0;
            label3.Text = "سجل دخولك لاكمال عملك";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(58, 295);
            label1.Name = "label1";
            label1.Size = new Size(440, 95);
            label1.TabIndex = 0;
            label1.Text = "مرحبا بك مرة اخرى";
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1096, 642);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserLoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            FormClosed += UserLoginForm_FormClosed;
            Load += AddCategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private RadioButton radioButtonRememberMe;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}