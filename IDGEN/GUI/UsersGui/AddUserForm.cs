
using IDGEN.Code;
using IDGEN.Core;
using IDGEN.Data;
using IDGEN.Data.EF;
using IDGEN.Gui.GuiLoading;
using IDGEN.GUI.UsersGui;
using System.Data;

namespace IDGEN.Gui.GuiUsers
{
    public partial class AddUserForm : Form
    {
        // Fields
        private readonly UsersUserControl pageControl;
        LoadingForm loadingForm;
        private int ID;
        private Colleges colleges;
        private IDataHelper<Colleges> dataHelper;
        private IDataHelper<Logs> dataHelperLogs;
        private IDataHelper<CollegeDep> dataHelperDep;
        private CollegeDep collegeDep;
        private List<int> IdList = new List<int>();
        private int RowId;
        private bool IsEdit;

        // Constructors
        public AddUserForm(UsersUserControl pageControl, int Id, bool isEdit, Main main)
        {
            InitializeComponent();
            this.Owner = main;
            IsEdit = isEdit;
            ID = Id;

            // Inject Data Helper
            dataHelper = new CollegeEF();
            dataHelperLogs = new LogsEF();
            dataHelperDep = new DepEF();
            //
            collegeDep = new CollegeDep();
            loadingForm = new LoadingForm(this);

            this.pageControl = pageControl; // Inint Page User Control

            if (ID == 0)
            {
                InitAddData(); // Create Tep Record
            }

            LoadData();
            IsEdit = isEdit;
        }

        #region TextBoxEvents
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "اسم الكلية: يمثل الاسم الكامل لها";
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "اسم المستخدم: يستخدم لتسجيل الدخول للكلية";
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "كلمة السر: يفضل ان تكون كلمة السر قوية ولا تقل عن 6 احرف";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            // Validate the text to ensure it represents a non-negative integer
            if (!int.TryParse(textBoxCollegeCode.Text, out int value) || value < 0)
            {
                // If the text is not a valid non-negative integer, reset the text to empty
                textBoxCollegeCode.Text = "0000";
                labelValidation.Text = "رمز الكلية:يتكون رمز الكلية من 4 مراتب ويكون مختلف لكل كلية";
            }
            // Trim the text to a maximum length of 4 characters
            if (textBoxCollegeCode.Text.Length > 4)
            {
                textBoxCollegeCode.Text = textBoxCollegeCode.Text.Substring(0, 4);
            }
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "البريد الالكتروني:يعتبر وسيلة اتصال رسمية";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "رقم الهاتف:ادخل رقم الهاتف بصيغته الكاملة";

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "القسم العلمي:ادخل اسم القسم العلمي حتى لو كانت الكلية ذا قسم واحد";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Validate the text to ensure it represents a non-negative integer
            if (!int.TryParse(textBoxDepCode.Text, out int value) || value < 0)
            {
                // If the text is not a valid non-negative integer, reset the text to empty
                textBoxDepCode.Text = "00";
                labelValidation.Text = "رمز القسم:يتكون رمز القسم من مرتبتين  ";
            }
            // Trim the text to a maximum length of 4 characters
            if (textBoxDepCode.Text.Length > 2)
            {
                textBoxDepCode.Text = textBoxDepCode.Text.Substring(0, 2);
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "اسم الكلية: يمثل الاسم الكامل لها";

        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "اسم المستخدم: يستخدم لتسجيل الدخول للكلية";
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "كلمة السر: يفضل ان تكون كلمة السر قوية ولا تقل عن 6 احرف";
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "رمز الكلية:يتكون رمز الكلية من 4 مراتب ويكون مختلف لكل كلية";
        }

        private void textBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "البريد الالكتروني:يعتبر وسيلة اتصال رسمية";

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "رقم الهاتف:ادخل رقم الهاتف بصيغته الكاملة";
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "القسم العلمي:ادخل اسم القسم العلمي حتى لو كانت الكلية ذا قسم واحد";

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "رمز القسم:يتكون رمز القسم من مرتبتين";
        }

        #endregion

