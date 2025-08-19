using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

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
        public CLSRegistro ObtenerRegistro(int id)
        {
            CLSRegistro reg = null;
            try
            {
                SqlConnection conn= new SqlConnection(Conexion.strConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Agregar_Registro", conn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", id);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if(datos.Rows.Count > 0)
                {
                    reg = new CLSRegistro
                    {
                        UsuarioID = Convert.ToInt32(datos.Rows[0].ItemArray[0]),
                        Contraseña = datos.Rows[0].ItemArray[1].ToString(),
                        Email = datos.Rows[0].ItemArray[2].ToString(),
                    };
                }
                return reg;
            }
            catch
            {
                return reg;
            }
        }

        public bool EliminarRegistro(int id)
        {

            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Borrar_Registro", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", id);
               

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
