using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAquaLink
{
    public partial class frmAdmiReporte : Form
    {
        ReporteControlador controlador = new ReporteControlador();
        public frmAdmiReporte()
        {
            InitializeComponent();
        }

        private void frmAdmiReporte_Load(object sender, EventArgs e)
        {
            llenarGrind();
            Limpiar();
        }
        void llenarGrind()
        {
            List<Reporte> repo = controlador.ListarReporte();
            GridReporte.DataSource = repo;
        }

        void LlenarForma(int id)
        {
            Reporte reporte = controlador.ObtenerReporte(id);
            if (reporte != null)
            {
                ctReporte.Enabled = false;
                ctReporte.Text = reporte.Id_reporte.ToString();
                ctUbicacion.Text = reporte.Ubicacion;
                ctDescripcion.Text = reporte.Descripcion;
                ctFecha.Text = reporte.Fecha;
                ctUsuario.Text = reporte.Id_usuario.ToString();
            }
        }

        void Limpiar()
        {
            ctReporte.Enabled = true;
            ctUbicacion.Text = "";
            ctUsuario.Text = "";
            ctDescripcion.Text = "";
            ctFecha.Text = "";
            ctUsuario.Text = "";
            ctReporte.Focus();
        }

        private void GridReporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridReporte.Rows.Count > 0)
            {
                ctReporte.Enabled = false;
                ctReporte.Text = GridReporte[0, e.RowIndex].Value.ToString();
                ctUbicacion.Text = GridReporte[1, e.RowIndex].Value.ToString();
                ctDescripcion.Text = GridReporte[2, e.RowIndex].Value.ToString();
                ctFecha.Text = GridReporte[3, e.RowIndex].Value.ToString();
                ctUsuario.Text = GridReporte[4, e.RowIndex].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ctReporte_Leave(object sender, EventArgs e)
        {
            try
            {
                LlenarForma(Convert.ToInt32(ctReporte.Text));
            }
            catch
            {
                ctReporte.Text = "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool guardo = false;
            int id_Reporte, id_usuario;
            string ubicacion, descripcion, fecha;
            if (ctReporte.Text.Trim() == "")
            {
                MessageBox.Show("Favor de teclear ID de reporte");
                ctReporte.Focus();
                return;
            }
            if (ctUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar usuario");
                ctUsuario.Focus();
                return;
            }
            if (ctFecha.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar la fecha");
                ctFecha.Focus();
                return;
            }
            if (ctUbicacion.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar la ubicación");
                ctUbicacion.Focus();
                return;
            }
            if (ctDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar una descripción");
                ctDescripcion.Focus();
                return;
            }
            id_Reporte = Convert.ToInt32(ctReporte.Text.Trim());
            ubicacion = ctUbicacion.Text;
            descripcion = ctDescripcion.Text;
            fecha = ctFecha.Text;
            id_usuario = Convert.ToInt32(ctUsuario.Text.Trim());
            Reporte repo = new Reporte(id_Reporte, descripcion, fecha, ubicacion, id_usuario);
            if (ctReporte.Enabled == true)
                guardo = controlador.AgregarReporte(repo);
            else
                guardo = controlador.ActualizarReporte(repo);

            if (guardo == true)
            {
                ctReporte.Enabled = false;
                llenarGrind();
                MessageBox.Show("El Reporte se guardó exitosamente");
            }
            else
            {
                MessageBox.Show("El Reporte no se guardo");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool elimino = false;
            if (ctReporte.Enabled == false)
            {
                if (MessageBox.Show("¿Desea eliminar el Reporte?", "Eliminar",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(ctReporte.Text);
                    elimino = controlador.eliminarReporte(id);
                    if (elimino == true)
                    {
                        MessageBox.Show("Reporte eliminado");
                        llenarGrind();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El Reporte no se elimino");
                    }
                }
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MDInicio inicio = new MDInicio();
            inicio.Show();
            this.Hide();
        }
    }
}
