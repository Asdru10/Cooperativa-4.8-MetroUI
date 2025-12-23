using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class Aporte
    {
        public int ID { get; set; }
        public int Cedula_Asociado { get; set; }
        public String Nombre_Asociado { get; set; }
        public int ID_Estado_Financiero_Mensual { get; set; }
        public int Periodo_Estado_Financiero_Mensual { get; set; }
        public String Detalle { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public String Tipo { get; set; }

        public Aporte() { }

        public Aporte(int id, int cedula_Asociado, string nombre_Asociado, int id_Estado_Financiero_Mensual, int periodo_Estado_Financiero_Mensual, String detalle, decimal monto, DateTime fecha, String tipo)
        {
            ID = id;
            Cedula_Asociado = cedula_Asociado;
            Nombre_Asociado = nombre_Asociado;
            ID_Estado_Financiero_Mensual = id_Estado_Financiero_Mensual;
            Periodo_Estado_Financiero_Mensual = periodo_Estado_Financiero_Mensual;
            Detalle = detalle;
            Monto = monto;
            Fecha = fecha;
            Tipo = tipo;
        }
    }
}
