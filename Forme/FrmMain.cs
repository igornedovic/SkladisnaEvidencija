using Forme.ServerCommunication;
using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ChangePanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }
        private void unosDokumentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCUnosDokumenta());
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Communication.Instance.Close();
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>> FormClosed event: " + ex.Message);
            }
        }

    }
}
