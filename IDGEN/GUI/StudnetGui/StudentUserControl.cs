using IDGEN.Code;
using IDGEN.Core;
using IDGEN.Data;
using IDGEN.Data.EF;
using IDGEN.Gui.GuiLoading;
using IDGEN.Gui.GuiUsers;
using IDGEN.Gui.StudnetGui;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IDGEN.GUI.StudnetGui
{
    public partial class StudentUserControl : UserControl
    {
        // Fileds
        AddStudentForm addForm;
        IDataHelper<Studnets> dataHelper;
        IDataHelper<Logs> dataHelperLogs;
        private static StudentUserControl? _StudentUserControl;
        LoadingForm loadingForm;
        public static Main? _main;
        List<int> IdList = new List<int>();
        private int RowId;
        private List<Studnets> data;
        private List<Studnets> dataExport;

        // Constructors
        public StudentUserControl()
        {
            InitializeComponent();
            // Inject
            data = new List<Studnets>();
            dataExport = new List<Studnets>();
            dataHelper = new StudnetEF();
            dataHelperLogs = new LogsEF();
            //

            loadingForm = new LoadingForm(_main);
            LoadData();

            // SetRole
            if (!LoggedUser.IsAdmin)
            {
                ExportAll.Visible = false;
            }

            if (LoggedUser.IsAdmin)
            {
                buttonAdd.Visible = false;
                buttonDelete.Visible = false;
                buttonEdit.Visible = false;
            }
        }

        // Methods & Events
        public async void LoadData()
        {
            loadingForm.Show();

            if (await Task.Run(() => dataHelper.IsConAvailable()))
            {
                if (Code.LoggedUser.IsAdmin)
                {
                    data = await Task.Run(() => dataHelper.GetAllData());
                }
                else
                {
                    data = await Task.Run(() => dataHelper.GetAllDataByUser(Code.LoggedUser.Id));
                }
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
            mainDataGridView.Columns[0].Visible = false;
            mainDataGridView.Columns[1].HeaderText = "اسم الطالب";
            mainDataGridView.Columns[2].Visible = false;
            mainDataGridView.Columns[3].HeaderText = "الكلية";
            mainDataGridView.Columns[4].HeaderText = "القسم";
            mainDataGridView.Columns[5].HeaderText = "سنة القبول";
            mainDataGridView.Columns[6].HeaderText = "مستوى الدراسة";
            mainDataGridView.Columns[7].HeaderText = "نوع الدراسة";
            mainDataGridView.Columns[8].HeaderText = "القناة";
            mainDataGridView.Columns[9].HeaderText = "الجنس";
            mainDataGridView.Columns[10].HeaderText = "التسلسل";
            mainDataGridView.Columns[11].HeaderText = "المعرف ";
            mainDataGridView.Columns[12].HeaderText = "تاريخ الاضافة ";

            mainDataGridView.Columns[13].Visible = false;
            mainDataGridView.Columns[14].Visible = false;

        }

        public static StudentUserControl Instance(Main main)
        {
            _main = main;
            return _StudentUserControl ?? (_StudentUserControl = new StudentUserControl());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Open second form only if it dose not open
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new AddStudentForm(this, 0, false, _main);
                if (!addForm.IsDisposed)
                {
                    addForm.Show();
                    addForm.buttonPrint.Enabled = false;

                }
            }
            else
            {
                addForm.Focus();
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
        }

        private void Edit(bool IsSaveButtonEnable)
        {
            if (mainDataGridView.RowCount > 0 && mainDataGridView.CurrentRow != null)
            {
                // Get Id
                RowId = Convert.ToInt32(mainDataGridView.CurrentRow.Cells[0].Value);
                // Open second form only if it dose not open
                if (addForm == null || addForm.IsDisposed)
                {
                    addForm = new AddStudentForm(this, RowId, true, _main);
                    addForm.buttonSaveAndClose.Enabled = IsSaveButtonEnable;
                    addForm.groupBox1.Enabled = IsSaveButtonEnable;
                    addForm.buttonPrint.Enabled = !IsSaveButtonEnable;
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
                                    LogTitle = " حذف طالب",
                                    UserFullName = Properties.Settings.Default.UserName,
                                    LogDescriptions = "تم حذف الطالب الذي يحمل الرقم التعريفي   " + mainDataGridView.CurrentRow.Cells[11].Value.ToString(),
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

                dataExport = (List<Studnets>)mainDataGridView.DataSource;

                DataTable dataTable = new DataTable();
                // Convert List of Data to DataTable
                using (var reader = FastMember.ObjectReader.Create(dataExport))
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
            dataTable.Columns["Id"].ColumnName = "ت";

            dataTable.Columns["Name"].SetOrdinal(1);
            dataTable.Columns["Name"].ColumnName = "اسم الطالب";

            dataTable.Columns["UniversityCode"].SetOrdinal(2);
            dataTable.Columns["UniversityCode"].ColumnName = "اسم الجامعة";

            dataTable.Columns["FacultyCode"].SetOrdinal(3);
            dataTable.Columns["FacultyCode"].ColumnName = "اسم الكلية ";

            dataTable.Columns["DepartmentCode"].SetOrdinal(4);
            dataTable.Columns["DepartmentCode"].ColumnName = "رمز القسم";

            dataTable.Columns["AdmissionYear"].SetOrdinal(5);
            dataTable.Columns["AdmissionYear"].ColumnName = "سنة القبول ";


            dataTable.Columns["StudyLevel"].SetOrdinal(6);
            dataTable.Columns["StudyLevel"].ColumnName = "مستوى الدراسة ";

            dataTable.Columns["StudySystem"].SetOrdinal(7);
            dataTable.Columns["StudySystem"].ColumnName = "نوع الدراسة";

            dataTable.Columns["AdmissionChannel"].SetOrdinal(8);
            dataTable.Columns["AdmissionChannel"].ColumnName = "قناة القبول  ";

            dataTable.Columns["Gender"].SetOrdinal(9);
            dataTable.Columns["Gender"].ColumnName = "الجنس   ";

            dataTable.Columns["EnrollmentOrder"].SetOrdinal(10);
            dataTable.Columns["EnrollmentOrder"].ColumnName = "التسلسل   ";

            dataTable.Columns["FullID"].SetOrdinal(11);
            dataTable.Columns["FullID"].ColumnName = "المعرف ";

            dataTable.Columns["AddDate"].SetOrdinal(11);
            dataTable.Columns["AddDate"].ColumnName = "تاريخ الاضافة ";

            dataTable.Columns.Remove("Colleges");
            dataTable.Columns.Remove("CollegesId");

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
            Edit(false);
        }

        private async void comboBoxPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadingForm.Show();
                if (await Task.Run(() => dataHelper.IsConAvailable()))
                {

                    if (Code.LoggedUser.IsAdmin)
                    {
                        data = await Task.Run(() => dataHelper.GetAllData());
                    }
                    else
                    {
                        data = await Task.Run(() => dataHelper.GetAllDataByUser(Code.LoggedUser.Id));
                    }

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
            data.Clear();

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
                    if (Code.LoggedUser.IsAdmin)
                    {
                        mainDataGridView.DataSource = await Task.Run(() => dataHelper.Search(searchIteam));
                    }
                    else
                    {
                        mainDataGridView.DataSource = await Task.Run(() => dataHelper.SearchByUser(searchIteam, Code.LoggedUser.Id));
                    }

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
            data.Clear();

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

        private async void ExportAll_Click(object sender, EventArgs e)
        {
            loadingForm.Show();
            if (await Task.Run(() => dataHelper.IsConAvailable()))
            {

                dataExport = await Task.Run(() => dataHelper.GetAllData());

                DataTable dataTable = new DataTable();
                // Convert List of Data to DataTable
                using (var reader = FastMember.ObjectReader.Create(dataExport))
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
