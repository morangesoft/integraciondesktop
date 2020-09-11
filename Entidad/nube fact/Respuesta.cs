using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk.nube_fact
{
  public  class Respuesta
    {

        //[JsonProperty(PropertyName = "errors")]
        public string errors { get; set; }

        //[JsonProperty(PropertyName = "tipo")]
        public string tipo { get; set; }

        //[JsonProperty(PropertyName = "serie")]
        public string serie { get; set; }

        //[JsonProperty(PropertyName = "numero")]
        public string numero { get; set; }

        //[JsonProperty(PropertyName = "url")]
        public string url { get; set; }

        //[JsonProperty(PropertyName = "aceptada_por_sunat")]
        public string aceptada_por_sunat { get; set; }

        //[JsonProperty(PropertyName = "sunat_description")]
        public string sunat_description { get; set; }

        //[JsonProperty(PropertyName = "sunat_note")]
        public string sunat_note { get; set; }

        //[JsonProperty(PropertyName = "sunat_responsecode")]
        public string sunat_responsecode { get; set; }

        //[JsonProperty(PropertyName = "sunat_soap_error")]
        public string sunat_soap_error { get; set; }

        //[JsonProperty(PropertyName = "pdf_zip_base64")]
        public string pdf_zip_base64 { get; set; }

        //[JsonProperty(PropertyName = "xml_zip_base64")]
        public string xml_zip_base64 { get; set; }

        //[JsonProperty(PropertyName = "cdr_zip_base64")]
        public string cdr_zip_base64 { get; set; }

        //[JsonProperty(PropertyName = "cadena_para_codigo_qr")]
        public string cadena_para_codigo_qr { get; set; }

        //[JsonProperty(PropertyName = "codigo_hash")]
        public string codigo_hash { get; set; }

        //[JsonProperty(PropertyName = "codigo_de_barras")]
        public string codigo_de_barras { get; set; }
    }
}
