using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Log_Moneda
    {
        private Dat_Moneda CapaDato = new Dat_Moneda();

        public List<Ent_Moneda> Listar(Ent_Moneda Cls_Enti)
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
