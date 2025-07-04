namespace PryBossi_IEFI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tssUsuario = new System.Windows.Forms.StatusStrip();
            this.tsslblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUno = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.tAREASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINISTRACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aUDITORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.eLIMINARUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.tssUsuario.SuspendLayout();
            this.ms1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // tssUsuario
            // 
            this.tssUsuario.BackColor = System.Drawing.Color.Black;
            this.tssUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblUsuario,
            this.tssUno});
            this.tssUsuario.Location = new System.Drawing.Point(0, 629);
            this.tssUsuario.Name = "tssUsuario";
            this.tssUsuario.Size = new System.Drawing.Size(957, 30);
            this.tssUsuario.TabIndex = 6;
            this.tssUsuario.Text = "statusStrip1";
            // 
            // tsslblUsuario
            // 
            this.tsslblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsslblUsuario.Name = "tsslblUsuario";
            this.tsslblUsuario.Size = new System.Drawing.Size(12, 25);
            this.tsslblUsuario.Text = "-";
            this.tsslblUsuario.Click += new System.EventHandler(this.tsslblUsuario_Click);
            // 
            // tssUno
            // 
            this.tssUno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssUno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tssUno.Name = "tssUno";
            this.tssUno.Size = new System.Drawing.Size(20, 25);
            this.tssUno.Text = "-";
            // 
            // ms1
            // 
            this.ms1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAREASToolStripMenuItem,
            this.aDMINISTRACIONToolStripMenuItem});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(957, 24);
            this.ms1.TabIndex = 7;
            this.ms1.Text = "menuStrip1";
            // 
            // tAREASToolStripMenuItem
            // 
            this.tAREASToolStripMenuItem.Name = "tAREASToolStripMenuItem";
            this.tAREASToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tAREASToolStripMenuItem.Text = "TAREAS";
            this.tAREASToolStripMenuItem.Click += new System.EventHandler(this.tAREASToolStripMenuItem_Click);
            // 
            // aDMINISTRACIONToolStripMenuItem
            // 
            this.aDMINISTRACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aUDITORIAToolStripMenuItem,
            this.toolStripMenuItem1,
            this.eLIMINARUSUARIOToolStripMenuItem});
            this.aDMINISTRACIONToolStripMenuItem.Name = "aDMINISTRACIONToolStripMenuItem";
            this.aDMINISTRACIONToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.aDMINISTRACIONToolStripMenuItem.Text = "ADMINISTRACIÓN";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 6);
            // 
            // aUDITORIAToolStripMenuItem
            // 
            this.aUDITORIAToolStripMenuItem.Name = "aUDITORIAToolStripMenuItem";
            this.aUDITORIAToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aUDITORIAToolStripMenuItem.Text = "AUDITORIA";
            this.aUDITORIAToolStripMenuItem.Click += new System.EventHandler(this.aUDITORIAToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // eLIMINARUSUARIOToolStripMenuItem
            // 
            this.eLIMINARUSUARIOToolStripMenuItem.Name = "eLIMINARUSUARIOToolStripMenuItem";
            this.eLIMINARUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.eLIMINARUSUARIOToolStripMenuItem.Text = "ELIMINAR USUARIO";
            this.eLIMINARUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARUSUARIOToolStripMenuItem_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Black;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(780, 641);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(14, 18);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "-";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Black;
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTiempo.Location = new System.Drawing.Point(462, 605);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(35, 13);
            this.lblTiempo.TabIndex = 9;
            this.lblTiempo.Text = "label1";
            // 
            // pbFondo
            // 
            this.pbFondo.Image = global::PryBossi_IEFI.Properties.Resources.imagn;
            this.pbFondo.Location = new System.Drawing.Point(-96, -60);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(1148, 778);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondo.TabIndex = 10;
            this.pbFondo.TabStop = false;
            this.pbFondo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(957, 659);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tssUsuario);
            this.Controls.Add(this.ms1);
            this.Controls.Add(this.pbFondo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tssUsuario.ResumeLayout(false);
            this.tssUsuario.PerformLayout();
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip tssUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tssUno;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem tAREASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aUDITORIAToolStripMenuItem;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARUSUARIOToolStripMenuItem;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox pbFondo;
    }
}