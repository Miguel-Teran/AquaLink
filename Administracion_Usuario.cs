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
    public partial class Administracion_Usuario : Form
    {

        public Administracion_Usuario()
        {
            InitializeComponent();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            panel4.Visible = !panel4.Visible;

            if (Eliminar.BackColor == Color.White)
            {
                Eliminar.BackColor = Color.RoyalBlue;
            }
            else
            {
                Eliminar.BackColor = Color.White;
            }

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;

            if (Actualizar.BackColor == Color.White)
            {
                Actualizar.BackColor = Color.RoyalBlue;
            }
            else
            {
                Actualizar.BackColor = Color.White;
            }
        }

        private void Enlistar_Click(object sender, EventArgs e)
        {
            panel5.Visible = !panel5.Visible;

            if (Enlistar.BackColor == Color.White)
            {
                Enlistar.BackColor = Color.RoyalBlue;
            }
            else
            {
                Enlistar.BackColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MDInicio principal = new MDInicio();
            principal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(UsuarioRB.Text))
                {
                    MessageBox.Show("Por favor, ingresa el ID del usuario a eliminar.");
                    return;
                }

             
                int idUsuario = Convert.ToInt32(UsuarioRB.Text.Trim());

               
                Registro_Controlador controlador = new Registro_Controlador();

                
                bool eliminado = controlador.EliminarRegistro(idUsuario);

           
                if (eliminado)
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    UsuarioRB.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario. Verifica que el ID exista.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID de usuario debe ser un número válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message);
            }
        }
    }
}
