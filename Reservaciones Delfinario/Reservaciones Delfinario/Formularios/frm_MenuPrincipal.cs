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

        private void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException ice)
                {
                    Console.WriteLine(ice.ToString());
                }
            }
        }

        private void btn_Usuarios_MouseEnter(object sender, EventArgs e)
        {
            btn_Usuarios.BackColor = this.BackColor;
        }

        private void btn_Reservaciones_MouseEnter(object sender, EventArgs e)
        {
            btn_Reservaciones.BackColor = this.BackColor;
        }

        private void btn_Disponibilidad_MouseEnter(object sender, EventArgs e)
        {
            btn_Disponibilidad.BackColor = this.BackColor;
        }

        private void btn_Fotos_MouseEnter(object sender, EventArgs e)
        {
            btn_Fotos.BackColor = this.BackColor;
        }

        private void btn_Catalagos_MouseEnter(object sender, EventArgs e)
        {
            btn_Catalagos.BackColor = this.BackColor;
        }

        private void btn_Reservaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
