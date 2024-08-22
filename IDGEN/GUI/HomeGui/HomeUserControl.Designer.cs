namespace IDGEN.GUI.HomeGui
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            pictureBoxLogo = new PictureBox();
            labelCompanyName = new Label();
            labelWellcome = new Label();
            panel1 = new Panel();
            labelDate = new Label();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Controls.Add(labelCompanyName);
            panel2.Location = new Point(223, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 217);
            panel2.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Image = Properties.Resources.Logo;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(574, 127);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Dock = DockStyle.Bottom;
            labelCompanyName.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelCompanyName.Location = new Point(0, 127);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(574, 90);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "اسم المؤسسة";
            labelCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWellcome
            // 
            labelWellcome.Font = new Font("Cairo", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelWellcome.ForeColor = SystemColors.ControlDark;
            labelWellcome.Location = new Point(3, 13);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new Size(385, 192);
            labelWellcome.TabIndex = 2;
            labelWellcome.Text = "مرحبا بك مجددا صفاء جاسم";
            labelWellcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(labelTime);
            panel1.Location = new Point(9, 429);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 160);
            panel1.TabIndex = 4;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Fill;
            labelDate.Font = new Font("Cairo", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.ForeColor = Color.FromArgb(224, 224, 224);
            labelDate.Location = new Point(0, 86);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(412, 74);
            labelDate.TabIndex = 2;
            labelDate.Text = "01-01-2024";
            labelDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTime
            // 
            labelTime.Dock = DockStyle.Top;
            labelTime.Font = new Font("Cairo", 32F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelTime.Location = new Point(0, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(412, 86);
            labelTime.TabIndex = 2;
            labelTime.Text = "11: 00 AM";
            labelTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(labelWellcome);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "HomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1062, 601);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBoxLogo;
        private Label labelCompanyName;
        private Label labelWellcome;
        private Panel panel1;
        private Label labelTime;
        private Label labelDate;
        private System.Windows.Forms.Timer timer1;
    }
}
