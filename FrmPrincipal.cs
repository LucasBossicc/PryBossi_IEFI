using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PryBossi_IEFI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nombreUsuario, string tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            tssUno.Text = "Bienvenido, " + nombreUsuario;

        }
        private DateTime horaInicio;
    
        private Timer timerUso;
        private Stopwatch cronometro = new Stopwatch();

        private string tipoUsuario;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            horaInicio = DateTime.Now;
            cronometro.Start();

          

            lblFecha.Text = DateTime.Now.ToString();
            horaInicio = DateTime.Now;

            // Iniciar el timer
            timerUso = new Timer();
            timerUso.Interval = 1000; // 1 segundo
            timerUso.Tick += TimerUso_Tick;
            timerUso.Start();
            ;
            
            if (tipoUsuario != "Administrador")
            {
                eLIMINARUSUARIOToolStripMenuItem.Visible = false;
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
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
            frmAuditoria irAuditoria = new frmAuditoria();
            irAuditoria.ShowDialog();
        }
      

        private void eLIMINARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar eliminar = new frmEliminar();
            eliminar.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimeSpan tiempoUso = DateTime.Now - clsRegistro.HoraInicio;

            string tiempoUsoString = $"{tiempoUso.Hours:D2}:{tiempoUso.Minutes:D2}:{tiempoUso.Seconds:D2}";
            // Ejemplo de resultado: "01:23:45"

            using (OleDbConnection conexionn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Inicio.mdb"))
            {
                conexionn.Open();
                string query = "INSERT INTO Registros (Nombre, FechaInicio, Duracion) VALUES (?, ?, ?)";
                using (OleDbCommand comandoo = new OleDbCommand(query, conexionn))
                {
                    comandoo.Parameters.AddWithValue("?", clsRegistro.UsuarioActual); // string -> Texto corto
                    comandoo.Parameters.AddWithValue("?", clsRegistro.HoraInicio.ToString("yyyy-MM-dd HH:mm:ss"));
                    comandoo.Parameters.AddWithValue("?", tiempoUsoString);         // string -> Texto corto 
                    comandoo.ExecuteNonQuery();
                }
            }
        }

        private void tsslblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tAREASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTareas irTareas = new FrmTareas();
            irTareas.ShowDialog();
        }
    }
}
