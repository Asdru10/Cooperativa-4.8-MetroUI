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

    public partial class AgregarAporte : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();
        private List<Asociado> asociados;
        private MensajeAUsuario mensaje = new MensajeAUsuario();

        public AgregarAporte()
        {
            InitializeComponent();
        }

        private void labelAgregarAporte_Click(object sender, EventArgs e)
        {

        }

        private void AgregarAporte_Load(object sender, EventArgs e)
        {
            asociados = cooperativa.getAsociados();
            cargarAsociados();
            cargarAportes();
            metroDateTimeFecha.MinDate = new DateTime(1900, 1, 1);
            metroDateTimeFecha.MaxDate = DateTime.Now.AddYears(1);
            metroDateTimeFecha.Value = DateTime.Now;
            metroGridAportes.Columns["Cedula_Asociado"].HeaderText = "Cédula Asociado";
            metroGridAportes.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridAportes.Columns["Periodo_Estado_Financiero_Mensual"].HeaderText = "Periodo";
            metroGridAportes.Columns["Monto"].DefaultCellStyle.Format = "N2";

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
            string tipoAporte = tipoAporteSeleccionado();

            if (metroComboBoxAsociado.SelectedIndex < 0)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de asociado", "Seleccione un asociado", "error");
                metroComboBoxAsociado.DroppedDown = true;
                return;
            }
            else if (metroTextBoxDetalle.Text.Trim().Equals(""))
            {
                metroTextBoxDetalle.Focus();
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de detalle", "Ingrese un detalle", "error");
                return;
            }
            else if (metroDateTimeFecha.Value < metroDateTimeFecha.MinDate && metroDateTimeFecha.Value > metroDateTimeFecha.MaxDate)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de fecha", "La fecha seleccionada está fuera del rango permitido.", "error");
                return;
            }
            else if (tipoAporte.Equals(""))
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de tipo de aporte", "Seleccione un tipo de aporte", "error");
                return;
            }

            try
            {
                Aporte aporte = new Aporte();
                aporte.Cedula_Asociado = asociados[metroComboBoxAsociado.SelectedIndex].Cedula;
                aporte.Detalle = metroTextBoxDetalle.Text.Trim();
                aporte.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
                aporte.Fecha = metroDateTimeFecha.Value;
                aporte.Tipo = tipoAporte;

                agregarEstadoFinanciero();
                EstadoFinancieroMensual estadoActual = cooperativa.getUltimoEstadoFinancieroMensual();
                aporte.ID_Estado_Financiero_Mensual = estadoActual.ID;
                aporte.Periodo_Estado_Financiero_Mensual = estadoActual.Periodo;
                cooperativa.agregarAporte(aporte);
                limpiarCampos();
                cargarAportes();
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Completado", "Aporte agregado exitosamente", "check");
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al agregar aporte", ex.Message, "error");
            }

        }

        private void agregarEstadoFinanciero()
        {
            String periodoActual = metroDateTimeFecha.Value.Month + "" + metroDateTimeFecha.Value.Year;
            EstadoFinancieroMensual estadoFinanciero = new EstadoFinancieroMensual();
            estadoFinanciero.Periodo = Convert.ToInt32(periodoActual);
            estadoFinanciero.Fecha = metroDateTimeFecha.Value;
            estadoFinanciero.Concepto = "Aporte";
            estadoFinanciero.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
            estadoFinanciero.Identificador = "S";
            cooperativa.agregarEstadoFinancieroMensual(estadoFinanciero);
        }

        private void cargarAportes()
        {
            try
            {
                metroGridAportes.DataSource = cooperativa.getAportes();
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al cargar aportes", ex.Message, "error");
            }
        }

        private string tipoAporteSeleccionado()
        {
            if (metroRadioButtonMensual.Checked)
            {
                return "M";
            }
            else if (metroRadioButtonAnual.Checked)
            {
                return "A";
            }
            else if (metroRadioButtonInteresBanco.Checked)
            {
                return "IB";
            }
            else
            {
                return "";
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
                mensaje.mostrar("Error de monto", "Ingrese un monto mayor a cero.", "error");
                return;
            }
            else
            {
                decimal montoAporte = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
                metroTextBoxMonto.Text = montoAporte.ToString("N2");
            }
        }

        private void limpiarCampos()
        {
            metroComboBoxAsociado.SelectedIndex = -1; 
            metroTextBoxDetalle.Text = "";
            metroTextBoxMonto.Text = "";
            metroDateTimeFecha.Value = DateTime.Now;
            metroRadioButtonMensual.Checked = false;
            metroRadioButtonAnual.Checked = false;
            metroRadioButtonInteresBanco.Checked = false;
        }

        private void dataGridViewAportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
