﻿using System;
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
    public partial class frm_Reservaciones : Form
    {
        public frm_Reservaciones()
        {
            InitializeComponent();
        }

        private void btn_Busca_Click(object sender, EventArgs e)
        {
            frm_ConsultaReservas frmReservas = new frm_ConsultaReservas();
            frmReservas.Show();
            this.Close();
        }
    }
}
