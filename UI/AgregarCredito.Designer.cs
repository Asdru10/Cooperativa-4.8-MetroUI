using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class AgregarCredito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroComboBoxAsociado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelAsociado = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFechaInicio = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFechaFinal = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCapitalCredito = new MetroFramework.Controls.MetroLabel();
            this.metroLabelInteresesCredito = new MetroFramework.Controls.MetroLabel();
            this.metroLabelSaldoCredito = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTasaInteres = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCuotaMensual = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCapitalCredito = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxInteresCredito = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSaldoCredito = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTasaInteres = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCuotaMensual = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAprobar = new MetroFramework.Controls.MetroButton();
            this.metroDateTimeFechaInicio = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTimeFechaFinal = new MetroFramework.Controls.MetroDateTime();
            this.metroGridCreditos = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBoxAsociado
            // 
            this.metroComboBoxAsociado.FormattingEnabled = true;
            this.metroComboBoxAsociado.ItemHeight = 24;
            this.metroComboBoxAsociado.Location = new System.Drawing.Point(193, 82);
            this.metroComboBoxAsociado.Name = "metroComboBoxAsociado";
            this.metroComboBoxAsociado.Size = new System.Drawing.Size(428, 30);
            this.metroComboBoxAsociado.TabIndex = 44;
            this.metroComboBoxAsociado.UseSelectable = true;
            // 
            // metroLabelAsociado
            // 
            this.metroLabelAsociado.AutoSize = true;
            this.metroLabelAsociado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAsociado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAsociado.Location = new System.Drawing.Point(71, 87);
            this.metroLabelAsociado.Name = "metroLabelAsociado";
            this.metroLabelAsociado.Size = new System.Drawing.Size(95, 25);
            this.metroLabelAsociado.TabIndex = 43;
            this.metroLabelAsociado.Text = "Asociado:";
            // 
            // metroLabelFechaInicio
            // 
            this.metroLabelFechaInicio.AutoSize = true;
            this.metroLabelFechaInicio.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelFechaInicio.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelFechaInicio.Location = new System.Drawing.Point(67, 138);
            this.metroLabelFechaInicio.Name = "metroLabelFechaInicio";
            this.metroLabelFechaInicio.Size = new System.Drawing.Size(118, 25);
            this.metroLabelFechaInicio.TabIndex = 45;
            this.metroLabelFechaInicio.Text = "Fecha Inicio:";
            // 
            // metroLabelFechaFinal
            // 
            this.metroLabelFechaFinal.AutoSize = true;
            this.metroLabelFechaFinal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelFechaFinal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelFechaFinal.Location = new System.Drawing.Point(67, 186);
            this.metroLabelFechaFinal.Name = "metroLabelFechaFinal";
            this.metroLabelFechaFinal.Size = new System.Drawing.Size(111, 25);
            this.metroLabelFechaFinal.TabIndex = 46;
            this.metroLabelFechaFinal.Text = "Fecha Final:";
            // 
            // metroLabelCapitalCredito
            // 
            this.metroLabelCapitalCredito.AutoSize = true;
            this.metroLabelCapitalCredito.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelCapitalCredito.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelCapitalCredito.Location = new System.Drawing.Point(67, 238);
            this.metroLabelCapitalCredito.Name = "metroLabelCapitalCredito";
            this.metroLabelCapitalCredito.Size = new System.Drawing.Size(169, 25);
            this.metroLabelCapitalCredito.TabIndex = 47;
            this.metroLabelCapitalCredito.Text = "Capital de Crédito:";
            // 
            // metroLabelInteresesCredito
            // 
            this.metroLabelInteresesCredito.AutoSize = true;
            this.metroLabelInteresesCredito.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelInteresesCredito.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelInteresesCredito.Location = new System.Drawing.Point(67, 284);
            this.metroLabelInteresesCredito.Name = "metroLabelInteresesCredito";
            this.metroLabelInteresesCredito.Size = new System.Drawing.Size(187, 25);
            this.metroLabelInteresesCredito.TabIndex = 48;
            this.metroLabelInteresesCredito.Text = "Intereses de Crédito:";
            // 
            // metroLabelSaldoCredito
            // 
            this.metroLabelSaldoCredito.AutoSize = true;
            this.metroLabelSaldoCredito.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelSaldoCredito.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelSaldoCredito.Location = new System.Drawing.Point(67, 332);
            this.metroLabelSaldoCredito.Name = "metroLabelSaldoCredito";
            this.metroLabelSaldoCredito.Size = new System.Drawing.Size(157, 25);
            this.metroLabelSaldoCredito.TabIndex = 49;
            this.metroLabelSaldoCredito.Text = "Saldo de Crédito:";
            // 
            // metroLabelTasaInteres
            // 
            this.metroLabelTasaInteres.AutoSize = true;
            this.metroLabelTasaInteres.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelTasaInteres.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTasaInteres.Location = new System.Drawing.Point(598, 261);
            this.metroLabelTasaInteres.Name = "metroLabelTasaInteres";
            this.metroLabelTasaInteres.Size = new System.Drawing.Size(144, 25);
            this.metroLabelTasaInteres.TabIndex = 50;
            this.metroLabelTasaInteres.Text = "Tasa de Interés:";
            // 
            // metroLabelCuotaMensual
            // 
            this.metroLabelCuotaMensual.AutoSize = true;
            this.metroLabelCuotaMensual.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelCuotaMensual.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelCuotaMensual.Location = new System.Drawing.Point(598, 298);
            this.metroLabelCuotaMensual.Name = "metroLabelCuotaMensual";
            this.metroLabelCuotaMensual.Size = new System.Drawing.Size(144, 25);
            this.metroLabelCuotaMensual.TabIndex = 51;
            this.metroLabelCuotaMensual.Text = "Cuota Mensual:";
            // 
            // metroTextBoxCapitalCredito
            // 
            // 
            // 
            // 
            this.metroTextBoxCapitalCredito.CustomButton.Image = null;
            this.metroTextBoxCapitalCredito.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.metroTextBoxCapitalCredito.CustomButton.Name = "";
            this.metroTextBoxCapitalCredito.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxCapitalCredito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCapitalCredito.CustomButton.TabIndex = 1;
            this.metroTextBoxCapitalCredito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCapitalCredito.CustomButton.UseSelectable = true;
            this.metroTextBoxCapitalCredito.CustomButton.Visible = false;
            this.metroTextBoxCapitalCredito.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxCapitalCredito.Lines = new string[0];
            this.metroTextBoxCapitalCredito.Location = new System.Drawing.Point(324, 226);
            this.metroTextBoxCapitalCredito.MaxLength = 32767;
            this.metroTextBoxCapitalCredito.Multiline = true;
            this.metroTextBoxCapitalCredito.Name = "metroTextBoxCapitalCredito";
            this.metroTextBoxCapitalCredito.PasswordChar = '\0';
            this.metroTextBoxCapitalCredito.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCapitalCredito.SelectedText = "";
            this.metroTextBoxCapitalCredito.SelectionLength = 0;
            this.metroTextBoxCapitalCredito.SelectionStart = 0;
            this.metroTextBoxCapitalCredito.ShortcutsEnabled = true;
            this.metroTextBoxCapitalCredito.Size = new System.Drawing.Size(190, 35);
            this.metroTextBoxCapitalCredito.TabIndex = 52;
            this.metroTextBoxCapitalCredito.UseSelectable = true;
            this.metroTextBoxCapitalCredito.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCapitalCredito.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCapitalCredito.Leave += new System.EventHandler(this.metroTextBoxCapitalCredito_Leave);
            // 
            // metroTextBoxInteresCredito
            // 
            // 
            // 
            // 
            this.metroTextBoxInteresCredito.CustomButton.Image = null;
            this.metroTextBoxInteresCredito.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.metroTextBoxInteresCredito.CustomButton.Name = "";
            this.metroTextBoxInteresCredito.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxInteresCredito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxInteresCredito.CustomButton.TabIndex = 1;
            this.metroTextBoxInteresCredito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxInteresCredito.CustomButton.UseSelectable = true;
            this.metroTextBoxInteresCredito.CustomButton.Visible = false;
            this.metroTextBoxInteresCredito.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxInteresCredito.Lines = new string[0];
            this.metroTextBoxInteresCredito.Location = new System.Drawing.Point(324, 274);
            this.metroTextBoxInteresCredito.MaxLength = 32767;
            this.metroTextBoxInteresCredito.Multiline = true;
            this.metroTextBoxInteresCredito.Name = "metroTextBoxInteresCredito";
            this.metroTextBoxInteresCredito.PasswordChar = '\0';
            this.metroTextBoxInteresCredito.ReadOnly = true;
            this.metroTextBoxInteresCredito.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxInteresCredito.SelectedText = "";
            this.metroTextBoxInteresCredito.SelectionLength = 0;
            this.metroTextBoxInteresCredito.SelectionStart = 0;
            this.metroTextBoxInteresCredito.ShortcutsEnabled = true;
            this.metroTextBoxInteresCredito.Size = new System.Drawing.Size(190, 35);
            this.metroTextBoxInteresCredito.TabIndex = 53;
            this.metroTextBoxInteresCredito.UseSelectable = true;
            this.metroTextBoxInteresCredito.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxInteresCredito.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxSaldoCredito
            // 
            // 
            // 
            // 
            this.metroTextBoxSaldoCredito.CustomButton.Image = null;
            this.metroTextBoxSaldoCredito.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.metroTextBoxSaldoCredito.CustomButton.Name = "";
            this.metroTextBoxSaldoCredito.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxSaldoCredito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSaldoCredito.CustomButton.TabIndex = 1;
            this.metroTextBoxSaldoCredito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSaldoCredito.CustomButton.UseSelectable = true;
            this.metroTextBoxSaldoCredito.CustomButton.Visible = false;
            this.metroTextBoxSaldoCredito.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxSaldoCredito.Lines = new string[0];
            this.metroTextBoxSaldoCredito.Location = new System.Drawing.Point(324, 322);
            this.metroTextBoxSaldoCredito.MaxLength = 32767;
            this.metroTextBoxSaldoCredito.Multiline = true;
            this.metroTextBoxSaldoCredito.Name = "metroTextBoxSaldoCredito";
            this.metroTextBoxSaldoCredito.PasswordChar = '\0';
            this.metroTextBoxSaldoCredito.ReadOnly = true;
            this.metroTextBoxSaldoCredito.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSaldoCredito.SelectedText = "";
            this.metroTextBoxSaldoCredito.SelectionLength = 0;
            this.metroTextBoxSaldoCredito.SelectionStart = 0;
            this.metroTextBoxSaldoCredito.ShortcutsEnabled = true;
            this.metroTextBoxSaldoCredito.Size = new System.Drawing.Size(190, 35);
            this.metroTextBoxSaldoCredito.TabIndex = 54;
            this.metroTextBoxSaldoCredito.UseSelectable = true;
            this.metroTextBoxSaldoCredito.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSaldoCredito.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxTasaInteres
            // 
            // 
            // 
            // 
            this.metroTextBoxTasaInteres.CustomButton.Image = null;
            this.metroTextBoxTasaInteres.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.metroTextBoxTasaInteres.CustomButton.Name = "";
            this.metroTextBoxTasaInteres.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxTasaInteres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTasaInteres.CustomButton.TabIndex = 1;
            this.metroTextBoxTasaInteres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTasaInteres.CustomButton.UseSelectable = true;
            this.metroTextBoxTasaInteres.CustomButton.Visible = false;
            this.metroTextBoxTasaInteres.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxTasaInteres.Lines = new string[0];
            this.metroTextBoxTasaInteres.Location = new System.Drawing.Point(768, 251);
            this.metroTextBoxTasaInteres.MaxLength = 32767;
            this.metroTextBoxTasaInteres.Multiline = true;
            this.metroTextBoxTasaInteres.Name = "metroTextBoxTasaInteres";
            this.metroTextBoxTasaInteres.PasswordChar = '\0';
            this.metroTextBoxTasaInteres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTasaInteres.SelectedText = "";
            this.metroTextBoxTasaInteres.SelectionLength = 0;
            this.metroTextBoxTasaInteres.SelectionStart = 0;
            this.metroTextBoxTasaInteres.ShortcutsEnabled = true;
            this.metroTextBoxTasaInteres.Size = new System.Drawing.Size(154, 35);
            this.metroTextBoxTasaInteres.TabIndex = 55;
            this.metroTextBoxTasaInteres.UseSelectable = true;
            this.metroTextBoxTasaInteres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTasaInteres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxTasaInteres.Leave += new System.EventHandler(this.metroTextBoxTasaInteres_Leave);
            // 
            // metroTextBoxCuotaMensual
            // 
            // 
            // 
            // 
            this.metroTextBoxCuotaMensual.CustomButton.Image = null;
            this.metroTextBoxCuotaMensual.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.metroTextBoxCuotaMensual.CustomButton.Name = "";
            this.metroTextBoxCuotaMensual.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxCuotaMensual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCuotaMensual.CustomButton.TabIndex = 1;
            this.metroTextBoxCuotaMensual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCuotaMensual.CustomButton.UseSelectable = true;
            this.metroTextBoxCuotaMensual.CustomButton.Visible = false;
            this.metroTextBoxCuotaMensual.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxCuotaMensual.Lines = new string[0];
            this.metroTextBoxCuotaMensual.Location = new System.Drawing.Point(768, 298);
            this.metroTextBoxCuotaMensual.MaxLength = 32767;
            this.metroTextBoxCuotaMensual.Multiline = true;
            this.metroTextBoxCuotaMensual.Name = "metroTextBoxCuotaMensual";
            this.metroTextBoxCuotaMensual.PasswordChar = '\0';
            this.metroTextBoxCuotaMensual.ReadOnly = true;
            this.metroTextBoxCuotaMensual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCuotaMensual.SelectedText = "";
            this.metroTextBoxCuotaMensual.SelectionLength = 0;
            this.metroTextBoxCuotaMensual.SelectionStart = 0;
            this.metroTextBoxCuotaMensual.ShortcutsEnabled = true;
            this.metroTextBoxCuotaMensual.Size = new System.Drawing.Size(154, 35);
            this.metroTextBoxCuotaMensual.TabIndex = 56;
            this.metroTextBoxCuotaMensual.UseSelectable = true;
            this.metroTextBoxCuotaMensual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCuotaMensual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonAprobar
            // 
            this.metroButtonAprobar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonAprobar.Location = new System.Drawing.Point(437, 388);
            this.metroButtonAprobar.Name = "metroButtonAprobar";
            this.metroButtonAprobar.Size = new System.Drawing.Size(93, 38);
            this.metroButtonAprobar.TabIndex = 57;
            this.metroButtonAprobar.Text = "Aprobar";
            this.metroButtonAprobar.UseSelectable = true;
            this.metroButtonAprobar.Click += new System.EventHandler(this.metroButtonAprobar_Click);
            // 
            // metroDateTimeFechaInicio
            // 
            this.metroDateTimeFechaInicio.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.metroDateTimeFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFechaInicio.Location = new System.Drawing.Point(271, 133);
            this.metroDateTimeFechaInicio.MinimumSize = new System.Drawing.Size(0, 35);
            this.metroDateTimeFechaInicio.Name = "metroDateTimeFechaInicio";
            this.metroDateTimeFechaInicio.Size = new System.Drawing.Size(182, 35);
            this.metroDateTimeFechaInicio.TabIndex = 45;
            this.metroDateTimeFechaInicio.ValueChanged += new System.EventHandler(this.metroDateTimeFechaInicio_ValueChanged);
            // 
            // metroDateTimeFechaFinal
            // 
            this.metroDateTimeFechaFinal.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.metroDateTimeFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFechaFinal.Location = new System.Drawing.Point(271, 176);
            this.metroDateTimeFechaFinal.MinimumSize = new System.Drawing.Size(0, 35);
            this.metroDateTimeFechaFinal.Name = "metroDateTimeFechaFinal";
            this.metroDateTimeFechaFinal.Size = new System.Drawing.Size(182, 35);
            this.metroDateTimeFechaFinal.TabIndex = 46;
            this.metroDateTimeFechaFinal.ValueChanged += new System.EventHandler(this.metroDateTimeFechaFinal_ValueChanged);
            // 
            // metroGridCreditos
            // 
            this.metroGridCreditos.AllowUserToResizeRows = false;
            this.metroGridCreditos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCreditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridCreditos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridCreditos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGridCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCreditos.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGridCreditos.EnableHeadersVisualStyles = false;
            this.metroGridCreditos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCreditos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCreditos.Location = new System.Drawing.Point(24, 454);
            this.metroGridCreditos.Name = "metroGridCreditos";
            this.metroGridCreditos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCreditos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGridCreditos.RowHeadersWidth = 51;
            this.metroGridCreditos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCreditos.RowTemplate.Height = 24;
            this.metroGridCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridCreditos.Size = new System.Drawing.Size(898, 150);
            this.metroGridCreditos.TabIndex = 58;
            // 
            // AgregarCredito
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(945, 609);
            this.Controls.Add(this.metroGridCreditos);
            this.Controls.Add(this.metroDateTimeFechaFinal);
            this.Controls.Add(this.metroDateTimeFechaInicio);
            this.Controls.Add(this.metroButtonAprobar);
            this.Controls.Add(this.metroTextBoxCuotaMensual);
            this.Controls.Add(this.metroTextBoxTasaInteres);
            this.Controls.Add(this.metroTextBoxSaldoCredito);
            this.Controls.Add(this.metroTextBoxInteresCredito);
            this.Controls.Add(this.metroTextBoxCapitalCredito);
            this.Controls.Add(this.metroLabelCuotaMensual);
            this.Controls.Add(this.metroLabelTasaInteres);
            this.Controls.Add(this.metroLabelSaldoCredito);
            this.Controls.Add(this.metroLabelInteresesCredito);
            this.Controls.Add(this.metroLabelCapitalCredito);
            this.Controls.Add(this.metroLabelFechaFinal);
            this.Controls.Add(this.metroLabelFechaInicio);
            this.Controls.Add(this.metroComboBoxAsociado);
            this.Controls.Add(this.metroLabelAsociado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarCredito";
            this.Text = "Solicitud de Crédito";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AgregarCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroComboBoxAsociado;
        private MetroFramework.Controls.MetroLabel metroLabelAsociado;
        private MetroFramework.Controls.MetroLabel metroLabelFechaInicio;
        private MetroFramework.Controls.MetroLabel metroLabelFechaFinal;
        private MetroFramework.Controls.MetroLabel metroLabelCapitalCredito;
        private MetroFramework.Controls.MetroLabel metroLabelInteresesCredito;
        private MetroFramework.Controls.MetroLabel metroLabelSaldoCredito;
        private MetroFramework.Controls.MetroLabel metroLabelTasaInteres;
        private MetroFramework.Controls.MetroLabel metroLabelCuotaMensual;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCapitalCredito;
        private MetroFramework.Controls.MetroTextBox metroTextBoxInteresCredito;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSaldoCredito;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTasaInteres;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCuotaMensual;
        private MetroFramework.Controls.MetroButton metroButtonAprobar;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFechaInicio;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFechaFinal;
        private MetroFramework.Controls.MetroGrid metroGridCreditos;
    }
}