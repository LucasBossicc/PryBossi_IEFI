﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryBossi_IEFI
{
    internal class clsBaseDatos
    {
        public static string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\..\..\BaseDatos\Inicio.mdb";

        public static OleDbConnection Conexion()
        {
            OleDbConnection conexion = new OleDbConnection(CadenaConexion);

            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }

            return conexion;
        }

       
       

    }
}