        private bool IsTextBoxValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxCollegeCode.Text) ||
                string.IsNullOrWhiteSpace(textBoxUserName.Text)
                )
            {
                return false;
            }
            else
            {
                return true;
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

        private async void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            if (!IsTextBoxValid())
            {
                MessageCollections.ShowFiledsRequired();
            }
            else
            {

                loadingForm.Show();
                if (await Task.Run(() => dataHelper.IsConAvailable()))
                {
                    // Check Duplicated Data => Add
                    var collegeName = textBoxName.Text; var collegeCode = textBoxCollegeCode.Text; var userName = textBoxUserName.Text;

                    var dupliateData = Task.Run(() => dataHelper.GetAllData().Where(X => X.Id != ID)
                                   .Where(x => x.CollegeName == collegeName || x.CollegeCode == collegeCode || x.UserName == userName)
                                   .FirstOrDefault() ?? new Colleges()).Result;

                    if (dupliateData.Id > 0)
                    {
                        loadingForm.Hide();
                        MessageBox.Show("يجب ان يكون رمز الكلية واسمها مختلف", "بيانات مكررة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (await EditData())
                        {
                            if (!IsEdit)
                            {
                                MessageCollections.ShowAddNotificaiton();
                                DialogResult = DialogResult.OK; 
                                this.Close();
                            }
                            else
                            {
                                MessageCollections.ShowUpdateNotificaiton();
                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        else
                        {
                            loadingForm.Hide();
                            MessageCollections.ShowErrorServer();
                        }
                    }

                }
                else
                {
                    loadingForm.Hide();
                    MessageCollections.ShowErrorServer();
                }

                loadingForm.Hide();
            }
        }

        private async Task<bool> EditData()
        {
            // Set Data
            colleges = new Colleges
            {
                Id = ID,
                CollegeName = textBoxName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Phone = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                Details = richTextBoxDetails.Text,
                CollegeCode = textBoxCollegeCode.Text,
                DepNo = mainDataGridView.RowCount
            };
            // Sumbit
            var result = await Task.Run(() => dataHelper.Update(colleges));
            if (result == 1)
            {

                // Save System Records
                var logs = new Logs
                {
                    LogTitle = " حفظ كلية",
                    UserFullName = Properties.Settings.Default.UserName,
                    LogDescriptions = "تم حفظ  كلية   " + colleges.CollegeName,
                    LogDate = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString(),
                    UserDeviceMac = DeviceHelper.GetDeviceMacAddress(),
                    UserDeviceName = Environment.MachineName,
                };

                await Task.Run(() => dataHelperLogs.Add(logs));
                pageControl.LoadData();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async void LoadData()
        {

            loadingForm.Show();
            var IsConAvai = await Task.Run(() => dataHelper.IsConAvailable());
            if (IsConAvai)
            {
                mainDataGridView.DataSource = await Task.Run(() => dataHelperDep.GetAllData()
                 .Where(x => x.CollegesId == ID).ToList() ?? new List<CollegeDep>());
                SetColumnsTitle();
            }
            else
            {
                loadingForm.Hide();
                MessageCollections.ShowErrorServer();
            }

            loadingForm.Hide();

        }

        private void SetColumnsTitle()
        {
            // Show
            mainDataGridView.Columns[1].HeaderText = "اسم القسم";
            mainDataGridView.Columns[2].HeaderText = "رمز القسم";

            // Hide
            mainDataGridView.Columns[3].Visible = false;
            mainDataGridView.Columns[4].Visible = false;
            mainDataGridView.Columns[0].Visible = false;
        }


        // Tep Record
        private async void InitAddData()
        {
            // Set Init Data
            Colleges colleges = new Colleges
            {
                CollegeCode = "0000",
                CollegeName = "",
                DepNo = 0,
                Details = "",
                Email = "",
                Password = "",
                Phone = "",
                UserName = "",
            };

            loadingForm.Show();
            var conResult = await Task.Run(() => dataHelper.IsConAvailable());
            if (conResult)
            {
                var result = Task.Run(() => dataHelper.Add(colleges)).Result;
                if (result == 1)
                {
                    ID = colleges.Id;
                }
                else
                {
                    loadingForm.Hide();
                    Code.MessageCollections.ShowErrorServer();
                    this.Close();
                }
            }
            else
            {
                loadingForm.Hide();
                MessageCollections.ShowErrorServer();
            }

            loadingForm.Hide();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            loadingForm.Show();


            if (string.IsNullOrEmpty(textBoxDepName.Text))
            {
                loadingForm.Hide();
                Code.MessageCollections.ShowFiledsRequired();
            }
            else
            {
                string DepCode = textBoxDepCode.Text;
                string DepName = textBoxDepName.Text;

                if (await Task.Run(() => dataHelper.IsConAvailable()))
                {

                    // Check Duplicated Data
                    collegeDep = Task.Run(() => dataHelperDep.GetAllData()
                                   .Where(x => x.CollegesId == ID).
                                   Where(x => x.DepCode == DepCode || x.DepName == DepName
                                   ).FirstOrDefault() ?? new CollegeDep()).Result;
                    if (collegeDep.Id > 0)
                    {
                        loadingForm.Hide();
                        MessageBox.Show("يجب ان يكون رمز القسم والاسم مختلف", "بيانات مكررة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Set Data
                        CollegeDep collegeDep = new CollegeDep
                        {
                            DepName = DepName,
                            DepCode = DepCode,
                            CollegesId = ID
                        };

                        // Save Data
                        var result = await Task.Run(() => dataHelperDep.Add(collegeDep));
                        if (result == 1)
                        {
                            loadingForm.Hide();
                            MessageCollections.ShowAddNotificaiton(); // Sucess

                            LoadData();
                            int newDepCode = Convert.ToInt32(DepCode) + 1;
                            textBoxDepCode.Text = "0" + newDepCode.ToString();

                            // Save System Records
                            var logs = new Logs
                            {
                                LogTitle = " اضافة قسم",
                                UserFullName = Properties.Settings.Default.UserName,
                                LogDescriptions = "تم اضافة قسم   " + DepName,
                                LogDate = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString(),
                                UserDeviceMac = DeviceHelper.GetDeviceMacAddress(),
                                UserDeviceName = Environment.MachineName,
                            };

                            await Task.Run(() => dataHelperLogs.Add(logs));
                        }
                        else
                        {
                            loadingForm.Hide();
                            MessageCollections.ShowErrorServer();
                        }
                    }
                }
                else
                {
                    loadingForm.Hide();
                    Code.MessageCollections.ShowErrorServer();
                }

            }
            loadingForm.Hide();
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
                            var result = await Task.Run(() => dataHelperDep.Delete(RowId));
                            if (result == 1)
                            {
                                // Save System Records
                                var logs = new Logs
                                {
                                    LogTitle = " حذف قسم",
                                    UserFullName = Properties.Settings.Default.UserName,
                                    LogDescriptions = "تم حذف قسم " + Convert.ToString(mainDataGridView.CurrentRow.Cells[1].Value),
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

        private async void buttonCancel_Click(object sender, EventArgs e)
        {
            if (!IsEdit)
            {
                var result = MessageBox.Show("سيؤدي هذا الاجراء الى حذف البيانات المؤقته"
              , "حذف البيانات المؤقته"
              , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    loadingForm.Show();
                    if (await Task.Run(() => dataHelper.IsConAvailable()))
                    {
                        var deleteResult = await Task.Run(() => dataHelper.Delete(ID));
                        if (deleteResult == 1)
                        {
                            loadingForm.Hide();
                            Code.MessageCollections.ShowDeleteNotificaiton();
                            pageControl.LoadData();
                            this.Close();
                        }
                        else
                        {
                            loadingForm.Hide();
                            Code.MessageCollections.ShowErrorServer();
                            this.Close();

                        }

                    }
                    else
                    {
                        loadingForm.Hide();
                        Code.MessageCollections.ShowErrorServer();
                        this.Close();
                    }

                    loadingForm.Hide();
                }
            }
            else
            {
                Close();
            }

        }

        private async void SetDataForEdit()
        {
            loadingForm.Show();
            if (await Task.Run(() => dataHelper.IsConAvailable()))
            {
                colleges = await Task.Run(() => dataHelper.Find(ID));
                if (colleges != null)
                {
                    textBoxUserName.Text = colleges.UserName;
                    textBoxName.Text = colleges.CollegeName;
                    textBoxPassword.Text = colleges.Password;
                    textBoxCollegeCode.Text = colleges.CollegeCode;
                    textBoxEmail.Text = colleges.Email;
                    textBoxPhoneNumber.Text = colleges.Phone;
                    richTextBoxDetails.Text = colleges.Details;
                }

            }
            else
            {
                loadingForm.Hide();
                MessageCollections.ShowErrorServer();
            }

            loadingForm.Hide();

        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            SetDataForEdit();
        }

        private void textBoxDepCode_MouseLeave(object sender, EventArgs e)
        {
            // Validate the text to ensure it represents a non-negative integer
            if (!int.TryParse(textBoxDepCode.Text, out int value) || value < 0)
            {
                // If the text is not a valid non-negative integer, reset the text to empty
                textBoxDepCode.Text = "00";
                labelValidation.Text = "رمز القسم:يتكون رمز القسم من مرتبتين  ";
            }
            // Trim the text to a maximum length of 4 characters
            if (textBoxDepCode.Text.Length > 2)
            {
                textBoxDepCode.Text = textBoxDepCode.Text.Substring(0, 2);
            }

            if (textBoxDepCode.TextLength != 2)
            {
                textBoxDepCode.Text = "00";
                MessageBox.Show("يجب ان يتكون رمز القسم من مرتبتين");
            }
        }

        private void textBoxCollegeCode_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxCollegeCode.TextLength != 4)
            {
                textBoxCollegeCode.Text = "0000";
                MessageBox.Show("يجب ان يتكون رمز الكلية من 4 مراتب");
            }
        }
    }
}
