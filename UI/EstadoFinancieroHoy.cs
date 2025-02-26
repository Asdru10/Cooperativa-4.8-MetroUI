using BL;
using DOM;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class EstadoFinancieroHoy : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();

        public EstadoFinancieroHoy()
        {
            InitializeComponent();
        }

        private void EstadoFinancieroHoy_Load(object sender, EventArgs e)
        {
            decimal ingresos = 0;
            decimal egresos = 0;
            decimal liquidez = 0;

            List<Aporte> aportes = cooperativa.getAportes();
            List<Ahorro> ahorros = cooperativa.getAhorros();
            List<Credito> creditos = cooperativa.getCreditos();
            List<Abono> abonos = cooperativa.getAbonos();

            foreach (Aporte aporte in aportes)
            {
                ingresos += aporte.Monto;
            }
            foreach (Ahorro ahorro in ahorros)
            {
                ingresos += ahorro.Monto;
            }
            foreach (Credito credito in creditos)
            {
                egresos += credito.Saldo_Total - credito.Intereses;
                // este calculo lo probe y se puede omitir esta linea ingresos += credito.Intereses_Cancelados;
            }
            foreach (Abono abono in abonos)
            {
                ingresos += abono.Abono_Interes;
            }

            liquidez = ingresos - egresos;

            metroTextBoxIngresos.Text = ingresos.ToString();
            metroTextBoxEgresos.Text = egresos.ToString();
            metroTextBoxLiquidez.Text = liquidez.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
