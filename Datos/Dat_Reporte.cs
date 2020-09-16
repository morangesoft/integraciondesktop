using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Dat_Reporte
    {
        public List<Ent_Reportes> Listar(Ent_Reportes Cls_Enti)
        {
            List<Ent_Reportes> ListaItems = new List<Ent_Reportes>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {


                    using (MySqlCommand Cmd = new MySqlCommand("sp_VentaReporte", Cn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {

                        Cmd.Parameters.Add("?_desde", MySqlDbType.DateTime).Value = Cls_Enti.desde;
                        Cmd.Parameters.Add("?_hasta", MySqlDbType.DateTime).Value = Cls_Enti.hasta;
                        Cmd.Parameters.Add("?_cliente", MySqlDbType.Int32).Value = Cls_Enti.cliente_id;

                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Reportes
                                {
                                    id = Dr.GetInt32(0),
                                    comprobante_id = Dr.GetInt32(1),
                                    comprobante_desc = Dr.GetString(2),
                                    comprobante_codSunat = Dr.GetString(3),
                                    serie = Dr.GetString(4),
                                    numero = Dr.GetString(5),
                                    fechaEmision = Dr.GetDateTime(6),
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
                                    estado = Dr.GetBoolean(25),
                                    glosa = Dr.GetString(26),
                                    aceptado_por_sunat = Dr.GetBoolean(27)
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


        public DataSet Rpte_DataSet(Ent_Reportes Cls_Enti)
        {
            var Ds = new DataSet();
            using (var Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
            {
                try
                {
                    using (var Cmd = new MySqlCommand("sp_VentaReporte", Cn)
                    { CommandType = CommandType.StoredProcedure, CommandTimeout = 0 })
                    {
                        using (var Da = new MySqlDataAdapter(Cmd))
                        {

                            Cmd.Parameters.Add("?_desde", MySqlDbType.DateTime).Value = Cls_Enti.desde;
                            Cmd.Parameters.Add("?_hasta", MySqlDbType.DateTime).Value = Cls_Enti.hasta;
                            Cmd.Parameters.Add("?_cliente", MySqlDbType.Int32).Value = Cls_Enti.cliente_id;

                            Da.Fill(Ds);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return Ds;
        }




        public List<Ent_Reportes> Listar_Det(Ent_Reportes Cls_Enti)
        {
            List<Ent_Reportes> ListaItems = new List<Ent_Reportes>();
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
                                ListaItems.Add(new Ent_Reportes
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






        public List<Ent_Reportes> ReportePivotDetallado(Ent_Reportes Cls_Enti)
        {
            List<Ent_Reportes> ListaItems = new List<Ent_Reportes>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {


                    using (MySqlCommand Cmd = new MySqlCommand("sp_VentaReportePivotDetallado", Cn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {

                        Cmd.Parameters.Add("?_desde", MySqlDbType.DateTime).Value = Cls_Enti.desde;
                        Cmd.Parameters.Add("?_hasta", MySqlDbType.DateTime).Value = Cls_Enti.hasta;
                        Cmd.Parameters.Add("?_cliente", MySqlDbType.Int32).Value = Cls_Enti.cliente_id;

                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Reportes
                                {
                                    id = Dr.GetInt32(0),
                                    comprobante_id = Dr.GetInt32(1),
                                    comprobante_desc = Dr.GetString(2),
                                    comprobante_codSunat = Dr.GetString(3),
                                    serie = Dr.GetString(4),
                                    numero = Dr.GetString(5),
                                    fechaEmision = Dr.GetDateTime(6),
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
                                    estado = Dr.GetBoolean(25),
                                    glosa = Dr.GetString(26),
                                    aceptado_por_sunat = Dr.GetBoolean(27),
                                    idVendedor=Dr.GetInt32(28)  ,                                 
                                    id_det = Dr.GetInt32(29),
                                    id_tipo_bien_servicio = Dr.GetInt32(30),
                                    tipo_bien_servicio_desc = Dr.GetString(31),
                                    prod_serv_id = Dr.GetInt32(32),
                                    productocod = Dr.GetString(33),
                                    productodesc = Dr.GetString(34),
                                    unidad_medida_id = Dr.GetInt32(35),
                                    unidad_medida_desc = Dr.GetString(36),
                                    unidad_medida_fe = Dr.GetString(37),
                                    cantidad = Dr.GetDecimal(38),
                                    valor_unitario = Dr.GetDecimal(39),
                                    precio_unitario = Dr.GetDecimal(40),
                                    subtotal_det = Dr.GetDecimal(41),
                                    igv_det = Dr.GetDecimal(42),
                                    total_det = Dr.GetDecimal(43)
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

//det.id,29
//det.tipo_prod_ser_id,30
//tipr.descripcion,31
//det.prod_serv_id,32
//case when det.tipo_prod_ser_id =1 then prod.codigoProducto  else serv.codigoServicio end as codProdServ,33
//case when det.tipo_prod_ser_id = 1 then prod.nombreProducto else serv.nombreServicio end as nombreProdServ,34
//det.unidad_medida_id,35
//unm.descripcion,36
//unm.codfe,37
//det.cantidad,38
//det.valor_unitario,39
//det.precio_unitario,40
//det.subtotal,41
//det.tipo_de_igv,42
//tipaf.afecIgvDescripcion,43
//tipaf.afecIgvTabla,44
//det.igv,45
//det.total 46











    }
}
