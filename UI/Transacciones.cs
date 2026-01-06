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
    public partial class Transacciones : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();
        private List<Asociado> asociados = new List<Asociado>();
        private Constantes constantes = new Constantes();
        private MensajeAUsuario mensaje = new MensajeAUsuario();
        private Credito creditoAcutal = new Credito();

        public Transacciones()
        {
            InitializeComponent();
        }

        private void Transacciones_Load(object sender, EventArgs e)
        {
            asociados = cooperativa.getAsociados();
            cargarAsociados();
            metroDateTimeFechaInicio.MinDate = constantes.FECHA_INICIO_COOPERATIVA;
            metroDateTimeFechaInicio.MaxDate = DateTime.Now.AddMonths(1);
            metroDateTimeFechaInicio.Value = constantes.FECHA_INICIO_COOPERATIVA;
            metroDateTimeFechaFinal.MinDate = constantes.FECHA_INICIO_COOPERATIVA;
            metroDateTimeFechaFinal.MaxDate = DateTime.Now.AddMonths(1);
            metroDateTimeFechaFinal.Value = DateTime.Now;

            metroGridAportes.DataSource = new List<Aporte>();
            metroGridAportes.Columns["Cedula_Asociado"].Visible = false;
            metroGridAportes.Columns["Nombre_Asociado"].Visible = false;
            metroGridAportes.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridAportes.Columns["Periodo_Estado_Financiero_Mensual"].Visible = false;
            metroGridAportes.Columns["Monto"].DefaultCellStyle.Format = "N2";

            metroGridAhorros.DataSource = new List<Ahorro>();
            metroGridAhorros.Columns["Cedula_Asociado"].Visible = false;
            metroGridAhorros.Columns["Nombre_Asociado"].Visible = false;
            metroGridAhorros.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridAhorros.Columns["Periodo_Estado_Financiero_Mensual"].Visible = false;
            metroGridAhorros.Columns["Monto"].DefaultCellStyle.Format = "N2";


            metroGridCreditos.DataSource = new List<Credito>();
            metroGridCreditos.Columns["Cedula_Asociado"].Visible = false;
            metroGridCreditos.Columns["Nombre_Asociado"].Visible = false;
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

            metroGridCreditos.Columns["Saldo_Total"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Total_Credito"].DefaultCellStyle.Format = "N2";

            metroGridAbonos.DataSource = new List<Abono>();
            metroGridAbonos.Columns["ID_Credito"].HeaderText = "ID Crédito";
            metroGridAbonos.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridAbonos.Columns["Periodo_Estado_Financiero_Mensual"].HeaderText = "Periodo";
            metroGridAbonos.Columns["Abono_Capital"].HeaderText = "Abono al Capital";
            metroGridAbonos.Columns["Abono_Interes"].HeaderText = "Abono a Intereses";
            metroGridAbonos.Columns["Abono_Total"].HeaderText = "Abono Total";

            metroGridAbonos.Columns["Abono_Capital"].DefaultCellStyle.Format = "N2";
            metroGridAbonos.Columns["Abono_Interes"].DefaultCellStyle.Format = "N2";
            metroGridAbonos.Columns["Abono_Total"].DefaultCellStyle.Format = "N2";
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

        private void cargarAportes()
        {
            try
            {
                List<Aporte> aportes = cooperativa.getAportesAsociado(asociados[metroComboBoxAsociado.SelectedIndex].Cedula);
                metroGridAportes.DataSource = aportes;
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
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al cargar créditos", ex.Message, "error");
            }
        }

        private void metroLabelDetallesAbonos_Click(object sender, EventArgs e)
        {

        }

        private void metroGridCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)metroGridCreditos.Rows[e.RowIndex].Cells["ID"].Value;
                creditoAcutal = cooperativa.getCreditoPorID(id);
                metroGridAbonos.DataSource = cooperativa.getAbonosCredito(id);
                if (metroGridAbonos.Rows.Count == 0)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Aviso", "El crédito no tiene abonos", "info");
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void metroButtonRestablecer_Click(object sender, EventArgs e)
        {
            metroDateTimeFechaInicio.Value = constantes.FECHA_INICIO_COOPERATIVA;
            metroDateTimeFechaFinal.Value = DateTime.Now;
            metroComboBoxAsociado.SelectedIndex = -1;
            metroGridAportes.DataSource = new List<Aporte>();
            metroGridAhorros.DataSource = new List<Ahorro>();
            metroGridCreditos.DataSource = new List<Credito>();
            metroGridAbonos.DataSource = new List<Abono>();
        }

        private void metroButtonObtener_Click(object sender, EventArgs e)
        {
            cargarAportes();
            cargarAhorros();
            cargarCreditos();
        }

        private void metroGridAbonos_CellClick(object sender, DataGridViewCellEventArgs e) { }

    }
}
