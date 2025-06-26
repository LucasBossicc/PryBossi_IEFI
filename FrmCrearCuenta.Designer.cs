namespace PryBossi_IEFI
{
    partial class FrmCrearCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearCuenta));
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtUsuarioNuevo = new System.Windows.Forms.TextBox();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.gbInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.BackColor = System.Drawing.SystemColors.MenuText;
            this.gbInicio.Controls.Add(this.cmbCategorias);
            this.gbInicio.Controls.Add(this.btnCrearUsuario);
            this.gbInicio.Controls.Add(this.pbLogo);
            this.gbInicio.Controls.Add(this.lblCategoria);
            this.gbInicio.Controls.Add(this.lblContraseña);
            this.gbInicio.Controls.Add(this.lblUsuario);
            this.gbInicio.Controls.Add(this.txtContraseñaNueva);
            this.gbInicio.Controls.Add(this.txtUsuarioNuevo);
            this.gbInicio.Location = new System.Drawing.Point(243, 82);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(484, 450);
            this.gbInicio.TabIndex = 1;
            this.gbInicio.TabStop = false;
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.cmbCategorias.Location = new System.Drawing.Point(103, 322);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(303, 21);
            this.cmbCategorias.TabIndex = 3;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.LightGreen;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(174, 358);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(141, 38);
            this.btnCrearUsuario.TabIndex = 2;
            this.btnCrearUsuario.Text = "CREAR";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLogo.Image = global::PryBossi_IEFI.Properties.Resources._44562;
            this.pbLogo.Location = new System.Drawing.Point(204, 19);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(82, 95);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoria.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategoria.Location = new System.Drawing.Point(199, 290);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(101, 29);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "CATEGORÍA\r\n";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContraseña.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContraseña.Location = new System.Drawing.Point(157, 215);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(189, 29);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "CREA TU CONTRASEÑA";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(112, 132);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(281, 29);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "INGRESE UN NOMBRE DE USUARIO";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaNueva.Location = new System.Drawing.Point(103, 248);
            this.txtContraseñaNueva.MaxLength = 30;
            this.txtContraseñaNueva.Multiline = true;
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(303, 38);
            this.txtContraseñaNueva.TabIndex = 0;
            // 
            // txtUsuarioNuevo
            // 
            this.txtUsuarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioNuevo.Location = new System.Drawing.Point(103, 164);
            this.txtUsuarioNuevo.MaxLength = 30;
            this.txtUsuarioNuevo.Multiline = true;
            this.txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            this.txtUsuarioNuevo.Size = new System.Drawing.Size(303, 38);
            this.txtUsuarioNuevo.TabIndex = 0;
            // 
            // pbFondo
            // 
            this.pbFondo.Image = global::PryBossi_IEFI.Properties.Resources.imagn;
            this.pbFondo.Location = new System.Drawing.Point(-96, -60);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(1148, 778);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondo.TabIndex = 4;
            this.pbFondo.TabStop = false;
            this.pbFondo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(957, 659);
            this.Controls.Add(this.gbInicio);
            this.Controls.Add(this.pbFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCrearCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Cuenta";
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.TextBox txtUsuarioNuevo;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox pbFondo;
    }
}