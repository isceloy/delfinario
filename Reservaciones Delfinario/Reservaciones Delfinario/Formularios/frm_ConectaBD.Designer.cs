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
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_Acceder = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.pcb_Contraseña = new System.Windows.Forms.PictureBox();
            this.pcb_Usuario = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Clave
            // 
            this.txt_Clave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txt_Clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Clave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clave.ForeColor = System.Drawing.Color.Gray;
            this.txt_Clave.Location = new System.Drawing.Point(334, 142);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(310, 19);
            this.txt_Clave.TabIndex = 2;
            this.txt_Clave.Text = "CONTRASEÑA";
            this.tot_Ayuda.SetToolTip(this.txt_Clave, "Contraseña");
            this.txt_Clave.Enter += new System.EventHandler(this.txt_Clave_Enter);
            this.txt_Clave.Leave += new System.EventHandler(this.txt_Clave_Leave);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.Color.Gray;
            this.txt_Usuario.Location = new System.Drawing.Point(334, 91);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(310, 19);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.Text = "USUARIO";
            this.tot_Ayuda.SetToolTip(this.txt_Usuario, "Usuario");
            this.txt_Usuario.Enter += new System.EventHandler(this.txt_Usuario_Enter);
            this.txt_Usuario.Leave += new System.EventHandler(this.txt_Usuario_Leave);
            // 
            // btn_Servidor
            // 
            this.btn_Servidor.AutoSize = true;
            this.btn_Servidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Servidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Servidor.FlatAppearance.BorderSize = 0;
            this.btn_Servidor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Servidor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Servidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Servidor.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Servidor.Location = new System.Drawing.Point(337, 240);
            this.btn_Servidor.Name = "btn_Servidor";
            this.btn_Servidor.Size = new System.Drawing.Size(307, 40);
            this.btn_Servidor.TabIndex = 4;
            this.btn_Servidor.Text = "Configura Servidor";
            this.tot_Ayuda.SetToolTip(this.btn_Servidor, "Configura Servidor");
            this.btn_Servidor.UseVisualStyleBackColor = false;
            this.btn_Servidor.Click += new System.EventHandler(this.btn_Servidor_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Cancelar;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(256, 182);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(32, 32);
            this.btn_Cancelar.TabIndex = 6;
            this.tot_Ayuda.SetToolTip(this.btn_Cancelar, "Cancelar");
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.tbn_Cancelar_Click);
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Entrar.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Ok;
            this.btn_Entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Entrar.FlatAppearance.BorderSize = 0;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Location = new System.Drawing.Point(256, 220);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(32, 32);
            this.btn_Entrar.TabIndex = 2;
            this.tot_Ayuda.SetToolTip(this.btn_Entrar, "Entrar");
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Visible = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 328);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reservaciones_Delfinario.Properties.Resources.logo_delfiniti;
            this.pictureBox1.Location = new System.Drawing.Point(46, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(334, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 1);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(334, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 1);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(431, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "LOGIN";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.LightGray;
            this.linkLabel1.Location = new System.Drawing.Point(414, 292);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ha olvidado la contraseña?";
            // 
            // btn_Acceder
            // 
            this.btn_Acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Acceder.FlatAppearance.BorderSize = 0;
            this.btn_Acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acceder.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Acceder.Location = new System.Drawing.Point(337, 192);
            this.btn_Acceder.Name = "btn_Acceder";
            this.btn_Acceder.Size = new System.Drawing.Size(307, 40);
            this.btn_Acceder.TabIndex = 3;
            this.btn_Acceder.Text = "Acceder";
            this.btn_Acceder.UseVisualStyleBackColor = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = global::Reservaciones_Delfinario.Properties.Resources.close;
            this.btn_Cerrar.Location = new System.Drawing.Point(704, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(15, 15);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 13;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // pcb_Contraseña
            // 
            this.pcb_Contraseña.Image = global::Reservaciones_Delfinario.Properties.Resources.Llave;
            this.pcb_Contraseña.Location = new System.Drawing.Point(256, 130);
            this.pcb_Contraseña.Name = "pcb_Contraseña";
            this.pcb_Contraseña.Size = new System.Drawing.Size(32, 32);
            this.pcb_Contraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Contraseña.TabIndex = 5;
            this.pcb_Contraseña.TabStop = false;
            this.pcb_Contraseña.Visible = false;
            // 
            // pcb_Usuario
            // 
            this.pcb_Usuario.Image = global::Reservaciones_Delfinario.Properties.Resources.Usuario;
            this.pcb_Usuario.Location = new System.Drawing.Point(256, 81);
            this.pcb_Usuario.Name = "pcb_Usuario";
            this.pcb_Usuario.Size = new System.Drawing.Size(32, 32);
            this.pcb_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Usuario.TabIndex = 4;
            this.pcb_Usuario.TabStop = false;
            this.pcb_Usuario.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(722, 328);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Acceder);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.pcb_Contraseña);
            this.Controls.Add(this.pcb_Usuario);
            this.Controls.Add(this.btn_Servidor);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Clave);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button btn_Servidor;
        private System.Windows.Forms.ToolTip tot_Ayuda;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.PictureBox pcb_Usuario;
        private System.Windows.Forms.PictureBox pcb_Contraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Acceder;
        private System.Windows.Forms.PictureBox btn_Cerrar;
    }
}

