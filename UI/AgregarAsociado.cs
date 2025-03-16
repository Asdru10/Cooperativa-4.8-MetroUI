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
        private PreguntaAUsuario pregunta = new PreguntaAUsuario();
        private Asociado asociadoSeleccionado = new Asociado();

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

                if (metroButtonAgregar.Text.Equals("Agregar"))
                {
                    agregarAsociado();
                }
                else if (metroButtonAgregar.Text.Equals("Actualizar"))
                {
                    actualizarAsociado();
                }

            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error de asociado", ex.Message, "error");
            }
        }

        private void agregarAsociado()
        {
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

        private void actualizarAsociado()
        {
            asociadoSeleccionado.Nombre = metroTextBoxNombre.Text.Trim();
            asociadoSeleccionado.Primer_Apellido = metroTextBoxPrimerApellido.Text.Trim();
            asociadoSeleccionado.Segundo_Apellido = metroTextBoxSegundoApellido.Text.Trim();
            asociadoSeleccionado.Fecha_Nacimiento = metroDateTimeFechaNacimento.Value;
            cooperativa.actualizarAsociado(asociadoSeleccionado);
            limpiarCampos();
            cargarAsociados();
            metroButtonAgregar.Text = "Agregar";
            metroButtonEditar.Text = "Editar";
            metroTextBoxCedula.ReadOnly = false;
            asociadoSeleccionado = new Asociado();
            mensaje = new MensajeAUsuario();
            mensaje.mostrar("Completado", "Asociado actualizado correctamente", "check");
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

        private void metroGridAsociados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int cedula = Convert.ToInt32(metroGridAsociados.Rows[e.RowIndex].Cells["Cedula"].Value);
                asociadoSeleccionado = cooperativa.getAsociadoPorCedula(cedula);
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
                if (metroButtonEditar.Text.Equals("Cancelar"))
                {
                    limpiarCampos();
                    metroButtonAgregar.Text = "Agregar";
                    metroButtonEditar.Text = "Editar";
                    metroTextBoxCedula.ReadOnly = false;
                    asociadoSeleccionado = new Asociado();
                    return;
                }
                else if (asociadoSeleccionado.Cedula == 0)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error al editar asociado", "Debe seleccionar un asociado", "error");
                    return;
                }
                metroButtonAgregar.Text = "Actualizar";
                metroTextBoxCedula.Text = asociadoSeleccionado.Cedula.ToString();
                metroTextBoxCedula.ReadOnly = true;
                metroTextBoxNombre.Text = asociadoSeleccionado.Nombre;
                metroTextBoxPrimerApellido.Text = asociadoSeleccionado.Primer_Apellido;
                metroTextBoxSegundoApellido.Text = asociadoSeleccionado.Segundo_Apellido;
                metroDateTimeFechaNacimento.Value = asociadoSeleccionado.Fecha_Nacimiento;
                metroButtonEditar.Text = "Cancelar";
            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al editar asociado", ex.Message, "error");
            }
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (asociadoSeleccionado.Cedula == 0)
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Error al eliminar asociado", "Debe seleccionar un asociado", "error");
                    return;
                }

                DialogResult resultado;
                pregunta = new PreguntaAUsuario();
                pregunta.titulo("Eliminar asociado");
                pregunta.mensaje("¿Está seguro que desea eliminar a " + asociadoSeleccionado.Nombre + " como asociado? \nEsta acción no se puede deshacer");
                resultado = pregunta.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    cooperativa.eliminarAsociado(asociadoSeleccionado.Cedula);
                    limpiarCampos();
                    cargarAsociados();
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Completado", "Asociado eliminado correctamente", "check");
                }
                else
                {
                    mensaje = new MensajeAUsuario();
                    mensaje.mostrar("Asociado No Eliminado", "Ha decidido no eliminar a " + asociadoSeleccionado.Nombre, "advertencia");
                }
                asociadoSeleccionado = new Asociado();

            }
            catch (Exception ex)
            {
                mensaje = new MensajeAUsuario();
                mensaje.mostrar("Error al eliminar asociado", ex.Message, "error");
            }
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

        private void textBoxPrimerApellid5o_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
