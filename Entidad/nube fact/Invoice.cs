using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk.nube_fact
{
  public  class Invoice
    {

        //[JsonProperty(PropertyName = "operacion")]
        public string operacion { get; set; }


        //[JsonProperty(PropertyName = "tipo_de_comprobante")]
        public string tipo_de_comprobante { get; set; }

        //[JsonProperty(PropertyName = "serie")]
        public string serie { get; set; }

        //[JsonProperty(PropertyName = "numero")]
        public string numero { get; set; }

        //[JsonProperty(PropertyName = "sunat_transaction")]
        public int sunat_transaction { get; set; }

        //[JsonProperty(PropertyName = "cliente_tipo_de_documento")]
        public int cliente_tipo_de_documento { get; set; }

        //[JsonProperty(PropertyName = "cliente_numero_de_documento")]
        public string cliente_numero_de_documento { get; set; }

        //[JsonProperty(PropertyName = "cliente_denominacion")]
        public string cliente_denominacion { get; set; }

        //[JsonProperty(PropertyName = "cliente_direccion")]
        public string cliente_direccion { get; set; }

        //[JsonProperty(PropertyName = "cliente_email")]
        public string cliente_email { get; set; }

        //[JsonProperty(PropertyName = "cliente_email_1")]
        public string cliente_email_1 { get; set; }

        //[JsonProperty(PropertyName = "cliente_email_2")]
        public string cliente_email_2 { get; set; }

        //[JsonProperty(PropertyName = "fecha_de_emision")]
        public string fecha_de_emision { get; set; }

        //[JsonProperty(PropertyName = "fecha_de_vencimiento")]
        public string fecha_de_vencimiento { get; set; }

        //[JsonProperty(PropertyName = "moneda")]
        public string moneda { get; set; }

        //[JsonProperty(PropertyName = "tipo_de_cambio")]
        public string tipo_de_cambio { get; set; } //? MAKES NATURAL TYPES NULLABLE

        //[JsonProperty(PropertyName = "porcentaje_de_igv")]
        public string porcentaje_de_igv { get; set; }

        //[JsonProperty(PropertyName = "descuento_global")]
        public string descuento_global { get; set; }

        //[JsonProperty(PropertyName = "total_descuento")]
        public string total_descuento { get; set; }

      //  [JsonProperty(PropertyName = "total_anticipo")]
        public string total_anticipo { get; set; }

       // [JsonProperty(PropertyName = "total_gravada")]
        public string total_gravada { get; set; }

      //  [JsonProperty(PropertyName = "total_inafecta")]
        public string total_inafecta { get; set; }

      //  [JsonProperty(PropertyName = "total_exonerada")]
        public string total_exonerada { get; set; }

       // [JsonProperty(PropertyName = "total_igv")]
        public string total_igv { get; set; }

       // [JsonProperty(PropertyName = "total_gratuita")]
        public string total_gratuita { get; set; }

       // [JsonProperty(PropertyName = "total_otros_cargos")]
        public string total_otros_cargos { get; set; }

       // [JsonProperty(PropertyName = "total")]
        public string total { get; set; }

       // [JsonProperty(PropertyName = "percepcion_tipo")]
        public string percepcion_tipo { get; set; }

       // [JsonProperty(PropertyName = "percepcion_base_imponible")]
        public string percepcion_base_imponible { get; set; }

       // [JsonProperty(PropertyName = "total_percepcion")]
        public string total_percepcion { get; set; }

        //[JsonProperty(PropertyName = "total_incluido_percepcion")]
        //public dynamic total_incluido_percepcion { get; set; }

       // [JsonProperty(PropertyName = "detraccion")]
        public string detraccion { get; set; }

       // [JsonProperty(PropertyName = "observaciones")]
        public string observaciones { get; set; }

       // [JsonProperty(PropertyName = "documento_que_se_modifica_tipo")]
        public string documento_que_se_modifica_tipo { get; set; }

       // [JsonProperty(PropertyName = "documento_que_se_modifica_serie")]
        public string documento_que_se_modifica_serie { get; set; }

        //[JsonProperty(PropertyName = "documento_que_se_modifica_numero")]
        public string documento_que_se_modifica_numero { get; set; }

       // [JsonProperty(PropertyName = "tipo_de_nota_de_credito")]
        public string tipo_de_nota_de_credito { get; set; }

        //[JsonProperty(PropertyName = "tipo_de_nota_de_debito")]
        public string tipo_de_nota_de_debito { get; set; }

        //[JsonProperty(PropertyName = "enviar_automaticamente_a_la_sunat")]
        public string enviar_automaticamente_a_la_sunat { get; set; }

       // [JsonProperty(PropertyName = "enviar_automaticamente_al_cliente")]
        public string enviar_automaticamente_al_cliente { get; set; }

        //[JsonProperty(PropertyName = "codigo_unico")]
        public string codigo_unico { get; set; }

      //  [JsonProperty(PropertyName = "condiciones_de_pago")]
        public string condiciones_de_pago { get; set; }

       // [JsonProperty(PropertyName = "medio_de_pago")]
        public string medio_de_pago { get; set; }

       /// [JsonProperty(PropertyName = "placa_vehiculo")]
        public string placa_vehiculo { get; set; }

       // [JsonProperty(PropertyName = "orden_compra_servicio")]
        public string orden_compra_servicio { get; set; }

       // [JsonProperty(PropertyName = "tabla_personalizada_codigo")]
        public string tabla_personalizada_codigo { get; set; }

       // [JsonProperty(PropertyName = "formato_de_pdf")]
        public string formato_de_pdf { get; set; }

       // [JsonProperty(PropertyName = "items")]
        public List<Items> items { get; set; }

        //[JsonProperty(PropertyName = "guias")]
        //public List<Guias> guias { get; set; }

    }
}
