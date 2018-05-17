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
            this.ss_Estado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mi_Reservaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Disponibilidad = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Fotos = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Catalagos = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_TipoCambio = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Reportes = new System.Windows.Forms.ToolStripMenuItem();
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
            // mi_Reservaciones
            // 
            this.mi_Reservaciones.AutoToolTip = true;
            this.mi_Reservaciones.Image = global::Reservaciones_Delfinario.Properties.Resources.Registro;
            this.mi_Reservaciones.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Reservaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mi_Reservaciones.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mi_Reservaciones.Name = "mi_Reservaciones";
            this.mi_Reservaciones.Size = new System.Drawing.Size(60, 52);
            this.mi_Reservaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Reservaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mi_Reservaciones.ToolTipText = "Reservaciones";
            this.mi_Reservaciones.Click += new System.EventHandler(this.mi_Reservaciones_Click);
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
            this.tmi_TipoCambio});
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
            // mi_Usuarios
            // 
            this.mi_Usuarios.AutoToolTip = true;
            this.mi_Usuarios.Image = global::Reservaciones_Delfinario.Properties.Resources.Usuarios;
            this.mi_Usuarios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mi_Usuarios.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mi_Usuarios.Name = "mi_Usuarios";
            this.mi_Usuarios.Size = new System.Drawing.Size(60, 52);
            this.mi_Usuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mi_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mi_Usuarios.ToolTipText = "Usuarios";
            this.mi_Usuarios.Click += new System.EventHandler(this.mi_Usuarios_Click);
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
            this.Opacity = 0.99D;
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
    }
}



