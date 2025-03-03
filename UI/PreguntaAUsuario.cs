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
    public partial class PreguntaAUsuario : MetroForm
    {
        public PreguntaAUsuario()
        {
            InitializeComponent();
        }

        private void PreguntaAUsuario_Load(object sender, EventArgs e)
        {
            this.pictureBoxIcono.Image = Properties.Resources.pregunta;
        }

        public void titulo(string texto)
        {
            this.Text = texto;
        }

        public void mensaje(string texto)
        {
            this.metroLabelTexto.Text = texto;
        }

        private void metroButtonSi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void metroButtonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void PreguntaAUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
