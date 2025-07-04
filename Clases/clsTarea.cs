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
    internal class clsTarea
    {
        public int AgregarTarea(DateTime fecha, int idTarea, int idLugar)
        {
            try
            {
                using (OleDbConnection conexion = clsBaseDatos.Conexion())
                {
                    string Consulta = "INSERT INTO RegistroTarea (Fecha, IdTarea, IdLugar) VALUES (?, ?, ?)";

                    OleDbCommand comando = new OleDbCommand(Consulta, conexion);

                    comando.Parameters.Add("?", OleDbType.Date).Value = fecha.Date;
                    comando.Parameters.Add("?", OleDbType.Integer).Value = idTarea;
                    comando.Parameters.Add("?", OleDbType.Integer).Value = idLugar;

                    comando.ExecuteNonQuery();

                    //Recuperar el último ID generado
                    OleDbCommand comandoID = new OleDbCommand("SELECT @@IDENTITY", conexion);
                    int idRegistro = Convert.ToInt32(comandoID.ExecuteScalar());

                    return idRegistro; //Devuelve el ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; //En caso de error devuelve -1
            }
        }


        public void GrabarDetalle(int idRegistro, bool insumo, bool estudio, bool vacaciones, bool salario, bool recibo, string comentario)
        {
            try
            {
                using (OleDbConnection conexion = clsBaseDatos.Conexion())
                {
                    string Consulta = @"UPDATE RegistroTarea 
                           SET Insumo = ?, Estudio = ?, Vacaciones = ?, Salario = ?, Recibo = ?, Comentario = ?
                           WHERE IdRegistro = ?";

                    OleDbCommand comando = new OleDbCommand(Consulta, conexion);

                    comando.Parameters.Add("?", OleDbType.Boolean).Value = insumo;
                    comando.Parameters.Add("?", OleDbType.Boolean).Value = estudio;
                    comando.Parameters.Add("?", OleDbType.Boolean).Value = vacaciones;
                    comando.Parameters.Add("?", OleDbType.Boolean).Value = salario;
                    comando.Parameters.Add("?", OleDbType.Boolean).Value = recibo;
                    comando.Parameters.Add("?", OleDbType.VarWChar).Value = comentario;
                    comando.Parameters.Add("?", OleDbType.Integer).Value = idRegistro;

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar los detalles:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ObtenerListadoTareas()
        {
            try
            {
                using (OleDbConnection conexion = clsBaseDatos.Conexion())
                {
                    string consulta = @"
                SELECT RegistroTarea.Fecha, Tarea.Nombre AS Tarea, Lugar.Nombre AS Lugar, RegistroTarea.Insumo,
                    RegistroTarea.Estudio,
                    RegistroTarea.Vacaciones,
                    RegistroTarea.Salario,
                    RegistroTarea.Recibo,
                    RegistroTarea.Comentario
                FROM (RegistroTarea
                INNER JOIN Tarea ON RegistroTarea.IdTarea = Tarea.IdTarea)
                INNER JOIN Lugar ON RegistroTarea.IdLugar = Lugar.IdLugar
            ";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el listado de tareas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void CargarComboTareas(ComboBox combo)
        {
            try
            {
                using (OleDbConnection conexion = clsBaseDatos.Conexion())
                {
                    string consulta = "SELECT IdTarea, Nombre FROM Tarea";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    combo.DataSource = tabla;
                    combo.DisplayMember = "Nombre";
                    combo.ValueMember = "IdTarea";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de tareas: " + ex.Message);
            }
        }

        // Cargar combo box con lugares (tabla Lugar)
        public void CargarComboLugares(ComboBox combo)
        {
            try
            {
                using (OleDbConnection conexion = clsBaseDatos.Conexion())
                {
                    string Consulta = "SELECT IdLugar, Nombre FROM Lugar";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(Consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    combo.DataSource = tabla;
                    combo.DisplayMember = "Nombre";
                    combo.ValueMember = "IdLugar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de lugares: " + ex.Message);
            }
        }
    }
}
