using BL;
using DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using MetroFramework.Forms;
using MetroFramework;

namespace UI
{
    public partial class MenuPrincipal : MetroForm
    {
        private CooperativaManager cooperativa = new CooperativaManager();
        private Timer dailyTimer;


        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
        }

        private void buttonAgregarAporte_Click(object sender, EventArgs e)
        {
        }

        private void buttonAgregarAhorro_Click(object sender, EventArgs e)
        {
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            verificarCreditosAtrasados();
            ConfigureDailyTask();
            MensajeAUsuario mensajeAUsuario = new MensajeAUsuario();
            //mensajeAUsuario.mostrar("Bienvenida", "Debe ingresar un monto utlizando una coma (,) como separador de decimales.", "Info");
            //MetroMessageBox.Show(this, "Bienvenido a la Cooperativa", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void verificarCreditosAtrasados()
        {
            DateTime fechaActual = DateTime.Now.Date;
            int mesActual = fechaActual.Month;
            int annoActual = fechaActual.Year;
            decimal saldoTotal = 0;

            List<Credito> creditosActivos = cooperativa.getCreditosActivos();

            foreach (Credito credito in creditosActivos)
            {
                if (credito.Fecha_Final < fechaActual)
                {
                    credito.Estado = "Vencido";
                    continue;
                }
                else
                {

                    List<ProyeccionPagoCredito> proyecciones = cooperativa.getProyeccionesCredito(credito.ID);

                    for (int i = 0; i < proyecciones.Count; i++)
                    {
                        if (proyecciones[i].Fecha.Month == mesActual && proyecciones[i].Fecha.Year == annoActual)
                        {
                            saldoTotal = proyecciones[i].Saldo_Total;
                            if (saldoTotal >= credito.Saldo_Total)
                            {
                                credito.Estado = "Al día";
                                break;
                            }
                            else //if (saldoTotal < credito.Saldo_Total)
                            {
                                credito.Estado = "Atrasado";
                                break;
                            }
                        }
                    }
                }
            }

            cooperativa.actualizarEstadoCreditos(creditosActivos);
        }

        private void estadoDeCuentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EstadoCta estadoCta = new EstadoCta();

            estadoCta.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            estadoCta.Show();
        }

        private void ahorroExtraordinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAhorro agregarAhorro = new AgregarAhorro();

            agregarAhorro.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            agregarAhorro.Show();
        }

        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAporte agregarAporte = new AgregarAporte();

            agregarAporte.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            agregarAporte.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAsociado agregarAsociado = new AgregarAsociado();

            agregarAsociado.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            agregarAsociado.Show();
        }

        private void nuevaSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCredito agregarCredito = new AgregarCredito();

            agregarCredito.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            agregarCredito.Show();
        }

        private void ConfigureDailyTask()
        {
            dailyTimer = new Timer(60000);
            dailyTimer.Elapsed += CheckDailyTask;
            dailyTimer.AutoReset = true;
            dailyTimer.Start();
        }

        private void CheckDailyTask(object sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;

            if (now.Hour == 24 && now.Minute == 0)
            {
                verificarCreditosAtrasados();
            }
        }

        private void abonoACréditoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbonoCredito abonoCredito = new AbonoCredito();

            abonoCredito.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            abonoCredito.Show();
        }

        private void reporteDeCréditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleAbonosCredito detalleAbonosCredito = new DetalleAbonosCredito();

            detalleAbonosCredito.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            detalleAbonosCredito.Show();
        }

        private void detalleDeAbonosACréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleAbonosCredito detalleAbonosCredito = new DetalleAbonosCredito();

            detalleAbonosCredito.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            detalleAbonosCredito.Show();

        }

        private void estadosFinancierosAlDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoFinancieroHoy estadoFinancieroHoy = new EstadoFinancieroHoy();

            estadoFinancieroHoy.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            estadoFinancieroHoy.Show();

        }

        private void cierreMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CierreMensual cierreMensual = new CierreMensual();

            cierreMensual.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            cierreMensual.mensual = true;
            cierreMensual.anual = false;
            cierreMensual.Show();
        }

        private void cieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CierreMensual cierreMensual = new CierreMensual();

            cierreMensual.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            cierreMensual.mensual = false;
            cierreMensual.anual = true;
            cierreMensual.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transacciones transacciones = new Transacciones();

            transacciones.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();

            transacciones.Show();
        }
    }
}
