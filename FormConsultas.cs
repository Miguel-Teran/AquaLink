using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoAquaLink.Encuesta;
using static ProyectoAquaLink.Encuestas;

namespace ProyectoAquaLink
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            try
            {

                EncuestaController controlador = new EncuestaController();


                List<ModeloEncuesta> encuestas = controlador.ObtenerEncuestas();


                dgvEncuestas.DataSource = encuestas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                dgvEncuestas.EndEdit();


                foreach (DataGridViewRow fila in dgvEncuestas.Rows)
                {
                    if (fila.IsNewRow) continue;


                    ModeloEncuesta encuestaActualizada = new ModeloEncuesta
                    {
                        ID = Convert.ToInt32(fila.Cells["ID"].Value),
                        EncuestaNombre = fila.Cells["EncuestaNombre"].Value.ToString(),
                        Pregunta = fila.Cells["Pregunta"].Value.ToString(),
                        Respuesta = fila.Cells["Respuesta"].Value.ToString(),
                        Fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value)
                    };


                    EncuestaController controlador = new EncuestaController();
                    controlador.ActualizarEncuesta(encuestaActualizada);
                }

                MessageBox.Show("Registros actualizados correctamente.", "Aqualink");


                FormConsultas_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la encuesta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Encuestas encuestas = new Encuestas();
            encuestas.Show();
            this.Hide();
        }

        private void btnHacerEncuesta_Click(object sender, EventArgs e)
        {
            SeleccionEncuesta selector = new SeleccionEncuesta();
            selector.Show();
            this.Hide();
        }

        private void btnConsultarEncuesta_Click(object sender, EventArgs e)
        {
            SeleccionEncuesta selector = new SeleccionEncuesta();
            selector.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDInicio mDInicio = new MDInicio();
            mDInicio.Show();
            this.Hide();
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            frmGraficas graficas = new frmGraficas();
            graficas.Show();
            this.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            mdiReportes mdiReportes = new mdiReportes();
            mdiReportes.Show();
            this.Hide();
        }

        private void FormConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEncuestas.CurrentRow != null)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que quieres eliminar esta encuesta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        int idRegistroAEliminar = (int)dgvEncuestas.CurrentRow.Cells["ID"].Value;

                        EncuestaController controlador = new EncuestaController();
                        controlador.EliminarEncuesta(idRegistroAEliminar);

                        MessageBox.Show("Encuesta eliminada correctamente.", "Aqualink");

                        FormConsultas_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la encuesta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso");
            }
        }
    }
}
