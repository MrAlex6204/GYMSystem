using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GYMManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
            catch (Exception ex)
            {
                FrmError.ShowError(ex);
            }
            finally {
                Application.Exit();
            }


        }
    }
}
