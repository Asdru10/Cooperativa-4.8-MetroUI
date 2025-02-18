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
    public partial class AgregarCredito : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();
        private List<Asociado> asociados;
        private Constantes constantes = new Constantes();

        public AgregarCredito()
        {
            InitializeComponent();
        }

        private void AgregarCredito_Load(object sender, EventArgs e)
        {
            asociados = cooperativa.getAsociados();
            cargarAsociados();
            cargarCreditos();
            metroGridCreditos.Columns["Cedula_Asociado"].HeaderText = "Cédula Asociado";
            metroGridCreditos.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridCreditos.Columns["Periodo_Estado_Financiero_Mensual"].HeaderText = "Periodo";
            metroGridCreditos.Columns["Fecha_Desembolso"].HeaderText = "Desembolso";
            metroGridCreditos.Columns["Fecha_Final"].HeaderText = "Vencimiento";
            metroGridCreditos.Columns["Capital_Desembolsado"].HeaderText = "Capital de Crédito";
            metroGridCreditos.Columns["Capital_Cancelado"].Visible = false;
            metroGridCreditos.Columns["Saldo_Capital"].Visible = false;
            metroGridCreditos.Columns["Intereses_Cancelados"].Visible = false;
            metroGridCreditos.Columns["Saldo_Intereses"].Visible = false;
            metroGridCreditos.Columns["Saldo_Total"].Visible = false;
            metroGridCreditos.Columns["Cuota_Mensual"].Visible = false;
            metroGridCreditos.Columns["Cuota_Intereses"].Visible = false;
            metroGridCreditos.Columns["Total_Cuota"].HeaderText = "Cuota Mensual Total";
            metroGridCreditos.Columns["Total_Credito"].HeaderText = "Crédito Total";
            metroDateTimeFechaInicio.MinDate = new DateTime(1900, 1, 1);
            metroDateTimeFechaInicio.MaxDate = DateTime.Now.AddYears(3);
            metroDateTimeFechaInicio.Value = DateTime.Now;
            calcularFechaFinal();
            metroTextBoxTasaInteres.Text = constantes.PORCENTAJE_INTERESES_CREDITO.ToString();
        }

        private void cargarAsociados()
        {
            try
            {
                metroComboBoxAsociado.Items.Clear();
                foreach (var asociado in asociados)
                {
                    String nombre = asociado.Nombre + " " + asociado.Primer_Apellido + " " + asociado.Segundo_Apellido;
                    metroComboBoxAsociado.Items.Add(nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar asociados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cargarCreditos()
        {
            try
            {
                metroGridCreditos.DataSource = cooperativa.getCreditos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar créditos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButtonAprobar_Click(object sender, EventArgs e)
        {
            if (metroComboBoxAsociado.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un asociado", "Error de asociado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroComboBoxAsociado.DroppedDown = true;
                return;
            }
            else if (metroDateTimeFechaInicio.Value < metroDateTimeFechaInicio.MinDate && metroDateTimeFechaInicio.Value > metroDateTimeFechaInicio.MaxDate)
            {
                MessageBox.Show("La fecha de inicio está fuera del rango permitido.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!decimal.TryParse(metroTextBoxCapitalCredito.Text.Trim(), out decimal monto))
            {
                metroTextBoxCapitalCredito.Focus();
                MessageBox.Show("Debe ingresar un monto utlizando una coma (,) como separador de decimales.", "Error de capital", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim()) <= 0)
            {
                metroTextBoxCapitalCredito.Focus();
                MessageBox.Show("Ingrese un monto de capital válido a desembolsar", "Error de capital", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (calcularLiquidez() < Convert.ToDecimal(metroTextBoxSaldoCredito.Text.Trim()))
            {
                MessageBox.Show("No se puede aprobar el crédito, el saldo supera el capital disponible", "Error de liquidez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!aprobarCredito())
            {
                MessageBox.Show("No se puede aprobar el crédito, el asociado no tiene suficientes ingresos para cubrir el crédito", "Error de capacidad de crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                calcularFechaFinal();
                realizarCalculos();

                Credito credito = new Credito();
                credito.Cedula_Asociado = asociados[metroComboBoxAsociado.SelectedIndex].Cedula;
                credito.Fecha_Desembolso = metroDateTimeFechaInicio.Value;
                credito.Fecha_Final = metroDateTimeFechaFinal.Value;
                credito.Capital_Desembolsado = Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim());
                credito.Capital_Cancelado = 0;
                credito.Saldo_Capital = Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim());
                credito.Intereses = Convert.ToDecimal(metroTextBoxInteresCredito.Text.Trim());
                credito.Intereses_Cancelados = 0;
                credito.Saldo_Intereses = Convert.ToDecimal(metroTextBoxInteresCredito.Text.Trim());
                credito.Saldo_Total = Convert.ToDecimal(metroTextBoxSaldoCredito.Text.Trim());
                credito.Cuota_Mensual = calcularCuotaCapital();
                credito.Cuota_Intereses = calcularCuotaIntereses();
                credito.Total_Cuota = Convert.ToDecimal(metroTextBoxCuotaMensual.Text.Trim());
                credito.Total_Credito = Convert.ToDecimal(metroTextBoxSaldoCredito.Text.Trim());
                credito.Estado = "Aprobado";

                agregarEstadoFinanciero();
                EstadoFinancieroMensual estadoActual = cooperativa.getUltimoEstadoFinancieroMensual();
                credito.ID_Estado_Financiero_Mensual = estadoActual.ID;
                credito.Periodo_Estado_Financiero_Mensual = estadoActual.Periodo;
                cooperativa.agregarCredito(credito);
                Credito creditoActual = cooperativa.getUltimoCredito();
                cooperativa.crearProyeccion(crearProyeccion(creditoActual));
                limpiarCampos();
                cargarCreditos();
                MessageBox.Show("Crédito agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarEstadoFinanciero()
        {
            String periodoActual = metroDateTimeFechaInicio.Value.Month + "" + metroDateTimeFechaInicio.Value.Year;
            EstadoFinancieroMensual estadoFinanciero = new EstadoFinancieroMensual();
            estadoFinanciero.Periodo = Convert.ToInt32(periodoActual);
            estadoFinanciero.Fecha = metroDateTimeFechaInicio.Value;
            estadoFinanciero.Concepto = "Crédito";
            estadoFinanciero.Monto = Convert.ToDecimal(metroTextBoxSaldoCredito.Text.Trim());
            estadoFinanciero.Identificador = "R";
            cooperativa.agregarEstadoFinancieroMensual(estadoFinanciero);
        }

        private void limpiarCampos()
        {
            metroComboBoxAsociado.Text = "";
            metroDateTimeFechaInicio.Value = DateTime.Now;
            metroTextBoxCapitalCredito.Text = "";
            metroTextBoxInteresCredito.Text = "";
            metroTextBoxSaldoCredito.Text = "";
            metroTextBoxCuotaMensual.Text = "";
        }

        private void realizarCalculos()
        {
            calcularIntereses();
            calcularSaldo();
            calcularCuotaTotal();
        }

        private void calcularFechaFinal()
        {
            try
            {
                if (metroDateTimeFechaInicio.Value >= metroDateTimeFechaInicio.MinDate && metroDateTimeFechaInicio.Value <= metroDateTimeFechaInicio.MaxDate)
                {
                    DateTime fechaInicio = metroDateTimeFechaInicio.Value;
                    DateTime fechaFinal = fechaInicio.AddYears(1);
                    fechaFinal = fechaFinal.AddDays(-1);
                    metroDateTimeFechaFinal.Value = fechaFinal;
                }
            }
            catch
            {
                metroDateTimeFechaInicio.Value = DateTime.Now;
                MessageBox.Show("Error al calcular fecha final", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void calcularIntereses()
        {
            try
            {
                if (metroTextBoxCapitalCredito.Text.Trim().Length > 0 && metroTextBoxTasaInteres.Text.Trim().Length > 0)
                {
                    decimal capital = Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim());
                    decimal tasaInteres = Convert.ToDecimal(metroTextBoxTasaInteres.Text.Trim());
                    decimal intereses = capital * (tasaInteres / 100);
                    metroTextBoxInteresCredito.Text = intereses.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al calcular intereses", "Error de intereses", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcularSaldo()
        {
            try
            {
                if (metroTextBoxCapitalCredito.Text.Trim().Length > 0 && metroTextBoxTasaInteres.Text.Trim().Length > 0)
                {
                    decimal capital = Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim());
                    decimal intereses = Convert.ToDecimal(metroTextBoxInteresCredito.Text.Trim());
                    decimal saldo = capital + intereses;
                    metroTextBoxSaldoCredito.Text = saldo.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al calcular saldo", "Error de saldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcularCuotaTotal()
        {
            try
            {
                if (metroTextBoxCapitalCredito.Text.Trim().Length > 0 && metroTextBoxTasaInteres.Text.Trim().Length > 0)
                {
                    decimal saldo = Convert.ToDecimal(metroTextBoxSaldoCredito.Text.Trim());
                    decimal cuota = saldo / 12;
                    metroTextBoxCuotaMensual.Text = cuota.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al calcular cuota", "Error de cuota", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private decimal calcularCuotaCapital()
        {
            if (metroTextBoxCapitalCredito.Text.Trim().Length > 0 && metroTextBoxTasaInteres.Text.Trim().Length > 0)
            {
                decimal saldo = Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim());
                decimal cuota = saldo / 12;
                return cuota;
            }
            return 0;
        }

        private decimal calcularCuotaIntereses()
        {
            if (metroTextBoxCapitalCredito.Text.Trim().Length > 0 && metroTextBoxTasaInteres.Text.Trim().Length > 0)
            {
                decimal saldo = Convert.ToDecimal(metroTextBoxInteresCredito.Text.Trim());
                decimal cuota = saldo / 12;
                return cuota;
            }
            return 0;
        }

        private void textBoxCapitalDesembolsar_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxFechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFechaInicio_Leave(object sender, EventArgs e)
        {

        }

        private void metroTextBoxCapitalCredito_Leave(object sender, EventArgs e)
        {
            realizarCalculos();

        }

        private void metroTextBoxTasaInteres_Leave(object sender, EventArgs e)
        {
            if (metroTextBoxTasaInteres.Text.Trim().Equals("") || Convert.ToDecimal(metroTextBoxTasaInteres.Text.Trim()) < 0 || Convert.ToDecimal(metroTextBoxTasaInteres.Text.Trim()) > 100)
            {
                MessageBox.Show("La tasa de interés debe ser mayor a 0 y menor a 100", "Error de tasa de interés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTextBoxTasaInteres.Text = "12";
                metroTextBoxTasaInteres.Focus();
                return;
            }
            else
            {
                realizarCalculos();
            }
        }

        private decimal calcularLiquidez()
        {
            List<EstadoFinancieroMensual> estadosFinancieros = new List<EstadoFinancieroMensual>();
            estadosFinancieros = cooperativa.getEstadosFinancieros();
            decimal ingresos = 0;
            decimal egresos = 0;
            decimal liquidez = 0;
            foreach (EstadoFinancieroMensual estado in estadosFinancieros)
            {
                if (estado.Identificador == "S")
                {
                    ingresos += estado.Monto;
                }
                else if (estado.Identificador == "R")
                {
                    egresos += estado.Monto;

                }
            }
            liquidez = ingresos - egresos;
            return liquidez;
        }

        private bool aprobarCredito()
        {
            List<Aporte> aportes = cooperativa.getAportesAsociado(asociados[metroComboBoxAsociado.SelectedIndex].Cedula);
            List<Ahorro> ahorros = cooperativa.getAhorrosAsociado(asociados[metroComboBoxAsociado.SelectedIndex].Cedula);
            List<Credito> creditos = cooperativa.getCreditosAsociado(asociados[metroComboBoxAsociado.SelectedIndex].Cedula);
            List<Abono> abonos = cooperativa.getAbonosAsociado(asociados[metroComboBoxAsociado.SelectedIndex].Cedula);
            decimal saldoIngresos = 0;
            decimal saldoEgresos = 0;
            foreach (Aporte aporte in aportes)
            {
                saldoIngresos += aporte.Monto;
            }
            foreach (Ahorro ahorro in ahorros)
            {
                saldoIngresos += ahorro.Monto;
            }
            foreach (Credito credito in creditos)
            {
                saldoEgresos += credito.Total_Credito;
            }
            foreach (Abono abono in abonos)
            {
                saldoIngresos += abono.Abono_Total;
            }

            if ((saldoIngresos - saldoEgresos) * 2 < Convert.ToDecimal(metroTextBoxSaldoCredito.Text.Trim()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<ProyeccionPagoCredito> crearProyeccion(Credito creditoActual)
        {
            decimal saldo = creditoActual.Total_Credito;
            List<ProyeccionPagoCredito> proyecciones = new List<ProyeccionPagoCredito>();
            for (int i = 0; i < 12; i++)
            {
                ProyeccionPagoCredito proyeccion = new ProyeccionPagoCredito();
                proyeccion.ID_Credito = creditoActual.ID;
                proyeccion.Fecha = creditoActual.Fecha_Desembolso.AddMonths(i + 1);
                proyeccion.Monto_Abono = creditoActual.Total_Cuota;
                proyeccion.Saldo_Total = saldo - creditoActual.Total_Cuota;
                saldo -= creditoActual.Total_Cuota;
                proyecciones.Add(proyeccion);
            }
            proyecciones.Last().Saldo_Total = 0;
            proyecciones.Last().Monto_Abono += saldo;
            return proyecciones;
        }

        private void metroDateTimeFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            calcularFechaFinal();
        }

        private void metroDateTimeFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            calcularFechaFinal();

        }

        private void dateTimePickerFechaInicio_ValueChanged(object sender, EventArgs e)
        {
        }        

        private void dateTimePickerFechaFinal_ValueChanged(object sender, EventArgs e)
        {
        }


        private void buttonAprobar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCapitalDesembolsar_Leave(object sender, EventArgs e)
        {
        }

        private void textBoxTasaInteres_Leave(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
