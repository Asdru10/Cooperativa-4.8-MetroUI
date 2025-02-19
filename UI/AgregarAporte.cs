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

        
        private void metroButtonAgregar_Click(object sender, EventArgs e)
        {
            string tipoAporte = tipoAporteSeleccionado();

            if (metroComboBoxAsociado.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un asociado", "Error de asociado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroComboBoxAsociado.DroppedDown = true;
                return;
            }
            else if (metroTextBoxDetalle.Text.Trim().Equals(""))
            {
                metroTextBoxDetalle.Focus();
                MessageBox.Show("Ingrese un detalle", "Error de detalle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!decimal.TryParse(metroTextBoxMonto.Text.Trim(), out decimal monto))
            {
                metroTextBoxMonto.Focus();
                MessageBox.Show("Debe ingresar un monto utlizando una coma (,) como separador de decimales.", "Error de monto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(metroTextBoxMonto.Text.Trim()) <= 0)
            {
                metroTextBoxMonto.Focus();
                MessageBox.Show("Ingrese un monto válido", "Error de monto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (metroDateTimeFecha.Value < metroDateTimeFecha.MinDate && metroDateTimeFecha.Value > metroDateTimeFecha.MaxDate)
            {
                MessageBox.Show("La fecha seleccionada está fuera del rango permitido.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tipoAporte.Equals(""))
            {
                MessageBox.Show("Seleccione un tipo de aporte", "Error de tipo de aporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Aporte agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar aporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error al cargar aportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
