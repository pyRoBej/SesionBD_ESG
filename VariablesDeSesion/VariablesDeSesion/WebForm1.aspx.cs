using System;

namespace VariablesDeSesion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int conteo = 1;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)    //los eventos postBack es aquel que envia el webForm al servidor para ser procesado
            {                   //los eventos Cached se guardan y se procesan cuando sucede un postback, se pueden
                                //convertir en Postback por medio de la propiedad AutoPostBack
                                //los eventos Validacion son usados con los controles de validacion, ocurren en el cliente
                                //antes deque el WebForm se envie al servidor

                txtConteo.Text = "0";
            }
            if (Session["click"] != null)
            {
                txtConteo.Text = ((int)Session["click"]).ToString();
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            //si ya se ha usado la variable click
            if (Session["click"] != null)
            {
                //leemos el valor, hacemos typecast, lo incrementamos y lo colocamos en la variable para poder trabajar con ese dato
                conteo = (int)Session["click"] + 1;
            }

            //actualizamos el textBox
            txtConteo.Text = conteo.ToString();

            //asignamos el valor en la variable click
            Session["click"] = conteo;

        }
    }
}