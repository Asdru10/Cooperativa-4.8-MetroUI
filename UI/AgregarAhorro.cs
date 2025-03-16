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
        private List<Ahorro> ahorros;
        private MensajeAUsuario mensaje = new MensajeAUsuario();
        private PreguntaAUsuario pregunta = new PreguntaAUsuario();
        private Ahorro ahorroSeleccionado = new Ahorro();

        public AgregarAhorro()
        {
            InitializeComponent();
        }

        private void AgregarAhorro_Load(object sender, EventArgs e)
        {
            asociados = cooperativa.getAsociados();
            metroDateTimeFecha.MinDate = new DateTime(1900, 1, 1);
            metroDateTimeFecha.MaxDate = DateTime.Now.AddYears(1);
            metroDateTimeFecha.Value = DateTime.Now;
            cargarAsociados();
            cargarAhorros();
            metroGridAhorros.Columns["Cedula_Asociado"].HeaderText = "Cédula Asociado";
            metroGridAhorros.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridAhorros.Columns["Periodo_Estado_Financiero_Mensual"].HeaderText = "Periodo";
            metroGridAhorros.Columns["Monto"].DefaultCellStyle.Format = "N2";
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
            else if (metroDateTimeFecha.Value < metroDateTimeFecha.MinDate && metroDateTimeFecha.Value > metroDateTimeFecha.MaxDate)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de fecha", "La fecha seleccionada está fuera del rango permitido.", "error");
                return;
            }

            try
            {
                if (metroButtonAgregar.Text == "Agregar")
                {
                    agregarAhorro();
                }
                else if (metroButtonAgregar.Text == "Actualizar")
                {
                    actualizarAhorro();
                }
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de ahorro", ex.Message, "error");
            }
        }

        private void agregarAhorro()
        {
            Ahorro ahorro = new Ahorro();
            ahorro.Cedula_Asociado = asociados[metroComboBoxAsociado.SelectedIndex].Cedula;
            ahorro.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
            ahorro.Fecha = metroDateTimeFecha.Value;

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

        private void actualizarAhorro()
        {
            ahorroSeleccionado.Cedula_Asociado = asociados[metroComboBoxAsociado.SelectedIndex].Cedula;
            ahorroSeleccionado.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
            ahorroSeleccionado.Fecha = metroDateTimeFecha.Value;

            EstadoFinancieroMensual estadoActual = cooperativa.getEstadoFinancieroPorID(ahorroSeleccionado.ID_Estado_Financiero_Mensual);
            estadoActual.ID = ahorroSeleccionado.ID_Estado_Financiero_Mensual;
            String periodoActual = metroDateTimeFecha.Value.Month + "" + metroDateTimeFecha.Value.Year;
            estadoActual.Periodo = Convert.ToInt32(periodoActual);
            estadoActual.Fecha = metroDateTimeFecha.Value;
            estadoActual.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());

            cooperativa.actualizarAhorro(ahorroSeleccionado);
            cooperativa.actualizarEstadoFinancieroMensual(estadoActual);

            limpiarCampos();
            cargarAhorros();
            metroButtonAgregar.Text = "Agregar";
            metroButtonEditar.Text = "Editar";
            ahorroSeleccionado = new Ahorro();
            mensaje = new MensajeAUsuario();
            mensaje.mostrar("Completado", "Ahorro actualizado exitosamente", "check");
        }

        private void agregarEstadoFinanciero()
        {
            String periodoActual = metroDateTimeFecha.Value.Month + "" + metroDateTimeFecha.Value.Year;
            EstadoFinancieroMensual estadoFinanciero = new EstadoFinancieroMensual();
            estadoFinanciero.Periodo = Convert.ToInt32(periodoActual);
            estadoFinanciero.Fecha = metroDateTimeFecha.Value;
            estadoFinanciero.Concepto = "Ahorro";
            estadoFinanciero.Monto = Convert.ToDecimal(metroTextBoxMonto.Text.Trim());
            estadoFinanciero.Identificador = "S";
            cooperativa.agregarEstadoFinancieroMensual(estadoFinanciero);
        }

        private void cargarAhorros()
        {
            try
            {
                ahorros = cooperativa.getAhorros();
                metroGridAhorros.DataSource = ahorros;
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
            metroDateTimeFecha.Value = DateTime.Now;
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
                    ahorroSeleccionado = new Ahorro();
                    return;
                }
                else if (ahorroSeleccionado.ID == 0)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error al editar ahorro", "Debe seleccionar un ahorro", "error");
                    return;
                }
                metroButtonAgregar.Text = "Actualizar";
                metroComboBoxAsociado.SelectedIndex = asociados.FindIndex(a => a.Cedula == ahorroSeleccionado.Cedula_Asociado);
                metroTextBoxMonto.Text = ahorroSeleccionado.Monto.ToString();
                metroDateTimeFecha.Value = ahorroSeleccionado.Fecha;
                metroButtonEditar.Text = "Cancelar";
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al editar ahorro", ex.Message, "error");
            }
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ahorroSeleccionado.ID == 0)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error al eliminar ahorro", "Debe seleccionar un ahorro", "error");
                    return;
                }

                DialogResult resultado;
                pregunta = new PreguntaAUsuario();
                pregunta.titulo("Eliminar ahorro");
                pregunta.mensaje("¿Está seguro que desea eliminar el ahorro seleccionado? \nEsta acción no se puede deshacer");
                resultado = pregunta.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    int idEstadoFinanciero = ahorroSeleccionado.ID_Estado_Financiero_Mensual;
                    cooperativa.eliminarAhorro(ahorroSeleccionado.ID);
                    cooperativa.eliminarEstadoFinancieroMensual(idEstadoFinanciero);
                    limpiarCampos();
                    cargarAhorros();
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Completado", "Ahorro eliminado correctamente", "check");
                }
                else
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Ahorro No Eliminado", "Ha decidido no eliminar el ahorro seleccionado", "advertencia");
                }
                ahorroSeleccionado = new Ahorro();

            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al eliminar ahorro", ex.Message, "error");
            }
        }

        private void metroGridAhorros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idAhorro = Convert.ToInt32(metroGridAhorros.Rows[e.RowIndex].Cells["ID"].Value);
                foreach (var ahorro in ahorros)
                {
                    if (ahorro.ID == idAhorro)
                    {
                        ahorroSeleccionado = ahorro;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }


    }
}
