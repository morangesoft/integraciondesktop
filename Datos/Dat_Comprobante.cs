using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Dat_Comprobante
    {
        public List<Ent_Comprobante> Listar(Ent_Comprobante Cls_Enti)
        {
            List<Ent_Comprobante> ListaItems = new List<Ent_Comprobante>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
 
                    string sqlCadena = "";
                    if (Cls_Enti.id != 0)
                    {
                        sqlCadena = "select * from comprobante where id=" + Cls_Enti.id;

                    }
                    else
                    {
                        sqlCadena = "select * from comprobante";
                    }

                    using (MySqlCommand Cmd = new MySqlCommand(sqlCadena, Cn) { CommandType = System.Data.CommandType.Text })
                    {
                        /*Cmd.Parameters.Add("?_usuario_id", MySqlDbType.Int32).Value = Cls_Enti.usuario_id;*/
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Comprobante
                                {
                                    id = Dr.GetInt32(0),
                                    descripcion = Dr.GetString(1),
                                    codsunat=Dr.GetString(2),
                                    comprobante_codNubefact = Dr.GetString(3)
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
