namespace IDGEN.GUI.GuiAbout
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            pictureBox1 = new PictureBox();
            labelNameVersion = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(15, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelNameVersion
            // 
            labelNameVersion.Font = new Font("Cairo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameVersion.Location = new Point(660, 98);
            labelNameVersion.Name = "labelNameVersion";
            labelNameVersion.Size = new Size(202, 46);
            labelNameVersion.TabIndex = 1;
            labelNameVersion.Text = "V 1.0.0.0";
            labelNameVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(412, 156);
            label2.Name = "label2";
            label2.Size = new Size(395, 160);
            label2.TabIndex = 1;
            label2.Text = "هو اداة برمجية  تم تطويرها حسب متطلبات وزارة التعليم العالي والبحث العلمي لتوليد المعرف الموحد للطالب\r\n";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 531);
            label1.Name = "label1";
            label1.Size = new Size(819, 33);
            label1.TabIndex = 1;
            label1.Text = "هذه البرنامج محمي بحقوق الطبع والنشر ويمنع تداولة الا بموافقة المطور والمؤسسة المالكة\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Cairo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(397, 345);
            label3.Name = "label3";
            label3.Size = new Size(410, 58);
            label3.TabIndex = 1;
            label3.Text = "المطور: المهندس صفاء جاسم كحيط";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Cairo", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(397, 30);
            label4.Name = "label4";
            label4.Size = new Size(257, 126);
            label4.TabIndex = 1;
            label4.Text = "IDGEN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 567);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(labelNameVersion);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox";
            Padding = new Padding(12, 14, 12, 14);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "حول البرنامج";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelNameVersion;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}
