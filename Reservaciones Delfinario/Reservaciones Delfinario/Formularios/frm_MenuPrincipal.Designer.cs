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
            this.tbc_Menu = new System.Windows.Forms.TabControl();
            this.tbp_Reservaciones = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbp_Disponibilidad = new System.Windows.Forms.TabPage();
            this.tbp_Catalagos = new System.Windows.Forms.TabPage();
            this.tbp_Usuarios = new System.Windows.Forms.TabPage();
            this.imgl_ListaIconos = new System.Windows.Forms.ImageList(this.components);
            this.tbc_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Menu
            // 
            this.tbc_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_Menu.Controls.Add(this.tbp_Reservaciones);
            this.tbc_Menu.Controls.Add(this.tabPage1);
            this.tbc_Menu.Controls.Add(this.tbp_Disponibilidad);
            this.tbc_Menu.Controls.Add(this.tbp_Catalagos);
            this.tbc_Menu.Controls.Add(this.tbp_Usuarios);
            this.tbc_Menu.ImageList = this.imgl_ListaIconos;
            this.tbc_Menu.Location = new System.Drawing.Point(2, 3);
            this.tbc_Menu.Name = "tbc_Menu";
            this.tbc_Menu.SelectedIndex = 0;
            this.tbc_Menu.ShowToolTips = true;
            this.tbc_Menu.Size = new System.Drawing.Size(1024, 768);
            this.tbc_Menu.TabIndex = 0;
            // 
            // tbp_Reservaciones
            // 
            this.tbp_Reservaciones.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Fondo;
            this.tbp_Reservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbp_Reservaciones.ImageIndex = 0;
            this.tbp_Reservaciones.Location = new System.Drawing.Point(4, 55);
            this.tbp_Reservaciones.Name = "tbp_Reservaciones";
            this.tbp_Reservaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Reservaciones.Size = new System.Drawing.Size(1016, 709);
            this.tbp_Reservaciones.TabIndex = 0;
            this.tbp_Reservaciones.ToolTipText = "Reservaciones";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Fondo;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.ImageIndex = 4;
            this.tabPage1.Location = new System.Drawing.Point(4, 55);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 709);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.ToolTipText = "Fotos";
            // 
            // tbp_Disponibilidad
            // 
            this.tbp_Disponibilidad.BackColor = System.Drawing.SystemColors.Control;
            this.tbp_Disponibilidad.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Fondo;
            this.tbp_Disponibilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbp_Disponibilidad.ImageIndex = 1;
            this.tbp_Disponibilidad.Location = new System.Drawing.Point(4, 55);
            this.tbp_Disponibilidad.Name = "tbp_Disponibilidad";
            this.tbp_Disponibilidad.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Disponibilidad.Size = new System.Drawing.Size(1016, 709);
            this.tbp_Disponibilidad.TabIndex = 1;
            this.tbp_Disponibilidad.ToolTipText = "Disponibilidad";
            // 
            // tbp_Catalagos
            // 
            this.tbp_Catalagos.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Fondo;
            this.tbp_Catalagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbp_Catalagos.ImageIndex = 2;
            this.tbp_Catalagos.Location = new System.Drawing.Point(4, 55);
            this.tbp_Catalagos.Name = "tbp_Catalagos";
            this.tbp_Catalagos.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Catalagos.Size = new System.Drawing.Size(1016, 709);
            this.tbp_Catalagos.TabIndex = 2;
            this.tbp_Catalagos.ToolTipText = "Catalagos";
            // 
            // tbp_Usuarios
            // 
            this.tbp_Usuarios.BackgroundImage = global::Reservaciones_Delfinario.Properties.Resources.Fondo;
            this.tbp_Usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbp_Usuarios.ImageIndex = 3;
            this.tbp_Usuarios.Location = new System.Drawing.Point(4, 55);
            this.tbp_Usuarios.Name = "tbp_Usuarios";
            this.tbp_Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Usuarios.Size = new System.Drawing.Size(1016, 709);
            this.tbp_Usuarios.TabIndex = 3;
            this.tbp_Usuarios.ToolTipText = "Usuarios";
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
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tbc_Menu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MenuPrincipal_FormClosing);
            this.tbc_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Menu;
        private System.Windows.Forms.TabPage tbp_Reservaciones;
        private System.Windows.Forms.TabPage tbp_Disponibilidad;
        private System.Windows.Forms.TabPage tbp_Catalagos;
        private System.Windows.Forms.TabPage tbp_Usuarios;
        private System.Windows.Forms.ImageList imgl_ListaIconos;
        private System.Windows.Forms.TabPage tabPage1;
    }
}