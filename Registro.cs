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
    public partial class Registro : Form
    {
        Registro_Controlador controlador = new Registro_Controlador();
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string contraseña = ContraseñaR.Text.Trim();
                string email = EmailR.Text.Trim();

                
                CLSRegistro reg = new CLSRegistro(contraseña, email);


               
                bool guardo = controlador.AgregarRegistro(reg);

               
                if (guardo)
                    MessageBox.Show("Registro guardado correctamente");
                else
                    MessageBox.Show("No se pudo guardar el registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
