using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
    public class Dat_Inicio_Sesion
    {
        public List<Ent_Inicio_Sesion> Iniciar(Ent_Inicio_Sesion Clas_Enti)
        {
            //Ent_Inicio_Sesion Ent = new Ent_Inicio_Sesion();
            List<Ent_Inicio_Sesion> ListaItems = new List<Ent_Inicio_Sesion>();
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("select * from usuario where usuario_dni='" + Clas_Enti.usuario + "' and usuario_clave='" + Clas_Enti.clave + "'", Cn))
                    {
                        Cmd.CommandType = System.Data.CommandType.Text;

                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Inicio_Sesion
                                {
                                    usuario = Dr.GetString(5)
                                });
                            }
                        }
                    }
                }
                return ListaItems;

            }
            catch (Exception ex)
            {
                Trs.Rollback();
                throw new Exception(ex.Message);
            }
        }


    }

}
