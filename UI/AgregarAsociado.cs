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
    public partial class AgregarAsociado : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();

        public AgregarAsociado()
        {
            InitializeComponent();
        }

        private void AgregarAsociado_Load(object sender, EventArgs e)
        {
            cargarAsociados();
            metroGridAsociados.Columns["Primer_Apellido"].HeaderText = "Primer Apellido";
            metroGridAsociados.Columns["Segundo_Apellido"].HeaderText = "Segundo Apellido";
            metroGridAsociados.Columns["Fecha_Nacimiento"].HeaderText = "Fecha de Nacimiento";
            metroDateTimeFechaNacimento.MinDate = new DateTime(1900, 1, 1);
            metroDateTimeFechaNacimento.MaxDate = DateTime.Now.AddYears(1);
            metroDateTimeFechaNacimento.Value = DateTime.Now;
        }

        private void metroButtonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(metroTextBoxCedula.Text.Trim(), out int cedula))
                {
                    metroTextBoxCedula.Focus();
                    MessageBox.Show("La cédula debe ser conformada por números", "Error de cédula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (metroTextBoxCedula.Text.Trim().Length != 9 || metroTextBoxCedula.Text.Trim().Equals(""))
                {
                    metroTextBoxCedula.Focus();
                    MessageBox.Show("La cédula debe tener 9 dígitos", "Error de cédula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (metroTextBoxNombre.Text.Trim().Equals(""))
                {
                    metroTextBoxNombre.Focus();
                    MessageBox.Show("Debe agregar un nombre", "Error de nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (metroTextBoxPrimerApellido.Text.Trim().Equals(""))
                {
                    metroTextBoxPrimerApellido.Focus();
                    MessageBox.Show("Debe agregar un primer apellido", "Error de apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (metroTextBoxSegundoApellido.Text.Trim().Equals(""))
                {
                    metroTextBoxSegundoApellido.Focus();
                    MessageBox.Show("Debe agregar un segundo apellido", "Error de apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (metroDateTimeFechaNacimento.Value < metroDateTimeFechaNacimento.MinDate || metroDateTimeFechaNacimento.Value > metroDateTimeFechaNacimento.MaxDate)
                {
                    MessageBox.Show("La fecha seleccionada está fuera del rango permitido.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Asociado asociado = new Asociado();
                asociado.Cedula = Convert.ToInt32(metroTextBoxCedula.Text.Trim());
                asociado.Nombre = metroTextBoxNombre.Text.Trim();
                asociado.Primer_Apellido = metroTextBoxPrimerApellido.Text.Trim();
                asociado.Segundo_Apellido = metroTextBoxSegundoApellido.Text.Trim();
                asociado.Fecha_Nacimiento = metroDateTimeFechaNacimento.Value;

                cooperativa.agregarAsociado(asociado);
                limpiarCampos();
                cargarAsociados();
                MessageBox.Show("Asociado agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar asociado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxPrimerApellid5o_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarAsociados()
        {
            try
            {
                metroGridAsociados.DataSource = cooperativa.getAsociados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar asociados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            metroTextBoxCedula.Text = "";
            metroTextBoxNombre.Text = "";
            metroTextBoxPrimerApellido.Text = "";
            metroTextBoxSegundoApellido.Text = "";
            metroDateTimeFechaNacimento.Value = DateTime.Now;
        }

        private void dataGridViewAsociados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxPrimerApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
