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

            while (true)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                DialogResult frmLoginResult = frmLogin.DialogResult;

                if (frmLoginResult == DialogResult.OK)
                {
                    try
                    {
                        Application.Run(new FrmMain());

                    }
                    catch (ServerCommunicationException ex) 
                    {
                        MessageBox.Show("Greska pri radu sa serverom! Bicete odjavljeni sa sistema ukoliko ste ulogovani! >>> " + ex.Message);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
