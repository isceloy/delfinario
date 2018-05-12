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
    public partial class Form1 : Form
    {
        private Conexion.Conexion con = new Conexion.Conexion();
        private String user = "";
        private String pass = "";
        private String tipo_usuario = "";

        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Servidor.Equals("") && Properties.Settings.Default.BD.Equals("") && Properties.Settings.Default.Usuario.Equals("") && Properties.Settings.Default.Clave.Equals(""))
            {
                txt_Usuario.Visible = false;
                txt_Clave.Visible = false;
                btn_Entrar.Visible = false;
                btn_Cancelar.Visible = false;
                pcb_Usuario.Visible = false;
                pcb_Contraseña.Visible = false;
                btn_Servidor.Visible = true;
            }
            else
            {
                con.servidor = Properties.Settings.Default.Servidor;
                con.BD = Properties.Settings.Default.BD;
                con.usuario = Properties.Settings.Default.Usuario;
                con.clave = Properties.Settings.Default.Clave;
                con.Conectar();
            }
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            user = txt_Usuario.Text;
            pass = txt_Clave.Text;
            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(pass))
            {
                tipo_usuario = con.Consulta_Usuario(user, pass);
                Limpiar_Cajas();
                if (tipo_usuario.Equals("Administrador"))
                {
                    MessageBox.Show("Bienvenido " + user, "Delfinario 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    frm_MenuPrincipal frmP = new frm_MenuPrincipal();
                    frmP.Show();
                    Dispose();
                }
                else
                {
                    MessageBox.Show(tipo_usuario, "Delfinario 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos de usuario y contraseña son obligatorios", "Delfinario 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar_Cajas();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Properties.Settings.Default.Servidor.Equals("") && !Properties.Settings.Default.BD.Equals("") && !Properties.Settings.Default.Usuario.Equals("") && !Properties.Settings.Default.Clave.Equals(""))
            {
                con.Desconectar();
            }
            Application.Exit();
        }

        private void btn_Servidor_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_ConfiguraServidor frm = new frm_ConfiguraServidor();
            frm.ShowDialog();
            Dispose();
        }

        private void tbn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar_Cajas();
        }

        private void Limpiar_Cajas()
        {
            txt_Usuario.Text = "";
            txt_Clave.Text = "";
        }
    }
}
