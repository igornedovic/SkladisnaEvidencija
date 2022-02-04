using Forme.Exceptions;
using Forme.ServerCommunication;
using Forme.Session;
using Projekat.Common.Communication;
using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.GUIController
{
    public class LoginController
    {

        public Admin Admin { get; set; }
        internal void Login(FrmLogin frmLogin)
        {
            string username = frmLogin.TxtUsername.Text;
            string password = frmLogin.TxtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                frmLogin.TxtUsername.BackColor = Color.Salmon;
                frmLogin.TxtPassword.BackColor = Color.Salmon;
                return;
            }


            try
            {
                Admin admin = new Admin()
                {
                    Username = username,
                    Password = password,
                };

                Communication.Instance.Connect();

                SessionData.Instance.Admin = Communication.Instance.SendRequestGetResult<Admin>(Operation.Login, admin);
                if (SessionData.Instance.Admin != null)
                {
                    MessageBox.Show($"Dobrodosli, {SessionData.Instance.Admin.Username}");
                    frmLogin.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Pogresni kredencijali!");
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greska pri radu sa serverom! " + ex.Message);
            }

        }
    }
}
