using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
 public   class Dat_Proveedor
    {

        public void Insertar(Ent_Proveedor Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_ProveedorInsertar", Cn))
                    {

                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Cmd.Parameters.Add("?nombreProveedor", MySqlDbType.VarChar).Value = Clas_Enti.nombreProveedor;
                        Cmd.Parameters.Add("?tipoDocumentoProveedor", MySqlDbType.VarChar).Value = Clas_Enti.tipoDocumentoProveedor;
                        Cmd.Parameters.Add("?numeroDocumentoProveedor", MySqlDbType.VarChar).Value = Clas_Enti.numeroDocumentoProveedor;

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

        public void Modificar(Ent_Proveedor Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_ProveedorModificar", Cn))
                    {

                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Cmd.Parameters.Add("?idProveedor", MySqlDbType.Int32).Value = Clas_Enti.idProveedor;
                        Cmd.Parameters.Add("?nombreProveedor", MySqlDbType.VarChar).Value = Clas_Enti.nombreProveedor;
                        Cmd.Parameters.Add("?tipoDocumentoProveedor", MySqlDbType.VarChar).Value = Clas_Enti.tipoDocumentoProveedor;
                        Cmd.Parameters.Add("?numeroDocumentoProveedor", MySqlDbType.VarChar).Value = Clas_Enti.numeroDocumentoProveedor;

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


        public List<Ent_Proveedor> Listar(Ent_Proveedor Cls_Enti)
        {
            List<Ent_Proveedor> ListaItems = new List<Ent_Proveedor>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    string sqlCadena = "";

                    if (Cls_Enti.idProveedor != 0)
                    {
                          sqlCadena = "select * from proveedor where idProveedor=" + Cls_Enti.idProveedor;
                    }else if (Cls_Enti.idProveedor == 2)
                    {
                        sqlCadena = "select top 1 * from proveedor where numeroDocumentoProveedor=" + Cls_Enti.numeroDocumentoProveedor;
                    }
                    else
                    {
                           sqlCadena = "select * from proveedor";
                    }
              

                    using (MySqlCommand Cmd = new MySqlCommand(sqlCadena, Cn) { CommandType = System.Data.CommandType.Text })
                    {
                        /*Cmd.Parameters.Add("?_usuario_id", MySqlDbType.Int32).Value = Cls_Enti.usuario_id;*/
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Proveedor
                                {
                                    idProveedor = Dr.GetInt32(0),
                                    nombreProveedor = Dr.GetString(1),
                                    tipoDocumentoProveedor=Dr.GetString(2),
                                    numeroDocumentoProveedor = Dr.GetString(3)
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
