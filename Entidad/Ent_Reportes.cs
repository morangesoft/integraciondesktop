using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Ent_Reportes
    {

        public DateTime desde { get; set; }
        public DateTime hasta { get; set; }
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
        public bool aceptado_por_sunat { get; set; }
        public int idVendedor { get; set; }

        public string vendedorDesc { get; set; }


        public List<Ent_Reportes> Detalle_Ventas { get; set; }
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
 

        public string tipo_afectacion_de_igv { get; set; }
        public string tipo_afectacion_de_igv_codNubefact { get; set; }
        public string afecIgvDescripcion { get; set; }
        public string DvtD_OperCodigo { get; set; }

        public decimal subtotal_det { get; set; }
 
        public decimal total_det { get; set; }

        public decimal igv_det { get; set; }

    }
}
