using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk.nube_fact
{
  public  class Items
    {
      //  [JsonProperty(PropertyName = "unidad_de_medida")]
        public string unidad_de_medida { get; set; }

        //[JsonProperty(PropertyName = "codigo")]
        public string codigo { get; set; }

        //[JsonProperty(PropertyName = "descripcion")]
        public string descripcion { get; set; }

        //[JsonProperty(PropertyName = "cantidad")]
        public string cantidad { get; set; }

        //[JsonProperty(PropertyName = "valor_unitario")]
        public string valor_unitario { get; set; }

        //[JsonProperty(PropertyName = "precio_unitario")]
        public string precio_unitario { get; set; }

        //[JsonProperty(PropertyName = "descuento")]
        public string descuento { get; set; }

       // [JsonProperty(PropertyName = "subtotal")]
        public string subtotal { get; set; }

        //[JsonProperty(PropertyName = "tipo_de_igv")]
        public string tipo_de_igv { get; set; }

        //[JsonProperty(PropertyName = "igv")]
        public string igv { get; set; }

        //[JsonProperty(PropertyName = "total")]
        public string total { get; set; }

        //[JsonProperty(PropertyName = "anticipo_regularizacion")]
        public string anticipo_regularizacion { get; set; }

        //[JsonProperty(PropertyName = "anticipo_comprobante_serie")]
        public string anticipo_comprobante_serie { get; set; }

        //[JsonProperty(PropertyName = "anticipo_comprobante_numero")]
        public string anticipo_comprobante_numero { get; set; }

    }
}
