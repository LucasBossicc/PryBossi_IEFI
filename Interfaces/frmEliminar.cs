﻿using System;
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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text;

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (clsCuenta.EliminarUsuario(usuario, contrasena))
            {
                MessageBox.Show("Usuario Eliminado.");
            }
            else
            {
                MessageBox.Show("No se encontró el usuario o la contraseña es incorrecta.");
            }

            txtUsuario.Text = "";
            txtContraseña.Text = "";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
