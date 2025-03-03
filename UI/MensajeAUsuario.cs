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
    public partial class MensajeAUsuario : MetroForm
    {
        public MensajeAUsuario()
        {
            InitializeComponent();
        }

        private void MensajeAUsuario_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void titulo(string texto)
        {
            this.Text = texto;
        }

        public void mensaje(string texto)
        {
            this.metroLabelTexto.Text = texto;
        }

        public void icono(string icono)
        {
            switch (icono)
            {
                case "error":
                    this.pictureBoxIcono.Image = Properties.Resources.error;
                    break;
                case "advertencia":
                    this.pictureBoxIcono.Image = Properties.Resources.advertencia;
                    break;
                case "info":
                    this.pictureBoxIcono.Image = Properties.Resources.info;
                    break;
                case "check":
                    this.pictureBoxIcono.Image = Properties.Resources.check;
                    break;
                default:
                    this.pictureBoxIcono.Image = Properties.Resources.info;
                    break;
            }
        }

        public void mostrar(string titulo, string mensaje, string icono)
        {
            this.titulo(titulo);
            this.mensaje(mensaje);
            this.icono(icono);
            this.ShowDialog();
        }

        private void metroLabelTexto_Click(object sender, EventArgs e)
        {

        }
    }
}
