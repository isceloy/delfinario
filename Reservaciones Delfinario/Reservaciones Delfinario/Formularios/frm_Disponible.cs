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
    public partial class frm_Disponible : Form
    {
        public frm_Disponible()
        {
            InitializeComponent();

            dtg_Nado.Columns.Add("reservacion","Reservación");
            dtg_Nado.Columns.Add("cliente", "Cliente");
            dtg_Nado.Columns.Add("cantidad", "Cantidad");

            dtg_Nado.Rows.Add("1234","Cliente Paterno Materno","3");
            dtg_Nado.Rows.Add("1234", "Cliente Paterno Materno", "2");
        }

    }
}