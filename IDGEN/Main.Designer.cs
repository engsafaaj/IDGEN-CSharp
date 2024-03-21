namespace IDGEN
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonHome = new Button();
            buttonUsers = new Button();
            buttonStudents = new Button();
            buttonLogs = new Button();
            buttonSettings = new Button();
            buttonAbout = new Button();
            panelContainer = new Panel();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(buttonHome);
            flowLayoutPanel1.Controls.Add(buttonUsers);
            flowLayoutPanel1.Controls.Add(buttonStudents);
            flowLayoutPanel1.Controls.Add(buttonLogs);
            flowLayoutPanel1.Controls.Add(buttonSettings);
            flowLayoutPanel1.Controls.Add(buttonAbout);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 601);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1062, 72);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Image = Properties.Resources.icons8_home_32px_2;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(887, 10);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(160, 55);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "الرئيسة";
            toolTip1.SetToolTip(buttonHome, "الصفحة الرئيسية");
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsers.Image = Properties.Resources.icons8_university_32px;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(717, 10);
            buttonUsers.Margin = new Padding(5);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(160, 55);
            buttonUsers.TabIndex = 1;
            buttonUsers.Text = "الكليات";
            toolTip1.SetToolTip(buttonUsers, "إدارة الكليات والاقسام العلمية");
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonStudents
            // 
            buttonStudents.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStudents.Image = Properties.Resources.icons8_students_32px;
            buttonStudents.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStudents.Location = new Point(547, 10);
            buttonStudents.Margin = new Padding(5);
            buttonStudents.Name = "buttonStudents";
            buttonStudents.Size = new Size(160, 55);
            buttonStudents.TabIndex = 2;
            buttonStudents.Text = "الطلبة";
            toolTip1.SetToolTip(buttonStudents, "إدارة بيانات الطلبة");
            buttonStudents.UseVisualStyleBackColor = true;
            buttonStudents.Click += buttonStudents_Click;
            // 
            // buttonLogs
            // 
            buttonLogs.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogs.Image = Properties.Resources.icons8_edit_property_32px;
            buttonLogs.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogs.Location = new Point(377, 10);
            buttonLogs.Margin = new Padding(5);
            buttonLogs.Name = "buttonLogs";
            buttonLogs.Size = new Size(160, 55);
            buttonLogs.TabIndex = 3;
            buttonLogs.Text = "السجل";
            toolTip1.SetToolTip(buttonLogs, "سجل حركة النظام");
            buttonLogs.UseVisualStyleBackColor = true;
            buttonLogs.Click += buttonLogs_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.Image = Properties.Resources.icons8_settings_32px_1;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(207, 10);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(160, 55);
            buttonSettings.TabIndex = 4;
            buttonSettings.Text = "الاعدادات";
            toolTip1.SetToolTip(buttonSettings, "اعدادات النظام العامة");
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAbout.Image = Properties.Resources.icons8_about_32px;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(37, 10);
            buttonAbout.Margin = new Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(160, 55);
            buttonAbout.TabIndex = 5;
            buttonAbout.Text = "حول";
            toolTip1.SetToolTip(buttonAbout, "حول النظام, المساعدة , الخصوصية");
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1062, 601);
            panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IDGEN";
            WindowState = FormWindowState.Maximized;
            FormClosing += Main_FormClosing;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonHome;
        private Button buttonUsers;
        private Button buttonStudents;
        private Button buttonLogs;
        private Button buttonSettings;
        private Button buttonAbout;
        public Panel panelContainer;
        private ToolTip toolTip1;
    }
}
