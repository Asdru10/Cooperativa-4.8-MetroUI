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
        private MensajeAUsuario mensaje = new MensajeAUsuario();

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
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error de cédula", "La cédula debe ser conformada por números", "error");
                    return;
                }
                else if (metroTextBoxCedula.Text.Trim().Length != 9 || metroTextBoxCedula.Text.Trim().Equals(""))
                {
                    metroTextBoxCedula.Focus();
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error de cédula", "La cédula debe tener 9 dígitos", "error");
                    return;
                }
                else if (metroTextBoxNombre.Text.Trim().Equals(""))
                {
                    metroTextBoxNombre.Focus();
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error de nombre", "Debe agregar un nombre", "error");
                    return;
                }
                else if (metroTextBoxPrimerApellido.Text.Trim().Equals(""))
                {
                    metroTextBoxPrimerApellido.Focus();
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error de apellido", "Debe agregar un primer apellido", "error");
                    return;
                }
                else if (metroTextBoxSegundoApellido.Text.Trim().Equals(""))
                {
                    metroTextBoxSegundoApellido.Focus();
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error de apellido", "Debe agregar un segundo apellido", "error");
                    return;
                }
                else if (metroDateTimeFechaNacimento.Value < metroDateTimeFechaNacimento.MinDate || metroDateTimeFechaNacimento.Value > metroDateTimeFechaNacimento.MaxDate)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error de fecha", "La fecha seleccionada está fuera del rango permitido.", "error");
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
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Completado", "Asociado agregado correctamente", "check");
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al agregar asociado", ex.Message, "error");
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
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al cargar asociados", ex.Message, "error");
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
