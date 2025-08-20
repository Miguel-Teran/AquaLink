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

namespace ProyectoAquaLink
{
    public partial class Encuestas : Form
    {
        public Encuestas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public static class DatosEncuesta
        {
            public static List<string> respuestas = new List<string>()
            {
                "", "", "", "", ""
            };
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {

                string respuesta1 = txtRes1.Text;
                string respuesta2 = txtRes2.Text;
                string respuesta3 = txtRes3.Text;
                string respuesta4 = txtRes4.Text;
                string respuesta5 = txtRes5.Text;


                string[] preguntas = new string[]
                {
                    "¿Tiene buena presión de agua?",
                    "¿Cuentas con cisterna?",
                    "¿Sueles tener problemas con el agua recientemente?",
                    "¿En que actividades usa el agua?",
                    "¿Cuantas horas suele usar el agua?"
                };


                string[] respuestas = new string[]
                {
                    respuesta1,
                    respuesta2,
                    respuesta3,
                    respuesta4,
                    respuesta5
                };


                EncuestaController controlador = new EncuestaController();


                for (int i = 0; i < respuestas.Length; i++)
                {

                    ModeloEncuesta nuevaEncuesta = new ModeloEncuesta
                    {
                        EncuestaNombre = "Encuesta de Agua",
                        Pregunta = preguntas[i],
                        Respuesta = respuestas[i],
                        Fecha = DateTime.Now
                    };


                    controlador.InsertarEncuesta(nuevaEncuesta);
                }

                MessageBox.Show("¡La encuesta ha sido guardada exitosamente!", "Aqualink");


                txtRes1.Text = "";
                txtRes2.Text = "";
                txtRes3.Text = "";
                txtRes4.Text = "";
                txtRes5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la encuesta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDInicio mDInicio = new MDInicio();
            mDInicio.Show();
            this.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            mdiReportes mdiReportes = new mdiReportes();
            mdiReportes.Show();
            this.Hide();
        }

        private void Encuestas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            frmGraficas graficas = new frmGraficas();
            graficas.Show();
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
            FormConsultas formConsulta = new FormConsultas();
            formConsulta.Show();
            this.Hide();
        }

        private void Encuestas_Load(object sender, EventArgs e)
        {
            txtPregunta1.Text = "¿Tiene buena presión de agua?";
            txtPregunta2.Text = "¿Cuentas con cisterna?";
            txtPregunta3.Text = "¿Sueles tener problemas con el agua recientemente?";
            txtPregunta4.Text = "¿En que actividades usa el agua?";
            txtPregunta5.Text = "¿Cuantas horas suele usar el agua?";


            txtPregunta1.ReadOnly = true;
            txtPregunta2.ReadOnly = true;
            txtPregunta3.ReadOnly = true;
            txtPregunta4.ReadOnly = true;
            txtPregunta5.ReadOnly = true;
        }
    }
}
