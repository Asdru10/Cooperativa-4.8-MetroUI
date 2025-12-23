using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class Credito
    {
        public int ID { get; set; }
        public int Cedula_Asociado { get; set; }
        public String Nombre_Asociado { get; set; }
        public int ID_Estado_Financiero_Mensual { get; set; }
        public int Periodo_Estado_Financiero_Mensual { get; set; }
        public DateTime Fecha_Desembolso { get; set; }
        public DateTime Fecha_Final { get; set; }
        public decimal Capital_Desembolsado { get; set; }
        public decimal Capital_Cancelado { get; set; }
        public decimal Saldo_Capital { get; set; }
        public decimal Intereses { get; set; }
        public decimal Intereses_Cancelados { get; set; }
        public decimal Saldo_Intereses { get; set; }
        public decimal Saldo_Total { get; set; }
        public decimal Cuota_Mensual { get; set; }
        public decimal Cuota_Intereses { get; set; }
        public decimal Total_Cuota { get; set; }
        public decimal Total_Credito { get; set; }
        public String Estado { get; set; }
        public List<Abono> Abonos { get; set; }
        public List<Abono> getAbonos { get { return Abonos; } }

        public Credito()
        {
            Abonos = new List<Abono>();
        }

        public Credito(int id, int cedula_asociado, String nombre_Asociado, int id_Estado_Financiero_Mensual, int periodo_Estado_Financiero_Mensual, DateTime fecha_desembolso, DateTime fecha_final, decimal capital_desembolsado, decimal capital_cancelado, decimal saldo_capital, decimal intereses, decimal intereses_cancelados, decimal saldo_intereses, decimal saldo_total, decimal cuota_mensual, decimal cuota_intereses, decimal total_cuota, decimal total_credito, string estado)
        {
            ID = id;
            Cedula_Asociado = cedula_asociado;
            Nombre_Asociado = nombre_Asociado;
            ID_Estado_Financiero_Mensual = id_Estado_Financiero_Mensual;
            Periodo_Estado_Financiero_Mensual = periodo_Estado_Financiero_Mensual;
            Fecha_Desembolso = fecha_desembolso;
            Fecha_Final = fecha_final;
            Capital_Desembolsado = capital_desembolsado;
            Capital_Cancelado = capital_cancelado;
            Saldo_Capital = saldo_capital;
            Intereses = intereses;
            Intereses_Cancelados = intereses_cancelados;
            Saldo_Intereses = saldo_intereses;
            Saldo_Total = saldo_total;
            Cuota_Mensual = cuota_mensual;
            Cuota_Intereses = cuota_intereses;
            Total_Cuota = total_cuota;
            Total_Credito = total_credito;
            Estado = estado;
            Abonos = new List<Abono>();
        }

    }
}
