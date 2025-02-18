using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class EstadoFinancieroMensual
    {
        public int ID { get; set; }
        public int Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public String Concepto { get; set; }
        public decimal Monto { get; set; }
        public String Identificador { get; set; }

        public EstadoFinancieroMensual() { }

        public EstadoFinancieroMensual(int id, DateTime fecha, String concepto, decimal monto, String identificador)
        {
            ID = id;
            Fecha = fecha;
            Concepto = concepto;
            Monto = monto;
            Identificador = identificador;
        }
    }
}
