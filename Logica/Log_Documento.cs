using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Log_Documento
    {
        private Dat_Documento CapaDato = new Dat_Documento();

        public List<Ent_Documento> Listar(Ent_Documento Cls_Enti)
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
