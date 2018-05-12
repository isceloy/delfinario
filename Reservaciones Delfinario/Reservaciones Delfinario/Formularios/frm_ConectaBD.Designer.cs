namespace Reservaciones_Delfinario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.btn_Servidor = new System.Windows.Forms.Button();
            this.tot_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.pcb_Contraseña = new System.Windows.Forms.PictureBox();
            this.pcb_Usuario = new System.Windows.Forms.PictureBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(132, 118);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.PasswordChar = '*';
            this.txt_Clave.Size = new System.Drawing.Size(227, 22);
            this.txt_Clave.TabIndex = 1;
            this.tot_Ayuda.SetToolTip(this.txt_Clave, "Contraseña");
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(132, 64);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(227, 22);
            this.txt_Usuario.TabIndex = 0;
            this.tot_Ayuda.SetToolTip(this.txt_Usuario, "Usuario");
            // 
            // btn_Servidor
            // 
            this.btn_Servidor.AutoSize = true;
            this.btn_Servidor.Location = new System.Drawing.Point(156, 225);
            this.btn_Servidor.Name = "btn_Servidor";
            this.btn_Servidor.Size = new System.Drawing.Size(122, 26);
            this.btn_Servidor.TabIndex = 3;
            this.btn_Servidor.Text = "Configura Servidor";
            this.tot_Ayuda.SetToolTip(this.btn_Servidor, "Configura Servidor");
            this.btn_Servidor.UseVisualStyleBackColor = true;
            this.btn_Servidor.Visible = false;
            this.btn_Servidor.Click += new System.EventHandler(this.btn_Servidor_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Cancelar;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(232, 166);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(32, 32);
            this.btn_Cancelar.TabIndex = 6;
            this.tot_Ayuda.SetToolTip(this.btn_Cancelar, "Cancelar");
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.tbn_Cancelar_Click);
            // 
            // pcb_Contraseña
            // 
            this.pcb_Contraseña.Image = global::Reservaciones_Delfinario.Properties.Resources.Llave;
            this.pcb_Contraseña.Location = new System.Drawing.Point(76, 113);
            this.pcb_Contraseña.Name = "pcb_Contraseña";
            this.pcb_Contraseña.Size = new System.Drawing.Size(32, 32);
            this.pcb_Contraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Contraseña.TabIndex = 5;
            this.pcb_Contraseña.TabStop = false;
            // 
            // pcb_Usuario
            // 
            this.pcb_Usuario.Image = global::Reservaciones_Delfinario.Properties.Resources.Usuario;
            this.pcb_Usuario.Location = new System.Drawing.Point(76, 59);
            this.pcb_Usuario.Name = "pcb_Usuario";
            this.pcb_Usuario.Size = new System.Drawing.Size(32, 32);
            this.pcb_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Usuario.TabIndex = 4;
            this.pcb_Usuario.TabStop = false;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Entrar.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Ok;
            this.btn_Entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Entrar.FlatAppearance.BorderSize = 0;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Location = new System.Drawing.Point(170, 166);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(32, 32);
            this.btn_Entrar.TabIndex = 2;
            this.tot_Ayuda.SetToolTip(this.btn_Entrar, "Entrar");
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.pcb_Contraseña);
            this.Controls.Add(this.pcb_Usuario);
            this.Controls.Add(this.btn_Servidor);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Clave);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Servidor;
        private System.Windows.Forms.PictureBox pcb_Usuario;
        private System.Windows.Forms.PictureBox pcb_Contraseña;
        private System.Windows.Forms.ToolTip tot_Ayuda;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

