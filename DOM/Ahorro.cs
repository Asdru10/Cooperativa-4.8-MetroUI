using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class Ahorro
    {
        public int ID { get; set; }
        public int Cedula_Asociado { get; set; }
        public int ID_Estado_Financiero_Mensual { get; set; }
        public int Periodo_Estado_Financiero_Mensual { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }


        public Ahorro() { }

        public Ahorro(int id, int cedula_Asociado, int id_Estado_Financiero_Mensual, int periodo_Estado_Financiero_Mensual, decimal monto, DateTime fecha)
        {
            ID = id;
            Cedula_Asociado = cedula_Asociado;
            ID_Estado_Financiero_Mensual = id_Estado_Financiero_Mensual;
            Periodo_Estado_Financiero_Mensual = periodo_Estado_Financiero_Mensual;
            Monto = monto;
            Fecha = fecha;
        }

    }
}
