using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Dat_Servicio
    {
        public void Insertar(Ent_Servicio Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_ServicioGuardar", Cn))
                    {
                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Cmd.Parameters.Add("?idProveedor", MySqlDbType.Int32).Value = Clas_Enti.idProveedor;
                        Cmd.Parameters.Add("?idCalificacion", MySqlDbType.Int32).Value = Clas_Enti.idCalificacion;
                        Cmd.Parameters.Add("?idHorario", MySqlDbType.Int32).Value = Clas_Enti.idHorario;
                        Cmd.Parameters.Add("?nombreServicio", MySqlDbType.VarChar).Value = Clas_Enti.nombreServicio;
                        Cmd.Parameters.Add("?descripcionServicio", MySqlDbType.VarChar).Value = Clas_Enti.descripcionServicio;
                        Cmd.Parameters.Add("?precioServicio", MySqlDbType.Decimal).Value = Clas_Enti.precioServicio;
                        Cmd.Parameters.Add("?fechaExpiracionServicio", MySqlDbType.DateTime).Value = Clas_Enti.fechaExpiracionServicio;
                        Cmd.Parameters.Add("?cantidadStockServicio", MySqlDbType.Decimal).Value = Clas_Enti.cantidadStockServicio;
                        Cmd.Parameters.Add("?codigoServicio", MySqlDbType.VarChar).Value = Clas_Enti.codigoServicio;
                        Cmd.Parameters.Add("?tiempoGarantiaServicio", MySqlDbType.VarChar).Value = Clas_Enti.tiempoGarantiaServicio;
                        Cmd.Parameters.Add("?fotosGaleriaServicio", MySqlDbType.VarChar).Value = Clas_Enti.fotosGaleriaServicio;

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



        public void Modificar(Ent_Servicio Clas_Enti)
        {
            MySqlTransaction Trs = null;
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {
                    using (MySqlCommand Cmd = new MySqlCommand("sp_ServicioModifcar", Cn))
                    {
                        Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        Cmd.Parameters.Add("?_idServicio", MySqlDbType.Int32).Value = Clas_Enti.idServicio;
                        Cmd.Parameters.Add("?idProveedor", MySqlDbType.Int32).Value = Clas_Enti.idProveedor;
                        Cmd.Parameters.Add("?idCalificacion", MySqlDbType.Int32).Value = Clas_Enti.idCalificacion;
                        Cmd.Parameters.Add("?idHorario", MySqlDbType.Int32).Value = Clas_Enti.idHorario;
                        Cmd.Parameters.Add("?nombreServicio", MySqlDbType.VarChar).Value = Clas_Enti.nombreServicio;
                        Cmd.Parameters.Add("?descripcionServicio", MySqlDbType.VarChar).Value = Clas_Enti.descripcionServicio;
                        Cmd.Parameters.Add("?precioServicio", MySqlDbType.Decimal).Value = Clas_Enti.precioServicio;
                        Cmd.Parameters.Add("?fechaExpiracionServicio", MySqlDbType.DateTime).Value = Clas_Enti.fechaExpiracionServicio;
                        Cmd.Parameters.Add("?cantidadStockServicio", MySqlDbType.Decimal).Value = Clas_Enti.cantidadStockServicio;
                        Cmd.Parameters.Add("?codigoServicio", MySqlDbType.VarChar).Value = Clas_Enti.codigoServicio;
                        Cmd.Parameters.Add("?tiempoGarantiaServicio", MySqlDbType.VarChar).Value = Clas_Enti.tiempoGarantiaServicio;
                        Cmd.Parameters.Add("?fotosGaleriaServicio", MySqlDbType.VarChar).Value = Clas_Enti.fotosGaleriaServicio;

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

        public List<Ent_Servicio> Listar(Ent_Servicio Cls_Enti)
        {
            List<Ent_Servicio> ListaItems = new List<Ent_Servicio>();
            try
            {
                using (MySqlConnection Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
                {

                    using (MySqlCommand Cmd = new MySqlCommand("sp_ServicioListar", Cn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        Cmd.Parameters.Add("?_idServicio", MySqlDbType.Int32).Value = Cls_Enti.idServicio;
                        Cn.Open();
                        using (MySqlDataReader Dr = Cmd.ExecuteReader())
                        {
                            while (Dr.Read())
                            {
                                ListaItems.Add(new Ent_Servicio
                                {
                                    idServicio = Dr.GetInt32(0),
                                    idProveedor = Dr.GetInt32(1),
                                    numeroDocumentoProveedor = Dr.GetString(2),
                                    nombreProveedor = Dr.GetString(3),
                                    idCalificacion = Dr.GetInt32(4),
                                    idHorario = Dr.GetInt32(5),
                                    nombreServicio = Dr.GetString(6),
                                    descripcionServicio = Dr.GetString(7),
                                    precioServicio = Dr.GetDecimal(8),
                                    fechaExpiracionServicio = Dr.GetDateTime(9),
                                    cantidadStockServicio = Dr.GetDecimal(10),
                                    codigoServicio = Dr.GetString(11),
                                    tiempoGarantiaServicio = Dr.GetString(12),
                                    fotosGaleriaServicio = Dr.GetString(13),
                                    estadoServicio = Dr.GetInt32(14),
                                    cantidadClicksServicio = Dr.GetInt32(15),
                                    cantidadPotencialesComprasServicio = Dr.GetInt32(16),
                             
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
