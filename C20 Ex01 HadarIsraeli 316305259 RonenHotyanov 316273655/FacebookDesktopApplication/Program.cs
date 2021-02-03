using System;
using System.Windows.Forms;


// $G$ THE-001 (-3) your grade on diagrams document - 97. please see comments inside the document. (40% of your grade).


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
            Application.Run(new FormMain());
        }
    }
}
