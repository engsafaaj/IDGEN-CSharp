
namespace IDGEN
{
    partial class StartForm
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
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            labelState = new Label();
            labelCopyright = new Label();
            linkLabelExit = new LinkLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            linkLabelSetCon = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(1, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(651, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(32, 347);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(591, 29);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 1;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelState.Location = new Point(32, 299);
            labelState.Name = "labelState";
            labelState.Size = new Size(79, 45);
            labelState.TabIndex = 2;
            labelState.Text = "البداية";
            // 
            // labelCopyright
            // 
            labelCopyright.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCopyright.ForeColor = Color.Red;
            labelCopyright.Location = new Point(275, 379);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(364, 32);
            labelCopyright.TabIndex = 2;
            labelCopyright.Text = "جميع الحقوق محفوظة 2023";
            labelCopyright.TextAlign = ContentAlignment.MiddleRight;
            // 
            // linkLabelExit
            // 
            linkLabelExit.AutoSize = true;
            linkLabelExit.Location = new Point(32, 379);
            linkLabelExit.Name = "linkLabelExit";
            linkLabelExit.Size = new Size(128, 37);
            linkLabelExit.TabIndex = 3;
            linkLabelExit.TabStop = true;
            linkLabelExit.Text = "اغلاق البرنامج";
            toolTip1.SetToolTip(linkLabelExit, "اغلاق البرنامج ومعاودة الاتصال فيما بعد");
            linkLabelExit.Visible = false;
            linkLabelExit.LinkClicked += linkLabelExit_LinkClicked;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // linkLabelSetCon
            // 
            linkLabelSetCon.AutoSize = true;
            linkLabelSetCon.Location = new Point(166, 379);
            linkLabelSetCon.Name = "linkLabelSetCon";
            linkLabelSetCon.Size = new Size(161, 37);
            linkLabelSetCon.TabIndex = 3;
            linkLabelSetCon.TabStop = true;
            linkLabelSetCon.Text = "تعديل نص الاتصال";
            linkLabelSetCon.Visible = false;
            linkLabelSetCon.LinkClicked += linkLabelSetCon_LinkClicked;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 243, 245);
            ClientSize = new Size(651, 425);
            Controls.Add(linkLabelSetCon);
            Controls.Add(linkLabelExit);
            Controls.Add(labelCopyright);
            Controls.Add(labelState);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "StartForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "البداية";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCopyright;
        private LinkLabel linkLabelExit;
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTip1;
        private LinkLabel linkLabelSetCon;
    }
}