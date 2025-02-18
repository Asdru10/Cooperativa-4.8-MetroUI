using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class ProyeccionPagoCredito
    {
        public int ID_Credito { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto_Abono { get; set; }
        public decimal Saldo_Total { get; set; }

        public ProyeccionPagoCredito() { }

        public ProyeccionPagoCredito(int id_Credito, DateTime fecha, decimal monto_Abono, decimal saldo_Total)
        {
            ID_Credito = id_Credito;
            Fecha = fecha;
            Monto_Abono = monto_Abono;
            Saldo_Total = saldo_Total;
        }
    }
}
