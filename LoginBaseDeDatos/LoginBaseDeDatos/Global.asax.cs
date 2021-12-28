using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace LoginBaseDeDatos
{
    public class Global : HttpApplication
    {
        //este handler se ejecuta cuando se crea una instancia de la aplicacion
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            // RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Creamos variables de estado para la aplicacion
            //Puede ser leida por todas las sesiones

            Application["Aplicaciones"] = 0;
            Application["SesionesUsuario"] = 0;

            //incrementamos
            Application["Aplicaciones"] = (int)Application["Aplicaciones"] + 1;  //se le aplica casteo al valor que esta dentro de la variable aplicacion


            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //las sesiones van a tener un tiempo de vida, ya existe un tiempo por default
        //este handler se ejecuta cuando se crea una sesion
        void Session_Start(object sender, EventArgs e)
        {
            Application["SesionesUsuario"] = (int)Application["SesionesUsuario"] + 1;
        }

        //este handler se ejecuta cuando se finaliza una sesion
        void Session_End(object sender, EventArgs e)
        {
            Application["SesionesUsuario"] = (int)Application["SesionesUsuario"] - 1;
        }


    }
}