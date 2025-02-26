using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class AbonoCredito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroComboBoxAsociado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelAsociado = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxSaldoActual = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelSaldoActual = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNuevoSaldo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelNuevoSaldo = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxMontoAbono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelMontoAbono = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeFechaAbono = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelFechaAbono = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAbonar = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancelacionTotal = new MetroFramework.Controls.MetroButton();
            this.metroGridCreditos = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBoxAsociado
            // 
            this.metroComboBoxAsociado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBoxAsociado.FormattingEnabled = true;
            this.metroComboBoxAsociado.ItemHeight = 29;
            this.metroComboBoxAsociado.Location = new System.Drawing.Point(160, 73);
            this.metroComboBoxAsociado.Name = "metroComboBoxAsociado";
            this.metroComboBoxAsociado.Size = new System.Drawing.Size(435, 35);
            this.metroComboBoxAsociado.TabIndex = 48;
            this.metroComboBoxAsociado.UseSelectable = true;
            this.metroComboBoxAsociado.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxAsociado_SelectedIndexChanged);
            // 
            // metroLabelAsociado
            // 
            this.metroLabelAsociado.AutoSize = true;
            this.metroLabelAsociado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAsociado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAsociado.Location = new System.Drawing.Point(23, 73);
            this.metroLabelAsociado.Name = "metroLabelAsociado";
            this.metroLabelAsociado.Size = new System.Drawing.Size(95, 25);
            this.metroLabelAsociado.TabIndex = 47;
            this.metroLabelAsociado.Text = "Asociado:";
            // 
            // metroTextBoxSaldoActual
            // 
            // 
            // 
            // 
            this.metroTextBoxSaldoActual.CustomButton.Image = null;
            this.metroTextBoxSaldoActual.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.metroTextBoxSaldoActual.CustomButton.Name = "";
            this.metroTextBoxSaldoActual.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxSaldoActual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSaldoActual.CustomButton.TabIndex = 1;
            this.metroTextBoxSaldoActual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSaldoActual.CustomButton.UseSelectable = true;
            this.metroTextBoxSaldoActual.CustomButton.Visible = false;
            this.metroTextBoxSaldoActual.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxSaldoActual.Lines = new string[0];
            this.metroTextBoxSaldoActual.Location = new System.Drawing.Point(181, 345);
            this.metroTextBoxSaldoActual.MaxLength = 32767;
            this.metroTextBoxSaldoActual.Name = "metroTextBoxSaldoActual";
            this.metroTextBoxSaldoActual.PasswordChar = '\0';
            this.metroTextBoxSaldoActual.ReadOnly = true;
            this.metroTextBoxSaldoActual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSaldoActual.SelectedText = "";
            this.metroTextBoxSaldoActual.SelectionLength = 0;
            this.metroTextBoxSaldoActual.SelectionStart = 0;
            this.metroTextBoxSaldoActual.ShortcutsEnabled = true;
            this.metroTextBoxSaldoActual.Size = new System.Drawing.Size(255, 35);
            this.metroTextBoxSaldoActual.TabIndex = 77;
            this.metroTextBoxSaldoActual.UseSelectable = true;
            this.metroTextBoxSaldoActual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSaldoActual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelSaldoActual
            // 
            this.metroLabelSaldoActual.AutoSize = true;
            this.metroLabelSaldoActual.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelSaldoActual.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelSaldoActual.Location = new System.Drawing.Point(23, 345);
            this.metroLabelSaldoActual.Name = "metroLabelSaldoActual";
            this.metroLabelSaldoActual.Size = new System.Drawing.Size(124, 25);
            this.metroLabelSaldoActual.TabIndex = 76;
            this.metroLabelSaldoActual.Text = "Saldo Actual:";
            // 
            // metroTextBoxNuevoSaldo
            // 
            // 
            // 
            // 
            this.metroTextBoxNuevoSaldo.CustomButton.Image = null;
            this.metroTextBoxNuevoSaldo.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.metroTextBoxNuevoSaldo.CustomButton.Name = "";
            this.metroTextBoxNuevoSaldo.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxNuevoSaldo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNuevoSaldo.CustomButton.TabIndex = 1;
            this.metroTextBoxNuevoSaldo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNuevoSaldo.CustomButton.UseSelectable = true;
            this.metroTextBoxNuevoSaldo.CustomButton.Visible = false;
            this.metroTextBoxNuevoSaldo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxNuevoSaldo.Lines = new string[0];
            this.metroTextBoxNuevoSaldo.Location = new System.Drawing.Point(181, 398);
            this.metroTextBoxNuevoSaldo.MaxLength = 32767;
            this.metroTextBoxNuevoSaldo.Name = "metroTextBoxNuevoSaldo";
            this.metroTextBoxNuevoSaldo.PasswordChar = '\0';
            this.metroTextBoxNuevoSaldo.ReadOnly = true;
            this.metroTextBoxNuevoSaldo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNuevoSaldo.SelectedText = "";
            this.metroTextBoxNuevoSaldo.SelectionLength = 0;
            this.metroTextBoxNuevoSaldo.SelectionStart = 0;
            this.metroTextBoxNuevoSaldo.ShortcutsEnabled = true;
            this.metroTextBoxNuevoSaldo.Size = new System.Drawing.Size(255, 35);
            this.metroTextBoxNuevoSaldo.TabIndex = 79;
            this.metroTextBoxNuevoSaldo.UseSelectable = true;
            this.metroTextBoxNuevoSaldo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNuevoSaldo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelNuevoSaldo
            // 
            this.metroLabelNuevoSaldo.AutoSize = true;
            this.metroLabelNuevoSaldo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelNuevoSaldo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelNuevoSaldo.Location = new System.Drawing.Point(23, 398);
            this.metroLabelNuevoSaldo.Name = "metroLabelNuevoSaldo";
            this.metroLabelNuevoSaldo.Size = new System.Drawing.Size(125, 25);
            this.metroLabelNuevoSaldo.TabIndex = 78;
            this.metroLabelNuevoSaldo.Text = "Nuevo Saldo:";
            // 
            // metroTextBoxMontoAbono
            // 
            // 
            // 
            // 
            this.metroTextBoxMontoAbono.CustomButton.Image = null;
            this.metroTextBoxMontoAbono.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.metroTextBoxMontoAbono.CustomButton.Name = "";
            this.metroTextBoxMontoAbono.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxMontoAbono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMontoAbono.CustomButton.TabIndex = 1;
            this.metroTextBoxMontoAbono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMontoAbono.CustomButton.UseSelectable = true;
            this.metroTextBoxMontoAbono.CustomButton.Visible = false;
            this.metroTextBoxMontoAbono.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxMontoAbono.Lines = new string[0];
            this.metroTextBoxMontoAbono.Location = new System.Drawing.Point(747, 345);
            this.metroTextBoxMontoAbono.MaxLength = 32767;
            this.metroTextBoxMontoAbono.Name = "metroTextBoxMontoAbono";
            this.metroTextBoxMontoAbono.PasswordChar = '\0';
            this.metroTextBoxMontoAbono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMontoAbono.SelectedText = "";
            this.metroTextBoxMontoAbono.SelectionLength = 0;
            this.metroTextBoxMontoAbono.SelectionStart = 0;
            this.metroTextBoxMontoAbono.ShortcutsEnabled = true;
            this.metroTextBoxMontoAbono.Size = new System.Drawing.Size(239, 35);
            this.metroTextBoxMontoAbono.TabIndex = 81;
            this.metroTextBoxMontoAbono.UseSelectable = true;
            this.metroTextBoxMontoAbono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMontoAbono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxMontoAbono.Leave += new System.EventHandler(this.metroTextBoxMontoAbono_Leave);
            // 
            // metroLabelMontoAbono
            // 
            this.metroLabelMontoAbono.AutoSize = true;
            this.metroLabelMontoAbono.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMontoAbono.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelMontoAbono.Location = new System.Drawing.Point(605, 345);
            this.metroLabelMontoAbono.Name = "metroLabelMontoAbono";
            this.metroLabelMontoAbono.Size = new System.Drawing.Size(136, 25);
            this.metroLabelMontoAbono.TabIndex = 80;
            this.metroLabelMontoAbono.Text = "Monto Abono:";
            // 
            // metroDateTimeFechaAbono
            // 
            this.metroDateTimeFechaAbono.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.metroDateTimeFechaAbono.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFechaAbono.Location = new System.Drawing.Point(181, 451);
            this.metroDateTimeFechaAbono.MinimumSize = new System.Drawing.Size(0, 35);
            this.metroDateTimeFechaAbono.Name = "metroDateTimeFechaAbono";
            this.metroDateTimeFechaAbono.Size = new System.Drawing.Size(182, 35);
            this.metroDateTimeFechaAbono.TabIndex = 82;
            // 
            // metroLabelFechaAbono
            // 
            this.metroLabelFechaAbono.AutoSize = true;
            this.metroLabelFechaAbono.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelFechaAbono.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelFechaAbono.Location = new System.Drawing.Point(21, 451);
            this.metroLabelFechaAbono.Name = "metroLabelFechaAbono";
            this.metroLabelFechaAbono.Size = new System.Drawing.Size(154, 25);
            this.metroLabelFechaAbono.TabIndex = 83;
            this.metroLabelFechaAbono.Text = "Fecha de Abono:";
            // 
            // metroButtonAbonar
            // 
            this.metroButtonAbonar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonAbonar.Location = new System.Drawing.Point(412, 510);
            this.metroButtonAbonar.Name = "metroButtonAbonar";
            this.metroButtonAbonar.Size = new System.Drawing.Size(110, 50);
            this.metroButtonAbonar.TabIndex = 84;
            this.metroButtonAbonar.Text = "Abonar";
            this.metroButtonAbonar.UseSelectable = true;
            this.metroButtonAbonar.Click += new System.EventHandler(this.metroButtonAbonar_Click);
            // 
            // metroButtonCancelacionTotal
            // 
            this.metroButtonCancelacionTotal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonCancelacionTotal.Location = new System.Drawing.Point(747, 398);
            this.metroButtonCancelacionTotal.Name = "metroButtonCancelacionTotal";
            this.metroButtonCancelacionTotal.Size = new System.Drawing.Size(239, 43);
            this.metroButtonCancelacionTotal.TabIndex = 85;
            this.metroButtonCancelacionTotal.Text = "Cancelación Total";
            this.metroButtonCancelacionTotal.UseSelectable = true;
            this.metroButtonCancelacionTotal.Click += new System.EventHandler(this.metroButtonCancelacionTotal_Click);
            // 
            // metroGridCreditos
            // 
            this.metroGridCreditos.AllowUserToResizeRows = false;
            this.metroGridCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.metroGridCreditos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridCreditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridCreditos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.metroGridCreditos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCreditos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridCreditos.EnableHeadersVisualStyles = false;
            this.metroGridCreditos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCreditos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCreditos.Location = new System.Drawing.Point(23, 136);
            this.metroGridCreditos.Name = "metroGridCreditos";
            this.metroGridCreditos.ReadOnly = true;
            this.metroGridCreditos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCreditos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridCreditos.RowHeadersWidth = 51;
            this.metroGridCreditos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCreditos.RowTemplate.Height = 24;
            this.metroGridCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridCreditos.Size = new System.Drawing.Size(966, 186);
            this.metroGridCreditos.TabIndex = 86;
            this.metroGridCreditos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridCreditos_CellClick);
            // 
            // AbonoCredito
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 581);
            this.Controls.Add(this.metroGridCreditos);
            this.Controls.Add(this.metroButtonCancelacionTotal);
            this.Controls.Add(this.metroButtonAbonar);
            this.Controls.Add(this.metroDateTimeFechaAbono);
            this.Controls.Add(this.metroLabelFechaAbono);
            this.Controls.Add(this.metroTextBoxMontoAbono);
            this.Controls.Add(this.metroLabelMontoAbono);
            this.Controls.Add(this.metroTextBoxNuevoSaldo);
            this.Controls.Add(this.metroLabelNuevoSaldo);
            this.Controls.Add(this.metroTextBoxSaldoActual);
            this.Controls.Add(this.metroLabelSaldoActual);
            this.Controls.Add(this.metroComboBoxAsociado);
            this.Controls.Add(this.metroLabelAsociado);
            this.Name = "AbonoCredito";
            this.Text = "Abono a Credito";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AbonoCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroComboBoxAsociado;
        private MetroFramework.Controls.MetroLabel metroLabelAsociado;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSaldoActual;
        private MetroFramework.Controls.MetroLabel metroLabelSaldoActual;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNuevoSaldo;
        private MetroFramework.Controls.MetroLabel metroLabelNuevoSaldo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMontoAbono;
        private MetroFramework.Controls.MetroLabel metroLabelMontoAbono;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFechaAbono;
        private MetroFramework.Controls.MetroLabel metroLabelFechaAbono;
        private MetroFramework.Controls.MetroButton metroButtonAbonar;
        private MetroFramework.Controls.MetroButton metroButtonCancelacionTotal;
        private MetroFramework.Controls.MetroGrid metroGridCreditos;
    }
}