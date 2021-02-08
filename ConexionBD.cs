using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Odbc;

namespace Dieta1
{
    public class ConexionBD
    {
        //Atributos
        //2.2 Declarar atributo con
        public OdbcConnection con { get; set; }

        //2.3 Hacer el constructor
        public ConexionBD()
        {
            //Abrir web.config y extraer el string de conexión
            //2.4 Abrir web.config
            System.Configuration.Configuration webConfig =
                System.Web.
                    Configuration.
                    WebConfigurationManager.
                    OpenWebConfiguration("/Dieta1");
            //2.5 Extraer el string de conexion del web.config
            //Declaro el string de conexión
            System.Configuration.ConnectionStringSettings conString;
            //Asigno los datos del web.config al string de conexion
            conString = webConfig.
                        ConnectionStrings.
                        ConnectionStrings["BDieta"];

            //2.6 Abrir la conexion!!! - ya casi
            con = new OdbcConnection(conString.ToString());
            con.Open();
        }
    }
}