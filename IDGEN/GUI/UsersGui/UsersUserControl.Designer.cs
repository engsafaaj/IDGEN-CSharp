namespace IDGEN.GUI.UsersGui
{
    partial class UsersUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            flowLayoutNavBar = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonExport = new Button();
            SearchPanel = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            mainDataGridView = new DataGridView();
            toolTip1 = new ToolTip(components);
            labelNoData = new Label();
            flowLayoutNavBar.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutNavBar
            // 
            flowLayoutNavBar.AutoScroll = true;
            flowLayoutNavBar.Controls.Add(buttonAdd);
            flowLayoutNavBar.Controls.Add(buttonEdit);
            flowLayoutNavBar.Controls.Add(buttonDelete);
            flowLayoutNavBar.Controls.Add(buttonUpdate);
            flowLayoutNavBar.Controls.Add(buttonExport);
            flowLayoutNavBar.Controls.Add(SearchPanel);
            flowLayoutNavBar.Dock = DockStyle.Top;
            flowLayoutNavBar.Location = new Point(0, 0);
            flowLayoutNavBar.Name = "flowLayoutNavBar";
            flowLayoutNavBar.Padding = new Padding(5);
            flowLayoutNavBar.Size = new Size(1181, 72);
            flowLayoutNavBar.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Image = Properties.Resources.icons8_add_32px;
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(1026, 10);
            buttonAdd.Margin = new Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(140, 50);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "اضافة";
            toolTip1.SetToolTip(buttonAdd, "اضافة بيانات جديدة");
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Image = Properties.Resources.icons8_edit_32px;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(876, 10);
            buttonEdit.Margin = new Padding(5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(140, 50);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "تعديل";
            toolTip1.SetToolTip(buttonEdit, "تعديل السطر الحالي");
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Image = Properties.Resources.icons8_Delete_32px;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(726, 10);
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(140, 50);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "حذف";
            toolTip1.SetToolTip(buttonDelete, "حذف البيانات بشكل نهائي");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.Image = Properties.Resources.icons8_refresh_32px;
            buttonUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdate.Location = new Point(576, 10);
            buttonUpdate.Margin = new Padding(5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(140, 50);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "تحديث";
            toolTip1.SetToolTip(buttonUpdate, "تحديث البيانات من السيرفر");
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonExport
            // 
            buttonExport.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExport.Image = Properties.Resources.icons8_Microsoft_Excel_32px;
            buttonExport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExport.Location = new Point(426, 10);
            buttonExport.Margin = new Padding(5);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(140, 50);
            buttonExport.TabIndex = 3;
            buttonExport.Text = "تصدير";
            toolTip1.SetToolTip(buttonExport, "تصدير البيانات على شكل ملف اكسل");
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // SearchPanel
            // 
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(textBoxSearch);
            SearchPanel.Controls.Add(buttonSearch);
            SearchPanel.Location = new Point(29, 8);
            SearchPanel.Margin = new Padding(3, 3, 5, 3);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(389, 50);
            SearchPanel.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Cairo", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(50, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(337, 48);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxSearch, "ابحث عن طريق كامل معلومات شبكة عرض البيانات");
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.Control;
            buttonSearch.Dock = DockStyle.Left;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Image = Properties.Resources.icons8_search_32px;
            buttonSearch.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch.Location = new Point(0, 0);
            buttonSearch.Margin = new Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(50, 48);
            buttonSearch.TabIndex = 4;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // mainDataGridView
            // 
            mainDataGridView.AllowUserToAddRows = false;
            mainDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            mainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mainDataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            mainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            mainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            mainDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            mainDataGridView.Dock = DockStyle.Fill;
            mainDataGridView.Location = new Point(0, 72);
            mainDataGridView.Name = "mainDataGridView";
            mainDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            mainDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            mainDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            mainDataGridView.RowTemplate.Height = 29;
            mainDataGridView.Size = new Size(1181, 620);
            mainDataGridView.TabIndex = 2;
            // 
            // labelNoData
            // 
            labelNoData.Anchor = AnchorStyles.None;
            labelNoData.AutoSize = true;
            labelNoData.BackColor = Color.White;
            labelNoData.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNoData.ForeColor = SystemColors.ActiveBorder;
            labelNoData.Location = new Point(524, 370);
            labelNoData.Name = "labelNoData";
            labelNoData.Size = new Size(132, 37);
            labelNoData.TabIndex = 6;
            labelNoData.Text = "لا يوجد بيانات";
            // 
            // UsersUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelNoData);
            Controls.Add(mainDataGridView);
            Controls.Add(flowLayoutNavBar);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "UsersUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1181, 692);
            flowLayoutNavBar.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutNavBar;
        private Button buttonAdd;
        private DataGridView mainDataGridView;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonExport;
        private Button buttonUpdate;
        private Panel SearchPanel;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private ToolTip toolTip1;
        private Label labelNoData;
    }
}
