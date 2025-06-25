using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace PryBossi_IEFI
{
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
            

        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
          
        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Inicio.mdb"))
            {
                conn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT Nombre, FechaInicio, Duracion FROM Registros ORDER BY FechaInicio DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAuditoria.DataSource = dt;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            

        }
    }
}
