using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace Dieta1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                //nombre
                OdbcConnection con = new ConexionBD().con;
                String query = "select nombre from usuario where CU=?";
                OdbcCommand comando = new OdbcCommand(query, con);
                comando.Parameters.AddWithValue("CU", Session["usuario"].ToString());
                OdbcDataReader lector = comando.ExecuteReader();
                lector.Read();
                Label1.Text = lector[0].ToString();
                lector.Close();

                //si el usuario es un administrador
                query = "select dietista from usuario where CU=?";
                comando = new OdbcCommand(query, con);
                comando.Parameters.AddWithValue("CU", Session["usuario"]);
                lector = comando.ExecuteReader();
                lector.Read();
                if (lector[0].ToString().Equals("1"))
                {
                    LinkButton3.Visible = true;
                }

                //calorías
                query = "select sum(kcal) from alimento, come, usuario " +
                    "where usuario.CU = come.CU " +
                    "and come.cAl = alimento.cAl " +
                    "and fecha=? " +
                    "and usuario.CU=? " +
                    "group by usuario.CU";
                comando = new OdbcCommand(query, con);
                String fecha = "";
                fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
                fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
                fecha += DateTime.Today.ToString().Substring(6, 4);
                String cu = Session["usuario"].ToString();
                comando.Parameters.AddWithValue("fecha", fecha);
                comando.Parameters.AddWithValue("usuario.CU", cu);
                lector = comando.ExecuteReader();
                lector.Read();
                try
                {
                    Label2.Text = "Has comido: "+lector[0].ToString()+" calorías hoy";
                }
                catch(Exception ex)
                {
                    Label2.Text = "¡No has comido nada hoy!";
                }
                
                lector.Close();

                //dropdowns
                query = "select nom, cAl from alimento where cTipo=?";
                comando = new OdbcCommand(query, con);
                //1
                if (DropDownList1.Items.Count == 0)
                {
                    
                    comando.Parameters.AddWithValue("cTipo", 1);
                    lector = comando.ExecuteReader();
                    DropDownList1.DataSource = lector;
                    DropDownList1.DataTextField = "nom";
                    DropDownList1.DataValueField = "cAl";
                    DropDownList1.DataBind();
                    lector.Close();
                    
                }
                //2
                if (DropDownList2.Items.Count == 0)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("cTipo", 2);
                    lector = comando.ExecuteReader();
                    DropDownList2.DataSource = lector;
                    DropDownList2.DataTextField = "nom";
                    DropDownList2.DataValueField = "cAl";
                    DropDownList2.DataBind();
                    lector.Close();
                }
                //3
                if (DropDownList3.Items.Count == 0)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("cTipo", 3);
                    lector = comando.ExecuteReader();
                    DropDownList3.DataSource = lector;
                    DropDownList3.DataTextField = "nom";
                    DropDownList3.DataValueField = "cAl";
                    DropDownList3.DataBind();
                    lector.Close();
                }
                //4
                if (DropDownList4.Items.Count == 0)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("cTipo", 4);
                    lector = comando.ExecuteReader();
                    DropDownList4.DataSource = lector;
                    DropDownList4.DataTextField = "nom";
                    DropDownList4.DataValueField = "cAl";
                    DropDownList4.DataBind();
                    lector.Close();
                }
                //5
                if (DropDownList5.Items.Count == 0)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("cTipo", 5);
                    lector = comando.ExecuteReader();
                    DropDownList5.DataSource = lector;
                    DropDownList5.DataTextField = "nom";
                    DropDownList5.DataValueField = "cAl";
                    DropDownList5.DataBind();
                    lector.Close();
                }
                //6
                if (DropDownList6.Items.Count == 0)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("cTipo", 6);
                    lector = comando.ExecuteReader();
                    DropDownList6.DataSource = lector;
                    DropDownList6.DataTextField = "nom";
                    DropDownList6.DataValueField = "cAl";
                    DropDownList6.DataBind();
                    lector.Close();
                }
                //7
                if (DropDownList7.Items.Count == 0)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("cTipo", 7);
                    lector = comando.ExecuteReader();
                    DropDownList7.DataSource = lector;
                    DropDownList7.DataTextField = "nom";
                    DropDownList7.DataValueField = "cAl";
                    DropDownList7.DataBind();
                    lector.Close();
                }
                //8
                if (DropDownList8.Items.Count == 0)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("cTipo", 8);
                    lector = comando.ExecuteReader();
                    DropDownList8.DataSource = lector;
                    DropDownList8.DataTextField = "nom";
                    DropDownList8.DataValueField = "cAl";
                    DropDownList8.DataBind();
                    lector.Close();
                }
                //9
                if (DropDownList9.Items.Count == 0)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("cTipo", 9);
                    lector = comando.ExecuteReader();
                    DropDownList9.DataSource = lector;
                    DropDownList9.DataTextField = "nom";
                    DropDownList9.DataValueField = "cAl";
                    DropDownList9.DataBind();
                    lector.Close();
                }
            }
            else
            {
                Response.Redirect("inicio.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
             Response.Redirect("Dieta.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "insert into come values(?,?,?) ";
            OdbcCommand comando = new OdbcCommand(query, con);
            String cAl = DropDownList1.SelectedValue;
            String CU = Session["usuario"].ToString();
            String fecha = "";
            fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(6, 4);
            comando.Parameters.AddWithValue("cAl", cAl);
            comando.Parameters.AddWithValue("CU", CU);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.ExecuteNonQuery();

            //Actualizar la cuenta de Kcal
            //calorías
            query = "select sum(kcal) from alimento, come, usuario " +
                "where usuario.CU = come.CU " +
                "and come.cAl = alimento.cAl " +
                "and fecha=? " +
                "and usuario.CU=? " +
                "group by usuario.CU";
            comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Parameters.AddWithValue("usuario.CU", CU);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                Label2.Text = "Has comido: " + lector[0].ToString() + " calorías hoy";
            }
            catch (Exception ex)
            {
                Label2.Text = "¡No has comido nada hoy!";
            }

            lector.Close();


        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "insert into come values(?,?,?) ";
            OdbcCommand comando = new OdbcCommand(query, con);
            String cAl = DropDownList2.SelectedValue;
            String CU = Session["usuario"].ToString();
            String fecha = "";
            fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(6, 4);
            comando.Parameters.AddWithValue("cAl", cAl);
            comando.Parameters.AddWithValue("CU", CU);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.ExecuteNonQuery();

            //Actualizar la cuenta de Kcal
            //calorías
            query = "select sum(kcal) from alimento, come, usuario " +
                "where usuario.CU = come.CU " +
                "and come.cAl = alimento.cAl " +
                "and fecha=? " +
                "and usuario.CU=? " +
                "group by usuario.CU";
            comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Parameters.AddWithValue("usuario.CU", CU);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                Label2.Text = "Has comido: " + lector[0].ToString() + " calorías hoy";
            }
            catch (Exception ex)
            {
                Label2.Text = "¡No has comido nada hoy!";
            }

            lector.Close();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "insert into come values(?,?,?) ";
            OdbcCommand comando = new OdbcCommand(query, con);
            String cAl = DropDownList3.SelectedValue;
            String CU = Session["usuario"].ToString();
            String fecha = "";
            fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(6, 4);
            comando.Parameters.AddWithValue("cAl", cAl);
            comando.Parameters.AddWithValue("CU", CU);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.ExecuteNonQuery();

            //Actualizar la cuenta de Kcal
            //calorías
            query = "select sum(kcal) from alimento, come, usuario " +
                "where usuario.CU = come.CU " +
                "and come.cAl = alimento.cAl " +
                "and fecha=? " +
                "and usuario.CU=? " +
                "group by usuario.CU";
            comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Parameters.AddWithValue("usuario.CU", CU);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                Label2.Text = "Has comido: " + lector[0].ToString() + " calorías hoy";
            }
            catch (Exception ex)
            {
                Label2.Text = "¡No has comido nada hoy!";
            }

            lector.Close();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "insert into come values(?,?,?) ";
            OdbcCommand comando = new OdbcCommand(query, con);
            String cAl = DropDownList1.SelectedValue;
            String CU = Session["usuario"].ToString();
            String fecha = "";
            fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(6, 4);
            comando.Parameters.AddWithValue("cAl", cAl);
            comando.Parameters.AddWithValue("CU", CU);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.ExecuteNonQuery();

            //Actualizar la cuenta de Kcal
            //calorías
            query = "select sum(kcal) from alimento, come, usuario " +
                "where usuario.CU = come.CU " +
                "and come.cAl = alimento.cAl " +
                "and fecha=? " +
                "and usuario.CU=? " +
                "group by usuario.CU";
            comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Parameters.AddWithValue("usuario.CU", CU);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                Label2.Text = "Has comido: " + lector[0].ToString() + " calorías hoy";
            }
            catch (Exception ex)
            {
                Label2.Text = "¡No has comido nada hoy!";
            }

            lector.Close();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "insert into come values(?,?,?) ";
            OdbcCommand comando = new OdbcCommand(query, con);
            String cAl = DropDownList1.SelectedValue;
            String CU = Session["usuario"].ToString();
            String fecha = "";
            fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(6, 4);
            comando.Parameters.AddWithValue("cAl", cAl);
            comando.Parameters.AddWithValue("CU", CU);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.ExecuteNonQuery();

            //Actualizar la cuenta de Kcal
            //calorías
            query = "select sum(kcal) from alimento, come, usuario " +
                "where usuario.CU = come.CU " +
                "and come.cAl = alimento.cAl " +
                "and fecha=? " +
                "and usuario.CU=? " +
                "group by usuario.CU";
            comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Parameters.AddWithValue("usuario.CU", CU);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                Label2.Text = "Has comido: " + lector[0].ToString() + " calorías hoy";
            }
            catch (Exception ex)
            {
                Label2.Text = "¡No has comido nada hoy!";
            }

            lector.Close();

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "insert into come values(?,?,?) ";
            OdbcCommand comando = new OdbcCommand(query, con);
            String cAl = DropDownList1.SelectedValue;
            String CU = Session["usuario"].ToString();
            String fecha = "";
            fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(6, 4);
            comando.Parameters.AddWithValue("cAl", cAl);
            comando.Parameters.AddWithValue("CU", CU);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.ExecuteNonQuery();

            //Actualizar la cuenta de Kcal
            //calorías
            query = "select sum(kcal) from alimento, come, usuario " +
                "where usuario.CU = come.CU " +
                "and come.cAl = alimento.cAl " +
                "and fecha=? " +
                "and usuario.CU=? " +
                "group by usuario.CU";
            comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Parameters.AddWithValue("usuario.CU", CU);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                Label2.Text = "Has comido: " + lector[0].ToString() + " calorías hoy";
            }
            catch (Exception ex)
            {
                Label2.Text = "¡No has comido nada hoy!";
            }

            lector.Close();

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "insert into come values(?,?,?) ";
            OdbcCommand comando = new OdbcCommand(query, con);
            String cAl = DropDownList1.SelectedValue;
            String CU = Session["usuario"].ToString();
            String fecha = "";
            fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(6, 4);
            comando.Parameters.AddWithValue("cAl", cAl);
            comando.Parameters.AddWithValue("CU", CU);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.ExecuteNonQuery();

            //Actualizar la cuenta de Kcal
            //calorías
            query = "select sum(kcal) from alimento, come, usuario " +
                "where usuario.CU = come.CU " +
                "and come.cAl = alimento.cAl " +
                "and fecha=? " +
                "and usuario.CU=? " +
                "group by usuario.CU";
            comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Parameters.AddWithValue("usuario.CU", CU);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                Label2.Text = "Has comido: " + lector[0].ToString() + " calorías hoy";
            }
            catch (Exception ex)
            {
                Label2.Text = "¡No has comido nada hoy!";
            }

            lector.Close();

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "insert into come values(?,?,?) ";
            OdbcCommand comando = new OdbcCommand(query, con);
            String cAl = DropDownList1.SelectedValue;
            String CU = Session["usuario"].ToString();
            String fecha = "";
            fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(6, 4);
            comando.Parameters.AddWithValue("cAl", cAl);
            comando.Parameters.AddWithValue("CU", CU);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.ExecuteNonQuery();

            //Actualizar la cuenta de Kcal
            //calorías
            query = "select sum(kcal) from alimento, come, usuario " +
                "where usuario.CU = come.CU " +
                "and come.cAl = alimento.cAl " +
                "and fecha=? " +
                "and usuario.CU=? " +
                "group by usuario.CU";
            comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Parameters.AddWithValue("usuario.CU", CU);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                Label2.Text = "Has comido: " + lector[0].ToString() + " calorías hoy";
            }
            catch (Exception ex)
            {
                Label2.Text = "¡No has comido nada hoy!";
            }

            lector.Close();

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String query = "insert into come values(?,?,?) ";
            OdbcCommand comando = new OdbcCommand(query, con);
            String cAl = DropDownList1.SelectedValue;
            String CU = Session["usuario"].ToString();
            String fecha = "";
            fecha += DateTime.Today.ToString().Substring(3, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(0, 2) + "/";
            fecha += DateTime.Today.ToString().Substring(6, 4);
            comando.Parameters.AddWithValue("cAl", cAl);
            comando.Parameters.AddWithValue("CU", CU);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.ExecuteNonQuery();

            //Actualizar la cuenta de Kcal
            //calorías
            query = "select sum(kcal) from alimento, come, usuario " +
                "where usuario.CU = come.CU " +
                "and come.cAl = alimento.cAl " +
                "and fecha=? " +
                "and usuario.CU=? " +
                "group by usuario.CU";
            comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Parameters.AddWithValue("usuario.CU", CU);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                Label2.Text = "Has comido: " + lector[0].ToString() + " calorías hoy";
            }
            catch (Exception ex)
            {
                Label2.Text = "¡No has comido nada hoy!";
            }

            lector.Close();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Inicio.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarDieta.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            //Response.Redirect("");
        }
    }
}