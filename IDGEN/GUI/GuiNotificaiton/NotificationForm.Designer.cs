
namespace IDGEN.Gui.GuiNotificaiton
{
    partial class NotificationForm
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
            labelTitle = new Label();
            timerNotification = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Notification;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(255, 128, 0);
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(75, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 51);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "هنا وصف الاشعار ";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Click += labelTitle_Click;
            // 
            // timerNotification
            // 
            timerNotification.Enabled = true;
            timerNotification.Interval = 2000;
            timerNotification.Tick += timerNotification_Tick;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 51);
            Controls.Add(labelTitle);
            Controls.Add(pictureBox1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "NotificationForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "NotificationForm";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Timer timerNotification;
    }
}