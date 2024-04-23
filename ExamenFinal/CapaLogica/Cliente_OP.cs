using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ExamenFinal.CapaLogica
{
    public class Cliente_OP
    {
        private string cadenaConexion = "Data Source=.;Initial Catalog=examenfinal;Integrated Security=True";

        public DataTable ObtenerCliente()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string procedimiento = "GestionarClientes";
                using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@accion", "consultar");
                    conexion.Open();
                    DataTable tabla = new DataTable();
                    tabla.Load(comando.ExecuteReader());
                    return tabla;
                }
            }
        }


        public void AgregarCliente(string nombre, string email, string telefono)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string procedimiento = "GestionarClientes";
                    using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@accion", "agregar");
                        comando.Parameters.AddWithValue("@cliente_nombre", nombre);
                        comando.Parameters.AddWithValue("@cliente_email", email);
                        comando.Parameters.AddWithValue("@cliente_telefono", telefono);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void BorrarCliente(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string procedimiento = "GestionarClientes";
                    using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@accion", "borrar");
                        comando.Parameters.AddWithValue("@cliente_id", id);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        public void ModificarCliente(int id, string nombre, string email, string telefono)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string procedimiento = "GestionarClientes";
                    using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@accion", "modificar");
                        comando.Parameters.AddWithValue("@cliente_id", id);
                        comando.Parameters.AddWithValue("@cliente_nombre", nombre);
                        comando.Parameters.AddWithValue("@cliente_email", email);
                        comando.Parameters.AddWithValue("@cliente_telefono", telefono);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}