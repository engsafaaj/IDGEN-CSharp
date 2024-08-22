using IDGEN.Code;
using IDGEN.Core;
using IDGEN.Data;
using IDGEN.Data.EF;
using IDGEN.Gui.GuiLoading;
using System.Data;

namespace IDGEN.GUI.LogsGui
{
    public partial class LogsUserControl : UserControl
    {
        // Fileds
        IDataHelper<Logs> dataHelperLogs;
        private static LogsUserControl? _LogsUserControl;
        LoadingForm loadingForm;
        public static Main? _main;
        List<int> IdList = new List<int>();

        // Constructors
        public LogsUserControl()
        {
            InitializeComponent();
            // Inject
            dataHelperLogs = new LogsEF();
            //
            loadingForm = new LoadingForm(_main);
            LoadData();
        }


        // Methods & Events
        public async void LoadData()
        {
            loadingForm.Show();

            if (await Task.Run(() => dataHelperLogs.IsConAvailable()))
            {
                var data = await Task.Run(() => dataHelperLogs.GetAllData());
                mainDataGridView.DataSource = data.Take(Properties.Settings.Default.DataGridViewRowNo).ToList();

                // Add No of Page into Combo Box
                comboBoxPageNo.Items.Clear();
                double value = (Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.DataGridViewRowNo));
                int NoOfPage = (int)Math.Round(value, MidpointRounding.AwayFromZero);

                for (int i = 0; i <= NoOfPage; i++)
                {
                    comboBoxPageNo.Items.Add(i);
                }
                //

                if (mainDataGridView.DataSource == null)
                {
                    loadingForm.Hide();

                    MessageCollections.ShowErrorServer();
                }
                else
                {
                    SetColumnsTitle();
                }
                data.Clear();
            }
            else
            {
                loadingForm.Hide();
                MessageCollections.ShowErrorServer();
            }
            loadingForm.Hide();
            labelNoData.Visible = dgvHelper.IsDataGridNull(mainDataGridView);

        }

        private void SetColumnsTitle()
        {
            mainDataGridView.Columns[0].HeaderText = "المعرف";
            mainDataGridView.Columns[1].HeaderText = "اسم المستخدم";
            mainDataGridView.Columns[2].HeaderText = "اسم الجهاز";
            mainDataGridView.Columns[3].HeaderText = "عنوان الجهاز";
            mainDataGridView.Columns[4].HeaderText = "عنوان الحركة";
            mainDataGridView.Columns[5].HeaderText = "وصف الحركة";
            mainDataGridView.Columns[6].HeaderText = "تاريخ الحركة";
        }

        public static LogsUserControl Instance(Main main)
        {
            _main = main;
            return _LogsUserControl ?? (_LogsUserControl = new LogsUserControl());
        }

