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
    public partial class frm_Usuarios : Form
    {
        public frm_Usuarios()
        {
            InitializeComponent();
        }

        private void btn_Agentes_Click(object sender, EventArgs e)
        {
            frm_Agentes frmA = new frm_Agentes();
            frmA.Show();
            this.Dispose();
        }
    }
}
