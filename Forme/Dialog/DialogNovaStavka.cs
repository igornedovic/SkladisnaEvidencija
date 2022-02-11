using Forme.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Dialog
{
    public partial class DialogNovaStavka : Form
    {
        private NovaStavkaController controller;
        public DialogNovaStavka()
        {
            InitializeComponent();
            controller = new NovaStavkaController(this);
            controller.Init();
        }

    }
}
