using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Log_Datos_Generales
    {

        private Dat_Datos_Generales CapaDato = new Dat_Datos_Generales();

        public List<Ent_Datos_Generales> Listar(Ent_Datos_Generales Cls_Enti)
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
