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
    }
}
