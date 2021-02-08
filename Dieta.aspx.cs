using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace Dieta1
{
    public partial class Dieta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                OdbcConnection con = new ConexionBD().con;
                String query = "select nom as 'Alimento', numPorciones as 'Porciones', kcal as 'Kilo Calorías' from alimento, dietaAlimento, dieta, usuario " +
                    "where usuario.cDieta = dieta.cDieta " +
                    "and dieta.cDieta = dietaAlimento.cDieta " +
                    "and dietaAlimento.cAl = alimento.cAl " +
                    "and CU=?";
                OdbcCommand comando = new OdbcCommand(query, con);
                comando.Parameters.AddWithValue("CU", Session["usuario"].ToString());
                OdbcDataReader lector = comando.ExecuteReader();
                GridView1.DataSource = lector;
                GridView1.DataBind();
                lector.Close();
            }
            else
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}