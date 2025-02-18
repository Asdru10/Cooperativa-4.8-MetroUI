using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class Constantes
    {
        public DateTime FECHA_INICIO_COOPERATIVA = new DateTime(2024, 06, 05);
        public decimal CUOTA_INGRESO = 5000;
        public decimal CUOTA_MENSUAL = 2500;
        public decimal CUOTA_ANUAL = 10000;
        public int PORCENTAJE_INTERESES_CREDITO = 12;
        public int PLAZO_MAXIMO_CREDITO = 12;

        public Constantes()
        {
        }

        public void set_FECHA_INICIO_COOPERATIVA(DateTime fecha)
        {
            FECHA_INICIO_COOPERATIVA = fecha;
        }

        public DateTime get_FECHA_INICIO_COOPERATIVA()
        {
            return FECHA_INICIO_COOPERATIVA;
        }

        public void set_CUOTA_INGRESO(decimal cuota)
        {
            CUOTA_INGRESO = cuota;
        }
        public decimal get_CUOTA_INGRESO()
        {
            return CUOTA_INGRESO;
        }

        public decimal getCUOTA_MENSUAL()
        {
            return CUOTA_MENSUAL;
        }

        public void setCUOTA_MENSUAL(decimal cuota)
        {
            CUOTA_MENSUAL = cuota;
        }

        public void setCUOTA_ANUAL(decimal cuota)
        {
            CUOTA_ANUAL = cuota;
        }

        public decimal getCUOTA_ANUAL()
        {
            return CUOTA_ANUAL;
        }

        public void set_PORCENTAJE_INTERESES_CREDITO(int porcentaje)
        {
            PORCENTAJE_INTERESES_CREDITO = porcentaje;
        }

        public int get_PORCENTAJE_INTERESES_CREDITO()
        {
            return PORCENTAJE_INTERESES_CREDITO;
        }

        public void set_PLAZO_MAXIMO_CREDITO(int plazo)
        {
            PLAZO_MAXIMO_CREDITO = plazo;
        }

        public int get_PLAZO_MAXIMO_CREDITO()
        {
            return PLAZO_MAXIMO_CREDITO;
        }
    }
}
