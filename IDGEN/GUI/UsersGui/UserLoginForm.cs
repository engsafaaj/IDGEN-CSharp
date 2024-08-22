using IDGEN.Code;
using IDGEN.Core;
using IDGEN.Data;
using IDGEN.Data.EF;
using IDGEN.Gui.GuiLoading;
using System.Data;

namespace IDGEN.Gui.GuiUsers
{
    public partial class UserLoginForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly IDataHelper<Colleges> dataHelper;
        private readonly GuiLoading.LoadingForm loadingForm;
        private readonly IDataHelper<Logs> dataHelperSystemRecords;

        // Constructors
        public UserLoginForm()
        {
            InitializeComponent();

            //
            dataHelper = new CollegeEF();
            dataHelperSystemRecords = new LogsEF();
            //

            loadingForm = new LoadingForm(this);

            
            // Get Properties
            if (Properties.Settings.Default.RememberMe)
            {
                radioButtonRememberMe.Checked = Properties.Settings.Default.RememberMe = true;
                textBoxUserName.Text = Properties.Settings.Default.UserName;
                textBoxPassword.Text = Properties.Settings.Default.Password;
            }
        }


        // Methods & Events
        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsFiledsEmpty())
            {
                loadingForm.Hide();
                MessageBox.Show("ادخل معلومات تسجيل الدخول اولا"
                    , "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var userName = textBoxUserName.Text;
                var password = textBoxPassword.Text;

                loadingForm.Show();
                if(await Task.Run(()=> dataHelper.IsConAvailable()))
                {
                    var UserLoginResult = await Task.Run(() => Login(userName, password));
                    if (UserLoginResult == 1)
                    {
                        if (radioButtonRememberMe.Checked)
                        {
                            Properties.Settings.Default.RememberMe = true;
                            Properties.Settings.Default.UserName = userName;
                            Properties.Settings.Default.Password = password;
                            Properties.Settings.Default.Save();
                        }
                        Main main = new Main();
                        main.Show();
                        Hide();
                    }
                    else if (UserLoginResult == 2)
                    {
                        loadingForm.Hide();
                        MessageCollections.ShowErrorServer();
                    }
                    else
                    {
                        loadingForm.Hide();
                        MessageBox.Show("معلومات تسجيل الدخول التي ادخلتها غير صحيحة. يمكنك الاتصال بمدير النظام لتزويدك بها"
                            , "خطا في معلومات تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {


        }

        private bool IsFiledsEmpty()
        {
            if (
                 textBoxUserName.Text == string.Empty
                || textBoxPassword.Text == string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int Login(string UserName, string Password)
        {

            try
            {
                // Check
                Colleges user = dataHelper.GetAllData().Where(x => x.UserName == UserName && x.Password == Password).FirstOrDefault();
                if (user != null)
                {
                    Properties.Settings.Default.UserName = user.UserName;
                    Properties.Settings.Default.Save();


                    // Set User info

                    Code.LoggedUser.UserName = user.UserName;
                    Code.LoggedUser.Id = user.Id;
                    Code.LoggedUser.IsAdmin = user.IsAdmin;
                    Code.LoggedUser.Password = Password;
                    Code.LoggedUser.CollegeCode = user.CollegeCode;
                    Code.LoggedUser.DepNo = user.DepNo;
                    Code.LoggedUser.Phone = user.Phone;
                    Code.LoggedUser.Details = user.Details;
                    Code.LoggedUser.Email = user.Email;
                    Code.LoggedUser.CollegeName = user.CollegeName;


                    // Save System Records
                    var logs = new Logs
                    {
                        LogTitle = " تسجيل الدخول",
                        UserFullName = Properties.Settings.Default.UserName,
                        LogDescriptions = "تم تسجيل دخول المستخدم     " + user.CollegeName,
                        LogDate = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString(),
                        UserDeviceMac = DeviceHelper.GetDeviceMacAddress(),
                        UserDeviceName = Environment.MachineName,
                    };

                    dataHelperSystemRecords.Add(logs);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 2;
            }

        }

        private void UserLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave_Click(sender, e);
            }
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave_Click(sender, e);
            }
        }
    }
}
