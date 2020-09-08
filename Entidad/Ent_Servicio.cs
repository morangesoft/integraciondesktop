using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Ent_Servicio
    {
 
        public int idServicio { get; set; }
        public int idProveedor { get; set; }
        public string numeroDocumentoProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public int idCalificacion { get; set; }
        public int idHorario { get; set; }
        public string nombreServicio { get; set; }
        public string descripcionServicio { get; set; }
        public decimal precioServicio { get; set; }
        public DateTime fechaExpiracionServicio { get; set; }
        public decimal cantidadStockServicio { get; set; }
        public string codigoServicio { get; set; }
        public string tiempoGarantiaServicio { get; set; }
        public string fotosGaleriaServicio { get; set; }
        public int estadoServicio { get; set; }
        public int cantidadClicksServicio { get; set; }
        public int cantidadPotencialesComprasServicio { get; set; }
 


    }
}
