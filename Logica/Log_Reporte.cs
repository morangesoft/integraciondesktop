﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Log_Reporte
    {
        private Dat_Reporte CapaDato = new Dat_Reporte();

        public List<Ent_Reportes> Listar(Ent_Reportes Cls_Enti)
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

        public DataSet Rpte_DataSet(Ent_Reportes pEntidad)
        {
            try
            {
                return CapaDato.Rpte_DataSet(pEntidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public List<Ent_Reportes> Listar_Det(Ent_Reportes Cls_Enti)
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


        public List<Ent_Reportes> ReportePivotDetallado(Ent_Reportes Cls_Enti)
        {
            try
            {
                return CapaDato.ReportePivotDetallado (Cls_Enti);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
