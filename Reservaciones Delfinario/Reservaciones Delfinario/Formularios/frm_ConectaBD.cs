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
        private Conectar.Conexion con = new Conectar.Conexion();
        private String user = "";
        private String pass = "";
        private String tipo_usuario = "";
        private DTO.DTO_Entrar dto_entrar = new DTO.DTO_Entrar();
        private DAO.DAO_Entrar dao_entrar = new DAO.DAO_Entrar();
        private DataTable dt = new DataTable();
        private String Query = "";

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
            dto_entrar.Usuario = txt_Usuario.Text;
            dto_entrar.Contraseña = txt_Clave.Text;
            if (!String.IsNullOrEmpty(dto_entrar.Usuario) && !String.IsNullOrEmpty(dto_entrar.Contraseña))
            {
                Query = dao_entrar.Entrar(dto_entrar.Usuario, dto_entrar.Contraseña);
                dt = con.Ejecuta_Query(Query);
                Limpiar_Cajas();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            if (col.ColumnName == "tipo")
                            {
                                if (row[col].ToString() == "Administrador")
                                {
                                    MessageBox.Show("Bienvenido " + row["nombre"].ToString(), "Delfinario 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Visible = false;
                                    frm_MenuPrincipal frmP = new frm_MenuPrincipal();
                                    frmP.Show();
                                    Dispose();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Delfinario 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos de usuario y contraseña son obligatorios", "Delfinario 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
