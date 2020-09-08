
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Log_Inicio_sesion
    {
        private Dat_Inicio_Sesion CapaDato = new Dat_Inicio_Sesion();
        public List<Ent_Inicio_Sesion> Iniciar(Ent_Inicio_Sesion Cls_Enti)
        {
            try
            {
                return CapaDato.Iniciar(Cls_Enti);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
