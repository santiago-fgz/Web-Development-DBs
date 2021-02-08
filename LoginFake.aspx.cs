using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace Dieta1
{
    public partial class LoginFake : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "select correo, pwd, CU from usuario where correo=?";
            OdbcCommand comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("correo",TextBox1.Text);
            OdbcDataReader lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
                String pwd = lector[1].ToString();
                if (pwd.Equals(TextBox2.Text))
                {
                    Session.Add("usuario", lector[2].ToString());
                    Response.Redirect("Menu.aspx");
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}