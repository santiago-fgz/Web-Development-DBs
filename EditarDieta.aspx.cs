using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace Dieta1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private String cDieta;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                OdbcConnection con = new ConexionBD().con;
                String query = "select dietista from usuario where CU=?";
                OdbcCommand comando = new OdbcCommand(query, con);
                comando.Parameters.AddWithValue("CU", Session["usuario"].ToString());
                OdbcDataReader lector = comando.ExecuteReader();
                lector.Read();
                if (lector[0].ToString().Equals("1"))
                {
                    if(DropDownList1.Items.Count == 0)
                    {
                        //dropdown de dietas
                        query = "select nombre, cDieta from dieta";
                        comando = new OdbcCommand(query, con);
                        lector = comando.ExecuteReader();

                        DropDownList1.DataSource = lector;
                        DropDownList1.DataTextField = "nombre";
                        DropDownList1.DataValueField = "cDieta";
                        DropDownList1.DataBind();
                        lector.Close();
                    }
                    if (DropDownList3.Items.Count == 0)
                    {
                        query = "select nom, cAl from alimento";
                        comando = new OdbcCommand(query, con);
                        lector = comando.ExecuteReader();
                        lector.Read();
                        DropDownList3.DataSource = lector;
                        DropDownList3.DataTextField = "nom";
                        DropDownList3.DataValueField = "cAl";
                        DropDownList3.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("Menu.aspx");
                }
                
            }
            else
            {
                Response.Redirect("Inicio.aspx");
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList2.Items.Count != 0)
            {
                DropDownList2.ClearSelection();
            }
            //alimentos en la dieta (dropdown)
            OdbcConnection con = new ConexionBD().con;
            String query = "select nom, alimento.cAl from alimento, dietaAlimento " +
                "where alimento.cAl = dietaAlimento.cAl " +
                "and dietaAlimento.cDieta=?";
            OdbcCommand comando = new OdbcCommand(query, con);
            cDieta = DropDownList1.SelectedValue;
            comando.Parameters.AddWithValue("dietaAlimento.cDieta", cDieta);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            DropDownList2.DataSource = lector;
            DropDownList2.DataTextField = "nom";
            DropDownList2.DataValueField = "cAl";
            DropDownList2.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "delete from dietaAlimento where cAl=? and cDieta=?";
            OdbcCommand comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("cAl", DropDownList2.SelectedValue);
            comando.Parameters.AddWithValue("cDieta", cDieta);
            comando.ExecuteNonQuery(); //hay un error aqui, puede que cDieta se haya borrado
            Label1.Text = "Se ha eliminado el alimento de la dieta";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //falta
        }
    }
}