        private void SetIdRowForDelete()
        {
            foreach (DataGridViewRow row in mainDataGridView.Rows)
            {
                if (row.Selected)
                {
                    IdList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            loadingForm.Show();
            if (await Task.Run(() => dataHelperLogs.IsConAvailable()))
            {
                var data = await Task.Run(() => dataHelperLogs.GetAllData());
                DataTable dataTable = new DataTable();
                // Convert List of Data to DataTable
                loadingForm.Show();
                using (var reader = FastMember.ObjectReader.Create(data))
                {
                    dataTable.Load(reader);
                }
                loadingForm.Hide();
                // Re-Set Columns
                DataTable dataTableArranged = SetDataTableColumns(dataTable);
                // Export Data to as Sheet Excel

                Code.ExcelExporter.ExportAsXlsxFile(dataTableArranged);

            }
            else
            {
                loadingForm.Hide();
                MessageCollections.ShowErrorServer();
            }
            loadingForm.Hide();
        }

        private DataTable SetDataTableColumns(DataTable dataTable)
        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "المعرف";

            dataTable.Columns["UserFullName"].SetOrdinal(1);
            dataTable.Columns["UserFullName"].ColumnName = "اسم المستخدم ";

            dataTable.Columns["UserDeviceName"].SetOrdinal(2);
            dataTable.Columns["UserDeviceName"].ColumnName = "اسم الجهاز الجهاز ";

            dataTable.Columns["UserDeviceMac"].SetOrdinal(3);
            dataTable.Columns["UserDeviceMac"].ColumnName = "عنوان الجهاز ";

            dataTable.Columns["LogTitle"].SetOrdinal(4);
            dataTable.Columns["LogTitle"].ColumnName = "عنوان الحركة ";

            dataTable.Columns["LogDescriptions"].SetOrdinal(5);
            dataTable.Columns["LogDescriptions"].ColumnName = "وصف الحركة ";


            dataTable.Columns["LogDate"].SetOrdinal(6);
            dataTable.Columns["LogDate"].ColumnName = "تاريخ الحركة";


            return dataTable;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void mainDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void comboBoxPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadingForm.Show();
                if (await Task.Run(() => dataHelperLogs.IsConAvailable()))
                {
                    var data = await Task.Run(() => dataHelperLogs.GetAllData());
                    var dataId = data.Select(x => x.Id).ToArray();
                    int index = comboBoxPageNo.SelectedIndex;
                    int IndexNoOfRow = index * Properties.Settings.Default.DataGridViewRowNo;

                    mainDataGridView.DataSource = data.Where(x => x.Id <= dataId[IndexNoOfRow]).Take(Properties.Settings.Default.DataGridViewRowNo).ToList();
                    if (mainDataGridView.DataSource == null)
                    {
                        MessageCollections.ShowErrorServer();
                    }
                    else
                    {
                        SetColumnsTitle();
                    }
                    data.Clear();
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
            }
            catch
            {
                loadingForm.Hide();
            }


        }

        private async void Search()
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                MessageBox.Show("لطفا ادخل كلمة في مربع البحث اولا ",
                    "لا يوجد كلمة بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                loadingForm.Show();

                if (await Task.Run(() => dataHelperLogs.IsConAvailable()))
                {
                    string searchIteam = textBoxSearch.Text;
                    mainDataGridView.DataSource = await Task.Run(() => dataHelperLogs.Search(searchIteam));


                    if (mainDataGridView.DataSource == null)
                    {
                        MessageCollections.ShowErrorServer();
                    }
                    else
                    {
                        SetColumnsTitle();
                    }
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
                labelNoData.Visible = dgvHelper.IsDataGridNull(mainDataGridView);
            }


        }

        private void buttonNextData_Click(object sender, EventArgs e)
        {

            try
            {
                comboBoxPageNo.SelectedIndex = comboBoxPageNo.SelectedIndex + 1;

            }
            catch { }


        }

        private void buttonPrevData_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBoxPageNo.SelectedIndex != 0)
                {
                    comboBoxPageNo.SelectedIndex = comboBoxPageNo.SelectedIndex - 1;

                }

            }
            catch { }

        }

        private async void buttonExportDataGrid_Click(object sender, EventArgs e)
        {
            loadingForm.Show();
            if (await Task.Run(() => dataHelperLogs.IsConAvailable()))
            {
                var data =(List<Logs>) mainDataGridView.DataSource;
                DataTable dataTable = new DataTable();
                // Convert List of Data to DataTable
                loadingForm.Show();
                using (var reader = FastMember.ObjectReader.Create(data))
                {
                    dataTable.Load(reader);
                }
                loadingForm.Hide();
                // Re-Set Columns
                DataTable dataTableArranged = SetDataTableColumns(dataTable);
                // Export Data to as Sheet Excel

                Code.ExcelExporter.ExportAsXlsxFile(dataTableArranged);

            }
            else
            {
                loadingForm.Hide();
                MessageCollections.ShowErrorServer();
            }
            loadingForm.Hide();
        }
    }
}
