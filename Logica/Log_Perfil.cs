using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Log_Perfil
    {
        private Dat_Perfil CapaDato = new Dat_Perfil();

        public List<Ent_Perfil> Listar(Ent_Perfil Cls_Enti)
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
