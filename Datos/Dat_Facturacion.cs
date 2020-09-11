using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Dat_Facturacion
    {
 
        public void Insertar(Ent_Facturacion Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_VentaCabInsertar", Cn))
                    {

                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Cmd.Parameters.Add("?_id", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                        Cmd.Parameters.Add("?comprobante_id", MySqlDbType.Int32).Value = Clas_Enti.comprobante_id;
                        Cmd.Parameters.Add("?serie", MySqlDbType.VarChar).Value = Clas_Enti.serie;
                        Cmd.Parameters.Add("?numero", MySqlDbType.VarChar).Value = Clas_Enti.numero;
                        Cmd.Parameters.Add("?fechaEmision", MySqlDbType.DateTime).Value = Clas_Enti.fechaEmision;
                        Cmd.Parameters.Add("?cliente_id", MySqlDbType.Int32).Value = Clas_Enti.cliente_id;
                        Cmd.Parameters.Add("?modena_id", MySqlDbType.Int32).Value = Clas_Enti.modena_id;
                        Cmd.Parameters.Add("?tipo_cambio_monto", MySqlDbType.Decimal).Value = Clas_Enti.tipo_cambio_monto;
                        Cmd.Parameters.Add("?total_gravada", MySqlDbType.Decimal).Value = Clas_Enti.total_gravada;
                        Cmd.Parameters.Add("?total_inafecta", MySqlDbType.Decimal).Value = Clas_Enti.total_inafecta;
                        Cmd.Parameters.Add("?total_exonerada", MySqlDbType.Decimal).Value = Clas_Enti.total_exonerada;
                        Cmd.Parameters.Add("?total_igv", MySqlDbType.Decimal).Value = Clas_Enti.total_igv;
                        Cmd.Parameters.Add("?total_gratuita", MySqlDbType.Decimal).Value = Clas_Enti.total_gratuita;
                        Cmd.Parameters.Add("?total_otros_cargos", MySqlDbType.Decimal).Value = Clas_Enti.total_otros_cargos;
                        Cmd.Parameters.Add("?total", MySqlDbType.Decimal).Value = Clas_Enti.total_cab;
                        Cmd.Parameters.Add("?glosa", MySqlDbType.VarChar).Value = Clas_Enti.glosa;
                        Cn.Open();
                        Trs = Cn.BeginTransaction();
                        Cmd.Transaction = Trs;
                        Cmd.ExecuteNonQuery();
                        Clas_Enti.id = Convert.ToInt32(Cmd.Parameters["?_id"].Value);

                        foreach (Ent_Facturacion ent in Clas_Enti.DetalleADM)
                        {
                            Cmd.Parameters.Clear();
                            Cmd.CommandText = "sp_VentaDetInsertar";
                            Cmd.Parameters.Add("?id_venta_cab", MySqlDbType.Int32).Value = Clas_Enti.id;
                            Cmd.Parameters.Add("?id", MySqlDbType.VarChar).Value = ent.id_det;
                            Cmd.Parameters.Add("?tipo_prod_ser_id", MySqlDbType.Int32).Value = ent.id_tipo_bien_servicio;
                            Cmd.Parameters.Add("?prod_serv_id", MySqlDbType.Int32).Value = ent.prod_serv_id;
                            Cmd.Parameters.Add("?unidad_medida_id", MySqlDbType.Int32).Value = ent.unidad_medida_id;
                            Cmd.Parameters.Add("?cantidad", MySqlDbType.Decimal).Value = ent.cantidad;
                            Cmd.Parameters.Add("?valor_unitario", MySqlDbType.Decimal).Value = ent.valor_unitario;
                            Cmd.Parameters.Add("?precio_unitario", MySqlDbType.Decimal).Value = ent.precio_unitario;
                            Cmd.Parameters.Add("?subtotal", MySqlDbType.Decimal).Value = ent.subtotal;
                            Cmd.Parameters.Add("?tipo_de_igv", MySqlDbType.VarChar).Value = ent.tipo_afectacion_de_igv;
                            Cmd.Parameters.Add("?igv", MySqlDbType.Decimal).Value = ent.DvtD_IGVMonto;
                           Cmd.Parameters.Add("?total", MySqlDbType.Decimal).Value = ent.total_det;
                            Cmd.ExecuteNonQuery();
                        }

                        Trs.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Modificar(Ent_Facturacion Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_VentaCabModificar", Cn))
                    {

                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Cmd.Parameters.Add("?_id", MySqlDbType.Int32).Value = Clas_Enti.id;
                        Cmd.Parameters.Add("?comprobante_id", MySqlDbType.Int32).Value = Clas_Enti.comprobante_id;
                        Cmd.Parameters.Add("?serie", MySqlDbType.VarChar).Value = Clas_Enti.serie;
                        Cmd.Parameters.Add("?numero", MySqlDbType.VarChar).Value = Clas_Enti.numero;
                        Cmd.Parameters.Add("?fechaEmision", MySqlDbType.DateTime).Value = Clas_Enti.fechaEmision;
                        Cmd.Parameters.Add("?cliente_id", MySqlDbType.Int32).Value = Clas_Enti.cliente_id;
                        Cmd.Parameters.Add("?modena_id", MySqlDbType.Int32).Value = Clas_Enti.modena_id;
                        Cmd.Parameters.Add("?tipo_cambio_monto", MySqlDbType.Decimal).Value = Clas_Enti.tipo_cambio_monto;
                        Cmd.Parameters.Add("?total_gravada", MySqlDbType.Decimal).Value = Clas_Enti.total_gravada;
                        Cmd.Parameters.Add("?total_inafecta", MySqlDbType.Decimal).Value = Clas_Enti.total_inafecta;
                        Cmd.Parameters.Add("?total_exonerada", MySqlDbType.Decimal).Value = Clas_Enti.total_exonerada;
                        Cmd.Parameters.Add("?total_igv", MySqlDbType.Decimal).Value = Clas_Enti.total_igv;
                        Cmd.Parameters.Add("?total_gratuita", MySqlDbType.Decimal).Value = Clas_Enti.total_gratuita;
                        Cmd.Parameters.Add("?total_otros_cargos", MySqlDbType.Decimal).Value = Clas_Enti.total_otros_cargos;
                        Cmd.Parameters.Add("?total", MySqlDbType.Decimal).Value = Clas_Enti.total_cab;
                        Cmd.Parameters.Add("?glosa", MySqlDbType.VarChar).Value = Clas_Enti.glosa;
                        Cn.Open();
                        Trs = Cn.BeginTransaction();
                        Cmd.Transaction = Trs;
                        Cmd.ExecuteNonQuery();
                        Clas_Enti.id = Convert.ToInt32(Cmd.Parameters["?_id"].Value);

                        foreach (Ent_Facturacion ent in Clas_Enti.DetalleADM)
                        {
                            Cmd.Parameters.Clear();
                            Cmd.CommandText = "sp_VentaDetInsertar";
                            Cmd.Parameters.Add("?id_venta_cab", MySqlDbType.Int32).Value = Clas_Enti.id;
                            Cmd.Parameters.Add("?id", MySqlDbType.VarChar).Value = ent.id_det;
                            Cmd.Parameters.Add("?tipo_prod_ser_id", MySqlDbType.Int32).Value = ent.id_tipo_bien_servicio;
                            Cmd.Parameters.Add("?prod_serv_id", MySqlDbType.Int32).Value = ent.prod_serv_id;
                            Cmd.Parameters.Add("?unidad_medida_id", MySqlDbType.Int32).Value = ent.unidad_medida_id;
                            Cmd.Parameters.Add("?cantidad", MySqlDbType.Decimal).Value = ent.cantidad;
                            Cmd.Parameters.Add("?valor_unitario", MySqlDbType.Decimal).Value = ent.valor_unitario;
                            Cmd.Parameters.Add("?precio_unitario", MySqlDbType.Decimal).Value = ent.precio_unitario;
                            Cmd.Parameters.Add("?subtotal", MySqlDbType.Decimal).Value = ent.subtotal;
                            Cmd.Parameters.Add("?tipo_de_igv", MySqlDbType.VarChar).Value = ent.tipo_afectacion_de_igv;
                            Cmd.Parameters.Add("?igv", MySqlDbType.Decimal).Value = ent.DvtD_IGVMonto;
                            Cmd.Parameters.Add("?total", MySqlDbType.Decimal).Value = ent.total_det;
                            Cmd.ExecuteNonQuery();
                        }

                        Trs.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public List<Ent_Facturacion> Listar(Ent_Facturacion Cls_Enti)
        {
            List<Ent_Facturacion> ListaItems = new List<Ent_Facturacion>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    

                    using (MySqlCommand Cmd = new MySqlCommand("sp_VentaCabListar", Cn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        Cmd.Parameters.Add("?_id", MySqlDbType.Int32).Value = Cls_Enti.id;
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Facturacion
                                {
                                    id = Dr.GetInt32(0),
                                    comprobante_id = Dr.GetInt32(1),
                                    comprobante_desc = Dr.GetString(2),
                                    comprobante_codSunat = Dr.GetString(3),
                                    serie=Dr.GetString(4),
                                    numero = Dr.GetString(5),
                                    fechaEmision=Dr.GetDateTime(6),
                                    cliente_id = Dr.GetInt32(7),
                                    cliente_desc = Dr.GetString(8),
                                    cliente_dniRuc = Dr.GetString(9),
                                    cliente_tipo_doc_id = Dr.GetInt32(10),
                                    cliente_tipo_doc_desc = Dr.GetString(11),
                                    cliente_tipo_doc_codSunat = Dr.GetString(12),
                                    modena_id = Dr.GetInt32(13),
                                    modena_desc = Dr.GetString(14),
                                    modena_fe = Dr.GetString(15),
                                    tipo_cambio_monto = Dr.GetDecimal(16),
                                    DvtD_IGVTasaPorcentaje = Dr.GetDecimal(17),
                                    total_gravada = Dr.GetDecimal(18),
                                    total_inafecta = Dr.GetDecimal(19),
                                    total_exonerada = Dr.GetDecimal(20),
                                    total_igv = Dr.GetDecimal(21),
                                    total_gratuita = Dr.GetDecimal(22),
                                    total_otros_cargos = Dr.GetDecimal(23),
                                    total_cab = Dr.GetDecimal(24),
                                    estado=Dr.GetBoolean(25),
                                    glosa = Dr.GetString(26)
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


        //select det.id_venta_cab,
        //det.id,
        //det.tipo_prod_ser_id, tipr.descripcion,
        //det.prod_serv_id,
        //case when det.tipo_prod_ser_id = 1 then prod.nombreProducto else serv.nombreServicio end as nombreProdServ,
        //det.unidad_medida_id, unm.descripcion, unm.codfe,
        //det.cantidad,
        //det.valor_unitario,
        //det.precio_unitario,
        //det.subtotal,
        //det.tipo_de_igv, tipaf.afecIgvDescripcion, tipaf.afecIgvTabla,
        //det.igv, det.total
        //from venta_det det



        public List<Ent_Facturacion> Listar_Det(Ent_Facturacion Cls_Enti)
        {
            List<Ent_Facturacion> ListaItems = new List<Ent_Facturacion>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {


                    using (MySqlCommand Cmd = new MySqlCommand("sp_VentaDetListar", Cn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        Cmd.Parameters.Add("?_id_venta_cab", MySqlDbType.Int32).Value = Cls_Enti.id;
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Facturacion
                                {
                                    id = Dr.GetInt32(0),
                                    id_det = Dr.GetInt32(1),
                                    id_tipo_bien_servicio = Dr.GetInt32(2),
                                    tipo_bien_servicio_desc = Dr.GetString(3),
                                    prod_serv_id = Dr.GetInt32(4),
                                    productocod = Dr.GetString(5),
                                    productodesc = Dr.GetString(6),
                                    unidad_medida_id = Dr.GetInt32(7),
                                    unidad_medida_desc = Dr.GetString(8),
                                    unidad_medida_fe = Dr.GetString(9),
                                    cantidad = Dr.GetDecimal(10),
                                    valor_unitario = Dr.GetDecimal(11),
                                    precio_unitario = Dr.GetDecimal(12),
                                    tipo_afectacion_de_igv = Dr.GetString(14),
                                    afecIgvDescripcion = Dr.GetString(15),
                                    DvtD_OperCodigo = Dr.GetString(16),
                                    total_det = Dr.GetDecimal(18)

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
