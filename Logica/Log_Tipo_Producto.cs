using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Log_Tipo_Producto
    {
        private Dat_Tipo_Producto CapaDato = new Dat_Tipo_Producto();

        public List<Ent_Tipo_Producto> Listar(Ent_Tipo_Producto Cls_Enti)
        {
            try
            {
                return CapaDato.Listar(Cls_Enti);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
