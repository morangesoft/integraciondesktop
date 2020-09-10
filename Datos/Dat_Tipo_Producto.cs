using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Dat_Tipo_Producto
    {
        public List<Ent_Tipo_Producto> Listar(Ent_Tipo_Producto Cls_Enti)
        {
            List<Ent_Tipo_Producto> ListaItems = new List<Ent_Tipo_Producto>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    string sqlCadena = "select * from tipo_producto";

                    using (MySqlCommand Cmd = new MySqlCommand(sqlCadena, Cn) { CommandType = System.Data.CommandType.Text })
                    {
                        /*Cmd.Parameters.Add("?_usuario_id", MySqlDbType.Int32).Value = Cls_Enti.usuario_id;*/
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Tipo_Producto
                                {
                                    id = Dr.GetInt32(0),
                                    descripcion = Dr.GetString(1)
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
