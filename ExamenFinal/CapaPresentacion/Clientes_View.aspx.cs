using ExamenFinal.CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Capa_Presentacion
{
    public partial class Clientes_View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {
            try
            {
                Cliente_OP cliente_OP = new Cliente_OP();
                gvClientes.DataSource = cliente_OP.ObtenerCliente();
                gvClientes.DataBind();

            }
            catch (Exception ex)
            {
                string errorMessage = "Error al Obtener el Reporte. Descripción del error: " + ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + errorMessage + "');", true);
            }
        }

        protected void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente_OP cliente_OP = new Cliente_OP();

                cliente_OP.AgregarCliente(nombre.Text, email.Text, telefono.Text);

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
        protected void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente_OP cliente_OP = new Cliente_OP();

                cliente_OP.BorrarCliente(Int32.Parse(idBorrar.Text));

                idBorrar.Text = "";
 
                llenarGrid();
            }
            catch (Exception ex)
            {
                string errorMessage = "Error al realizar el proceso. Descripción del error: " + ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + errorMessage + "');", true);
            }
        }

        protected void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente_OP cliente_OP = new Cliente_OP();

                cliente_OP.ModificarCliente(Int32.Parse(idModificar.Text), nombreModificar.Text, emailModificar.Text, telefonoModificar.Text);

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