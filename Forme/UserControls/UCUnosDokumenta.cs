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

namespace Forme.UserControls
{
    public partial class UCUnosDokumenta : UserControl
    {
        private UnosDokumentaController controller;
        public UCUnosDokumenta()
        {
            InitializeComponent();
            controller = new UnosDokumentaController(this);
            controller.Init();
        }
    }
}
