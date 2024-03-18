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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panelContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 601);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1062, 72);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.icons8_home_32px_2;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(887, 10);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(160, 55);
            button1.TabIndex = 0;
            button1.Text = "الرئيسة";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.icons8_university_32px;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(717, 10);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(160, 55);
            button2.TabIndex = 1;
            button2.Text = "الكليات";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.icons8_students_32px;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(547, 10);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(160, 55);
            button3.TabIndex = 2;
            button3.Text = "الطلبة";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = Properties.Resources.icons8_edit_property_32px;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(377, 10);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(160, 55);
            button4.TabIndex = 3;
            button4.Text = "السجل";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = Properties.Resources.icons8_settings_32px_1;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(207, 10);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(160, 55);
            button5.TabIndex = 4;
            button5.Text = "الاعدادات";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Image = Properties.Resources.icons8_about_32px;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(37, 10);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Size = new Size(160, 55);
            button6.TabIndex = 5;
            button6.Text = "حول";
            button6.UseVisualStyleBackColor = true;
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
            Margin = new Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IDGEN";
            FormClosing += Main_FormClosing;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelContainer;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
