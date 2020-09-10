using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Dat_tipo_afectacion_igv
    {

        public List<Ent_tipo_afectacion_igv> Listar(Ent_tipo_afectacion_igv Cls_Enti)
        {
            List<Ent_tipo_afectacion_igv> ListaItems = new List<Ent_tipo_afectacion_igv>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    string sqlCadena = "select * from tipo_afectacion_igv";

                    using (MySqlCommand Cmd = new MySqlCommand(sqlCadena, Cn) { CommandType = System.Data.CommandType.Text })
                    {
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_tipo_afectacion_igv
                                {
                                    afecIgvCodigo = Dr.GetString(0),
                                    afecIgvDescripcion = Dr.GetString(1),
                                    afecIgvTabla = Dr.GetString(2)
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
