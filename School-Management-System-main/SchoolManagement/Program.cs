using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /// Application.Run(new Intro());
            ///Application.Run(new MainFormProfessor());
            Application.Run(new Intro());
            /// Application.Run(new PersonalData());
            ///Application.Run(new AddCourseForm());
        }
    }
}
