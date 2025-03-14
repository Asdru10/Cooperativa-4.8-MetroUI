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
        private MensajeAUsuario mensaje = new MensajeAUsuario();
        private PreguntaAUsuario pregunta = new PreguntaAUsuario();

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
            metroGridCreditos.Columns["Capital_Desembolsado"].HeaderText = "Capital Crédito";
            metroGridCreditos.Columns["Capital_Cancelado"].Visible = false;
            metroGridCreditos.Columns["Saldo_Capital"].Visible = false;
            metroGridCreditos.Columns["Intereses_Cancelados"].Visible = false;
            metroGridCreditos.Columns["Saldo_Intereses"].Visible = false;
            metroGridCreditos.Columns["Saldo_Total"].Visible = false;
            metroGridCreditos.Columns["Cuota_Mensual"].Visible = false;
            metroGridCreditos.Columns["Cuota_Intereses"].Visible = false;
            metroGridCreditos.Columns["Total_Cuota"].HeaderText = "Cuota Mensual";
            metroGridCreditos.Columns["Total_Credito"].HeaderText = "Crédito Total";
            metroGridCreditos.Columns["Capital_Desembolsado"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Intereses"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Total_Cuota"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Total_Credito"].DefaultCellStyle.Format = "N2";
            metroDateTimeFechaInicio.MinDate = new DateTime(1900, 1, 1);
            metroDateTimeFechaInicio.MaxDate = DateTime.Now.AddMonths(1);
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
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al cargar asociados", ex.Message, "error");
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
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al cargar créditos", ex.Message, "error");
            }
        }

        private void metroButtonAprobar_Click(object sender, EventArgs e)
        {
            if (metroComboBoxAsociado.SelectedIndex < 0)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de asociado", "Seleccione un asociado", "error");
                metroComboBoxAsociado.DroppedDown = true;
                return;
            }
            else if (metroDateTimeFechaInicio.Value < metroDateTimeFechaInicio.MinDate && metroDateTimeFechaInicio.Value > metroDateTimeFechaInicio.MaxDate)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de fecha", "La fecha de inicio está fuera del rango permitido", "error");
                return;
            }
            else if (!decimal.TryParse(metroTextBoxCapitalCredito.Text.Trim(), out decimal monto))
            {
                metroTextBoxCapitalCredito.Focus();
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de capital", "Debe ingresar un monto utlizando una coma (,) como separador de decimales.", "error");
                return;
            }
            else if (Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim()) <= 0)
            {
                metroTextBoxCapitalCredito.Focus();
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de capital", "Ingrese un monto de capital válido a desembolsar", "error");
                return;
            }
            else if (calcularLiquidez() < Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim()))
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de liquidez", "No se puede aprobar el crédito, el saldo supera el capital disponible", "error");
                return;
            }
            else if (!aprobarCredito())
            {
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
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Completado", "Crédito agregado exitosamente", "check");
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al agregar crédito", ex.Message, "error");
            }
        }

        private void agregarEstadoFinanciero()
        {
            String periodoActual = metroDateTimeFechaInicio.Value.Month + "" + metroDateTimeFechaInicio.Value.Year;
            EstadoFinancieroMensual estadoFinanciero = new EstadoFinancieroMensual();
            estadoFinanciero.Periodo = Convert.ToInt32(periodoActual);
            estadoFinanciero.Fecha = metroDateTimeFechaInicio.Value;
            estadoFinanciero.Concepto = "Crédito";
            estadoFinanciero.Monto = Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim());
            estadoFinanciero.Identificador = "R";
            cooperativa.agregarEstadoFinancieroMensual(estadoFinanciero);
        }

        private void limpiarCampos()
        {
            metroComboBoxAsociado.SelectedIndex = -1;
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
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de fecha", "Error al calcular fecha final", "error");
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
                    intereses = Math.Round(intereses, 2);
                    metroTextBoxInteresCredito.Text = intereses.ToString("N2");
                }
            }
            catch
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de intereses", "Error al calcular intereses", "error");
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
                    saldo = Math.Round(saldo, 2);
                    metroTextBoxSaldoCredito.Text = saldo.ToString("N2");
                }
            }
            catch
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de saldo", "Error al calcular saldo", "error");
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
                    cuota = Math.Round(cuota, 2);
                    metroTextBoxCuotaMensual.Text = cuota.ToString("N2");
                }
            }
            catch
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de cuota", "Error al calcular cuota", "error");
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

        

        private void metroTextBoxCapitalCredito_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(metroTextBoxCapitalCredito.Text.Trim(), out decimal capitalCredito))
            {
                decimal capital = Convert.ToDecimal(metroTextBoxCapitalCredito.Text.Trim());
                metroTextBoxCapitalCredito.Text = capital.ToString("N2");
                realizarCalculos();
            } 
            else
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de capital", "El capital de crédito debe ser un número", "error");
                metroTextBoxCapitalCredito.Text = "";
                metroTextBoxCapitalCredito.Focus();
                return;
            }

        }

        private void metroTextBoxTasaInteres_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(metroTextBoxTasaInteres.Text.Trim(), out decimal tasaInteres))
            {
                if (metroTextBoxTasaInteres.Text.Trim().Equals("") || Convert.ToDecimal(metroTextBoxTasaInteres.Text.Trim()) < 0 || Convert.ToDecimal(metroTextBoxTasaInteres.Text.Trim()) > 100)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error de tasa de interés", "La tasa de interés debe ser mayor a 0 y menor a 100", "error");
                    metroTextBoxTasaInteres.Text = "12";
                    metroTextBoxTasaInteres.Focus();
                    return;
                }
                else
                {
                    realizarCalculos();
                }
            }
            else
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de tasa de interés", "La tasa de interés debe ser un número", "error");
                metroTextBoxTasaInteres.Text = "12";
                metroTextBoxTasaInteres.Focus();
                return;

            }
        }

        private decimal calcularLiquidez()
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
                saldoEgresos += credito.Capital_Desembolsado;
            }
            foreach (Abono abono in abonos)
            {
                saldoIngresos += abono.Abono_Total;
            }

            decimal capacidadCredito = (saldoIngresos - saldoEgresos) * 2;

            if (capacidadCredito < Convert.ToDecimal(metroTextBoxSaldoCredito.Text.Trim()))
            {
                DialogResult resultado;
                if (capacidadCredito < 0)
                {
                    pregunta = new PreguntaAUsuario();
                    pregunta.titulo("Exceso de Crédito");
                    pregunta.mensaje("El asociado no ha realizado los suficientes aportes para poder solicitar este crédito.\nSu capacidad de crédito es negativa. \n¿Desea continuar?");
                    resultado = pregunta.ShowDialog();
                }
                else
                {
                    pregunta = new PreguntaAUsuario();
                    pregunta.titulo("Exceso de Crédito");
                    pregunta.mensaje("El asociado no ha realizado los suficientes aportes para poder solicitar este crédito.\nSu capacidad de crédito es de " + capacidadCredito + " colones. \n¿Desea continuar?");
                    resultado = pregunta.ShowDialog();
                }

                if (resultado == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Crédito no aprobado", "Ha decidido no aprobar el crédito", "advertencia");
                    return false;
                }
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

        private void textBoxCapitalDesembolsar_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxFechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFechaInicio_Leave(object sender, EventArgs e)
        {

        }

        private void metroGridCreditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
