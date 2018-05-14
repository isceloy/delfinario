namespace Reservaciones_Delfinario.Formularios
{
    partial class frm_MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MenuPrincipal));
            this.imgl_ListaIconos = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Catalagos = new System.Windows.Forms.Button();
            this.btn_Fotos = new System.Windows.Forms.Button();
            this.btn_Disponibilidad = new System.Windows.Forms.Button();
            this.btn_Reservaciones = new System.Windows.Forms.Button();
            this.tot_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgl_ListaIconos
            // 
            this.imgl_ListaIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgl_ListaIconos.ImageStream")));
            this.imgl_ListaIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgl_ListaIconos.Images.SetKeyName(0, "Registro.png");
            this.imgl_ListaIconos.Images.SetKeyName(1, "Calendario-Reloj.png");
            this.imgl_ListaIconos.Images.SetKeyName(2, "Carpeta.png");
            this.imgl_ListaIconos.Images.SetKeyName(3, "Usuarios.png");
            this.imgl_ListaIconos.Images.SetKeyName(4, "Fotos.png");
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Usuarios);
            this.panel1.Controls.Add(this.btn_Catalagos);
            this.panel1.Controls.Add(this.btn_Fotos);
            this.panel1.Controls.Add(this.btn_Disponibilidad);
            this.panel1.Controls.Add(this.btn_Reservaciones);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 48);
            this.panel1.TabIndex = 2;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.BackColor = System.Drawing.Color.Transparent;
            this.btn_Usuarios.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Usuarios;
            this.btn_Usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.Location = new System.Drawing.Point(297, -1);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(48, 48);
            this.btn_Usuarios.TabIndex = 6;
            this.tot_Ayuda.SetToolTip(this.btn_Usuarios, "Usuarios");
            this.btn_Usuarios.UseVisualStyleBackColor = false;
            this.btn_Usuarios.MouseEnter += new System.EventHandler(this.btn_Usuarios_MouseEnter);
            // 
            // btn_Catalagos
            // 
            this.btn_Catalagos.BackColor = System.Drawing.Color.Transparent;
            this.btn_Catalagos.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Carpeta;
            this.btn_Catalagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Catalagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Catalagos.FlatAppearance.BorderSize = 0;
            this.btn_Catalagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Catalagos.Location = new System.Drawing.Point(225, -1);
            this.btn_Catalagos.Name = "btn_Catalagos";
            this.btn_Catalagos.Size = new System.Drawing.Size(48, 48);
            this.btn_Catalagos.TabIndex = 5;
            this.tot_Ayuda.SetToolTip(this.btn_Catalagos, "Catalagos");
            this.btn_Catalagos.UseVisualStyleBackColor = false;
            this.btn_Catalagos.MouseEnter += new System.EventHandler(this.btn_Catalagos_MouseEnter);
            // 
            // btn_Fotos
            // 
            this.btn_Fotos.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fotos.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Fotos;
            this.btn_Fotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fotos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fotos.FlatAppearance.BorderSize = 0;
            this.btn_Fotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fotos.Location = new System.Drawing.Point(153, -1);
            this.btn_Fotos.Name = "btn_Fotos";
            this.btn_Fotos.Size = new System.Drawing.Size(48, 48);
            this.btn_Fotos.TabIndex = 5;
            this.tot_Ayuda.SetToolTip(this.btn_Fotos, "Venta de fotos");
            this.btn_Fotos.UseVisualStyleBackColor = false;
            this.btn_Fotos.MouseEnter += new System.EventHandler(this.btn_Fotos_MouseEnter);
            // 
            // btn_Disponibilidad
            // 
            this.btn_Disponibilidad.BackColor = System.Drawing.Color.Transparent;
            this.btn_Disponibilidad.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Calendario_Reloj;
            this.btn_Disponibilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Disponibilidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Disponibilidad.FlatAppearance.BorderSize = 0;
            this.btn_Disponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Disponibilidad.Location = new System.Drawing.Point(81, -1);
            this.btn_Disponibilidad.Name = "btn_Disponibilidad";
            this.btn_Disponibilidad.Size = new System.Drawing.Size(48, 48);
            this.btn_Disponibilidad.TabIndex = 4;
            this.tot_Ayuda.SetToolTip(this.btn_Disponibilidad, "Disponibilidad");
            this.btn_Disponibilidad.UseVisualStyleBackColor = false;
            this.btn_Disponibilidad.MouseEnter += new System.EventHandler(this.btn_Disponibilidad_MouseEnter);
            // 
            // btn_Reservaciones
            // 
            this.btn_Reservaciones.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reservaciones.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Registro;
            this.btn_Reservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reservaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reservaciones.FlatAppearance.BorderSize = 0;
            this.btn_Reservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reservaciones.Location = new System.Drawing.Point(9, -1);
            this.btn_Reservaciones.Name = "btn_Reservaciones";
            this.btn_Reservaciones.Size = new System.Drawing.Size(48, 48);
            this.btn_Reservaciones.TabIndex = 3;
            this.tot_Ayuda.SetToolTip(this.btn_Reservaciones, "Reservaciones");
            this.btn_Reservaciones.UseVisualStyleBackColor = false;
            this.btn_Reservaciones.Click += new System.EventHandler(this.btn_Reservaciones_Click);
            this.btn_Reservaciones.MouseEnter += new System.EventHandler(this.btn_Reservaciones_MouseEnter);
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "frm_MenuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frm_MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgl_ListaIconos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Disponibilidad;
        private System.Windows.Forms.Button btn_Reservaciones;
        private System.Windows.Forms.Button btn_Fotos;
        private System.Windows.Forms.Button btn_Catalagos;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.ToolTip tot_Ayuda;
    }
}