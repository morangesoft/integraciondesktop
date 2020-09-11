using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Ent_Facturacion
    {

        public int id { get; set; }
        public int comprobante_id { get; set; }
        public string comprobante_desc { get; set; }
        public string comprobante_codSunat { get; set; }

        public string serie { get; set; }
        public string numero { get; set; }
        public DateTime fechaEmision { get; set; }
        public int cliente_id { get; set; }
        public string cliente_desc { get; set; }
        public string cliente_dniRuc { get; set; }
        public int cliente_tipo_doc_id { get; set; }
        public string cliente_tipo_doc_desc { get; set; }
        public string cliente_tipo_doc_codSunat { get; set; }

        public int modena_id { get; set; }
        public string modena_desc { get; set; }
        public string modena_fe { get; set; }

        public decimal tipo_cambio_monto { get; set; }
        public decimal DvtD_IGVTasaPorcentaje { get; set; }
        public decimal total_gravada { get; set; }
        public decimal total_inafecta { get; set; }
        public decimal total_exonerada { get; set; }
        public decimal total_igv { get; set; }
        public decimal total_gratuita { get; set; }
        public decimal total_otros_cargos { get; set; }
        public decimal total_cab { get; set; }
        public bool estado { get; set; }
        public string glosa { get; set; }

        //detalle
        public List<Ent_Facturacion> DetalleADM { get; set; }
        public int id_det { get; set; }
        public int id_venta_cab { get; set; }
        public int id_tipo_bien_servicio { get; set; }
        public string tipo_bien_servicio_desc { get; set; }
        public int prod_serv_id { get; set; }
        public string productocod { get; set; }
        public string productodesc { get; set; }
        public int unidad_medida_id { get; set; }
        public string unidad_medida_desc { get; set; }
        public string unidad_medida_fe { get; set; }

        public decimal cantidad { get; set; }
        public decimal valor_unitario { get; set; }
        public decimal precio_unitario { get; set; }
        //public decimal subtotal { get; set; }

        public string tipo_afectacion_de_igv { get; set; }
        public string afecIgvDescripcion { get; set; }
        public string DvtD_OperCodigo { get; set; }

        public decimal subtotal_det { get; set; }
        //public decimal igv_det { get; set; }
        public decimal total_det { get; set; }

        public decimal subtotal
        {
            get
            {
                return Math.Round(Convert.ToDecimal(total_det) / (1 + (Convert.ToDecimal(DvtD_IGVTasaPorcentaje) / 100)), 2);
            }
        }

        public decimal DvtD_IGVMonto
        {
            get
            {
                if ((DvtD_OperCodigo == "0565"))
                {
                    return Math.Round((Convert.ToDecimal(total_det) / (1 + (Convert.ToDecimal(DvtD_IGVTasaPorcentaje) / 100))) * (Convert.ToDecimal(DvtD_IGVTasaPorcentaje) / 100), 2);

                }
                else
                {
                    return 0;
                }

            }
        }

        public decimal DvtD_BaseImpobleOperacionGravada
        {
            get
            {
                if (DvtD_OperCodigo == "0564")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0565")
                {
                    return subtotal;
                }
                else if (DvtD_OperCodigo == "0566")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0567")
                {
                    return 0;
                }
                else
                {
                    return 0;
                }

            }
        }

        public decimal DvtD_ValorFactExportacion
        {
            get
            {
                if (DvtD_OperCodigo == "0564")
                {
                    return subtotal;
                }
                else if (DvtD_OperCodigo == "0565")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0566")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0567")
                {
                    return 0;
                }
                else
                {
                    return 0;
                }

            }
        }

        public decimal DvtD_IGV_IPM
        {
            get
            {
                if (DvtD_OperCodigo == "0564")
                {
                    return subtotal;
                }
                else if (DvtD_OperCodigo == "0565")
                {
                    return DvtD_IGVMonto;
                }
                else if (DvtD_OperCodigo == "0566")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0567")
                {
                    return 0;
                }
                else
                {
                    return 0;
                }

            }
        }
        public decimal DvtD_Exonerada
        {
            get
            {
                if (DvtD_OperCodigo == "0564")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0565")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0566")
                {
                    return total_det;
                }
                else if (DvtD_OperCodigo == "0567")
                {
                    return 0;
                }
                else
                {
                    return 0;
                }

            }
        }

        public decimal DvtD_Inafecta
        {
            get
            {
                if (DvtD_OperCodigo == "0564")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0565")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0566")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0567")
                {
                    return subtotal;
                }
                else
                {
                    return 0;
                }

            }
        }


        public decimal DvtD_ISC
        {
            get
            {
                if (DvtD_OperCodigo == "0564")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0565")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0566")
                {
                    return 0;
                }
                else if (DvtD_OperCodigo == "0567")
                {
                    return 0;
                }
                else
                {
                    return 0;
                }

            }
        }

    }
}
