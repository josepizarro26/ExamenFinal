using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        private string cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=examenfinal;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla;

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string procedimiento = "GestionarAgentes";
                    using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@accion", "consultarXID");
                        comando.Parameters.AddWithValue("@agente_nombre", username.Text);
                        comando.Parameters.AddWithValue("@agente_contraseña", password.Text);
                        
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            using (tabla = new DataTable())
                            {
                                adapter.Fill(tabla);

                                for (int i = 0; i < tabla.Rows.Count; i++)
                                {
                                    string resultado = tabla.Rows[0]["Nombre"].ToString();
                                }
                            }
                        }                                         
                    }
                }

                if (tabla.Rows.Count > 0)
                {
                    Response.Redirect("MenuPrincipal.aspx");
                }
                else
                {
                    string Message = "No existe el usuario: ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + Message + "');", true);
                }               
            }
            catch (Exception ex)
            {
                string errorMessage = "Error al realizar el proceso. Descripción del error: " + ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + errorMessage + "');", true);
            }
        }
    }
}