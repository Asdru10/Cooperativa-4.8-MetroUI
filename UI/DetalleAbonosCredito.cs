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
        private Credito creditoAcutal;

        public DetalleAbonosCredito()
        {
            InitializeComponent();
        }

        private void DetalleAbonosCredito_Load(object sender, EventArgs e)
        {
            asociados = cooperativa.getAsociados();
            cargarAsociados();
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

            metroGridAbonos.DataSource = new List<Abono>();
            metroGridAbonos.Columns["ID_Credito"].HeaderText = "ID Crédito";
            metroGridAbonos.Columns["ID_Estado_Financiero_Mensual"].Visible = false;
            metroGridAbonos.Columns["Periodo_Estado_Financiero_Mensual"].HeaderText = "Periodo";
            metroGridAbonos.Columns["Abono_Capital"].HeaderText = "Abono al Capital";
            metroGridAbonos.Columns["Abono_Interes"].HeaderText = "Abono a Intereses";
            metroGridAbonos.Columns["Abono_Total"].HeaderText = "Abono Total";


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

        private void metroComboBoxAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCreditos();
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
                    MessageBox.Show("El crédito no tiene abonos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                return;
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
