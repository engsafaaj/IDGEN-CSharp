
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Spreadsheet;
using IDGEN.Code;
using IDGEN.Core;
using IDGEN.Data;
using IDGEN.Data.EF;
using IDGEN.Gui.GuiLoading;
using IDGEN.Gui.GuiUsers;
using IDGEN.GUI.StudnetGui;
using IDGEN.GUI.UsersGui;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Color = System.Drawing.Color;
using Control = System.Windows.Forms.Control;

namespace IDGEN.Gui.StudnetGui
{
    public partial class AddStudentForm : Form
    {
        // Fields
        public readonly StudentUserControl pageControl;
        LoadingForm loadingForm;
        public int ID;
        private Colleges colleges;
        private IDataHelper<Colleges> dataHelper;
        private IDataHelper<Logs> dataHelperLogs;
        private IDataHelper<CollegeDep> dataHelperDep;
        private IDataHelper<Studnets> dataHelperStudent;
        private int RowId;
        public bool IsEdit;
        private List<Colleges> listOfCollege;
        private int collegeId;
        private List<CollegeDep> listOfDep;
        private StudentCode studentCode;
        public Main main;
        private AddUserForm addForm;

        // Constructors
        public AddStudentForm(StudentUserControl pageControl, int Id, bool isEdit, Main main)
        {
            InitializeComponent();
            //
            this.Owner = main;
            this.main = main;
            studentCode = new StudentCode();
            listOfCollege = new List<Colleges>();
            listOfDep = new List<CollegeDep>();
            IsEdit = isEdit;
            ID = Id;
            // Inject Data Helper
            dataHelper = new CollegeEF();
            dataHelperStudent = new StudnetEF();
            dataHelperLogs = new LogsEF();
            dataHelperDep = new DepEF();
            //
            loadingForm = new LoadingForm(this);

            this.pageControl = pageControl; // Inint Page User Control

            IsEdit = isEdit;

        }

        // Methods & Events
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Text = "الاسم الكامل للطالب: اسم الطالب كما هو مكتوب في القوائم الرسمية";
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "الاسم الكامل للطالب: اسم الطالب كما هو مكتوب في القوائم الرسمية";

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "رمز القسم:يتكون رمز القسم من مرتبتين";
        }

