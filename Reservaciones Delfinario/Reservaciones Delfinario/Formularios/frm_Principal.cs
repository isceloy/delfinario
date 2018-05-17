﻿using System;
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

        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Disponible formulario = new frm_Disponible();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void mi_Disponibilidad_Click(object sender, EventArgs e)
        {
            frm_Disponible formulario = new frm_Disponible();
            formulario.MdiParent = this.MdiParent;
            formulario.Show();
        }

        private void mi_Reservaciones_Click(object sender, EventArgs e)
        {
            frm_Reservaciones frmReservas = new frm_Reservaciones();
            frmReservas.MdiParent = this.MdiParent;
            frmReservas.Show();
        }

        private void tmi_TipoCambio_Click(object sender, EventArgs e)
        {
            frm_TipoCambio frmTC = new frm_TipoCambio();
            frmTC.MdiParent = this.MdiParent;
            frmTC.Show();
        }

        private void mi_Usuarios_Click(object sender, EventArgs e)
        {
            frm_Usuarios frmU = new frm_Usuarios();
            frmU.MdiParent = this.MdiParent;
            frmU.Show();
        }
    }
}
