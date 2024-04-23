using ExamenFinal.CapaDatos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenFinal.CapaLogica;

namespace ExamenFinal.Capa_Presentacion
{
    public partial class Agente_Vista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {           
            try
            {
                Agente_OP agente_OP = new Agente_OP();
                gvAgentes.DataSource = agente_OP.ObtenerAgentes();
                gvAgentes.DataBind();

            }
            catch (Exception ex)
            {
                string errorMessage = "Error al Obtener el Reporte. Descripción del error: " + ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + errorMessage + "');", true);
            }
        }

        protected void btnAgregarAgente_Click(object sender, EventArgs e)
        {
            try
            {
                Agente_OP agente_OP = new Agente_OP();

                agente_OP.AgregarAgente(nombre.Text, email.Text, telefono.Text, contraseña.Text);

                nombre.Text = "";
                email.Text = "";
                telefono.Text = "";
                contraseña.Text = "";

                llenarGrid();
            }
            catch (Exception ex)
            {
                string errorMessage = "Error al realizar el proceso. Descripción del error: " + ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + errorMessage + "');", true);
            }
        }
        protected void btnBorrarAgente_Click(object sender, EventArgs e)
        {
            try
            {
                Agente_OP agente_OP = new Agente_OP();

                agente_OP.BorrarAgente(Int32.Parse(idBorrar.Text));

                idBorrar.Text = "";

                llenarGrid();
            }
            catch (Exception ex)
            {
                string errorMessage = "Error al realizar el proceso. Descripción del error: " + ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + errorMessage + "');", true);
            }
        }       

        protected void btnModificarAgente_Click(object sender, EventArgs e)
        {
            try
            {
                Agente_OP agente_OP = new Agente_OP();
                
                agente_OP.ModificarAgente(Int32.Parse(idModificar.Text), nombreModificar.Text, emailModificar.Text, telefonoModificar.Text);

                idBorrar.Text = "";
                nombre.Text = "";
                email.Text = "";
                telefono.Text = "";

                llenarGrid();
            }
            catch (Exception ex)
            {
                string errorMessage = "Error al realizar el proceso. Descripción del error: " + ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + errorMessage + "');", true);
            }
        }
    }
}