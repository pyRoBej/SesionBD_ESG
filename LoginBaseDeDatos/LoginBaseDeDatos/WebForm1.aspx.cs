using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginBaseDeDatos
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        //la sesion de usuario es una instancia de un browser pero usan cookies, las cuales pueden
        //ser compartidas por dos instancias del browser y se consideraria la misma sesion
        //si abrimos otro browser veremos que tenemos dos sesiones y una app instanciada

        //si no queremos tener cookies para nuestra sesion, en web.config <sessionState mode = "InProc" cookiesless="true"> </sessionState>
        //y nos manda visiblemente el sessionID

        //este handler se ejecuta cuando se carga la pagina
        protected void Page_Load(object sender, EventArgs e)    
        {
            //el servidor manda la respuesta al cliente
            Response.Write("Cantidad de aplicaciones instanciadas " + Application["Aplicaciones"] + "<br/>");
            Response.Write("Cantidad de sesiones de usuario " + Application["SesionesUsuario"]);
        }
    }
}