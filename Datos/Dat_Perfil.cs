using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Dat_Perfil
    {
        public List<Ent_Perfil> Listar(Ent_Perfil Cls_Enti)
        {
            List<Ent_Perfil> ListaItems = new List<Ent_Perfil>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    string sqlCadena = "select * from perfil";

                    using (MySqlCommand Cmd = new MySqlCommand(sqlCadena, Cn) { CommandType = System.Data.CommandType.Text })
                    {
                        /*Cmd.Parameters.Add("?_usuario_id", MySqlDbType.Int32).Value = Cls_Enti.usuario_id;*/
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Perfil
                                {
                                    perfil_id = Dr.GetInt32(0),
                                    perfil_nombre = Dr.GetString(1) 
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
