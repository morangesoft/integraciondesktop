using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Dat_Unidad_Medida
    {
        public List<Ent_Unidad_Medida> Listar(Ent_Unidad_Medida Cls_Enti)
        {
            List<Ent_Unidad_Medida> ListaItems = new List<Ent_Unidad_Medida>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    string sqlCadena = "select * from unidad_medida";

                    using (MySqlCommand Cmd = new MySqlCommand(sqlCadena, Cn) { CommandType = System.Data.CommandType.Text })
                    {
                        /*Cmd.Parameters.Add("?_usuario_id", MySqlDbType.Int32).Value = Cls_Enti.usuario_id;*/
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Unidad_Medida
                                {
                                    id = Dr.GetInt32(0),
                                    descripcion = Dr.GetString(1),
                                    codfe=Dr.GetString(2)
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
