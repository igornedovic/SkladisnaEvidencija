using Projekat.Common.Domain;
using Projekat.Server.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            dgvKlijenti.DataSource = new BindingList<Admin>(Controller.Instance.Admini);
            dgvKlijenti.Columns["Username"].HeaderText = "Korisnicko ime";
            dgvKlijenti.Columns["Password"].HeaderText = "Sifra";

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblVreme.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

            dgvKlijenti.DataSource = new BindingList<Admin>(Controller.Instance.Admini);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            if (server.Start())
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                MessageBox.Show("Server je pokrenut!");
                Thread nit = new Thread(server.Listen);
                nit.IsBackground = true;
                nit.Start();
            }
            else
            {
                MessageBox.Show("Server nije pokrenut! Doslo je do greske!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server?.Stop();
            server = null;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            MessageBox.Show("Server je zaustavljen!");
        }
    }
}
