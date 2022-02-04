using Forme.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            DialogResult result = frmLogin.DialogResult;
            frmLogin.Dispose();

            while (true)
            {
                try
                {
                    if (result == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Greska pri radu sa serverom!");
                }
            }
        }
    }
}
