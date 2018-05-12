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
    public partial class frm_ConfiguraServidor : Form
    {
        public frm_ConfiguraServidor()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!txt_Servidor.Text.Equals("") && !txt_BD.Text.Equals("") && !txt_Usuario.Text.Equals("") && !txt_Clave.Text.Equals(""))
            {
                Properties.Settings.Default.Servidor = txt_Servidor.Text;
                Properties.Settings.Default.BD = txt_BD.Text;
                Properties.Settings.Default.Usuario = txt_Usuario.Text;
                Properties.Settings.Default.Clave = txt_Clave.Text;
                Properties.Settings.Default.Save();
                Form1 frm = new Form1();
                frm.Show();
                this.Close();
            }
        }
    }
}
