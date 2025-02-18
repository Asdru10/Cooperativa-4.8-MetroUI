using BL;
using DOM;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class AbonoCredito : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();
        private List<Asociado> asociados = new List<Asociado>();
        private Credito creditoAcutal;

        public AbonoCredito()
        {
            InitializeComponent();
        }

        private void AbonoCredito_Load(object sender, EventArgs e)
        {
            asociados = cooperativa.getAsociados();
            cargarAsociados();
            metroDateTimeFechaAbono.MinDate = new DateTime(1900, 1, 1);
            metroDateTimeFechaAbono.MaxDate = DateTime.Now.AddYears(1);
            metroDateTimeFechaAbono.Value = DateTime.Now;
            metroGridCreditos.DataSource = new List<Credito>();
            metroGridCreditos.Columns["Cedula_Asociado"].HeaderText = "Cédula Asociado";
            metroGridCreditos.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridCreditos.Columns["Periodo_Estado_Financiero_Mensual"].HeaderText = "Periodo";
            metroGridCreditos.Columns["Fecha_Desembolso"].HeaderText = "Desembolso";
            metroGridCreditos.Columns["Fecha_Final"].HeaderText = "Vencimiento";
            metroGridCreditos.Columns["Capital_Desembolsado"].HeaderText = "Capital de Crédito";
            metroGridCreditos.Columns["Capital_Cancelado"].HeaderText = "Capital Cancelado";
            metroGridCreditos.Columns["Saldo_Capital"].HeaderText = "Saldo de Capital";
            metroGridCreditos.Columns["Intereses_Cancelados"].HeaderText = "Intereses Cancelados";
            metroGridCreditos.Columns["Saldo_Intereses"].HeaderText = "Saldo de Intereses";
            metroGridCreditos.Columns["Saldo_Total"].HeaderText = "Saldo Total";
            metroGridCreditos.Columns["Cuota_Mensual"].Visible = false;
            metroGridCreditos.Columns["Cuota_Intereses"].Visible = false;
            metroGridCreditos.Columns["Total_Cuota"].HeaderText = "Cuota Mensual Total";
            metroGridCreditos.Columns["Total_Credito"].HeaderText = "Crédito Total";
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

        private void metroComboBoxAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCreditos();
        }

        private void cargarCreditos()
        {
            try
            {
                if (metroComboBoxAsociado.SelectedIndex == -1)
                {
                    metroGridCreditos.DataSource = new List<Credito>();
                    return;
                }

                List<Credito> creditos = cooperativa.getCreditosAsociado(asociados[metroComboBoxAsociado.SelectedIndex].Cedula);
                if (creditos.Count == 0)
                {
                    MessageBox.Show("El asociado no tiene créditos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    List<Credito> creditosActivos = new List<Credito>();
                    foreach (var credito in creditos)
                    {
                        if (!credito.Estado.Equals("Cancelado"))
                        {
                            creditosActivos.Add(credito);
                        }
                    }

                    if (creditosActivos.Count == 0)
                    {
                        MessageBox.Show("El asociado no tiene créditos activos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    metroGridCreditos.DataSource = creditosActivos;

                    for (int i = 0; i < metroGridCreditos.Rows.Count; i++)
                    {
                        if (metroGridCreditos.Rows[i].Cells["Estado"].Value.Equals("Atrasado"))
                        {
                            metroGridCreditos.Rows[i].Cells["Estado"].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            metroGridCreditos.Rows[i].Cells["Estado"].Style.BackColor = Color.LightGreen;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar créditos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void metroGridCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)metroGridCreditos.Rows[e.RowIndex].Cells["ID"].Value;
                creditoAcutal = cooperativa.getCreditoPorID(id);
                metroTextBoxSaldoActual.Text = creditoAcutal.Saldo_Total.ToString();
                metroTextBoxMontoAbono.Text = "";
                metroTextBoxNuevoSaldo.Text = "";
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void metroTextBoxMontoAbono_Leave(object sender, EventArgs e)
        {
            if (metroTextBoxSaldoActual.Text.Trim().Equals(""))
            {
                metroTextBoxMontoAbono.Text = "";
                MessageBox.Show("Seleccione un crédito para abonar", "Error de crédito seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (metroTextBoxMontoAbono.Text.Trim() != "")
            {
                if (Convert.ToDecimal(metroTextBoxMontoAbono.Text) > Convert.ToDecimal(metroTextBoxSaldoActual.Text))
                {
                    metroTextBoxMontoAbono.Text = "";
                    MessageBox.Show("El monto de abono no debe superar el saldo del crédito", "Error de monto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                metroTextBoxNuevoSaldo.Text = Convert.ToString(calcularNuevoSaldo(Convert.ToDecimal(metroTextBoxSaldoActual.Text), Convert.ToDecimal(metroTextBoxMontoAbono.Text)));
            }
        }

        private decimal calcularNuevoSaldo(decimal saldo, decimal abono)
        {
            return saldo - abono;
        }
        
        private void metroButtonCancelacionTotal_Click(object sender, EventArgs e)
        {
            if (metroTextBoxSaldoActual.Text.Trim().Equals(""))
            {
                metroTextBoxMontoAbono.Text = "";
                MessageBox.Show("Seleccione un crédito para abonar", "Error de crédito seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            metroTextBoxMontoAbono.Text = metroTextBoxSaldoActual.Text;
            metroTextBoxNuevoSaldo.Text = Convert.ToString(calcularNuevoSaldo(Convert.ToDecimal(metroTextBoxSaldoActual.Text), Convert.ToDecimal(metroTextBoxMontoAbono.Text)));
        }

        private void metroButtonAbonar_Click(object sender, EventArgs e)
        {
            if (metroComboBoxAsociado.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un asociado", "Error de asociado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroComboBoxAsociado.DroppedDown = true;
                return;
            }
            else if (!decimal.TryParse(metroTextBoxMontoAbono.Text.Trim(), out decimal monto))
            {
                metroTextBoxMontoAbono.Focus();
                MessageBox.Show("Debe ingresar un monto utlizando una coma (,) como separador de decimales.", "Error de monto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (metroTextBoxMontoAbono.Text.Trim().Equals("") || Convert.ToDecimal(metroTextBoxMontoAbono.Text.Trim()) <= 0)
            {
                metroTextBoxMontoAbono.Focus();
                MessageBox.Show("Ingrese un monto válido para abonar", "Error de monto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (metroDateTimeFechaAbono.Value < metroDateTimeFechaAbono.MinDate && metroDateTimeFechaAbono.Value > metroDateTimeFechaAbono.MaxDate)
            {
                MessageBox.Show("La fecha seleccionada está fuera del rango permitido.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                decimal abonoTotal = Convert.ToDecimal(metroTextBoxMontoAbono.Text.Trim());
                decimal abonoCapital = 0;
                decimal abonoInteres = 0;
                decimal capitalCancelado = creditoAcutal.Capital_Cancelado;
                decimal interesCancelado = creditoAcutal.Intereses_Cancelados;
                decimal saldoCapital = creditoAcutal.Saldo_Capital;
                decimal saldoInteres = creditoAcutal.Saldo_Intereses;

                if (creditoAcutal.Saldo_Intereses > 0) // Si hay saldo de intereses
                {
                    if (abonoTotal > creditoAcutal.Saldo_Intereses) // Si el abono es mayor al saldo de intereses
                    {
                        decimal interesCanceladoPrevio = interesCancelado;
                        interesCancelado = creditoAcutal.Intereses;
                        saldoInteres = 0;

                        abonoInteres = creditoAcutal.Intereses - interesCanceladoPrevio;
                        abonoTotal -= abonoInteres;
                        capitalCancelado += abonoTotal;

                        abonoCapital = abonoTotal;
                        saldoCapital -= abonoTotal;
                    }
                    else // Si el abono es menor o igual al saldo de intereses
                    {
                        interesCancelado += abonoTotal;
                        saldoInteres -= abonoTotal;
                        abonoInteres = abonoTotal;
                        abonoCapital = 0;
                    }
                }
                else if (creditoAcutal.Saldo_Intereses == 0) // Si no hay saldo de intereses
                {
                    capitalCancelado += abonoTotal;
                    saldoCapital -= abonoTotal;
                    abonoInteres = 0;
                    abonoCapital = abonoTotal;
                }

                creditoAcutal.Capital_Cancelado = capitalCancelado;
                creditoAcutal.Intereses_Cancelados = interesCancelado;
                creditoAcutal.Saldo_Capital = saldoCapital;
                creditoAcutal.Saldo_Intereses = saldoInteres;
                creditoAcutal.Saldo_Total = saldoCapital + saldoInteres;

                // Esto es para el error de los negativos en el capital cancelado
                if (capitalCancelado < 0 || interesCancelado < 0)
                {
                    MessageBox.Show("Ocurrió el Error! Capital cancelado: " + capitalCancelado + ". \nInteres Cancelado: " + interesCancelado + ". \nSaldo Capital: " + saldoCapital + ". \nSaldo Interes: " + saldoCapital + ". \nAbono Total: " + abonoTotal);
                }

                Abono abono = new Abono();
                abono.ID_Credito = creditoAcutal.ID;
                abono.Fecha = metroDateTimeFechaAbono.Value;
                abono.Abono_Capital = abonoCapital;
                abono.Abono_Interes = abonoInteres;
                abono.Abono_Total = Convert.ToDecimal(metroTextBoxMontoAbono.Text.Trim());

                agregarEstadoFinanciero();
                EstadoFinancieroMensual estadoActual = cooperativa.getUltimoEstadoFinancieroMensual();

                abono.ID_Estado_Financiero_Mensual = estadoActual.ID;
                abono.Periodo_Estado_Financiero_Mensual = estadoActual.Periodo;
                cooperativa.agregarAbono(abono);
                cooperativa.actualizarCreditoPorAbono(creditoAcutal);
                verificarEstadoCredito(creditoAcutal.ID);

                limpiarCampos();
                if (creditoAcutal.Saldo_Total == 0)
                {
                    MessageBox.Show("Crédito cancelado");
                }
                else
                {
                    MessageBox.Show("Abono realizado con éxito");
                }
                cargarCreditos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al abonar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void agregarEstadoFinanciero()
        {
            String periodoActual = metroDateTimeFechaAbono.Value.Month + "" + metroDateTimeFechaAbono.Value.Year;
            EstadoFinancieroMensual estadoFinanciero = new EstadoFinancieroMensual();
            estadoFinanciero.Periodo = Convert.ToInt32(periodoActual);
            estadoFinanciero.Fecha = metroDateTimeFechaAbono.Value;
            estadoFinanciero.Concepto = "Abono";
            estadoFinanciero.Monto = Convert.ToDecimal(metroTextBoxMontoAbono.Text.Trim());
            estadoFinanciero.Identificador = "S";
            cooperativa.agregarEstadoFinancieroMensual(estadoFinanciero);
        }

        private void limpiarCampos()
        {
            metroTextBoxSaldoActual.Text = "";
            metroTextBoxMontoAbono.Text = "";
            metroTextBoxNuevoSaldo.Text = "";
            metroDateTimeFechaAbono.Value = DateTime.Now;
        }

        private void verificarEstadoCredito(int id)
        {
            DateTime fechaActual = DateTime.Now.Date;
            int mesActual = fechaActual.Month;
            int annoActual = fechaActual.Year;
            decimal saldoTotal = 0;

            Credito credito = cooperativa.getCreditoPorID(id);
            List<ProyeccionPagoCredito> proyecciones = cooperativa.getProyeccionesCredito(credito.ID);

            for (int i = 0; i < proyecciones.Count; i++)
            {
                if (credito.Saldo_Total == 0)
                {
                    credito.Estado = "Cancelado";
                    cooperativa.eliminarProyeccion(credito.ID);    
                    break;
                }
                else if (proyecciones[i].Fecha.Month == mesActual && proyecciones[i].Fecha.Year == annoActual)
                {
                    saldoTotal = proyecciones[i].Saldo_Total;
                    if (proyecciones[i].Fecha <= fechaActual && saldoTotal < credito.Saldo_Total)
                    {
                        credito.Estado = "Atrasado";
                        break;
                    }
                    else if (saldoTotal >= credito.Saldo_Total)
                    {
                        credito.Estado = "Al día";
                        break;
                    }
                }
            }

            List<Credito> creditosList = new List<Credito>();
            creditosList.Add(credito);
            cooperativa.actualizarEstadoCreditos(creditosList);
        }

        private void comboBoxAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxMontoAbono_Leave(object sender, EventArgs e)
        {

        }

        private void buttonCancelaTotal_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbonar_Click(object sender, EventArgs e)
        {

        }
    }
}
