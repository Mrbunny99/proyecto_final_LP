using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capanegocios;

namespace CapaPresentacion
{
    public partial class Index : System.Web.UI.Page
    {       

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            negocios.Insertar(txt_nombre.Text, txt_apellido.Text, txt_direccion.Text, txt_telefono.Text, txt_email.Text);
            string script = string.Format("alert('Mantenimiento de usuarios:{0}');", "Registros guardados");
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}