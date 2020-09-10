using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
  public  class Ent_Usuario
    {

        public int idtipdoc { get; set; }
        public string tipodocdesc { get; set; }
        public int usuario_id { get; set; }
        public string usuario_nombre { get; set; }
        public string usuario_apellido { get; set; }
        public string usuario_email { get; set; }
        public string usuario_clave { get; set; }
        public string usuario_dni { get; set; }
        public string usuario_celular { get; set; }
        public string usuario_img { get; set; }
        public int perfil_id { get; set; }
        public string perfil_nombre { get; set; }
        public int usuario_activo { get; set; }
        public int usuario_eliminado { get; set; }
        public string direccion { get; set; }



    }
}
