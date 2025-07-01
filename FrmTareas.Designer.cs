namespace PryBossi_IEFI
{
    partial class FrmTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareas));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.gbTarea = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvTarea = new System.Windows.Forms.DataGridView();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblComentario = new System.Windows.Forms.Label();
            this.rtbComentario = new System.Windows.Forms.RichTextBox();
            this.chInsumo = new System.Windows.Forms.CheckBox();
            this.chEstudio = new System.Windows.Forms.CheckBox();
            this.chVacaciones = new System.Windows.Forms.CheckBox();
            this.chSalario = new System.Windows.Forms.CheckBox();
            this.chRecibo = new System.Windows.Forms.CheckBox();
            this.lblUniforme = new System.Windows.Forms.Label();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.lblReclamo = new System.Windows.Forms.Label();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gbTarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarea)).BeginInit();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFecha.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(94, 89);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 29);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "FECHA\r\n";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTarea.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTarea.Location = new System.Drawing.Point(94, 118);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(63, 29);
            this.lblTarea.TabIndex = 7;
            this.lblTarea.Text = "TAREA";
            this.lblTarea.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLugar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLugar.Location = new System.Drawing.Point(94, 147);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(65, 29);
            this.lblLugar.TabIndex = 7;
            this.lblLugar.Text = "LUGAR";
            this.lblLugar.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(190, 118);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(121, 21);
            this.cmbTarea.TabIndex = 8;
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(190, 150);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(121, 21);
            this.cmbLugar.TabIndex = 8;
            // 
            // gbTarea
            // 
            this.gbTarea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbTarea.Controls.Add(this.dtpFecha);
            this.gbTarea.Controls.Add(this.btnAgregar);
            this.gbTarea.Location = new System.Drawing.Point(29, 40);
            this.gbTarea.Name = "gbTarea";
            this.gbTarea.Size = new System.Drawing.Size(362, 294);
            this.gbTarea.TabIndex = 9;
            this.gbTarea.TabStop = false;
            this.gbTarea.Enter += new System.EventHandler(this.gbTarea_Enter);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(161, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 39);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTarea
            // 
            this.dgvTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarea.Location = new System.Drawing.Point(413, 40);
            this.dgvTarea.Name = "dgvTarea";
            this.dgvTarea.Size = new System.Drawing.Size(532, 294);
            this.dgvTarea.TabIndex = 10;
            // 
            // gbDetalle
            // 
            this.gbDetalle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbDetalle.Controls.Add(this.chRecibo);
            this.gbDetalle.Controls.Add(this.chSalario);
            this.gbDetalle.Controls.Add(this.chVacaciones);
            this.gbDetalle.Controls.Add(this.chEstudio);
            this.gbDetalle.Controls.Add(this.chInsumo);
            this.gbDetalle.Controls.Add(this.rtbComentario);
            this.gbDetalle.Controls.Add(this.btnGrabar);
            this.gbDetalle.Controls.Add(this.lblReclamo);
            this.gbDetalle.Controls.Add(this.lblLicencia);
            this.gbDetalle.Controls.Add(this.lblUniforme);
            this.gbDetalle.Controls.Add(this.lblComentario);
            this.gbDetalle.Location = new System.Drawing.Point(29, 359);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(916, 267);
            this.gbDetalle.TabIndex = 11;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "DETALLE";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(545, 213);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(121, 39);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblComentario.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComentario.Location = new System.Drawing.Point(538, 16);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(128, 29);
            this.lblComentario.TabIndex = 7;
            this.lblComentario.Text = "COMENTARIOS";
            this.lblComentario.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtbComentario
            // 
            this.rtbComentario.Location = new System.Drawing.Point(384, 48);
            this.rtbComentario.Name = "rtbComentario";
            this.rtbComentario.Size = new System.Drawing.Size(443, 159);
            this.rtbComentario.TabIndex = 8;
            this.rtbComentario.Text = "";
            // 
            // chInsumo
            // 
            this.chInsumo.AutoSize = true;
            this.chInsumo.Location = new System.Drawing.Point(39, 48);
            this.chInsumo.Name = "chInsumo";
            this.chInsumo.Size = new System.Drawing.Size(69, 17);
            this.chInsumo.TabIndex = 9;
            this.chInsumo.Text = "INSUMO";
            this.chInsumo.UseVisualStyleBackColor = true;
            // 
            // chEstudio
            // 
            this.chEstudio.AutoSize = true;
            this.chEstudio.Location = new System.Drawing.Point(39, 94);
            this.chEstudio.Name = "chEstudio";
            this.chEstudio.Size = new System.Drawing.Size(74, 17);
            this.chEstudio.TabIndex = 9;
            this.chEstudio.Text = "ESTUDIO";
            this.chEstudio.UseVisualStyleBackColor = true;
            // 
            // chVacaciones
            // 
            this.chVacaciones.AutoSize = true;
            this.chVacaciones.Location = new System.Drawing.Point(39, 117);
            this.chVacaciones.Name = "chVacaciones";
            this.chVacaciones.Size = new System.Drawing.Size(94, 17);
            this.chVacaciones.TabIndex = 9;
            this.chVacaciones.Text = "VACACIONES";
            this.chVacaciones.UseVisualStyleBackColor = true;
            // 
            // chSalario
            // 
            this.chSalario.AutoSize = true;
            this.chSalario.Location = new System.Drawing.Point(39, 167);
            this.chSalario.Name = "chSalario";
            this.chSalario.Size = new System.Drawing.Size(72, 17);
            this.chSalario.TabIndex = 9;
            this.chSalario.Text = "SALARIO";
            this.chSalario.UseVisualStyleBackColor = true;
            // 
            // chRecibo
            // 
            this.chRecibo.AutoSize = true;
            this.chRecibo.Location = new System.Drawing.Point(39, 190);
            this.chRecibo.Name = "chRecibo";
            this.chRecibo.Size = new System.Drawing.Size(66, 17);
            this.chRecibo.TabIndex = 9;
            this.chRecibo.Text = "RECIBO";
            this.chRecibo.UseVisualStyleBackColor = true;
            // 
            // lblUniforme
            // 
            this.lblUniforme.AutoSize = true;
            this.lblUniforme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblUniforme.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUniforme.Location = new System.Drawing.Point(6, 21);
            this.lblUniforme.Name = "lblUniforme";
            this.lblUniforme.Size = new System.Drawing.Size(77, 24);
            this.lblUniforme.TabIndex = 7;
            this.lblUniforme.Text = "UNIFORME";
            this.lblUniforme.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLicencia.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLicencia.Location = new System.Drawing.Point(6, 68);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(67, 24);
            this.lblLicencia.TabIndex = 7;
            this.lblLicencia.Text = "LICENCIA";
            this.lblLicencia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblReclamo
            // 
            this.lblReclamo.AutoSize = true;
            this.lblReclamo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblReclamo.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReclamo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReclamo.Location = new System.Drawing.Point(6, 140);
            this.lblReclamo.Name = "lblReclamo";
            this.lblReclamo.Size = new System.Drawing.Size(71, 24);
            this.lblReclamo.TabIndex = 7;
            this.lblReclamo.Text = "RECLAMO";
            this.lblReclamo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbFondo
            // 
            this.pbFondo.Image = global::PryBossi_IEFI.Properties.Resources.imagn;
            this.pbFondo.Location = new System.Drawing.Point(-96, -60);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(1148, 778);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondo.TabIndex = 12;
            this.pbFondo.TabStop = false;
            this.pbFondo.Click += new System.EventHandler(this.pbFondo_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(161, 49);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // FrmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 659);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.dgvTarea);
            this.Controls.Add(this.cmbLugar);
            this.Controls.Add(this.cmbTarea);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblTarea);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.gbTarea);
            this.Controls.Add(this.pbFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.FrmTareas_Load);
            this.gbTarea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarea)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.GroupBox gbTarea;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTarea;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.RichTextBox rtbComentario;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.CheckBox chRecibo;
        private System.Windows.Forms.CheckBox chSalario;
        private System.Windows.Forms.CheckBox chVacaciones;
        private System.Windows.Forms.CheckBox chEstudio;
        private System.Windows.Forms.CheckBox chInsumo;
        private System.Windows.Forms.Label lblReclamo;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label lblUniforme;
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}