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
    public partial class DetalleAbonosCredito : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();
        private List<Asociado> asociados;
        private List<Credito> creditosActivos;
        private List<Credito> creditosCancelados;
        private List<Abono> abonos;
        private MensajeAUsuario mensaje = new MensajeAUsuario();
        private PreguntaAUsuario pregunta = new PreguntaAUsuario();
        private Credito creditoAcutal = new Credito();
        private Abono abonoSeleccionado = new Abono();
        private string tipo = "T";

        public DetalleAbonosCredito()
        {
            InitializeComponent();
        }

        private void DetalleAbonosCredito_Load(object sender, EventArgs e)
        {
            asociados = cooperativa.getAsociados();
            cargarAsociados();
            metroRadioButtonTodos.Checked = true;
            metroGridCreditos.DataSource = new List<Credito>();
            //metroGridCreditos.Columns["Cedula_Asociado"].HeaderText = "Cédula Asociado";
            metroGridCreditos.Columns["Cedula_Asociado"].Visible = false;
            metroGridCreditos.Columns["Nombre_Asociado"].Visible = false;
            metroGridCreditos.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridCreditos.Columns["Periodo_Estado_Financiero_Mensual"].HeaderText = "Periodo";
            metroGridCreditos.Columns["Fecha_Desembolso"].HeaderText = "Desembolso";
            metroGridCreditos.Columns["Fecha_Final"].HeaderText = "Vencimiento";
            metroGridCreditos.Columns["Capital_Desembolsado"].HeaderText = "Capital Crédito";
            metroGridCreditos.Columns["Capital_Cancelado"].HeaderText = "Capital Cancelado";
            metroGridCreditos.Columns["Saldo_Capital"].HeaderText = "Saldo de Capital";
            metroGridCreditos.Columns["Intereses_Cancelados"].HeaderText = "Intereses Cancelados";
            metroGridCreditos.Columns["Saldo_Intereses"].HeaderText = "Saldo de Intereses";
            metroGridCreditos.Columns["Saldo_Total"].HeaderText = "Saldo Total";
            metroGridCreditos.Columns["Cuota_Mensual"].Visible = false;
            metroGridCreditos.Columns["Cuota_Intereses"].Visible = false;
            metroGridCreditos.Columns["Total_Cuota"].HeaderText = "Cuota Mensual";
            metroGridCreditos.Columns["Total_Credito"].HeaderText = "Crédito Total";

            metroGridCreditos.Columns["Capital_Desembolsado"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Capital_Cancelado"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Saldo_Capital"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Intereses"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Intereses_Cancelados"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Saldo_Intereses"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Saldo_Total"].DefaultCellStyle.Format = "N2";
            metroGridCreditos.Columns["Total_Cuota"].DefaultCellStyle.Format = "N2";
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

        private void cargarCreditos(string tipo)
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
                    metroGridCreditos.DataSource = new List<Credito>();
                    metroGridAbonos.DataSource = new List<Abono>();
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Aviso", "El asociado no tiene créditos", "info");
                    return;
                }

                switch (tipo)
                {
                    case "T":
                        metroGridCreditos.DataSource = creditos;
                        break;

                    case "A":
                        creditosActivos = new List<Credito>();
                        foreach (var credito in creditos)
                        {
                            if (!credito.Estado.Equals("Cancelado"))
                            {
                                creditosActivos.Add(credito);
                            }
                        }

                        if (creditosActivos.Count == 0)
                        {
                            metroGridCreditos.DataSource = new List<Credito>();
                            metroGridAbonos.DataSource = new List<Abono>();
                            mensaje = new MensajeAUsuario();
                            mensaje.mostrar("Aviso", "El asociado no tiene créditos activos", "info");
                        }
                        metroGridCreditos.DataSource = creditosActivos;
                        break;

                    case "C":
                        creditosCancelados = new List<Credito>();
                        foreach (var credito in creditos)
                        {
                            if (credito.Estado.Equals("Cancelado"))
                            {
                                creditosCancelados.Add(credito);
                            }
                        }

                        if (creditosCancelados.Count == 0)
                        {
                            metroGridCreditos.DataSource = new List<Credito>();
                            metroGridAbonos.DataSource = new List<Abono>();
                            mensaje = new MensajeAUsuario();
                            mensaje.mostrar("Aviso", "El asociado no tiene créditos cancelados", "info");
                        }
                        metroGridCreditos.DataSource = creditosCancelados;
                        break;
                }

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

        private void metroComboBoxAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCreditos(tipo);
        }

        private void metroGridCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)metroGridCreditos.Rows[e.RowIndex].Cells["ID"].Value;
                creditoAcutal = cooperativa.getCreditoPorID(id);
                abonos = cooperativa.getAbonosCredito(id);
                metroGridAbonos.DataSource = abonos;
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

        private void metroGridAbonos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(metroGridAbonos.Rows[e.RowIndex].Cells["ID"].Value);
                foreach (var abono in abonos)
                {
                    if (abono.ID == id)
                    {
                        abonoSeleccionado = abono;
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

        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (abonoSeleccionado.ID == 0)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error al eliminar abono", "Debe seleccionar un abono", "error");
                    return;
                }
                else if (creditoAcutal.Estado.Equals("Cancelado"))
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error al eliminar abono", "No se pueden eliminar abonos de un crédito cancelado", "error");
                    return;
                }

                DialogResult resultado;
                pregunta = new PreguntaAUsuario();
                pregunta.titulo("Eliminar abono");
                pregunta.mensaje("¿Está seguro que desea eliminar el abono seleccionado? \nEsta acción no se puede deshacer");
                resultado = pregunta.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    int idEstadoFinanciero = abonoSeleccionado.ID_Estado_Financiero_Mensual;
                    cooperativa.eliminarAbono(abonoSeleccionado.ID);
                    cooperativa.eliminarEstadoFinancieroMensual(idEstadoFinanciero);
                    rollbackCredito();
                    cargarCreditos(tipo);
                    metroGridAbonos.DataSource = cooperativa.getAbonosCredito(creditoAcutal.ID);
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Completado", "Abono eliminado correctamente", "check");
                }
                else
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Abono No Eliminado", "Ha decidido no eliminar el abono seleccionado", "advertencia");
                }
                abonoSeleccionado = new Abono();

            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al eliminar abono", ex.Message, "error");
            }
        }

        private void rollbackCredito()
        {
            creditoAcutal.Capital_Cancelado -= abonoSeleccionado.Abono_Capital;
            creditoAcutal.Saldo_Capital += abonoSeleccionado.Abono_Capital;
            creditoAcutal.Intereses_Cancelados -= abonoSeleccionado.Abono_Interes;
            creditoAcutal.Saldo_Intereses += abonoSeleccionado.Abono_Interes;
            creditoAcutal.Saldo_Total += abonoSeleccionado.Abono_Total;
            cooperativa.actualizarCredito(creditoAcutal);
        }

        private void metroRadioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButtonTodos.Checked)
            {
                tipo = "T";
                cargarCreditos(tipo);
            }
            else if (metroRadioButtonActivos.Checked)
            {
                tipo = "A";
                cargarCreditos(tipo);
            }
            else if (metroRadioButtonCancelados.Checked)
            {
                tipo = "C";
                cargarCreditos(tipo);
            }
        }

        private void metroRadioButtonActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButtonTodos.Checked)
            {
                tipo = "T";
                cargarCreditos(tipo);
            }
            else if (metroRadioButtonActivos.Checked)
            {
                tipo = "A";
                cargarCreditos(tipo);
            }
            else if (metroRadioButtonCancelados.Checked)
            {
                tipo = "C";
                cargarCreditos(tipo);
            }
        }

        private void metroRadioButtonCancelados_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButtonTodos.Checked)
            {
                tipo = "T";
                cargarCreditos(tipo);
            }
            else if (metroRadioButtonActivos.Checked)
            {
                tipo = "A";
                cargarCreditos(tipo);
            }
            else if (metroRadioButtonCancelados.Checked)
            {
                tipo = "C";
                cargarCreditos(tipo);
            }
        }

        private void dataGridViewCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroGridCreditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
