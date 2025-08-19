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
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("Agregar_Registro", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Contraseña", registro.Contraseña);
                        cmd.Parameters.AddWithValue("@Email", registro.Email);

                        conn.Open();
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                return false;
            }
        }

       
        public bool ActualizarRegistro(CLSRegistro registro)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("Actualizar_Registro", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UsuarioID", registro.UsuarioID);
                        cmd.Parameters.AddWithValue("@Contraseña", registro.Contraseña);
                        cmd.Parameters.AddWithValue("@Email", registro.Email);

                        conn.Open();
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
                return false;
            }
        }

      public CLSRegistro ObtenerRegistro(int id)
        {
            CLSRegistro reg = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    string query = "SELECT UsuarioID, Contraseña, Email FROM Registro WHERE UsuarioID = @UsuarioID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UsuarioID", id);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reg = new CLSRegistro(reader["Contraseña"].ToString(),
                                                      reader["Email"].ToString());
                                reg.UsuarioID = Convert.ToInt32(reader["UsuarioID"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener registro: " + ex.Message);
            }
            return reg;
        }

        public bool EliminarRegistro(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("Borrar_Registro", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UsuarioID", id);

                        conn.Open();
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
        }
    }
}