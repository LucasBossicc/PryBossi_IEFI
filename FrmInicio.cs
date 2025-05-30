using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryBossi_IEFI
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

         

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            int radius = 10; // radio de las esquinas
            Rectangle bounds = txtUsuario.ClientRectangle;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // Esquina superior izquierda
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90); // Superior derecha
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90); // Inferior derecha
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90); // Inferior izquierda
            path.CloseAllFigures();

            txtUsuario.Region = new Region(path);

            
        }
        private string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Inicio.mdb";
        private bool ValidarLogin(string usuario, string contraseña)
        {

            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            //Crea una conexión nueva y la usa dentro de un bloque using, lo que asegura que se cierre automáticamente al salir del bloque.
            {
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Ingresá usuario y contraseña.");
                    return false;
                }
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM Inicio WHERE nombre = ? AND contraseña = ?";
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("?", usuario);
                    comando.Parameters.AddWithValue("?", contraseña);

                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (ValidarLogin(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                FrmPrincipal form = new FrmPrincipal(usuario);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (ValidarLogin(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                FrmPrincipal form = new FrmPrincipal(usuario);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void lblCuentaNueva_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta a = new FrmCrearCuenta();    
            a.ShowDialog();
        }
    }
}
