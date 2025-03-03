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
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

namespace UI
{
    public partial class EstadoCta : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();
        private List<Asociado> asociados = new List<Asociado>();
        private Constantes constantes = new Constantes();
        private MensajeAUsuario mensaje = new MensajeAUsuario();

        public EstadoCta()
        {
            InitializeComponent();
        }

        private void EstadoCta_Load(object sender, EventArgs e)
        {
            asociados = cooperativa.getAsociados();
            cargarAsociados();

            metroGridAportes.DataSource = new List<Aporte>();
            metroGridAportes.Columns["Cedula_Asociado"].Visible = false;
            metroGridAportes.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridAportes.Columns["Periodo_Estado_Financiero_Mensual"].Visible = false;

            metroGridAhorros.DataSource = new List<Ahorro>();
            metroGridAhorros.Columns["Cedula_Asociado"].Visible = false;
            metroGridAhorros.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridAhorros.Columns["Periodo_Estado_Financiero_Mensual"].Visible = false;

            metroGridCreditos.DataSource = new List<Credito>();
            metroGridCreditos.Columns["Cedula_Asociado"].Visible = false;
            metroGridCreditos.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridCreditos.Columns["Periodo_Estado_Financiero_Mensual"].Visible = false;
            metroGridCreditos.Columns["Fecha_Desembolso"].Visible = false;
            metroGridCreditos.Columns["Fecha_Final"].Visible = false;
            metroGridCreditos.Columns["Capital_Desembolsado"].Visible = false;
            metroGridCreditos.Columns["Capital_Cancelado"].Visible = false;
            metroGridCreditos.Columns["Saldo_Capital"].Visible = false;
            metroGridCreditos.Columns["Intereses"].Visible = false;
            metroGridCreditos.Columns["Intereses_Cancelados"].Visible = false;
            metroGridCreditos.Columns["Saldo_Intereses"].Visible = false;
            metroGridCreditos.Columns["Saldo_Total"].HeaderText = "Saldo Total";
            metroGridCreditos.Columns["Cuota_Mensual"].Visible = false;
            metroGridCreditos.Columns["Cuota_Intereses"].Visible = false;
            metroGridCreditos.Columns["Total_Cuota"].Visible = false;
            metroGridCreditos.Columns["Total_Credito"].HeaderText = "Crédito Total";
            metroGridCreditos.Columns.Add("TotalCancelado", "Total Cancelado");
            metroGridCreditos.Columns.Add("TotalAtrasado", "Total Atrasado");


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

        private void comboBoxAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cargarAportes()
        {
            try
            {
                List<Aporte> aportes = cooperativa.getAportesAsociado(asociados[metroComboBoxAsociado.SelectedIndex].Cedula);
                decimal totalAportes = 0;
                foreach (var aporte in aportes)
                {
                    totalAportes += aporte.Monto;
                }
                metroTextBoxTotalAportes.Text = totalAportes.ToString();
                metroGridAportes.DataSource = aportes;
                calcularCuotasPendientesAporte(aportes);
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al cargar aportes", ex.Message, "error");
            }
        }

        private void cargarAhorros()
        {
            try
            {
                List<Ahorro> ahorros = cooperativa.getAhorrosAsociado(asociados[metroComboBoxAsociado.SelectedIndex].Cedula);
                decimal totalAhorros = 0;

                foreach (var ahorro in ahorros)
                {
                    totalAhorros += ahorro.Monto;
                }

                metroTextBoxTotalAhorros.Text = totalAhorros.ToString();
                metroGridAhorros.DataSource = ahorros;
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al cargar ahorros", ex.Message, "error");
            }
        }

        private void cargarCreditos()
        {
            try
            {
                List<Credito> creditos = cooperativa.getCreditosAsociado(asociados[metroComboBoxAsociado.SelectedIndex].Cedula);
                List<Credito> creditosActivos = new List<Credito>();
                decimal saldoCreditos = 0;
                bool atrasado = false;

                foreach (var credito in creditos)
                {
                    if (credito.Estado.Equals("Aprobado") || credito.Estado.Equals("Al día"))
                    {
                        creditosActivos.Add(credito);
                        saldoCreditos += credito.Saldo_Total;
                    }
                    else
                    {
                        if (credito.Estado.Equals("Atrasado"))
                        {
                            creditosActivos.Add(credito);
                            atrasado = true;
                            saldoCreditos += credito.Saldo_Total;
                        }
                    }
                }

                if (atrasado)
                {
                    metroTextBoxStatusCreditos.Text = "Atrasado";
                    metroTextBoxStatusCreditos.ForeColor = Color.Red;
                }
                else
                {
                    metroTextBoxStatusCreditos.Text = "Al día";
                    metroTextBoxStatusCreditos.ForeColor = Color.Green;
                }
                metroTextBoxSaldoCreditos.Text = saldoCreditos.ToString();

                metroGridCreditos.DataSource = creditosActivos;
                List<decimal> atrasos = calcularCuotasPendientesCredito(creditosActivos);

                for (int i = 0; i < metroGridCreditos.Rows.Count; i++)
                {
                    decimal interesesCancelados = Convert.ToDecimal(metroGridCreditos.Rows[i].Cells["Intereses_Cancelados"].Value ?? 0);
                    decimal capitalCancelado = Convert.ToDecimal(metroGridCreditos.Rows[i].Cells["Capital_Cancelado"].Value ?? 0);

                    metroGridCreditos.Rows[i].Cells["TotalCancelado"].Value = interesesCancelados + capitalCancelado;
                    metroGridCreditos.Rows[i].Cells["TotalAtrasado"].Value = atrasos[i].ToString();

                    if (atrasos[i] > 0)
                    {
                        metroGridCreditos.Rows[i].Cells["Estado"].Style.BackColor = Color.Red;
                    } 
                    else if (atrasos[i] == 0)
                    {
                        metroGridCreditos.Rows[i].Cells["Estado"].Style.BackColor = Color.LightGreen;
                    }
                }
                

            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al cargar créditos", ex.Message, "error");
            }
        }

        //Prueba de método diferente
        private List<decimal> calcularCuotasPendientesCredito(List<Credito> creditos)
        {
            DateTime fechaActual = DateTime.Now.Date;
            int mesActual = fechaActual.Month;
            int annoActual = fechaActual.Year;
            decimal saldoCredito = 0;
            decimal saldoTotal = 0;
            List<decimal> atrasos = new List<decimal>();

            foreach (var creditoActual in creditos)
            {
                Credito credito = cooperativa.getCreditoPorID(creditoActual.ID);
                if (credito.Estado.Equals("Al día") || credito.Estado.Equals("Aprobado"))
                {
                    atrasos.Add(0);
                    continue;
                }
                else
                {
                    List<ProyeccionPagoCredito> proyecciones = cooperativa.getProyeccionesCredito(credito.ID);
                    for (int i = 0; i < proyecciones.Count; i++)
                    {
                        if (proyecciones[i].Fecha.Month == mesActual && proyecciones[i].Fecha.Year == annoActual)
                        {
                            saldoCredito = proyecciones[i].Saldo_Total;
                            if (proyecciones[i].Fecha <= fechaActual && saldoCredito < credito.Saldo_Total)
                            {
                                decimal totalCancelado = credito.Capital_Cancelado + credito.Intereses_Cancelados;
                                decimal totalAtrasado = proyecciones[i].Monto_Abono * (i + 1) - totalCancelado;
                                if (totalAtrasado > 0)
                                {
                                    saldoTotal = saldoTotal + totalAtrasado;
                                    atrasos.Add(totalAtrasado);
                                }
                                continue;
                            }
                        }
                    }
                }
            }
            metroTextBoxTotalPendienteCreditos.Text = saldoTotal.ToString();
            return atrasos;
        }

        /*
        private List<decimal> calcularCuotasPendientesCredito(List<Credito> creditos)
        {
            DateTime fechaActual = DateTime.Now.Date;
            int mesActual = fechaActual.Month;
            int annoActual = fechaActual.Year;
            decimal saldoCredito = 0;
            decimal saldoTotal = 0;
            List<decimal> atrasos = new List<decimal>();

            foreach (var creditoActual in creditos)
            {
                Credito credito = cooperativa.getCreditoPorID(creditoActual.ID);
                List<ProyeccionPagoCredito> proyecciones = cooperativa.getProyeccionesCredito(credito.ID);

                for (int i = 0; i < proyecciones.Count; i++)
                {
                    if (proyecciones[i].Fecha.Month == mesActual && proyecciones[i].Fecha.Year == annoActual)
                    {
                        saldoCredito = proyecciones[i].Saldo_Total;
                        if (proyecciones[i].Fecha <= fechaActual && saldoCredito < credito.Saldo_Total)
                        {
                            decimal totalCancelado = credito.Capital_Cancelado + credito.Intereses_Cancelados;
                            decimal totalAtrasado = proyecciones[i].Monto_Abono * (i + 1) - totalCancelado;
                            if (totalAtrasado > 0)
                            {
                                saldoTotal = saldoTotal + totalAtrasado;
                                atrasos.Add(totalAtrasado);
                            }
                            break;
                        }
                        else if (saldoCredito >= credito.Saldo_Total)
                        {
                            atrasos.Add(0);
                            break;
                        }
                    }
                }
            }
            metroTextBoxTotalPendienteCreditos.Text = saldoTotal.ToString();
            return atrasos;
        }
        */

        private void calcularCuotasPendientesAporte(List<Aporte> aportes)
        {
            DateTime fechaInicio = constantes.FECHA_INICIO_COOPERATIVA.Date;
            DateTime fechaActual = DateTime.Now.Date;
            bool fin = false;
            int meses = 0;
            int annos = 0;
            do
            {
                if (fechaInicio.Month == fechaActual.Month && fechaInicio.Year == fechaActual.Year)
                {
                    fin = true;
                }
                else
                {
                    fechaInicio = fechaInicio.AddMonths(1);
                    meses++;
                    if (fechaInicio.Month == 1)
                    {
                        annos++;
                    }
                }
            } while (!fin);

            decimal totalAportesMensualesRequeridos = meses * constantes.CUOTA_MENSUAL;
            decimal totalAportesAnualesRequeridos = annos * constantes.CUOTA_ANUAL;
            decimal totalAportesRequeridos = totalAportesAnualesRequeridos + totalAportesMensualesRequeridos + constantes.CUOTA_INGRESO;

            decimal totalAportes = 0;
            foreach (var aporte in aportes)
            {
                totalAportes += aporte.Monto;
            }

            decimal totalPendiente = totalAportesRequeridos - totalAportes;
            metroTextBoxTotalPendienteAportes.Text = totalPendiente.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void metroGridCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroComboBoxAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBoxAsociado.SelectedIndex == -1)
            {
                metroGridAportes.DataSource = new List<Aporte>();
                metroGridAhorros.DataSource = new List<Ahorro>();
                metroGridCreditos.DataSource = new List<Credito>();
                return;
            }
            cargarAportes();
            cargarAhorros();
            cargarCreditos();
        }
    }
}
