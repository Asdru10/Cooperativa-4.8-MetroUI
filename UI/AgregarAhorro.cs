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
    public partial class AgregarAhorro : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();
        private List<Asociado> asociados;
        private MensajeAUsuario mensaje = new MensajeAUsuario();

        public AgregarAhorro()
        {
            InitializeComponent();
        }

        private void AgregarAhorro_Load(object sender, EventArgs e)
        {
            asociados = cooperativa.getAsociados();
            cargarAsociados();
            cargarAhorros();
            metroGridAhorros.Columns["Cedula_Asociado"].HeaderText = "Cédula Asociado";
            metroGridAhorros.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridAhorros.Columns["Periodo_Estado_Financiero_Mensual"].HeaderText = "Periodo";
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

        private void metroButtonAgregar_Click(object sender, EventArgs e)
        {
            if (metroComboBoxAsociado.SelectedIndex < 0)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de asociado", "Seleccione un asociado", "error");
                metroComboBoxAsociado.DroppedDown = true;
                return;
            }

            try
            {

                Ahorro ahorro = new Ahorro();
                ahorro.Cedula_Asociado = asociados[metroComboBoxAsociado.SelectedIndex].Cedula;
                ahorro.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
                ahorro.Fecha = DateTime.Now;

                agregarEstadoFinanciero();
                EstadoFinancieroMensual estadoActual = cooperativa.getUltimoEstadoFinancieroMensual();
                ahorro.ID_Estado_Financiero_Mensual = estadoActual.ID;
                ahorro.Periodo_Estado_Financiero_Mensual = estadoActual.Periodo;
                cooperativa.agregarAhorro(ahorro);

                limpiarCampos();
                cargarAhorros();
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Completado", "Ahorro agregado exitosamente", "check");
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al agregar ahorro", ex.Message, "error");
            }
        }

        private void agregarEstadoFinanciero()
        {
            String periodoActual = DateTime.Now.Month + "" + DateTime.Now.Year;
            EstadoFinancieroMensual estadoFinanciero = new EstadoFinancieroMensual();
            estadoFinanciero.Periodo = Convert.ToInt32(periodoActual);
            estadoFinanciero.Fecha = DateTime.Now;
            estadoFinanciero.Concepto = "Ahorro";
            estadoFinanciero.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
            estadoFinanciero.Identificador = "S";
            cooperativa.agregarEstadoFinancieroMensual(estadoFinanciero);
        }

        private void cargarAhorros()
        {
            try
            {
                metroGridAhorros.DataSource = cooperativa.getAhorros();
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al cargar ahorros", ex.Message, "error");
            }
        }

        private void metroTextBoxMonto_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(metroTextBoxMonto.Text.Trim(), out decimal monto))
            {
                metroTextBoxMonto.Focus();
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de monto", "Debe ingresar un monto utlizando una coma (,) como separador de decimales.", "error");
                return;
            }
            else if (Convert.ToDecimal(metroTextBoxMonto.Text.Trim()) <= 0)
            {
                metroTextBoxMonto.Focus();
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de monto", "Ingrese un monto mayor a cero", "error");
                return;
            }
            else
            {
                decimal montoAhorro = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
                metroTextBoxMonto.Text = monto.ToString("N2");
            }

        }

        private void limpiarCampos()
        {
            metroComboBoxAsociado.SelectedIndex = -1;
            metroTextBoxMonto.Text = "";
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
