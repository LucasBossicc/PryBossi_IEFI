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
        
        private bool ValidarLogin(string usuario, string contraseña)
        {


            using (OleDbConnection conexion = clsBaseDatos.Conexion())
            {
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Ingresá usuario y contraseña.");
                    return false;
                }
                
                string consulta = "SELECT COUNT(*) FROM NewCuenta WHERE nombre = ? AND contraseña = ?";
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("?", usuario);
                    comando.Parameters.AddWithValue("?", contraseña);

                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;
            string tipoUsuario = ObtenerTipoUsuario(usuario);
            clsRegistro.UsuarioActual = usuario;
            clsRegistro.HoraInicio = DateTime.Now;

            if (ValidarLogin(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                FrmPrincipal irPrinciapal = new FrmPrincipal(txtUsuario.Text, tipoUsuario);
                irPrinciapal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
        private string ObtenerTipoUsuario(string usuario)
        {
            using (OleDbConnection conexion = clsBaseDatos.Conexion())
            {
                string consulta = "SELECT Categoria FROM NewCuenta WHERE nombre = ?";
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("?", usuario);
                    object resultado = comando.ExecuteScalar();
                    return resultado?.ToString() ?? "Operador"; // valor por defecto si no se encuentra
                }
            }
        }

        private void lblCuentaNueva_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta irCuentaNueva = new FrmCrearCuenta();    
            irCuentaNueva.Show();
            this.Hide();
        }

        private void lblOlvido_Click(object sender, EventArgs e)
        {
            frmModificarContraseña irModificar = new frmModificarContraseña();
            irModificar.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick(); // Simula el clic en el botón
            }
        }
    }
}
