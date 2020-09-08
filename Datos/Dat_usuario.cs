using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using MySql.Data.MySqlClient;
namespace interfacedsk
{
   public class Dat_usuario
    {


        public void Insertar(Ent_Usuario Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_UsuarioInsertar", Cn))
                    {

                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Cmd.Parameters.Add("?usuario_nombre", MySqlDbType.VarChar).Value = Clas_Enti.usuario_nombre;
                        Cmd.Parameters.Add("?usuario_apellido", MySqlDbType.VarChar).Value = Clas_Enti.usuario_apellido;
                        Cmd.Parameters.Add("?usuario_email", MySqlDbType.VarChar).Value = Clas_Enti.usuario_email;
                        Cmd.Parameters.Add("?usuario_clave", MySqlDbType.VarChar).Value = Clas_Enti.usuario_clave;
                        Cmd.Parameters.Add("?usuario_dni", MySqlDbType.VarChar).Value = Clas_Enti.usuario_dni;
                        Cmd.Parameters.Add("?usuario_celular", MySqlDbType.VarChar).Value = Clas_Enti.usuario_celular;
                        Cmd.Parameters.Add("?perfil_id", MySqlDbType.Int32).Value = Clas_Enti.perfil_id;

                        Cn.Open();
                        Trs = Cn.BeginTransaction();
                        Cmd.Transaction = Trs;
                        Cmd.ExecuteNonQuery();
 
                        Trs.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Modificar(Ent_Usuario Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_UsuarioModificar", Cn))
                    {

                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                       Cmd.Parameters.Add("?_usuario_id", MySqlDbType.Int32).Value = Clas_Enti.usuario_id;
                       Cmd.Parameters.Add("?_usuario_nombre", MySqlDbType.VarChar).Value = Clas_Enti.usuario_nombre;
                        Cmd.Parameters.Add("?_usuario_apellido", MySqlDbType.VarChar).Value = Clas_Enti.usuario_apellido;
                        Cmd.Parameters.Add("?_usuario_email", MySqlDbType.VarChar).Value = Clas_Enti.usuario_email;
                        Cmd.Parameters.Add("?_usuario_clave", MySqlDbType.VarChar).Value = Clas_Enti.usuario_clave;
                        Cmd.Parameters.Add("?_usuario_dni", MySqlDbType.VarChar).Value = Clas_Enti.usuario_dni;
                        Cmd.Parameters.Add("?_usuario_celular", MySqlDbType.VarChar).Value = Clas_Enti.usuario_celular;
                        Cmd.Parameters.Add("?_perfil_id", MySqlDbType.Int32).Value = Clas_Enti.perfil_id;

                        Cn.Open();
                        Trs = Cn.BeginTransaction();
                        Cmd.Transaction = Trs;
                        Cmd.ExecuteNonQuery();

                        Trs.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Ent_Usuario> Listar(Ent_Usuario Cls_Enti)
        {
            List<Ent_Usuario> ListaItems = new List<Ent_Usuario>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    //string sqlCadena = "select usuario_id,ifnull(usuario_nombre,'') usuario_nombre,ifnull(usuario_apellido,'') as usuario_apellido,ifnull(usuario_email,'') usuario_email, ifnull(usuario_clave,'')usuario_clave,ifnull(usuario_dni,'') usuario_dni, ifnull(usuario_celular,'') usuario_celular,ifnull(usuario_img,'') usuario_img,ifnull(perfil_id,'') perfil_id,ifnull(usuario_activo,0) usuario_activo, ifnull(usuario_eliminado,0) usuario_eliminado  from usuario";

                    using (MySqlCommand Cmd = new MySqlCommand("sp_UsuarioListar", Cn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        Cmd.Parameters.Add("?_usuario_id", MySqlDbType.Int32).Value = Cls_Enti.usuario_id;
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Usuario
                                {
                                    usuario_id = Dr.GetInt32(0),
                                    usuario_nombre = Dr.GetString(1),
                                    usuario_apellido = Dr.GetString(2),
                                    usuario_email = Dr.GetString(3),
                                    usuario_clave = Dr.GetString(4),
                                    usuario_dni = Dr.GetString(5),
                                    usuario_celular = Dr.GetString(6),
                                    usuario_img = Dr.GetString(7),
                                    perfil_id = Dr.GetInt32(8),
                                    perfil_nombre=Dr.GetString(9),
                                    usuario_activo = Dr.GetInt32(10),
                                    usuario_eliminado = Dr.GetInt32(11)
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
