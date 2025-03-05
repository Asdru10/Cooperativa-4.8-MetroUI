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
    public partial class CierreMensual : MetroForm
    {

        private CooperativaManager cooperativa = new CooperativaManager();
        Constantes constantes = new Constantes();
        private MensajeAUsuario mensaje = new MensajeAUsuario();
        public bool mensual;
        public bool anual;

        public CierreMensual()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void CierreMensual_Load(object sender, EventArgs e)
        {
            metroComboBoxMes.Items.Add("Enero");
            metroComboBoxMes.Items.Add("Febrero");
            metroComboBoxMes.Items.Add("Marzo");
            metroComboBoxMes.Items.Add("Abril");
            metroComboBoxMes.Items.Add("Mayo");
            metroComboBoxMes.Items.Add("Junio");
            metroComboBoxMes.Items.Add("Julio");
            metroComboBoxMes.Items.Add("Agosto");
            metroComboBoxMes.Items.Add("Septiembre");
            metroComboBoxMes.Items.Add("Octubre");
            metroComboBoxMes.Items.Add("Noviembre");
            metroComboBoxMes.Items.Add("Diciembre");

            for (int i = constantes.FECHA_INICIO_COOPERATIVA.Year; i <= DateTime.Now.Year; i++)
            {
                metroComboBoxAnno.Items.Add(i);
            }


            metroComboBoxAnno.SelectedIndex = metroComboBoxAnno.Items.IndexOf(DateTime.Now.Year);
            metroComboBoxMes.SelectedIndex = DateTime.Now.Month - 1;
            cargarVista();
        }

        private void calcularCierreMensual()
        {
            String periodo = (metroComboBoxMes.SelectedIndex + 1) + "" + metroComboBoxAnno.Text;
            int periodoInt = Convert.ToInt32(periodo);

            decimal ingresos = 0;
            decimal egresos = 0;
            decimal liquidez = 0;

            List<Aporte> aportes = cooperativa.getAportesPorPeriodo(periodoInt);
            List<Ahorro> ahorros = cooperativa.getAhorrosPorPeriodo(periodoInt);
            List<Credito> creditos = cooperativa.getCreditosPorPeriodo(periodoInt);
            List<Abono> abonos = cooperativa.getAbonosPorPeriodo(periodoInt);

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
            }
            foreach (Abono abono in abonos)
            {
                ingresos += abono.Abono_Interes;
            }

            liquidez = ingresos - egresos;

            metroTextBoxIngresos.Text = ingresos.ToString("N2");
            metroTextBoxEgresos.Text = egresos.ToString("N2");
            metroTextBoxLiquidez.Text = liquidez.ToString("N2");
        }

        private void calcularCierreAnual()
        {
            int anno = Convert.ToInt32(metroComboBoxAnno.Text);

            decimal ingresos = 0;
            decimal egresos = 0;
            decimal liquidez = 0;

            List<Aporte> aportes = cooperativa.getAportesPorAnno(anno);
            List<Ahorro> ahorros = cooperativa.getAhorrosPorAnno(anno);
            List<Credito> creditos = cooperativa.getCreditosPorAnno(anno);
            List<Abono> abonos = cooperativa.getAbonosPorAnno(anno);

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
            }
            foreach (Abono abono in abonos)
            {
                ingresos += abono.Abono_Interes;
            }

            liquidez = ingresos - egresos;

            metroTextBoxIngresos.Text = ingresos.ToString("N2");
            metroTextBoxEgresos.Text = egresos.ToString("N2");
            metroTextBoxLiquidez.Text = liquidez.ToString("N2");
        }

        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool verificacionesCierreMensual()
        {
            if ((metroComboBoxMes.SelectedIndex + 1) > DateTime.Now.Month && Convert.ToInt32(metroComboBoxAnno.Text) == DateTime.Now.Year)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de Fecha", "Aún no hay registros de " + metroComboBoxMes.Text + " en el año actual.", "error");
                return false;
            }
            else if ((metroComboBoxMes.SelectedIndex + 1) < constantes.FECHA_INICIO_COOPERATIVA.Month && Convert.ToInt32(metroComboBoxAnno.Text) == constantes.FECHA_INICIO_COOPERATIVA.Year)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de Fecha", "La cooperativa no existía en " + metroComboBoxMes.Text + " del año " + metroComboBoxAnno.Text, "error");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool verificacionesCierreAnual()
        {
            if (Convert.ToInt32(metroComboBoxAnno.Text) < constantes.FECHA_INICIO_COOPERATIVA.Year || Convert.ToInt32(metroComboBoxAnno.Text) > DateTime.Now.Year)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de Fecha", "El año seleccionado no es válido", "error");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void metroButtonObtener_Click(object sender, EventArgs e)
        {
            if (mensual)
            {
                if (verificacionesCierreMensual() && verificacionesCierreAnual())
                {
                    calcularCierreMensual();
                }
            }
            else if (anual)
            {
                if (verificacionesCierreAnual())
                {
                    calcularCierreAnual();
                }
            }
        }

        private void cargarVista()
        {
            if (mensual)
            {
                //quiero que el titulo de la ventana sea Cierre Mensual, es un metroform

                this.Text = "Cierre Mensual";
                metroComboBoxMes.Show();
                metroLabelMes.Show();
                metroComboBoxMes.Enabled = true;
                metroComboBoxAnno.Enabled = true;
                metroButtonObtener.Enabled = true;
            }
            else if (anual)
            {
                this.Text = "Cierre Anual";
                metroComboBoxMes.Hide();
                metroLabelMes.Hide();
                metroComboBoxAnno.Enabled = true;
                metroButtonObtener.Enabled = true;
            }
        }

        private void radioButtonMensual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonObtener_Click(object sender, EventArgs e)
        {

        }

    }
}
