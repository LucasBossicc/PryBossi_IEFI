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
    public partial class FrmTareas : Form
    {
        public FrmTareas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbTarea_Enter(object sender, EventArgs e)
        {

        }
        clsTarea tarea = new clsTarea();
        int idUltimoRegistro = -1;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value.Date; // solo fecha, sin hora
            int idTarea = Convert.ToInt32(cmbTarea.SelectedValue);
            int idLugar = Convert.ToInt32(cmbLugar.SelectedValue);

            try
            {
                idUltimoRegistro = tarea.AgregarTarea(fecha, idTarea, idLugar);

                if (idUltimoRegistro > 0)
                {
                    MessageBox.Show("La tarea fue agregada correctamente.", "Tarea agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTarea.DataSource = tarea.ObtenerListadoTareas();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del registro insertado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar agregar la tarea:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbFondo_Click(object sender, EventArgs e)
        {

        }

        private void FrmTareas_Load(object sender, EventArgs e)
        {
            tarea.CargarComboTareas(cmbTarea);
            tarea.CargarComboLugares(cmbLugar);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (idUltimoRegistro == -1)
            {
                MessageBox.Show("Primero debés agregar una tarea antes de grabar los detalles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool insumo = chInsumo.Checked;
            bool estudio = chEstudio.Checked;
            bool vacaciones = chVacaciones.Checked;
            bool salario = chSalario.Checked;
            bool recibo = chRecibo.Checked;
            string comentario = rtbComentario.Text;

            try
            {
                tarea.GrabarDetalle(idUltimoRegistro, insumo, estudio, vacaciones, salario, recibo, comentario);

                MessageBox.Show("Detalle grabado correctamente.", "Detalle guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                chInsumo.Checked = false;
                chEstudio.Checked = false;
                chVacaciones.Checked = false;
                chSalario.Checked = false;
                chRecibo.Checked = false;
                rtbComentario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar el detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
