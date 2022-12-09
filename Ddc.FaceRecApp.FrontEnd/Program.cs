using Ddc.FaceRecApp.FrontEnd.Persistence;
using Ddc.FaceRecApp.FrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddc.FaceRecApp.FrontEnd
{
    public static class Program
    {
        public static VerilookManagerFactory VerilookFactory;
        public static TimelogDbManager TimelogDbManager;
        public static AdministratorDbManager AdministratorDbManager;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VerilookFactory = new VerilookManagerFactory("DSN=mysql_dsn;UID=root;PWD=Soft1234", "subjects");

            string connectionString = "Server=localhost;Database=capitol_facerec;Uid=root;Pwd=Soft1234;";
            AdministratorDbManager = new AdministratorDbManager(connectionString);
            TimelogDbManager = new TimelogDbManager(connectionString);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainView mainView = new MainView()
            {
                Text = $"DDC FaceRec Attendance v{Application.ProductVersion}"
            };

            Application.Run( mainView);
        }
    }
}
