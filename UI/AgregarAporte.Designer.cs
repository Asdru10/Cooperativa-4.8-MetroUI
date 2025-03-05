using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class AgregarAporte
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
            this.metroTextBoxDetalle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelDetalle = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxMonto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelMonto = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeFecha = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelFecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTipo = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButtonMensual = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonAnual = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonInteresBanco = new MetroFramework.Controls.MetroRadioButton();
            this.metroButtonAgregar = new MetroFramework.Controls.MetroButton();
            this.metroGridAportes = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAportes)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBoxAsociado
            // 
            this.metroComboBoxAsociado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBoxAsociado.FormattingEnabled = true;
            this.metroComboBoxAsociado.ItemHeight = 29;
            this.metroComboBoxAsociado.Location = new System.Drawing.Point(151, 89);
            this.metroComboBoxAsociado.Name = "metroComboBoxAsociado";
            this.metroComboBoxAsociado.Size = new System.Drawing.Size(414, 35);
            this.metroComboBoxAsociado.TabIndex = 44;
            this.metroComboBoxAsociado.UseSelectable = true;
            // 
            // metroLabelAsociado
            // 
            this.metroLabelAsociado.AutoSize = true;
            this.metroLabelAsociado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAsociado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAsociado.Location = new System.Drawing.Point(36, 89);
            this.metroLabelAsociado.Name = "metroLabelAsociado";
            this.metroLabelAsociado.Size = new System.Drawing.Size(95, 25);
            this.metroLabelAsociado.TabIndex = 43;
            this.metroLabelAsociado.Text = "Asociado:";
            // 
            // metroTextBoxDetalle
            // 
            // 
            // 
            // 
            this.metroTextBoxDetalle.CustomButton.Image = null;
            this.metroTextBoxDetalle.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.metroTextBoxDetalle.CustomButton.Name = "";
            this.metroTextBoxDetalle.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxDetalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDetalle.CustomButton.TabIndex = 1;
            this.metroTextBoxDetalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDetalle.CustomButton.UseSelectable = true;
            this.metroTextBoxDetalle.CustomButton.Visible = false;
            this.metroTextBoxDetalle.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxDetalle.Lines = new string[0];
            this.metroTextBoxDetalle.Location = new System.Drawing.Point(151, 134);
            this.metroTextBoxDetalle.MaxLength = 32767;
            this.metroTextBoxDetalle.Multiline = true;
            this.metroTextBoxDetalle.Name = "metroTextBoxDetalle";
            this.metroTextBoxDetalle.PasswordChar = '\0';
            this.metroTextBoxDetalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDetalle.SelectedText = "";
            this.metroTextBoxDetalle.SelectionLength = 0;
            this.metroTextBoxDetalle.SelectionStart = 0;
            this.metroTextBoxDetalle.ShortcutsEnabled = true;
            this.metroTextBoxDetalle.Size = new System.Drawing.Size(414, 35);
            this.metroTextBoxDetalle.TabIndex = 62;
            this.metroTextBoxDetalle.UseSelectable = true;
            this.metroTextBoxDetalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDetalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelDetalle
            // 
            this.metroLabelDetalle.AutoSize = true;
            this.metroLabelDetalle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDetalle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelDetalle.Location = new System.Drawing.Point(36, 134);
            this.metroLabelDetalle.Name = "metroLabelDetalle";
            this.metroLabelDetalle.Size = new System.Drawing.Size(77, 25);
            this.metroLabelDetalle.TabIndex = 61;
            this.metroLabelDetalle.Text = "Detalle:";
            // 
            // metroTextBoxMonto
            // 
            // 
            // 
            // 
            this.metroTextBoxMonto.CustomButton.Image = null;
            this.metroTextBoxMonto.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.metroTextBoxMonto.CustomButton.Name = "";
            this.metroTextBoxMonto.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMonto.CustomButton.TabIndex = 1;
            this.metroTextBoxMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMonto.CustomButton.UseSelectable = true;
            this.metroTextBoxMonto.CustomButton.Visible = false;
            this.metroTextBoxMonto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxMonto.Lines = new string[0];
            this.metroTextBoxMonto.Location = new System.Drawing.Point(151, 182);
            this.metroTextBoxMonto.MaxLength = 32767;
            this.metroTextBoxMonto.Multiline = true;
            this.metroTextBoxMonto.Name = "metroTextBoxMonto";
            this.metroTextBoxMonto.PasswordChar = '\0';
            this.metroTextBoxMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMonto.SelectedText = "";
            this.metroTextBoxMonto.SelectionLength = 0;
            this.metroTextBoxMonto.SelectionStart = 0;
            this.metroTextBoxMonto.ShortcutsEnabled = true;
            this.metroTextBoxMonto.Size = new System.Drawing.Size(414, 35);
            this.metroTextBoxMonto.TabIndex = 64;
            this.metroTextBoxMonto.UseSelectable = true;
            this.metroTextBoxMonto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMonto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxMonto.Leave += new System.EventHandler(this.metroTextBoxMonto_Leave);
            // 
            // metroLabelMonto
            // 
            this.metroLabelMonto.AutoSize = true;
            this.metroLabelMonto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMonto.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelMonto.Location = new System.Drawing.Point(36, 182);
            this.metroLabelMonto.Name = "metroLabelMonto";
            this.metroLabelMonto.Size = new System.Drawing.Size(74, 25);
            this.metroLabelMonto.TabIndex = 63;
            this.metroLabelMonto.Text = "Monto:";
            // 
            // metroDateTimeFecha
            // 
            this.metroDateTimeFecha.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.metroDateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFecha.Location = new System.Drawing.Point(151, 228);
            this.metroDateTimeFecha.MinimumSize = new System.Drawing.Size(0, 35);
            this.metroDateTimeFecha.Name = "metroDateTimeFecha";
            this.metroDateTimeFecha.Size = new System.Drawing.Size(182, 35);
            this.metroDateTimeFecha.TabIndex = 65;
            // 
            // metroLabelFecha
            // 
            this.metroLabelFecha.AutoSize = true;
            this.metroLabelFecha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelFecha.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelFecha.Location = new System.Drawing.Point(36, 228);
            this.metroLabelFecha.Name = "metroLabelFecha";
            this.metroLabelFecha.Size = new System.Drawing.Size(66, 25);
            this.metroLabelFecha.TabIndex = 66;
            this.metroLabelFecha.Text = "Fecha:";
            // 
            // metroLabelTipo
            // 
            this.metroLabelTipo.AutoSize = true;
            this.metroLabelTipo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelTipo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTipo.Location = new System.Drawing.Point(36, 280);
            this.metroLabelTipo.Name = "metroLabelTipo";
            this.metroLabelTipo.Size = new System.Drawing.Size(55, 25);
            this.metroLabelTipo.TabIndex = 67;
            this.metroLabelTipo.Text = "Tipo:";
            // 
            // metroRadioButtonMensual
            // 
            this.metroRadioButtonMensual.AutoSize = true;
            this.metroRadioButtonMensual.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroRadioButtonMensual.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButtonMensual.Location = new System.Drawing.Point(151, 280);
            this.metroRadioButtonMensual.Name = "metroRadioButtonMensual";
            this.metroRadioButtonMensual.Size = new System.Drawing.Size(80, 20);
            this.metroRadioButtonMensual.TabIndex = 68;
            this.metroRadioButtonMensual.Text = "Mensual";
            this.metroRadioButtonMensual.UseSelectable = true;
            // 
            // metroRadioButtonAnual
            // 
            this.metroRadioButtonAnual.AutoSize = true;
            this.metroRadioButtonAnual.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButtonAnual.Location = new System.Drawing.Point(151, 306);
            this.metroRadioButtonAnual.Name = "metroRadioButtonAnual";
            this.metroRadioButtonAnual.Size = new System.Drawing.Size(63, 20);
            this.metroRadioButtonAnual.TabIndex = 69;
            this.metroRadioButtonAnual.Text = "Anual";
            this.metroRadioButtonAnual.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroRadioButtonAnual.UseSelectable = true;
            // 
            // metroRadioButtonInteresBanco
            // 
            this.metroRadioButtonInteresBanco.AutoSize = true;
            this.metroRadioButtonInteresBanco.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButtonInteresBanco.Location = new System.Drawing.Point(151, 332);
            this.metroRadioButtonInteresBanco.Name = "metroRadioButtonInteresBanco";
            this.metroRadioButtonInteresBanco.Size = new System.Drawing.Size(114, 20);
            this.metroRadioButtonInteresBanco.TabIndex = 70;
            this.metroRadioButtonInteresBanco.Text = "Interés Banco";
            this.metroRadioButtonInteresBanco.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroRadioButtonInteresBanco.UseSelectable = true;
            // 
            // metroButtonAgregar
            // 
            this.metroButtonAgregar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonAgregar.Location = new System.Drawing.Point(345, 379);
            this.metroButtonAgregar.Name = "metroButtonAgregar";
            this.metroButtonAgregar.Size = new System.Drawing.Size(93, 38);
            this.metroButtonAgregar.TabIndex = 71;
            this.metroButtonAgregar.Text = "Agregar";
            this.metroButtonAgregar.UseSelectable = true;
            this.metroButtonAgregar.Click += new System.EventHandler(this.metroButtonAgregar_Click);
            // 
            // metroGridAportes
            // 
            this.metroGridAportes.AllowUserToResizeRows = false;
            this.metroGridAportes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.metroGridAportes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridAportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.metroGridAportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridAportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAportes.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridAportes.EnableHeadersVisualStyles = false;
            this.metroGridAportes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAportes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAportes.Location = new System.Drawing.Point(23, 442);
            this.metroGridAportes.Name = "metroGridAportes";
            this.metroGridAportes.ReadOnly = true;
            this.metroGridAportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridAportes.RowHeadersWidth = 51;
            this.metroGridAportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAportes.RowTemplate.Height = 24;
            this.metroGridAportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.metroGridAportes.Size = new System.Drawing.Size(748, 150);
            this.metroGridAportes.TabIndex = 72;
            // 
            // AgregarAporte
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(794, 623);
            this.Controls.Add(this.metroGridAportes);
            this.Controls.Add(this.metroButtonAgregar);
            this.Controls.Add(this.metroRadioButtonInteresBanco);
            this.Controls.Add(this.metroRadioButtonAnual);
            this.Controls.Add(this.metroRadioButtonMensual);
            this.Controls.Add(this.metroLabelTipo);
            this.Controls.Add(this.metroDateTimeFecha);
            this.Controls.Add(this.metroLabelFecha);
            this.Controls.Add(this.metroTextBoxMonto);
            this.Controls.Add(this.metroLabelMonto);
            this.Controls.Add(this.metroTextBoxDetalle);
            this.Controls.Add(this.metroLabelDetalle);
            this.Controls.Add(this.metroComboBoxAsociado);
            this.Controls.Add(this.metroLabelAsociado);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarAporte";
            this.Text = "Agregar Aporte";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AgregarAporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroComboBoxAsociado;
        private MetroFramework.Controls.MetroLabel metroLabelAsociado;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDetalle;
        private MetroFramework.Controls.MetroLabel metroLabelDetalle;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMonto;
        private MetroFramework.Controls.MetroLabel metroLabelMonto;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFecha;
        private MetroFramework.Controls.MetroLabel metroLabelFecha;
        private MetroFramework.Controls.MetroLabel metroLabelTipo;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonMensual;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonAnual;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonInteresBanco;
        private MetroFramework.Controls.MetroButton metroButtonAgregar;
        private MetroFramework.Controls.MetroGrid metroGridAportes;
    }
}