using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones_Delfinario.Formularios
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void frm_MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
