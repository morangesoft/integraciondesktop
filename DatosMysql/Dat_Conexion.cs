using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Dat_Conexion
    {
        public static String ObtenerConnection()
        {

            string appServerBD = System.Configuration.ConfigurationSettings.AppSettings["server"];
            string appAmbiente = System.Configuration.ConfigurationSettings.AppSettings["DataBase"];
            string appUser = System.Configuration.ConfigurationSettings.AppSettings["user"];
            string appPassword = System.Configuration.ConfigurationSettings.AppSettings["password"];


            return "server=" + appServerBD + ";user id=" + appUser + ";password=" + appPassword + ";database=" + appAmbiente;
            //"myConexionMysql2": "server=localhost ;user id=root;password=root123;database=ruben"
        }
    }
}
