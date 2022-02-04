﻿using Forme.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController;
        public FrmLogin()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginController.Login(this);
        }
    }
}