        private bool IsTextBoxValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                 textBoxStudentID.TextLength != 3 ||
                 textBoxAddYear.TextLength != 2
                 )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private async void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            if (!IsTextBoxValid())
            {
                MessageBox.Show("انتبه ! يجب ان تدخل اسم الطالب الكامل وتذكر ان سنة القبول تتكون من مرتبتين و ترتيبه من 3 مراتب",
                    "خطأ ادخال",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (comboBoxDep.Items.Count == 0)
                {
                    MessageBox.Show("يبدو انك لم تقم باضافة الاقسام العلمية. تتيح لك الصفحة القادمة اضافة الاقسام العلمية"
    , "لا يوجد اقسام علمية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Edit();
                }
                else
                {

                    loadingForm.Show();
                    if (await Task.Run(() => dataHelper.IsConAvailable()))
                    {
                        // Check Duplicated Data => Add
                        var studentID = studentCode.GenerateStudentIDWithOutSpace();

                        var dupliateData = Task.Run(() => dataHelperStudent.GetAllData().Where(X => X.Id != ID)
                                       .Where(x => x.FullID == studentID)
                                       .FirstOrDefault() ?? new Studnets()).Result;

                        if (dupliateData.Id > 0)
                        {
                            loadingForm.Hide();
                            MessageBox.Show("يجب ان يكون معرف الطالب مختلف", "بيانات مكررة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (SaveData())
                            {
                                if (!IsEdit)
                                {
                                    MessageCollections.ShowAddNotificaiton();
                                    IncreaseStudentID();
                                    textBoxFullName.Text = string.Empty;
                                }
                                else
                                {
                                    MessageCollections.ShowUpdateNotificaiton();
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
                }

            }
            loadingForm.Hide();
        }

        private bool SaveData()
        {
            if (!IsEdit)
            {
                AddData();
            }
            else
            {
                EditData();
            }
            return true;
        }

        private async Task<bool> EditData()
        {
            // Set Data
            var studnet = new Studnets
            {
                Id = ID,
                AddDate = DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToShortTimeString(),
                DepartmentCode = comboBoxDep.SelectedItem.ToString(),
                AdmissionChannel = comboBoxAdmChannel.SelectedItem.ToString(),
                FacultyCode = comboBoxCollegeName.SelectedItem.ToString(),
                Gender = comboBoxStudentGender.SelectedItem.ToString(),
                AdmissionYear = textBoxAddYear.Text,
                CollegesId = listOfCollege.Where(X => X.CollegeName == comboBoxCollegeName.SelectedItem).Select(X => X.Id).FirstOrDefault(),
                EnrollmentOrder = textBoxStudentID.Text,
                FullID = studentCode.GenerateStudentIDWithOutSpace(),
                Name = textBoxFullName.Text,
                StudyLevel = comboBoxStudyType.SelectedItem.ToString(),
                StudySystem = comboBoxStudySystem.SelectedItem.ToString(),
                UniversityCode = textBoxUniversityName.Text,
            };
            // Sumbit
            var result = await Task.Run(() => dataHelperStudent.Update(studnet));
            if (result == 1)
            {

                // Save System Records
                var logs = new Logs
                {
                    LogTitle = " تعديل طالب",
                    UserFullName = Properties.Settings.Default.UserName,
                    LogDescriptions = "تم تعديل  الطالب الذي يحمل المعلومات التالية   " + studnet.Name + " | " + studnet.FullID,
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

        private async Task<bool> AddData()
        {
            // Set Data

            var studnet = new Studnets
            {
                AddDate = DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToShortTimeString(),
                DepartmentCode = comboBoxDep.SelectedItem.ToString(),
                AdmissionChannel = comboBoxAdmChannel.SelectedItem.ToString(),
                FacultyCode = comboBoxCollegeName.SelectedItem.ToString(),
                Gender = comboBoxStudentGender.SelectedItem.ToString(),
                AdmissionYear = textBoxAddYear.Text,
                CollegesId = listOfCollege.Where(X => X.CollegeName == comboBoxCollegeName.SelectedItem).Select(X => X.Id).FirstOrDefault(),
                EnrollmentOrder = textBoxStudentID.Text,
                FullID = studentCode.GenerateStudentIDWithOutSpace(),
                Name = textBoxFullName.Text,
                StudyLevel = comboBoxStudyType.SelectedItem.ToString(),
                StudySystem = comboBoxStudySystem.SelectedItem.ToString(),
                UniversityCode = textBoxUniversityName.Text,
            };
            // Sumbit
            var result = await Task.Run(() => dataHelperStudent.Add(studnet));
            if (result == 1)
            {

                // Save System Records
                var logs = new Logs
                {
                    LogTitle = " اضافة طالب",
                    UserFullName = Properties.Settings.Default.UserName,
                    LogDescriptions = "تم اضافة  الطالب الذي يحمل المعلومات التالية   " + studnet.Name + " | " + studnet.FullID,
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

        private async void SetDataForEdit()
        {
            loadingForm.Show();
            if (await Task.Run(() => dataHelper.IsConAvailable()))
            {
                var student = await Task.Run(() => dataHelperStudent.Find(ID));
                if (student != null)
                {
                    comboBoxDep.SelectedItem = student.DepartmentCode;
                    comboBoxAdmChannel.SelectedItem = student.AdmissionChannel;
                    comboBoxCollegeName.SelectedItem = student.FacultyCode;
                    comboBoxStudentGender.SelectedItem = student.Gender;
                    textBoxAddYear.Text = student.AdmissionYear;
                    textBoxStudentID.Text = student.EnrollmentOrder;
                    textBoxFullName.Text = student.Name;
                    comboBoxStudyType.SelectedItem = student.StudyLevel;
                    comboBoxStudySystem.SelectedItem = student.StudySystem;
                    textBoxUniversityName.Text = student.UniversityCode;
                }
                studentCode.EnrollmentOrder = student.EnrollmentOrder;
                studentCode.AdmissionYear = student.AdmissionYear;
                textBoxStudentFinalID.Text = studentCode.GenerateStudentID();
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
            LoadCollege();

            if (ID > 0)
            {
                SetDataForEdit();

            }
            SetDefualtValue();

            studentCode.UniversityCode = "28"; // Change this code 
            studentCode.EnrollmentOrder = textBoxStudentID.Text;
            studentCode.AdmissionYear = textBoxAddYear.Text;

            // Set College Role
            if (!Code.LoggedUser.IsAdmin)
            {
                comboBoxCollegeName.SelectedItem = LoggedUser.CollegeName;
                comboBoxCollegeName.Enabled = false;
            }


            LoadDep();

        }

        private void textBoxStudentID_Enter(object sender, EventArgs e)
        {
            labelValidation.Text = "تسلسل الطالب: تسلسل الطالب كما هو مكتوب في القوائم الرسمية";

        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            labelValidation.Text = "سنة القبول: سنة قبول الطالب كما هو مكتوب في القوائم الرسمية";
        }

        private async void LoadCollege()
        {
            listOfCollege.Clear();
            loadingForm.Show();
            if (await Task.Run(() => dataHelper.IsConAvailable()))
            {
                if (Code.LoggedUser.IsAdmin)
                {
                    listOfCollege = await Task.Run(() => dataHelper.GetAllData().Where(X => X.IsAdmin == false).ToList());
                    comboBoxCollegeName.DataSource = listOfCollege.Select(x => x.CollegeName).ToList();
                }
                else
                {
                    listOfCollege = await Task.Run(() => dataHelper.GetAllData().Where(X => X.IsAdmin == false && X.Id == LoggedUser.Id).ToList());
                    comboBoxCollegeName.DataSource = listOfCollege.Select(x => x.CollegeName).ToList();
                }

            }
            else
            {
                loadingForm.Hide();
                MessageCollections.ShowErrorServer();
            }

            loadingForm.Hide();

        }

        private void textBoxStudentID_TextChanged(object sender, EventArgs e)
        {
            // Validate the text to ensure it represents a non-negative integer
            if (!int.TryParse(textBoxStudentID.Text, out int value) || value < 0)
            {
                // If the text is not a valid non-negative integer, reset the text to empty
                textBoxStudentID.Text = "000";
                labelValidation.Text = "ترتيب الطالب:يتكون ترتيب الطالب من ثلاث مراحل ويمثل ترتيبة في القوائم الرسمية  ";
            }
            // Trim the text to a maximum length of 4 characters
            if (textBoxStudentID.Text.Length > 2)
            {
                textBoxStudentID.Text = textBoxStudentID.Text.Substring(0, 3);
            }
        }

        private void textBoxAdmYear_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxAddYear.Text, out int value) || value < 0)
            {
                // If the text is not a valid non-negative integer, reset the text to empty
                textBoxAddYear.Text = "00";
                labelValidation.Text = "سنة القبول:تتكون سنة القبول من مرتبتين   ";
            }
            // Trim the text to a maximum length of 4 characters
            if (textBoxAddYear.Text.Length > 2)
            {
                textBoxAddYear.Text = textBoxAddYear.Text.Substring(0, 2);
            }

        }

        private void SetDefualtValue()
        {
            textBoxFullName.Text = string.Empty;
            textBoxStudentID.Text = "000";
            var year = DateTime.Now.Year.ToString();
            textBoxAddYear.Text = year[2].ToString() + year[3].ToString();
            comboBoxStudySystem.SelectedIndex = 0;
            comboBoxAdmChannel.SelectedIndex = 0;
            comboBoxStudyType.SelectedIndex = 0;
            comboBoxStudentGender.SelectedIndex = 0;
        }

        private void IncreaseStudentID()
        {
            var prevID = Convert.ToInt32(textBoxStudentID.Text);
            var newID = prevID + 1;
            if (newID < 10)
            {
                textBoxStudentID.Text = "00" + newID.ToString();
            }
            else if (newID >= 10 && newID < 100)
            {
                textBoxStudentID.Text = "0" + newID.ToString();
            }
            else
            {
                textBoxStudentID.Text = newID.ToString();

            }
            studentCode.EnrollmentOrder = textBoxStudentID.Text;
            textBoxStudentFinalID.Text = studentCode.GenerateStudentID();

        }

        private void comboBoxCollegeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                studentCode.FacultyCode = listOfCollege.Where(X => X.CollegeName == comboBoxCollegeName.SelectedItem).Select(X => X.CollegeCode).FirstOrDefault();
                LoadDep();
            }
            catch { }
            textBoxStudentFinalID.Text = studentCode.GenerateStudentID();
        }

        public async void LoadDep()
        {
            listOfDep.Clear();
            try
            {
                loadingForm.Show();
                if (await Task.Run(() => dataHelperDep.IsConAvailable()))
                {
                    if (comboBoxCollegeName.Items.Count > 0)
                    {
                        collegeId = LoggedUser.Id;
                        listOfDep = await Task.Run(() => dataHelperDep.GetAllData().Where(X => X.CollegesId == collegeId).ToList());
                        if (listOfDep.Count == 0 && LoggedUser.IsAdmin==false)
                        {
                            MessageBox.Show("يبدو انك لم تقم باضافة الاقسام العلمية. تتيح لك الصفحة القادمة اضافة الاقسام العلمية"
                              , "لا يوجد اقسام علمية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Edit();

                        }
                        else
                        {
                            comboBoxDep.DataSource = listOfDep.Select(x => x.DepName).ToList();
                            comboBoxDep.SelectedIndex = 0;
                        }

                    }

                }
                else
                {
                    loadingForm.Hide();
                    MessageCollections.ShowErrorServer();
                }
            }
            catch { }


            loadingForm.Hide();
        }

        private void textBoxStudentID_MouseLeave(object sender, EventArgs e)
        {

            if (textBoxStudentID.TextLength != 3)
            {
                MessageBox.Show("يجب ان يكون تسلسل الطالب من 3 مراتب", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                studentCode.EnrollmentOrder = "000";
                studentCode.EnrollmentOrder = textBoxStudentID.Text;
            }
            else
            {
                studentCode.EnrollmentOrder = textBoxStudentID.Text;
            }
            textBoxStudentFinalID.Text = studentCode.GenerateStudentID();

        }

        private void textBoxAddYear_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxAddYear.TextLength != 2)
            {
                MessageBox.Show("يجب ان يكون تسلسل الطالب من مرتبتين", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var year = DateTime.Now.Year.ToString();
                textBoxAddYear.Text = year[2].ToString() + year[3].ToString();
                studentCode.AdmissionYear = textBoxAddYear.Text;
            }
            else
            {
                studentCode.AdmissionYear = textBoxAddYear.Text;
            }
            textBoxStudentFinalID.Text = studentCode.GenerateStudentID();


        }

        private void comboBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                studentCode.DepartmentCode = listOfDep.Where(X => X.DepName == comboBoxDep.SelectedItem).Select(X => X.DepCode).FirstOrDefault();
            }
            catch { }
            textBoxStudentFinalID.Text = studentCode.GenerateStudentID();

        }

        private void comboBoxStudySystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentCode.StudyLevel = Convert.ToString(comboBoxStudySystem.SelectedIndex + 1);
            textBoxStudentFinalID.Text = studentCode.GenerateStudentID();
        }

        private void comboBoxStudyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentCode.StudySystem = Convert.ToString(comboBoxStudyType.SelectedIndex + 1);
            textBoxStudentFinalID.Text = studentCode.GenerateStudentID();

        }

        private void comboBoxAdmChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentCode.AdmissionChannel = Convert.ToString(comboBoxAdmChannel.SelectedIndex + 1) + Convert.ToString(comboBoxAdmChannel.SelectedIndex + 1);
            textBoxStudentFinalID.Text = studentCode.GenerateStudentID();

        }

        private void comboBoxStudentGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentCode.Gender = Convert.ToString(comboBoxStudentGender.SelectedIndex + 1);
            textBoxStudentFinalID.Text = studentCode.GenerateStudentID();

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonCopy.Enabled = false;
            buttonPrint.Enabled = false;
            this.BackColor = Color.White;
            PrintHelper.PrintPanel(panelPrint);
            if (buttonSaveAndClose.Enabled == false)
            {
                groupBox1.Enabled = false;

            }
            buttonCopy.Enabled = true;
            buttonPrint.Enabled = true;
            this.BackColor = SystemColors.Control;

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(studentCode.GenerateStudentIDWithOutSpace());
            MessageBox.Show("تم نسخ النص إلى الحافظة!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabelDep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit();
        }

        private void Edit()
        {

            // Get Id
            RowId = LoggedUser.Id;

            addForm = new AddUserForm(UsersUserControl.Instance(main), RowId, true, main);

            addForm.TopMost = true;
            addForm.groupBox1.Enabled = false;
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDep();
            }

        }

    }
}
