using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace Dieta1
{
    public partial class Alta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox5.Text = "0";
            TextBox6.Text = "0";
            TextBox7.Text = "0";
            if (DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("Hombre");
                DropDownList1.Items.Add("Mujer");
            }
        }

        //insert into usuario values (101, 'Luis',0, 'luisito',
        // 'luis99@gmail.com', 25,180, 80, 0,1001);
        //clave,nombre,esDietista,contraseña,correo,edad,altura,peso,sexo
        protected void Button1_Click(object sender, EventArgs e)
        {
            String contraseña = TextBox3.Text;
            String CONFcontraseña = TextBox4.Text;
            if (contraseña.Equals(CONFcontraseña))
            {
                Boolean exito = false;
                //Cachar los valores
                String nombre = TextBox1.Text;
                String correo = TextBox2.Text;

                int sexo;
                if (DropDownList1.SelectedItem.Text.Equals("Hombre"))
                {
                    sexo = 0;
                }
                else
                {
                    sexo = 1;
                }
                int edad = int.Parse(TextBox5.Text);
                int estatura = int.Parse(TextBox6.Text);
                int peso = int.Parse(TextBox7.Text);
                int dietista;
                if (RadioButton1.Checked)
                {
                    dietista = 1;
                }
                else
                {
                    dietista = 0;
                }
                int cDieta = 0;
                String datos = nombre + "," + correo + "," + contraseña
                   + "," + CONFcontraseña + "," + sexo + "," + edad
                   + "," + estatura + ","
                    + peso + "," + dietista;

                double est = estatura;
                est = est / 100;
                est = (est * est);
                double imc = (peso) / (est);
                if (sexo == 0)
                {
                    if (imc < 18.5)
                        cDieta = 1004;
                    if (imc > 18.5 && imc < 25)
                        cDieta = 1002;
                    else
                        cDieta = 1000;
                }
                else
                {
                    if (imc < 18.5)
                        cDieta = 1005;
                    if (imc > 18.5 && imc < 25)
                        cDieta = 1003;
                    else
                        cDieta = 1001;
                }

                //Creacion de CU
                int cu;
                Random r = new Random();

                //String query = "insert into usuario values (108, 'Alicia',0, 'lissa', 'lza99@gmail.com', 60, 150,50,1)";
                String query = "insert into usuario values (?,?,?, ?,?,?,?,?,?,?)";

                //Crear conexion
                OdbcConnection con = new ConexionBD().con;
                while (exito == false)
                {
                    cu = r.Next(1, 2147483647);
                    OdbcCommand comando = new OdbcCommand(query, con);
                    comando.Parameters.AddWithValue("CU", cu);
                    comando.Parameters.AddWithValue("nombre", nombre);
                    comando.Parameters.AddWithValue("dietista", dietista);
                    comando.Parameters.AddWithValue("pwd", contraseña);
                    comando.Parameters.AddWithValue("correo", correo);
                    comando.Parameters.AddWithValue("edad", edad);
                    comando.Parameters.AddWithValue("altura", estatura);
                    comando.Parameters.AddWithValue("peso", peso);
                    comando.Parameters.AddWithValue("sexo", sexo);
                    comando.Parameters.AddWithValue("cDieta", cDieta);
                    try
                    {
                        int resultado = comando.ExecuteNonQuery();
                        exito = true;
                    }
                    catch (Exception ex)
                    {
                        exito = false;
                    }
                }
                if (exito)
                {
                    Label1.Text = "Creación de la cuenta exitosa";
                }
                else
                {
                    Label1.Text = "Error al crear la cuenta";
                }
            }
            else
            {
                Label1.Text = "ERROR: Las contraseñas no coinciden";
            }

                

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("LoginFake.aspx");
        }
    }
}