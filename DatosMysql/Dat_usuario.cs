
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
    public class Dat_usuario
    {
        //public List<Ent_Usuario> Listar(Ent_Usuario Cls_Enti)
        //{
        //    List<Ent_Usuario> ListaItems = new List<Ent_Usuario>();
        //    try
        //    {
        //        using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
        //        {
        //            string sqlCadena = "select usuario_id,ifnull(usuario_nombre,'') usuario_nombre,ifnull(usuario_apellido,'') as usuario_apellido,ifnull(usuario_email,'') usuario_email, ifnull(usuario_clave,'')usuario_clave,ifnull(usuario_dni,'') usuario_dni, ifnull(usuario_celular,'') usuario_celular,ifnull(usuario_img,'') usuario_img,ifnull(perfil_id,'') perfil_id,ifnull(usuario_activo,'') usuario_activo, ifnull(usuario_eliminado,'') usuario_eliminado  from usuario";

        //            using (MySqlCommand Cmd = new MySqlCommand(sqlCadena, Cn) { CommandType = System.Data.CommandType.Text })
        //            {
        //                //Cmd.Parameters.Add("@Usuario_dni", System.Data.SqlDbType.Char).Value = Actual_Conexion.UserID;
        //                //Cmd.Parameters.Add("@Id_Opcion", System.Data.SqlDbType.Char).Value = Cls_Enti.Id_Opcion;
        //                //Cmd.Parameters.Add("@Modulo", System.Data.SqlDbType.Char).Value = Cls_Enti.Modulo_Cod;
        //                Cn.Open();
        //                using (MySqlDataReader Dr = Cmd.ExecuteReader())
        //                {
        //                    while (Dr.Read())
        //                    {
        //                        ListaItems.Add(new Ent_Usuario
        //                        {
        //                            usuario_id = Dr.GetString(0),
        //                            usuario_nombre = Dr.GetString(1),
        //                            usuario_apellido = Dr.GetString(2),
        //                            usuario_email = Dr.GetString(3),
        //                            usuario_clave = Dr.GetString(4),
        //                            usuario_dni = Dr.GetString(5),
        //                            usuario_celular = Dr.GetString(6),
        //                            usuario_img = Dr.GetString(7),
        //                            perfil_id = Dr.GetInt32(8),
        //                            usuario_activo = Dr.GetInt32(9),
        //                            usuario_eliminado = Dr.GetInt32(10)
        //                        });
        //                    }
        //                }
        //            }
        //        }
        //        return ListaItems;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }


        //}




    }


}
