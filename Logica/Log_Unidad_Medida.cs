using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
    public   class Log_Unidad_Medida
    {
        private Dat_Unidad_Medida CapaDato = new Dat_Unidad_Medida();

        public List<Ent_Unidad_Medida> Listar(Ent_Unidad_Medida Cls_Enti)
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
