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
    public partial class frmModificarContraseña : Form
    {
        public frmModificarContraseña()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioNuevo.Text.Trim();
            string nueva = txtContraseñaNueva.Text;
            string confirmar = txtContraseñaRepe.Text;

            if (usuario == "" || nueva == "" || confirmar == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (clsCuenta.UsuarioExiste(usuario))
            {
                clsCuenta.ActualizarContraseña(usuario, nueva);
            }
            else
            {
                MessageBox.Show("El usuario no existe.");
            }

            FrmInicio login = new FrmInicio();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
