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
            this.tssUsuario = new System.Windows.Forms.StatusStrip();
            this.tsslblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUno = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tAREASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINISTRACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aUDITORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tssUsuario.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tssUsuario
            // 
            this.tssUsuario.BackColor = System.Drawing.Color.LightGreen;
            this.tssUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblUsuario,
            this.tssUno});
            this.tssUsuario.Location = new System.Drawing.Point(0, 436);
            this.tssUsuario.Name = "tssUsuario";
            this.tssUsuario.Size = new System.Drawing.Size(824, 30);
            this.tssUsuario.TabIndex = 6;
            this.tssUsuario.Text = "statusStrip1";
            // 
            // tsslblUsuario
            // 
            this.tsslblUsuario.Name = "tsslblUsuario";
            this.tsslblUsuario.Size = new System.Drawing.Size(12, 17);
            this.tsslblUsuario.Text = "-";
            // 
            // tssUno
            // 
            this.tssUno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssUno.Name = "tssUno";
            this.tssUno.Size = new System.Drawing.Size(20, 25);
            this.tssUno.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAREASToolStripMenuItem,
            this.aDMINISTRACIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tAREASToolStripMenuItem
            // 
            this.tAREASToolStripMenuItem.Name = "tAREASToolStripMenuItem";
            this.tAREASToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tAREASToolStripMenuItem.Text = "TAREAS";
            // 
            // aDMINISTRACIONToolStripMenuItem
            // 
            this.aDMINISTRACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aUDITORIAToolStripMenuItem});
            this.aDMINISTRACIONToolStripMenuItem.Name = "aDMINISTRACIONToolStripMenuItem";
            this.aDMINISTRACIONToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.aDMINISTRACIONToolStripMenuItem.Text = "ADMINISTRACION";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // aUDITORIAToolStripMenuItem
            // 
            this.aUDITORIAToolStripMenuItem.Name = "aUDITORIAToolStripMenuItem";
            this.aUDITORIAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aUDITORIAToolStripMenuItem.Text = "AUDITORIA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(628, 448);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(14, 18);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "-";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(824, 466);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tssUsuario);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tssUsuario.ResumeLayout(false);
            this.tssUsuario.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip tssUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tssUno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tAREASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aUDITORIAToolStripMenuItem;
        private System.Windows.Forms.Label lblFecha;
    }
}