using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public  class Log_Facturacion
    {
        private Dat_Facturacion CapaDato = new Dat_Facturacion();


        public bool Insertar(Ent_Facturacion Cls_Enti)
        {
            try
            {

                CapaDato.Insertar(Cls_Enti);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Modificar(Ent_Facturacion Cls_Enti)
        {
            try
            {

                CapaDato.Modificar(Cls_Enti);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Actualizar_Campos_Sunat(Ent_Facturacion Cls_Enti)
        {
            try
            {

                CapaDato.Actualizar_Campos_Sunat(Cls_Enti);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Ent_Facturacion> Listar(Ent_Facturacion Cls_Enti)
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

        public List<Ent_Facturacion> Listar_Det(Ent_Facturacion Cls_Enti)
        {
            try
            {
                return CapaDato.Listar_Det(Cls_Enti);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
