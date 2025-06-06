using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryBossi_IEFI
{
     public class clsCuenta
    {
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        public static bool RegistrarUsuario(string nombre, string contraseña, string categoria)
        {
            try
            {
                using (OleDbConnection conexion = clsBaseDatos.Conexion()) // Usa tu método que devuelve una conexión abierta
                {
                    string consulta = "INSERT INTO NewCuenta (Nombre, Contraseña, Categoria) VALUES (?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("?", nombre);
                        comando.Parameters.AddWithValue("?", contraseña);
                        comando.Parameters.AddWithValue("?", categoria);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
                return false;
            }
        }

       
       

        public static bool UsuarioExiste(string usuario)
        {
            using (OleDbConnection conexion = clsBaseDatos.Conexion())
            {
                string consulta = "SELECT COUNT(*) FROM NewCuenta WHERE Nombre = ?";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                comando.Parameters.AddWithValue("?", usuario);

                int count = (int)comando.ExecuteScalar();
                return count > 0;
            }
        }

        public static bool ActualizarContraseña(string usuario, string nuevaContraseña)
        {
            using (OleDbConnection conexion = clsBaseDatos.Conexion())
            {
                string consulta = "UPDATE NewCuenta SET Contraseña = ? WHERE Nombre = ?";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                comando.Parameters.AddWithValue("?", nuevaContraseña);
                comando.Parameters.AddWithValue("?", usuario);

                int filas = comando.ExecuteNonQuery();
                if (filas > 0)
                {
                    MessageBox.Show("Contraseña Reestablecida.");
                    return true;
                }
                else
                {
                    MessageBox.Show("No se pudo Reestablecer la contraseña.");
                    return false;
                }
            }
        }

        public static bool EliminarUsuario(string usuario, string contrasena)
        {
            using (OleDbConnection conexion = clsBaseDatos.Conexion())
            {
                string consulta = "DELETE FROM NewCuenta WHERE Nombre = ? AND Contraseña = ?";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);

                comando.Parameters.AddWithValue("?", usuario);
                comando.Parameters.AddWithValue("?", contrasena);

                int filas = comando.ExecuteNonQuery();
                return filas > 0;
            }
        }

    }
}
