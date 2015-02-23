using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GYMManager {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            try {
                Application.SetCompatibleTextRenderingDefault(false);
                Settings.Load();//===>Load Application DbSettings
                Application.Run(new FrmMain());
            } catch (System.Data.OleDb.OleDbException oledbEx) {
                FrmError.OledbShowError(oledbEx);
            } catch (Exception ex) {
                FrmError.ShowError(ex);
            } finally {
                Application.Exit();
            }


        }
    }
}