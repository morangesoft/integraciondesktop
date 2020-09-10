using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
 public   class Ent_Producto
    {
        

        public int idProducto { get; set; }
        public int idProveedor { get; set; }
        public string numeroDocumentoProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public int idCalificacion { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public string especificacionesProducto { get; set; }
        public decimal precioProducto { get; set; }
        public DateTime fechaExpiracionProducto { get; set; }
        public DateTime fechaIngresoProducto { get; set; }
        public decimal cantidadStockProducto { get; set; }
        public string colorProducto { get; set; }
        public string tamProducto { get; set; }
        public string alturaProducto { get; set; }
        public string anchoProducto { get; set; }
        public string volumenProducto { get; set; }
        public string pesoProducto { get; set; }
        public string marcaProducto { get; set; }
        public string modeloProducto { get; set; }
        public string skuProducto { get; set; }
        public string codigoProducto { get; set; }
        public string tiempoGarantiaProducto { get; set; }
        public string fotoPrincipalProducto { get; set; }
        public string fotosGaleriaProducto { get; set; }
        public int estadoProducto { get; set; }
        public int cantidadClicksProducto { get; set; }
        public int cantidadPetencialesComprasProducto { get; set; }
        public int idUnidadMedida { get; set; }
        public string descripcionUnm { get; set; }
        public string unm_fe { get; set; }
        public string idAfectacionIgv { get; set; }
        public string afecIgvDescripcion { get; set; }
        public string afecIgvTabla { get; set; }
    }
}
