using System;
using System.Windows.Forms;


//
// THE-001 (-0) your grade on diagrams document - 100 please see comments inside the document. (50% of your grade).

namespace FacebookDesktopApplication
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormFactory.CreateNewForm(FormFactory.eFormType.FormMain));
        }
    }
}
