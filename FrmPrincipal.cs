using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PryBossi_IEFI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            
            tssUno.Text = "Bienvenido, " + nombreUsuario;

        }
        private DateTime horaInicio;
    
        private Timer timerUso;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           
            lblFecha.Text = DateTime.Now.ToString();
            horaInicio = DateTime.Now;

            // Iniciar el timer
            timerUso = new Timer();
            timerUso.Interval = 1000; // 1 segundo
            timerUso.Tick += TimerUso_Tick;
            timerUso.Start();


        }
        private void TimerUso_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempo = DateTime.Now - horaInicio;
            lblTiempo.Text = tiempo.ToString(@"hh\:mm\:ss");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            timerUso.Stop();

            TimeSpan duracion = DateTime.Now - horaInicio;
            string tiempoUso = duracion.ToString(@"hh\:mm\:ss");

          
        }


        private void aUDITORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria a = new frmAuditoria();
            a.ShowDialog();
        }
      

        private void eLIMINARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar aa = new frmEliminar();
            aa.ShowDialog();
        }
       

 
    }
}
