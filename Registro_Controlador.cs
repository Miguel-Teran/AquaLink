using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAquaLink
{
    internal class Registro_Controlador
    {
        public Registro_Controlador()
        {

        }
        public bool AgregarRegistro(CLSRegistro registro)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Agregar_Registro", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", registro.UsuarioID);
                cmd.Parameters.AddWithValue("@Contraseña", registro.Contraseña);
                cmd.Parameters.AddWithValue("@Email", registro.Email);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ActualizarRegistro(CLSRegistro registro)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Actualizar_Registro", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", registro.UsuarioID);
                cmd.Parameters.AddWithValue("@Contraseña", registro.Contraseña);
                cmd.Parameters.AddWithValue("@Email", registro.Email);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
       
    }
}
