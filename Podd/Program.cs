using System;
using System.IO;
using System.Windows.Forms;


namespace Podd
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path2 = Directory.GetCurrentDirectory();
            string combined = (path2 + "\\Podcasts");

            if (!Directory.Exists(combined))
            {
                Directory.CreateDirectory(combined);
            }

            string combinedPath = (path2 + "\\kategorier");

            if (!Directory.Exists(combinedPath))
            {
                Directory.CreateDirectory(combinedPath);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
