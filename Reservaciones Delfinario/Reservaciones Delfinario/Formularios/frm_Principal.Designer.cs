namespace Reservaciones_Delfinario
{
    partial class frm_Pricipal
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
            this.ms_Barra = new System.Windows.Forms.MenuStrip();
            this.mi_Reservaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaReservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Disponibilidad = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Fotos = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Catalagos = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_TipoCambio = new System.Windows.Forms.ToolStripMenuItem();
            this.form_TipoNado = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_Programas = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_Estado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms_Barra.SuspendLayout();
            this.ss_Estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Barra
            // 
            this.ms_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ms_Barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Reservaciones,
            this.mi_Disponibilidad,
            this.mi_Fotos,
            this.mi_Catalagos,
            this.mi_Usuarios,
            this.mi_Reportes});
            this.ms_Barra.Location = new System.Drawing.Point(0, 0);
            this.ms_Barra.Name = "ms_Barra";
            this.ms_Barra.ShowItemToolTips = true;
            this.ms_Barra.Size = new System.Drawing.Size(1008, 56);
            this.ms_Barra.TabIndex = 0;
            this.ms_Barra.Text = "MenuStrip";
            // 
            // mi_Reservaciones
            // 
            this.mi_Reservaciones.AutoToolTip = true;
            this.mi_Reservaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservacionesToolStripMenuItem,
            this.consultaReservacionesToolStripMenuItem});
            this.mi_Reservaciones.Image = global::Reservaciones_Delfinario.Properties.Resources.Registro;
            this.mi_Reservaciones.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Reservaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mi_Reservaciones.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mi_Reservaciones.Name = "mi_Reservaciones";
            this.mi_Reservaciones.Size = new System.Drawing.Size(60, 52);
            this.mi_Reservaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Reservaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mi_Reservaciones.ToolTipText = "Reservaciones";
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            this.reservacionesToolStripMenuItem.Click += new System.EventHandler(this.reservacionesToolStripMenuItem_Click);
            // 
            // consultaReservacionesToolStripMenuItem
            // 
            this.consultaReservacionesToolStripMenuItem.Name = "consultaReservacionesToolStripMenuItem";
            this.consultaReservacionesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.consultaReservacionesToolStripMenuItem.Text = "Consulta reservaciones";
            this.consultaReservacionesToolStripMenuItem.Click += new System.EventHandler(this.consultaReservacionesToolStripMenuItem_Click);
            // 
            // mi_Disponibilidad
            // 
            this.mi_Disponibilidad.AutoToolTip = true;
            this.mi_Disponibilidad.Image = global::Reservaciones_Delfinario.Properties.Resources.Calendario_Reloj;
            this.mi_Disponibilidad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Disponibilidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mi_Disponibilidad.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mi_Disponibilidad.Name = "mi_Disponibilidad";
            this.mi_Disponibilidad.Size = new System.Drawing.Size(60, 52);
            this.mi_Disponibilidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Disponibilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mi_Disponibilidad.ToolTipText = "Disponibilidad";
            this.mi_Disponibilidad.Click += new System.EventHandler(this.mi_Disponibilidad_Click);
            // 
            // mi_Fotos
            // 
            this.mi_Fotos.AutoToolTip = true;
            this.mi_Fotos.Image = global::Reservaciones_Delfinario.Properties.Resources.Fotos;
            this.mi_Fotos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Fotos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mi_Fotos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mi_Fotos.Name = "mi_Fotos";
            this.mi_Fotos.Size = new System.Drawing.Size(60, 52);
            this.mi_Fotos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Fotos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mi_Fotos.ToolTipText = "Venta de fotos";
            // 
            // mi_Catalagos
            // 
            this.mi_Catalagos.AutoToolTip = true;
            this.mi_Catalagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_TipoCambio,
            this.form_TipoNado,
            this.tmi_Programas,
            this.productosToolStripMenuItem});
            this.mi_Catalagos.Image = global::Reservaciones_Delfinario.Properties.Resources.Carpeta;
            this.mi_Catalagos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Catalagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mi_Catalagos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mi_Catalagos.Name = "mi_Catalagos";
            this.mi_Catalagos.Size = new System.Drawing.Size(60, 52);
            this.mi_Catalagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Catalagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mi_Catalagos.ToolTipText = "Catálagos";
            // 
            // tmi_TipoCambio
            // 
            this.tmi_TipoCambio.BackColor = System.Drawing.Color.Transparent;
            this.tmi_TipoCambio.Image = global::Reservaciones_Delfinario.Properties.Resources.Billete;
            this.tmi_TipoCambio.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tmi_TipoCambio.Name = "tmi_TipoCambio";
            this.tmi_TipoCambio.Size = new System.Drawing.Size(157, 22);
            this.tmi_TipoCambio.Text = "Tipo de cambio";
            this.tmi_TipoCambio.Click += new System.EventHandler(this.tmi_TipoCambio_Click);
            // 
            // form_TipoNado
            // 
            this.form_TipoNado.Name = "form_TipoNado";
            this.form_TipoNado.Size = new System.Drawing.Size(157, 22);
            this.form_TipoNado.Text = "Nados";
            this.form_TipoNado.Click += new System.EventHandler(this.nadosToolStripMenuItem_Click);
            // 
            // tmi_Programas
            // 
            this.tmi_Programas.Name = "tmi_Programas";
            this.tmi_Programas.Size = new System.Drawing.Size(157, 22);
            this.tmi_Programas.Text = "Programas";
            this.tmi_Programas.Click += new System.EventHandler(this.tmi_Programas_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // mi_Usuarios
            // 
            this.mi_Usuarios.AutoToolTip = true;
            this.mi_Usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.agentesToolStripMenuItem});
            this.mi_Usuarios.Image = global::Reservaciones_Delfinario.Properties.Resources.Usuarios;
            this.mi_Usuarios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mi_Usuarios.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mi_Usuarios.Name = "mi_Usuarios";
            this.mi_Usuarios.Size = new System.Drawing.Size(60, 52);
            this.mi_Usuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mi_Usuarios.ToolTipText = "Usuarios";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::Reservaciones_Delfinario.Properties.Resources.Usuario;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // agentesToolStripMenuItem
            // 
            this.agentesToolStripMenuItem.Image = global::Reservaciones_Delfinario.Properties.Resources.Agentes;
            this.agentesToolStripMenuItem.Name = "agentesToolStripMenuItem";
            this.agentesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.agentesToolStripMenuItem.Text = "Agentes";
            this.agentesToolStripMenuItem.Click += new System.EventHandler(this.agentesToolStripMenuItem_Click);
            // 
            // mi_Reportes
            // 
            this.mi_Reportes.AutoToolTip = true;
            this.mi_Reportes.Image = global::Reservaciones_Delfinario.Properties.Resources.Excel;
            this.mi_Reportes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mi_Reportes.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mi_Reportes.Name = "mi_Reportes";
            this.mi_Reportes.Size = new System.Drawing.Size(60, 52);
            this.mi_Reportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mi_Reportes.ToolTipText = "Reportes";
            // 
            // ss_Estado
            // 
            this.ss_Estado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.ss_Estado.Location = new System.Drawing.Point(0, 587);
            this.ss_Estado.Name = "ss_Estado";
            this.ss_Estado.Size = new System.Drawing.Size(1008, 22);
            this.ss_Estado.TabIndex = 2;
            this.ss_Estado.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // frm_Pricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1008, 609);
            this.Controls.Add(this.ss_Estado);
            this.Controls.Add(this.ms_Barra);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_Barra;
            this.MinimumSize = new System.Drawing.Size(1024, 597);
            this.Name = "frm_Pricipal";
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Pricipal_FormClosing);
            this.Load += new System.EventHandler(this.frm_Pricipal_Load);
            this.ms_Barra.ResumeLayout(false);
            this.ms_Barra.PerformLayout();
            this.ss_Estado.ResumeLayout(false);
            this.ss_Estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip ms_Barra;
        private System.Windows.Forms.StatusStrip ss_Estado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mi_Usuarios;
        private System.Windows.Forms.ToolStripMenuItem mi_Reservaciones;
        private System.Windows.Forms.ToolStripMenuItem mi_Disponibilidad;
        private System.Windows.Forms.ToolStripMenuItem mi_Fotos;
        private System.Windows.Forms.ToolStripMenuItem mi_Catalagos;
        private System.Windows.Forms.ToolStripMenuItem tmi_TipoCambio;
        private System.Windows.Forms.ToolStripMenuItem mi_Reportes;
        private System.Windows.Forms.ToolStripMenuItem tmi_Programas;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaReservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form_TipoNado;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}



