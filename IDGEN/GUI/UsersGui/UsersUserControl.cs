using IDGEN.Code;
using IDGEN.Core;
using IDGEN.Data;
using IDGEN.Data.EF;
using IDGEN.Gui.GuiLoading;
using IDGEN.Gui.GuiUsers;
using System.Data;

namespace IDGEN.GUI.UsersGui
{
    public partial class UsersUserControl : UserControl
    {
        // Fileds
        AddUserForm addForm;
        IDataHelper<Colleges> dataHelper;
        IDataHelper<Logs> dataHelperLogs;
        private static UsersUserControl? _UsersUserControl;
        LoadingForm loadingForm;
        public static Main? _main;
        List<int> IdList = new List<int>();
        private int RowId;

        // Constructors
        public UsersUserControl()
        {
            InitializeComponent();

            // Inject
            dataHelper = new CollegeEF();
            dataHelperLogs = new LogsEF();
            loadingForm = new LoadingForm(_main);
            //

            LoadData();
        }


        // Methods and Events
        public async void LoadData()
        {
            loadingForm.Show();

            if (await Task.Run(() => dataHelper.IsConAvailable()))
            {
                var data = await Task.Run(() => dataHelper.GetAllData().Where(X=>X.IsAdmin==false).ToList());
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
            mainDataGridView.Columns[1].HeaderText = "اسم الكلية";
            mainDataGridView.Columns[2].HeaderText = "اسم المستخدم";
            mainDataGridView.Columns[3].HeaderText = "كلمة السر";
            mainDataGridView.Columns[4].HeaderText = "رمز الكلية";
            mainDataGridView.Columns[5].HeaderText = "البريد الالكتروني";
            mainDataGridView.Columns[6].HeaderText = "رقم الهاتف";
            mainDataGridView.Columns[7].HeaderText = "اخرى";
            mainDataGridView.Columns[8].HeaderText = "الاقسام";
            mainDataGridView.Columns[9].Visible = false;
        }

        public static UsersUserControl Instance(Main main)
        {
            _main = main;
            return _UsersUserControl ?? (_UsersUserControl = new UsersUserControl());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Open second form only if it dose not open
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new AddUserForm(this, 0, false, _main);
                if (!addForm.IsDisposed)
                {
                    addForm.Show();
                }
            }
            else
            {
                addForm.Focus();
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            if (mainDataGridView.RowCount > 0 && mainDataGridView.CurrentRow != null)
            {
                // Get Id
                RowId = Convert.ToInt32(mainDataGridView.CurrentRow.Cells[0].Value);
                // Open second form only if it dose not open
                if (addForm == null || addForm.IsDisposed)
                {
                    addForm = new AddUserForm(this, RowId, true, _main);
                    if (!addForm.IsDisposed)
                    {
                        addForm.Show();
                    }
                }
                else
                {
                    addForm.Focus();
                }

            }
            else
            {
                MessageCollections.ShowEmptyDataMessage();
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.RowCount > 0 && mainDataGridView.CurrentRow != null)
            {
                var Deleteresult = MessageCollections.ShowDeleteDialog();
                if (Deleteresult)
                {
                    IdList.Clear();
                    SetIdRowForDelete();
                    loadingForm.Show();
                    if (IdList.Count > 0)
                    {
                        for (int i = 0; i < IdList.Count; i++)
                        {
                            RowId = IdList[i];
                            var result = await Task.Run(() => dataHelper.Delete(RowId));
                            if (result == 1)
                            {
                                // Save System Records
                                var logs = new Logs
                                {
                                    LogTitle = " حذف كلية",
                                    UserFullName = Properties.Settings.Default.UserName,
                                    LogDescriptions = "تم حذف الكلية التي تحمل الرقم التعريفي   " + RowId.ToString(),
                                    LogDate = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString(),
                                    UserDeviceMac = DeviceHelper.GetDeviceMacAddress(),
                                    UserDeviceName = Environment.MachineName,
                                };

                                await Task.Run(() => dataHelperLogs.Add(logs));

                                // 
                                MessageCollections.ShowDeleteNotificaiton();

                            }
                            else
                            {
                                loadingForm.Hide();
                                MessageCollections.ShowErrorServer();
                            }
                        }
                        LoadData();

                    }
                    else
                    {
                        loadingForm.Hide();
                        MessageCollections.ShowRequiredDeleteRow();
                    }

                    loadingForm.Hide();
                }

            }
            else
            {
                MessageCollections.ShowEmptyDataMessage();
            }
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
            if (await Task.Run(() => dataHelper.IsConAvailable()))
            {
                var data = await Task.Run(() => dataHelper.GetAllData());
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

            dataTable.Columns["CollegeName"].SetOrdinal(1);
            dataTable.Columns["CollegeName"].ColumnName = "اسم الكلية";

            dataTable.Columns["UserName"].SetOrdinal(2);
            dataTable.Columns["UserName"].ColumnName = "اسم المستخدم";

            dataTable.Columns["Password"].SetOrdinal(3);
            dataTable.Columns["Password"].ColumnName = "كلمة السر";

            dataTable.Columns["CollegeCode"].SetOrdinal(4);
            dataTable.Columns["CollegeCode"].ColumnName = "رمز الكلية";

            dataTable.Columns["Email"].SetOrdinal(5);
            dataTable.Columns["Email"].ColumnName = "البريد الالكتروني";


            dataTable.Columns["Phone"].SetOrdinal(6);
            dataTable.Columns["Phone"].ColumnName = "رقم الهاتف";

            dataTable.Columns["Details"].SetOrdinal(7);
            dataTable.Columns["Details"].ColumnName = "اخرى";

            dataTable.Columns["DepNo"].SetOrdinal(8);
            dataTable.Columns["DepNo"].ColumnName = "عدد الاقسام العلمية";

            dataTable.Columns.Remove("CollegeDep");
            dataTable.Columns.Remove("IsAdmin");

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
            Edit();
        }

        private async void comboBoxPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadingForm.Show();
                if (await Task.Run(() => dataHelper.IsConAvailable()))
                {
                    var data = await Task.Run(() => dataHelper.GetAllData().Where(X => X.IsAdmin == false).ToList());
                    var dataId = data.Select(x => x.Id).ToArray();
                    int index = comboBoxPageNo.SelectedIndex;
                    int IndexNoOfRow = index * Properties.Settings.Default.DataGridViewRowNo;

                    mainDataGridView.DataSource = data.Where(x => x.Id >= dataId[IndexNoOfRow]).Take(Properties.Settings.Default.DataGridViewRowNo).ToList();
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

                if (await Task.Run(() => dataHelper.IsConAvailable()))
                {
                    string searchIteam = textBoxSearch.Text;
                    mainDataGridView.DataSource = await Task.Run(() => dataHelper.Search(searchIteam).Where(X => X.IsAdmin == false).ToList());


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

        private async void buttonExportDataGridView_Click(object sender, EventArgs e)
        {
            loadingForm.Show();
            if (await Task.Run(() => dataHelper.IsConAvailable()))
            {
                var data = (List<Colleges>) mainDataGridView.DataSource;
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
