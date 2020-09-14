using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Dat_Datos_Generales
    {
        public List<Ent_Datos_Generales> Listar(Ent_Datos_Generales Cls_Enti)
        {
            List<Ent_Datos_Generales> ListaItems = new List<Ent_Datos_Generales>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {

                    string sqlCadena = "";
          
                        sqlCadena = "select * from empresa";
           

                    using (MySqlCommand Cmd = new MySqlCommand(sqlCadena, Cn) { CommandType = System.Data.CommandType.Text })
                    {
                        /*Cmd.Parameters.Add("?_usuario_id", MySqlDbType.Int32).Value = Cls_Enti.usuario_id;*/
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Datos_Generales
                                {
                                    rucEmpresa = Dr.GetString(0),
                                    razonSocialEmpresa = Dr.GetString(1),
                                    direccionEmpresa = Dr.GetString(2),
                                    urlServicio = Dr.GetString(3),
                                    urlNubeFact=Dr.GetString(4),
                                    tokenNubeFact=Dr.GetString(5)
                                });
                            }
                        }
                    }
                }
                return ListaItems;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
