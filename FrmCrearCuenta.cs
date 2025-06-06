using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryBossi_IEFI
{
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuarioNuevo.Text.Trim();
            string contraseña = txtContraseñaNueva.Text.Trim();
            string categoria = cmbCategorias.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contraseña)  || string.IsNullOrWhiteSpace(categoria))
{
                
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            bool exito = clsCuenta.RegistrarUsuario(nombre, contraseña, categoria);

            if (exito)
            {
                MessageBox.Show("Cuenta creada exitosamente.");
                FrmInicio login = new FrmInicio();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo crear la cuenta.");
            }
        }
    }
}
