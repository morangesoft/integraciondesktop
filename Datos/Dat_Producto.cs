using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Dat_Producto
    {

        public void Insertar(Ent_Producto Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_ProductoInsertar", Cn))
                    {

                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Cmd.Parameters.Add("?idProducto", MySqlDbType.Int32).Value = Clas_Enti.idProducto;
                        Cmd.Parameters.Add("?idProveedor", MySqlDbType.Int32).Value = Clas_Enti.idProveedor;
                        Cmd.Parameters.Add("?idCalificacion", MySqlDbType.Int32).Value = Clas_Enti.idCalificacion;
                        Cmd.Parameters.Add("?nombreProducto", MySqlDbType.VarChar).Value = Clas_Enti.nombreProducto;
                        Cmd.Parameters.Add("?descripcionProducto", MySqlDbType.VarChar).Value = Clas_Enti.descripcionProducto;
                        Cmd.Parameters.Add("?especificacionesProducto", MySqlDbType.VarChar).Value = Clas_Enti.especificacionesProducto;
                        Cmd.Parameters.Add("?precioProducto", MySqlDbType.Decimal).Value = Clas_Enti.precioProducto;
                        Cmd.Parameters.Add("?fechaExpiracionProducto", MySqlDbType.DateTime).Value = Clas_Enti.fechaExpiracionProducto;
                        Cmd.Parameters.Add("?fechaIngresoProducto", MySqlDbType.DateTime).Value = Clas_Enti.fechaIngresoProducto;
                        Cmd.Parameters.Add("?cantidadStockProducto", MySqlDbType.Decimal).Value = Clas_Enti.cantidadStockProducto;
                        Cmd.Parameters.Add("?colorProducto", MySqlDbType.VarChar).Value = Clas_Enti.colorProducto;
                        Cmd.Parameters.Add("?tamProducto", MySqlDbType.VarChar).Value = Clas_Enti.tamProducto;
                        Cmd.Parameters.Add("?alturaProducto", MySqlDbType.VarChar).Value = Clas_Enti.alturaProducto;
                        Cmd.Parameters.Add("?anchoProducto", MySqlDbType.VarChar).Value = Clas_Enti.anchoProducto;
                        Cmd.Parameters.Add("?volumenProducto", MySqlDbType.VarChar).Value = Clas_Enti.volumenProducto;
                        Cmd.Parameters.Add("?pesoProducto", MySqlDbType.VarChar).Value = Clas_Enti.pesoProducto;
                        Cmd.Parameters.Add("?marcaProducto", MySqlDbType.VarChar).Value = Clas_Enti.marcaProducto;
                        Cmd.Parameters.Add("?modeloProducto", MySqlDbType.VarChar).Value = Clas_Enti.modeloProducto;
                        Cmd.Parameters.Add("?skuProducto", MySqlDbType.VarChar).Value = Clas_Enti.skuProducto;
                        Cmd.Parameters.Add("?codigoProducto", MySqlDbType.VarChar).Value = Clas_Enti.codigoProducto;
                        Cmd.Parameters.Add("?tiempoGarantiaProducto", MySqlDbType.VarChar).Value = Clas_Enti.tiempoGarantiaProducto;
                        Cmd.Parameters.Add("?fotoPrincipalProducto", MySqlDbType.VarChar).Value = Clas_Enti.fotoPrincipalProducto;
                        Cmd.Parameters.Add("?fotosGaleriaProducto", MySqlDbType.VarChar).Value = Clas_Enti.fotosGaleriaProducto;
                        Cmd.Parameters.Add("?cantidadClicksProducto", MySqlDbType.Int32).Value = Clas_Enti.cantidadClicksProducto;
                        Cmd.Parameters.Add("?cantidadPetencialesComprasProducto", MySqlDbType.Int32).Value = Clas_Enti.cantidadPetencialesComprasProducto;

                        Cmd.Parameters.Add("?idUnidadMedida", MySqlDbType.Int32).Value = Clas_Enti.idUnidadMedida;
                        Cmd.Parameters.Add("?idAfectacionIgv", MySqlDbType.VarChar).Value = Clas_Enti.idAfectacionIgv;


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

         public void Modificar(Ent_Producto Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_ProductoModificar", Cn))
                    {
                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Cmd.Parameters.Add("?_idProducto", MySqlDbType.Int32).Value = Clas_Enti.idProducto;
                        Cmd.Parameters.Add("?idProveedor", MySqlDbType.Int32).Value = Clas_Enti.idProveedor;
                        Cmd.Parameters.Add("?idCalificacion", MySqlDbType.Int32).Value = Clas_Enti.idCalificacion;
                        Cmd.Parameters.Add("?nombreProducto", MySqlDbType.VarChar).Value = Clas_Enti.nombreProducto;
                        Cmd.Parameters.Add("?descripcionProducto", MySqlDbType.VarChar).Value = Clas_Enti.descripcionProducto;
                        Cmd.Parameters.Add("?especificacionesProducto", MySqlDbType.VarChar).Value = Clas_Enti.especificacionesProducto;
                        Cmd.Parameters.Add("?precioProducto", MySqlDbType.Decimal).Value = Clas_Enti.precioProducto;
                        Cmd.Parameters.Add("?fechaExpiracionProducto", MySqlDbType.DateTime).Value = Clas_Enti.fechaExpiracionProducto;
                        Cmd.Parameters.Add("?fechaIngresoProducto", MySqlDbType.DateTime).Value = Clas_Enti.fechaIngresoProducto;
                        Cmd.Parameters.Add("?cantidadStockProducto", MySqlDbType.Decimal).Value = Clas_Enti.cantidadStockProducto;
                        Cmd.Parameters.Add("?colorProducto", MySqlDbType.VarChar).Value = Clas_Enti.colorProducto;
                        Cmd.Parameters.Add("?tamProducto", MySqlDbType.VarChar).Value = Clas_Enti.tamProducto;
                        Cmd.Parameters.Add("?alturaProducto", MySqlDbType.VarChar).Value = Clas_Enti.alturaProducto;
                        Cmd.Parameters.Add("?anchoProducto", MySqlDbType.VarChar).Value = Clas_Enti.anchoProducto;
                        Cmd.Parameters.Add("?volumenProducto", MySqlDbType.VarChar).Value = Clas_Enti.volumenProducto;
                        Cmd.Parameters.Add("?pesoProducto", MySqlDbType.VarChar).Value = Clas_Enti.pesoProducto;
                        Cmd.Parameters.Add("?marcaProducto", MySqlDbType.VarChar).Value = Clas_Enti.marcaProducto;
                        Cmd.Parameters.Add("?modeloProducto", MySqlDbType.VarChar).Value = Clas_Enti.modeloProducto;
                        Cmd.Parameters.Add("?skuProducto", MySqlDbType.VarChar).Value = Clas_Enti.skuProducto;
                        Cmd.Parameters.Add("?codigoProducto", MySqlDbType.VarChar).Value = Clas_Enti.codigoProducto;
                        Cmd.Parameters.Add("?tiempoGarantiaProducto", MySqlDbType.VarChar).Value = Clas_Enti.tiempoGarantiaProducto;
                        Cmd.Parameters.Add("?fotoPrincipalProducto", MySqlDbType.VarChar).Value = Clas_Enti.fotoPrincipalProducto;
                        Cmd.Parameters.Add("?fotosGaleriaProducto", MySqlDbType.VarChar).Value = Clas_Enti.fotosGaleriaProducto;
                        Cmd.Parameters.Add("?cantidadClicksProducto", MySqlDbType.Int32).Value = Clas_Enti.cantidadClicksProducto;
                        Cmd.Parameters.Add("?cantidadPetencialesComprasProducto", MySqlDbType.Int32).Value = Clas_Enti.cantidadPetencialesComprasProducto;
                     
                        Cmd.Parameters.Add("?idUnidadMedida", MySqlDbType.Int32).Value = Clas_Enti.idUnidadMedida;
                        Cmd.Parameters.Add("?idAfectacionIgv", MySqlDbType.VarChar).Value = Clas_Enti.idAfectacionIgv;
 


                        //public int idUnidadMedida { get; set; }
                        //public string descripcionUnm { get; set; }
                        //public string idAfectacionIgv { get; set; }
                        //public string afecIgvDescripcion { get; set; }
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


        public List<Ent_Producto> Listar(Ent_Producto Cls_Enti)
        {
            List<Ent_Producto> ListaItems = new List<Ent_Producto>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    //string sqlCadena = "select usuario_id,ifnull(usuario_nombre,'') usuario_nombre,ifnull(usuario_apellido,'') as usuario_apellido,ifnull(usuario_email,'') usuario_email, ifnull(usuario_clave,'')usuario_clave,ifnull(usuario_dni,'') usuario_dni, ifnull(usuario_celular,'') usuario_celular,ifnull(usuario_img,'') usuario_img,ifnull(perfil_id,'') perfil_id,ifnull(usuario_activo,0) usuario_activo, ifnull(usuario_eliminado,0) usuario_eliminado  from usuario";

                    using (MySqlCommand Cmd = new MySqlCommand("sp_ProductoListar", Cn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        Cmd.Parameters.Add("?_idProducto", MySqlDbType.Int32).Value = Cls_Enti.idProducto;
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Producto
                                {
                                idProducto =Dr.GetInt32(0),
                                idProveedor = Dr.GetInt32(1),
                                numeroDocumentoProveedor = Dr.GetString(2),
                                nombreProveedor = Dr.GetString(3),
                                idCalificacion = Dr.GetInt32(4),
                                nombreProducto = Dr.GetString(5),
                                descripcionProducto = Dr.GetString(6),
                                especificacionesProducto = Dr.GetString(7),
                                precioProducto = Dr.GetDecimal(8),
                                fechaExpiracionProducto = Dr.GetDateTime(9),
                                fechaIngresoProducto = Dr.GetDateTime(10),
                                cantidadStockProducto = Dr.GetDecimal(11),
                                colorProducto = Dr.GetString(12),
                                tamProducto = Dr.GetString(13),
                                alturaProducto = Dr.GetString(14),
                                anchoProducto = Dr.GetString(15),
                                volumenProducto = Dr.GetString(16),
                                pesoProducto = Dr.GetString(17),
                                marcaProducto = Dr.GetString(18),
                                modeloProducto = Dr.GetString(19),
                                skuProducto = Dr.GetString(20),
                                codigoProducto = Dr.GetString(21),
                                tiempoGarantiaProducto = Dr.GetString(22),
                                fotoPrincipalProducto = Dr.GetString(23),
                                fotosGaleriaProducto = Dr.GetString(24),
                                estadoProducto = Dr.GetInt32(25),
                                cantidadClicksProducto = Dr.GetInt32(26),
                                cantidadPetencialesComprasProducto = Dr.GetInt32(27),
                                idUnidadMedida = Dr.GetInt32(28),
                                descripcionUnm = Dr.GetString(29),
                                idAfectacionIgv = Dr.GetString(30),
                                afecIgvDescripcion = Dr.GetString(31),
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

        public List<Ent_Producto> ListarPorCodigo(Ent_Producto Cls_Enti)
        {
            List<Ent_Producto> ListaItems = new List<Ent_Producto>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_ProductoListarPorCodigo", Cn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        Cmd.Parameters.Add("?_codigoProducto", MySqlDbType.Int32).Value = Cls_Enti.codigoProducto;
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Producto
                                {
                                    idProducto = Dr.GetInt32(0),
                                    idProveedor = Dr.GetInt32(1),
                                    numeroDocumentoProveedor = Dr.GetString(2),
                                    nombreProveedor = Dr.GetString(3),
                                    idCalificacion = Dr.GetInt32(4),
                                    nombreProducto = Dr.GetString(5),
                                    descripcionProducto = Dr.GetString(6),
                                    especificacionesProducto = Dr.GetString(7),
                                    precioProducto = Dr.GetDecimal(8),
                                    fechaExpiracionProducto = Dr.GetDateTime(9),
                                    fechaIngresoProducto = Dr.GetDateTime(10),
                                    cantidadStockProducto = Dr.GetDecimal(11),
                                    colorProducto = Dr.GetString(12),
                                    tamProducto = Dr.GetString(13),
                                    alturaProducto = Dr.GetString(14),
                                    anchoProducto = Dr.GetString(15),
                                    volumenProducto = Dr.GetString(16),
                                    pesoProducto = Dr.GetString(17),
                                    marcaProducto = Dr.GetString(18),
                                    modeloProducto = Dr.GetString(19),
                                    skuProducto = Dr.GetString(20),
                                    codigoProducto = Dr.GetString(21),
                                    tiempoGarantiaProducto = Dr.GetString(22),
                                    fotoPrincipalProducto = Dr.GetString(23),
                                    fotosGaleriaProducto = Dr.GetString(24),
                                    estadoProducto = Dr.GetInt32(25),
                                    cantidadClicksProducto = Dr.GetInt32(26),
                                    cantidadPetencialesComprasProducto = Dr.GetInt32(27),
                                    idUnidadMedida = Dr.GetInt32(28),
                                    descripcionUnm = Dr.GetString(29),
                                    unm_fe = Dr.GetString(30),
                                    idAfectacionIgv = Dr.GetString(31),
                                    afecIgvDescripcion = Dr.GetString(32),
                                    afecIgvTabla = Dr.GetString(33),
                                    tipo_afectacion_de_igv_codNubefact = Dr.GetString(34)
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
