using DocumentFormat.OpenXml.Wordprocessing;
using IDGEN.Data.SqlServer;
using IDGEN.Gui.GuiUsers;

namespace IDGEN
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                SqlCon.SqlConnetion = Properties.Settings.Default.SqlServerConString;
                Application.Run(new StartForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
           
        }
    }
}