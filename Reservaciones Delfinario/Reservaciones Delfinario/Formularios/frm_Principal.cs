using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservaciones_Delfinario.Formularios;

namespace Reservaciones_Delfinario
{
    public partial class frm_Pricipal : Form
    {
        public frm_Pricipal()
        {
            InitializeComponent();
        }

        private void frm_Pricipal_Load(object sender, EventArgs e)
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

        private void frm_Pricipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void mi_Disponibilidad_Click(object sender, EventArgs e)
        {
            frm_Disponible formulario = new frm_Disponible();
            formulario.MdiParent = this.MdiParent;
            formulario.Show();
        }

        private void tmi_TipoCambio_Click(object sender, EventArgs e)
        {
            frm_TipoCambio frmTC = new frm_TipoCambio();
            frmTC.MdiParent = this.MdiParent;
            frmTC.Show();
        }

        private void tmi_Programas_Click(object sender, EventArgs e)
        {
            frm_TipoNados frmTN = new frm_TipoNados();
            frmTN.MdiParent = this.MdiParent;
            frmTN.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Usuarios frmU = new frm_Usuarios();
            frmU.MdiParent = this.MdiParent;
            frmU.Show();
        }

        private void agentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Agentes frmA = new frm_Agentes();
            frmA.MdiParent = this.MdiParent;
            frmA.Show();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Reservaciones frmReservas = new frm_Reservaciones();
            frmReservas.MdiParent = this.MdiParent;
            frmReservas.Show();
        }

        private void consultaReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultaReservas frmCR = new frm_ConsultaReservas();
            frmCR.MdiParent = this.MdiParent;
            frmCR.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Productos frmP = new frm_Productos();
            frmP.MdiParent = this.MdiParent;
            frmP.Show();
        }
    }
}
