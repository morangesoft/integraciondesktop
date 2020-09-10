using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Log_tipo_afectacion_igv
    {

        private Dat_tipo_afectacion_igv CapaDato = new Dat_tipo_afectacion_igv();

        public List<Ent_tipo_afectacion_igv> Listar(Ent_tipo_afectacion_igv Cls_Enti)
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
