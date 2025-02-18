using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class Abono
    {
        public int ID { get; set; }
        public int ID_Credito { get; set; }
        public int ID_Estado_Financiero_Mensual { get; set; }
        public int Periodo_Estado_Financiero_Mensual { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Abono_Capital { get; set; }
        public decimal Abono_Interes { get; set; }
        public decimal Abono_Total { get; set; }

        public Abono() { }

        public Abono(int id, int id_credito, int id_Estado_Financiero_Mensual, int periodo_Estado_Financiero_Mensual,DateTime fecha, decimal abono_capital, decimal abono_interes, decimal abono_total)
        {
            ID = id;
            ID_Credito = id_credito;
            ID_Estado_Financiero_Mensual = id_Estado_Financiero_Mensual;
            Periodo_Estado_Financiero_Mensual = periodo_Estado_Financiero_Mensual;
            Fecha = fecha;
            Abono_Capital = abono_capital;
            Abono_Interes = abono_interes;
            Abono_Total = abono_total;
        }
    }
}
