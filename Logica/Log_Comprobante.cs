using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Log_Comprobante
    {
        private Dat_Comprobante CapaDato = new Dat_Comprobante();

        public List<Ent_Comprobante> Listar(Ent_Comprobante Cls_Enti)
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
