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
        private List<Aporte> aportes;
        private MensajeAUsuario mensaje = new MensajeAUsuario();
        private PreguntaAUsuario pregunta = new PreguntaAUsuario();
        private Aporte aporteSeleccionado = new Aporte();
        private string tipoAporte = "";

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
            metroGridAportes.Columns["Nombre_Asociado"].HeaderText = "Nombre";
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
            tipoAporte = tipoAporteSeleccionado();

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
                if (metroButtonAgregar.Text.Equals("Agregar"))
                {
                    agregarAporte();
                }
                else if (metroButtonAgregar.Text.Equals("Actualizar"))
                {
                    actualizarAporte();
                }
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al agregar aporte", ex.Message, "error");
            }

        }

        private void agregarAporte()
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

        private void actualizarAporte()
        {
            aporteSeleccionado.Cedula_Asociado = asociados[metroComboBoxAsociado.SelectedIndex].Cedula;
            aporteSeleccionado.Detalle = metroTextBoxDetalle.Text.Trim();
            aporteSeleccionado.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
            aporteSeleccionado.Fecha = metroDateTimeFecha.Value;
            aporteSeleccionado.Tipo = tipoAporte;

            EstadoFinancieroMensual estadoActual = cooperativa.getEstadoFinancieroPorID(aporteSeleccionado.ID_Estado_Financiero_Mensual);
            estadoActual.ID = aporteSeleccionado.ID_Estado_Financiero_Mensual;
            String periodoActual = metroDateTimeFecha.Value.Month + "" + metroDateTimeFecha.Value.Year;
            estadoActual.Periodo = Convert.ToInt32(periodoActual);
            estadoActual.Fecha = metroDateTimeFecha.Value;
            estadoActual.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());

            cooperativa.actualizarAporte(aporteSeleccionado);
            cooperativa.actualizarEstadoFinancieroMensual(estadoActual);

            limpiarCampos();
            cargarAportes();
            metroButtonAgregar.Text = "Agregar";
            metroButtonEditar.Text = "Editar";
            aporteSeleccionado = new Aporte();
            mensaje = new MensajeAUsuario();
            mensaje.mostrar("Completado", "Aporte actualizado exitosamente", "check");
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
                aportes = cooperativa.getAportes();
                metroGridAportes.DataSource = aportes;
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

        private void metroGridAportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idAporte = Convert.ToInt32(metroGridAportes.Rows[e.RowIndex].Cells["ID"].Value);
                foreach (var aporte in aportes)
                {
                    if (aporte.ID == idAporte)
                    {
                        aporteSeleccionado = aporte;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroButtonEditar.Text == "Cancelar")
                {
                    limpiarCampos();
                    metroButtonAgregar.Text = "Agregar";
                    metroButtonEditar.Text = "Editar";
                    aporteSeleccionado = new Aporte();
                    return;
                }
                else if (aporteSeleccionado.ID == 0)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error al editar aporte", "Debe seleccionar un aporte", "error");
                    return;
                }
                metroButtonAgregar.Text = "Actualizar";
                metroButtonEditar.Text = "Cancelar";
                metroComboBoxAsociado.SelectedIndex = asociados.FindIndex(x => x.Cedula == aporteSeleccionado.Cedula_Asociado);
                metroTextBoxDetalle.Text = aporteSeleccionado.Detalle;
                metroTextBoxMonto.Text = aporteSeleccionado.Monto.ToString();
                metroDateTimeFecha.Value = aporteSeleccionado.Fecha;
                switch (aporteSeleccionado.Tipo)
                {
                    case "M":
                        metroRadioButtonMensual.Checked = true;
                        break;
                    case "A":
                        metroRadioButtonAnual.Checked = true;
                        break;
                    case "IB":
                        metroRadioButtonInteresBanco.Checked = true;
                        break;
                }

            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al editar aporte", ex.Message, "error");
            }
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (aporteSeleccionado.ID == 0)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error al eliminar aporte", "Debe seleccionar un aporte", "error");
                    return;
                }

                DialogResult resultado;
                pregunta = new PreguntaAUsuario();
                pregunta.titulo("Eliminar aporte");
                pregunta.mensaje("¿Está seguro que desea eliminar el aporte seleccionado? \nEsta acción no se puede deshacer");
                resultado = pregunta.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    int idEstadoFinanciero = aporteSeleccionado.ID_Estado_Financiero_Mensual;
                    cooperativa.eliminarAporte(aporteSeleccionado.ID);
                    cooperativa.eliminarEstadoFinancieroMensual(idEstadoFinanciero);
                    limpiarCampos();
                    cargarAportes();
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Completado", "Aporte eliminado correctamente", "check");
                }
                else
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Aporte No Eliminado", "Ha decidido no eliminar el aporte seleccionado", "advertencia");
                }
                aporteSeleccionado = new Aporte();

            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al eliminar aporte", ex.Message, "error");
            }
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
