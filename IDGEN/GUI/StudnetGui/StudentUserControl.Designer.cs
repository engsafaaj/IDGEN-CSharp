namespace IDGEN.GUI.StudnetGui
{
    partial class StudentUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            flowLayoutNavBar = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonExport = new Button();
            ExportAll = new Button();
            SearchPanel = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            mainDataGridView = new DataGridView();
            toolTip1 = new ToolTip(components);
            comboBoxPageNo = new ComboBox();
            buttonPrevData = new Button();
            buttonNextData = new Button();
            labelNoData = new Label();
            panel1 = new Panel();
            flowLayoutNavBar.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).BeginInit();
            panel1.SuspendLayout();
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
            flowLayoutNavBar.Controls.Add(ExportAll);
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
            buttonAdd.Location = new Point(1005, 10);
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
            buttonEdit.Location = new Point(855, 10);
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
            buttonDelete.Location = new Point(705, 10);
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
            buttonUpdate.Location = new Point(555, 10);
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
            buttonExport.Location = new Point(405, 10);
            buttonExport.Margin = new Padding(5);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(140, 50);
            buttonExport.TabIndex = 3;
            buttonExport.Text = "تصدير";
            toolTip1.SetToolTip(buttonExport, "يتم تصدير البيانات المتواجدة في شبكة العرض");
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // ExportAll
            // 
            ExportAll.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExportAll.Image = Properties.Resources.icons8_Microsoft_Excel_32px;
            ExportAll.ImageAlign = ContentAlignment.MiddleLeft;
            ExportAll.Location = new Point(222, 10);
            ExportAll.Margin = new Padding(5);
            ExportAll.Name = "ExportAll";
            ExportAll.Size = new Size(173, 50);
            ExportAll.TabIndex = 7;
            ExportAll.Text = "تصدير الكل";
            toolTip1.SetToolTip(ExportAll, "تصدير جميع البيانات");
            ExportAll.UseVisualStyleBackColor = true;
            ExportAll.Click += ExportAll_Click;
            // 
            // SearchPanel
            // 
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(textBoxSearch);
            SearchPanel.Controls.Add(buttonSearch);
            SearchPanel.Location = new Point(758, 68);
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
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
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
            mainDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            mainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mainDataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            mainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            mainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            mainDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            mainDataGridView.Dock = DockStyle.Fill;
            mainDataGridView.Location = new Point(0, 72);
            mainDataGridView.Name = "mainDataGridView";
            mainDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            mainDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            mainDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            mainDataGridView.RowTemplate.Height = 29;
            mainDataGridView.Size = new Size(1181, 620);
            mainDataGridView.TabIndex = 2;
            mainDataGridView.CellDoubleClick += mainDataGridView_CellDoubleClick;
            // 
            // comboBoxPageNo
            // 
            comboBoxPageNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxPageNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPageNo.FormattingEnabled = true;
            comboBoxPageNo.Location = new Point(53, 11);
            comboBoxPageNo.Name = "comboBoxPageNo";
            comboBoxPageNo.Size = new Size(121, 45);
            comboBoxPageNo.TabIndex = 7;
            toolTip1.SetToolTip(comboBoxPageNo, "اختر الصفحة");
            comboBoxPageNo.SelectedIndexChanged += comboBoxPageNo_SelectedIndexChanged;
            // 
            // buttonPrevData
            // 
            buttonPrevData.Anchor = AnchorStyles.None;
            buttonPrevData.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrevData.Image = Properties.Resources.icons8_chevron_left_32px;
            buttonPrevData.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPrevData.Location = new Point(5, 9);
            buttonPrevData.Margin = new Padding(5);
            buttonPrevData.Name = "buttonPrevData";
            buttonPrevData.Size = new Size(40, 50);
            buttonPrevData.TabIndex = 2;
            toolTip1.SetToolTip(buttonPrevData, "الصفحة السابقة");
            buttonPrevData.UseVisualStyleBackColor = true;
            buttonPrevData.Click += buttonPrevData_Click;
            // 
            // buttonNextData
            // 
            buttonNextData.Anchor = AnchorStyles.None;
            buttonNextData.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNextData.Image = Properties.Resources.icons8_chevron_right_32px;
            buttonNextData.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNextData.Location = new Point(182, 9);
            buttonNextData.Margin = new Padding(5);
            buttonNextData.Name = "buttonNextData";
            buttonNextData.Size = new Size(40, 50);
            buttonNextData.TabIndex = 9;
            toolTip1.SetToolTip(buttonNextData, "الصفحة التالية");
            buttonNextData.UseVisualStyleBackColor = true;
            buttonNextData.Click += buttonNextData_Click;
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
            labelNoData.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonNextData);
            panel1.Controls.Add(comboBoxPageNo);
            panel1.Controls.Add(buttonPrevData);
            panel1.Location = new Point(9, 619);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 64);
            panel1.TabIndex = 8;
            // 
            // StudentUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(labelNoData);
            Controls.Add(mainDataGridView);
            Controls.Add(flowLayoutNavBar);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "StudentUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1181, 692);
            flowLayoutNavBar.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).EndInit();
            panel1.ResumeLayout(false);
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
        private ComboBox comboBoxPageNo;
        private Panel panel1;
        private Button buttonPrevData;
        private Button buttonNextData;
        private Button ExportAll;
    }
}
