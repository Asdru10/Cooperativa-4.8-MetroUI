using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class EstadoCta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabelAsociado = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxAsociado = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControlCreditos = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageCreditos = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBoxTotalPendienteCreditos = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxStatusCreditos = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSaldoCreditos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelTotalPendienteCreditos = new MetroFramework.Controls.MetroLabel();
            this.metroLabelStatusCreditos = new MetroFramework.Controls.MetroLabel();
            this.metroLabelSaldoCreditos = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageAportes = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBoxTotalPendienteAportes = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTotalAportes = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelTotalPendienteAportes = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTotalAportes = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageAhorros = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBoxTotalAhorros = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelTotalAhorros = new MetroFramework.Controls.MetroLabel();
            this.metroGridAhorros = new MetroFramework.Controls.MetroGrid();
            this.metroGridAportes = new MetroFramework.Controls.MetroGrid();
            this.metroGridCreditos = new MetroFramework.Controls.MetroGrid();
            this.metroTabControlCreditos.SuspendLayout();
            this.metroTabPageCreditos.SuspendLayout();
            this.metroTabPageAportes.SuspendLayout();
            this.metroTabPageAhorros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAhorros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelAsociado
            // 
            this.metroLabelAsociado.AutoSize = true;
            this.metroLabelAsociado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAsociado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAsociado.Location = new System.Drawing.Point(27, 82);
            this.metroLabelAsociado.Name = "metroLabelAsociado";
            this.metroLabelAsociado.Size = new System.Drawing.Size(95, 25);
            this.metroLabelAsociado.TabIndex = 41;
            this.metroLabelAsociado.Text = "Asociado:";
            // 
            // metroComboBoxAsociado
            // 
            this.metroComboBoxAsociado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBoxAsociado.FormattingEnabled = true;
            this.metroComboBoxAsociado.ItemHeight = 29;
            this.metroComboBoxAsociado.Location = new System.Drawing.Point(128, 82);
            this.metroComboBoxAsociado.Name = "metroComboBoxAsociado";
            this.metroComboBoxAsociado.Size = new System.Drawing.Size(332, 35);
            this.metroComboBoxAsociado.TabIndex = 42;
            this.metroComboBoxAsociado.UseSelectable = true;
            this.metroComboBoxAsociado.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxAsociado_SelectedIndexChanged);
            // 
            // metroTabControlCreditos
            // 
            this.metroTabControlCreditos.Controls.Add(this.metroTabPageCreditos);
            this.metroTabControlCreditos.Controls.Add(this.metroTabPageAportes);
            this.metroTabControlCreditos.Controls.Add(this.metroTabPageAhorros);
            this.metroTabControlCreditos.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControlCreditos.Location = new System.Drawing.Point(23, 152);
            this.metroTabControlCreditos.Name = "metroTabControlCreditos";
            this.metroTabControlCreditos.SelectedIndex = 2;
            this.metroTabControlCreditos.Size = new System.Drawing.Size(682, 379);
            this.metroTabControlCreditos.TabIndex = 43;
            this.metroTabControlCreditos.UseSelectable = true;
            // 
            // metroTabPageCreditos
            // 
            this.metroTabPageCreditos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPageCreditos.Controls.Add(this.metroGridCreditos);
            this.metroTabPageCreditos.Controls.Add(this.metroTextBoxTotalPendienteCreditos);
            this.metroTabPageCreditos.Controls.Add(this.metroTextBoxStatusCreditos);
            this.metroTabPageCreditos.Controls.Add(this.metroTextBoxSaldoCreditos);
            this.metroTabPageCreditos.Controls.Add(this.metroLabelTotalPendienteCreditos);
            this.metroTabPageCreditos.Controls.Add(this.metroLabelStatusCreditos);
            this.metroTabPageCreditos.Controls.Add(this.metroLabelSaldoCreditos);
            this.metroTabPageCreditos.HorizontalScrollbarBarColor = true;
            this.metroTabPageCreditos.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageCreditos.HorizontalScrollbarSize = 10;
            this.metroTabPageCreditos.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageCreditos.Name = "metroTabPageCreditos";
            this.metroTabPageCreditos.Size = new System.Drawing.Size(674, 337);
            this.metroTabPageCreditos.TabIndex = 0;
            this.metroTabPageCreditos.Text = "Créditos";
            this.metroTabPageCreditos.VerticalScrollbarBarColor = true;
            this.metroTabPageCreditos.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageCreditos.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxTotalPendienteCreditos
            // 
            // 
            // 
            // 
            this.metroTextBoxTotalPendienteCreditos.CustomButton.Image = null;
            this.metroTextBoxTotalPendienteCreditos.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.metroTextBoxTotalPendienteCreditos.CustomButton.Name = "";
            this.metroTextBoxTotalPendienteCreditos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTotalPendienteCreditos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTotalPendienteCreditos.CustomButton.TabIndex = 1;
            this.metroTextBoxTotalPendienteCreditos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTotalPendienteCreditos.CustomButton.UseSelectable = true;
            this.metroTextBoxTotalPendienteCreditos.CustomButton.Visible = false;
            this.metroTextBoxTotalPendienteCreditos.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxTotalPendienteCreditos.Lines = new string[0];
            this.metroTextBoxTotalPendienteCreditos.Location = new System.Drawing.Point(157, 263);
            this.metroTextBoxTotalPendienteCreditos.MaxLength = 32767;
            this.metroTextBoxTotalPendienteCreditos.Name = "metroTextBoxTotalPendienteCreditos";
            this.metroTextBoxTotalPendienteCreditos.PasswordChar = '\0';
            this.metroTextBoxTotalPendienteCreditos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTotalPendienteCreditos.SelectedText = "";
            this.metroTextBoxTotalPendienteCreditos.SelectionLength = 0;
            this.metroTextBoxTotalPendienteCreditos.SelectionStart = 0;
            this.metroTextBoxTotalPendienteCreditos.ShortcutsEnabled = true;
            this.metroTextBoxTotalPendienteCreditos.Size = new System.Drawing.Size(181, 23);
            this.metroTextBoxTotalPendienteCreditos.TabIndex = 8;
            this.metroTextBoxTotalPendienteCreditos.UseSelectable = true;
            this.metroTextBoxTotalPendienteCreditos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTotalPendienteCreditos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxStatusCreditos
            // 
            // 
            // 
            // 
            this.metroTextBoxStatusCreditos.CustomButton.Image = null;
            this.metroTextBoxStatusCreditos.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.metroTextBoxStatusCreditos.CustomButton.Name = "";
            this.metroTextBoxStatusCreditos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxStatusCreditos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxStatusCreditos.CustomButton.TabIndex = 1;
            this.metroTextBoxStatusCreditos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxStatusCreditos.CustomButton.UseSelectable = true;
            this.metroTextBoxStatusCreditos.CustomButton.Visible = false;
            this.metroTextBoxStatusCreditos.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxStatusCreditos.Lines = new string[0];
            this.metroTextBoxStatusCreditos.Location = new System.Drawing.Point(157, 227);
            this.metroTextBoxStatusCreditos.MaxLength = 32767;
            this.metroTextBoxStatusCreditos.Name = "metroTextBoxStatusCreditos";
            this.metroTextBoxStatusCreditos.PasswordChar = '\0';
            this.metroTextBoxStatusCreditos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxStatusCreditos.SelectedText = "";
            this.metroTextBoxStatusCreditos.SelectionLength = 0;
            this.metroTextBoxStatusCreditos.SelectionStart = 0;
            this.metroTextBoxStatusCreditos.ShortcutsEnabled = true;
            this.metroTextBoxStatusCreditos.Size = new System.Drawing.Size(181, 23);
            this.metroTextBoxStatusCreditos.TabIndex = 7;
            this.metroTextBoxStatusCreditos.UseSelectable = true;
            this.metroTextBoxStatusCreditos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxStatusCreditos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxSaldoCreditos
            // 
            // 
            // 
            // 
            this.metroTextBoxSaldoCreditos.CustomButton.Image = null;
            this.metroTextBoxSaldoCreditos.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.metroTextBoxSaldoCreditos.CustomButton.Name = "";
            this.metroTextBoxSaldoCreditos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxSaldoCreditos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSaldoCreditos.CustomButton.TabIndex = 1;
            this.metroTextBoxSaldoCreditos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSaldoCreditos.CustomButton.UseSelectable = true;
            this.metroTextBoxSaldoCreditos.CustomButton.Visible = false;
            this.metroTextBoxSaldoCreditos.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxSaldoCreditos.Lines = new string[0];
            this.metroTextBoxSaldoCreditos.Location = new System.Drawing.Point(157, 191);
            this.metroTextBoxSaldoCreditos.MaxLength = 32767;
            this.metroTextBoxSaldoCreditos.Name = "metroTextBoxSaldoCreditos";
            this.metroTextBoxSaldoCreditos.PasswordChar = '\0';
            this.metroTextBoxSaldoCreditos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSaldoCreditos.SelectedText = "";
            this.metroTextBoxSaldoCreditos.SelectionLength = 0;
            this.metroTextBoxSaldoCreditos.SelectionStart = 0;
            this.metroTextBoxSaldoCreditos.ShortcutsEnabled = true;
            this.metroTextBoxSaldoCreditos.Size = new System.Drawing.Size(181, 23);
            this.metroTextBoxSaldoCreditos.TabIndex = 6;
            this.metroTextBoxSaldoCreditos.UseSelectable = true;
            this.metroTextBoxSaldoCreditos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSaldoCreditos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelTotalPendienteCreditos
            // 
            this.metroLabelTotalPendienteCreditos.AutoSize = true;
            this.metroLabelTotalPendienteCreditos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTotalPendienteCreditos.Location = new System.Drawing.Point(3, 263);
            this.metroLabelTotalPendienteCreditos.Name = "metroLabelTotalPendienteCreditos";
            this.metroLabelTotalPendienteCreditos.Size = new System.Drawing.Size(129, 20);
            this.metroLabelTotalPendienteCreditos.TabIndex = 5;
            this.metroLabelTotalPendienteCreditos.Text = "Total Pendientes:";
            // 
            // metroLabelStatusCreditos
            // 
            this.metroLabelStatusCreditos.AutoSize = true;
            this.metroLabelStatusCreditos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelStatusCreditos.Location = new System.Drawing.Point(3, 227);
            this.metroLabelStatusCreditos.Name = "metroLabelStatusCreditos";
            this.metroLabelStatusCreditos.Size = new System.Drawing.Size(140, 20);
            this.metroLabelStatusCreditos.TabIndex = 4;
            this.metroLabelStatusCreditos.Text = "Status de Créditos:";
            // 
            // metroLabelSaldoCreditos
            // 
            this.metroLabelSaldoCreditos.AutoSize = true;
            this.metroLabelSaldoCreditos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelSaldoCreditos.Location = new System.Drawing.Point(3, 191);
            this.metroLabelSaldoCreditos.Name = "metroLabelSaldoCreditos";
            this.metroLabelSaldoCreditos.Size = new System.Drawing.Size(134, 20);
            this.metroLabelSaldoCreditos.TabIndex = 3;
            this.metroLabelSaldoCreditos.Text = "Saldo de Créditos:";
            // 
            // metroTabPageAportes
            // 
            this.metroTabPageAportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPageAportes.Controls.Add(this.metroGridAportes);
            this.metroTabPageAportes.Controls.Add(this.metroTextBoxTotalPendienteAportes);
            this.metroTabPageAportes.Controls.Add(this.metroTextBoxTotalAportes);
            this.metroTabPageAportes.Controls.Add(this.metroLabelTotalPendienteAportes);
            this.metroTabPageAportes.Controls.Add(this.metroLabelTotalAportes);
            this.metroTabPageAportes.HorizontalScrollbarBarColor = true;
            this.metroTabPageAportes.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageAportes.HorizontalScrollbarSize = 10;
            this.metroTabPageAportes.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageAportes.Name = "metroTabPageAportes";
            this.metroTabPageAportes.Size = new System.Drawing.Size(674, 337);
            this.metroTabPageAportes.TabIndex = 1;
            this.metroTabPageAportes.Text = "Aportes";
            this.metroTabPageAportes.VerticalScrollbarBarColor = true;
            this.metroTabPageAportes.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageAportes.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxTotalPendienteAportes
            // 
            // 
            // 
            // 
            this.metroTextBoxTotalPendienteAportes.CustomButton.Image = null;
            this.metroTextBoxTotalPendienteAportes.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.metroTextBoxTotalPendienteAportes.CustomButton.Name = "";
            this.metroTextBoxTotalPendienteAportes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTotalPendienteAportes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTotalPendienteAportes.CustomButton.TabIndex = 1;
            this.metroTextBoxTotalPendienteAportes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTotalPendienteAportes.CustomButton.UseSelectable = true;
            this.metroTextBoxTotalPendienteAportes.CustomButton.Visible = false;
            this.metroTextBoxTotalPendienteAportes.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxTotalPendienteAportes.Lines = new string[0];
            this.metroTextBoxTotalPendienteAportes.Location = new System.Drawing.Point(160, 226);
            this.metroTextBoxTotalPendienteAportes.MaxLength = 32767;
            this.metroTextBoxTotalPendienteAportes.Name = "metroTextBoxTotalPendienteAportes";
            this.metroTextBoxTotalPendienteAportes.PasswordChar = '\0';
            this.metroTextBoxTotalPendienteAportes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTotalPendienteAportes.SelectedText = "";
            this.metroTextBoxTotalPendienteAportes.SelectionLength = 0;
            this.metroTextBoxTotalPendienteAportes.SelectionStart = 0;
            this.metroTextBoxTotalPendienteAportes.ShortcutsEnabled = true;
            this.metroTextBoxTotalPendienteAportes.Size = new System.Drawing.Size(181, 23);
            this.metroTextBoxTotalPendienteAportes.TabIndex = 12;
            this.metroTextBoxTotalPendienteAportes.UseSelectable = true;
            this.metroTextBoxTotalPendienteAportes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTotalPendienteAportes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxTotalAportes
            // 
            // 
            // 
            // 
            this.metroTextBoxTotalAportes.CustomButton.Image = null;
            this.metroTextBoxTotalAportes.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.metroTextBoxTotalAportes.CustomButton.Name = "";
            this.metroTextBoxTotalAportes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTotalAportes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTotalAportes.CustomButton.TabIndex = 1;
            this.metroTextBoxTotalAportes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTotalAportes.CustomButton.UseSelectable = true;
            this.metroTextBoxTotalAportes.CustomButton.Visible = false;
            this.metroTextBoxTotalAportes.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxTotalAportes.Lines = new string[0];
            this.metroTextBoxTotalAportes.Location = new System.Drawing.Point(160, 190);
            this.metroTextBoxTotalAportes.MaxLength = 32767;
            this.metroTextBoxTotalAportes.Name = "metroTextBoxTotalAportes";
            this.metroTextBoxTotalAportes.PasswordChar = '\0';
            this.metroTextBoxTotalAportes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTotalAportes.SelectedText = "";
            this.metroTextBoxTotalAportes.SelectionLength = 0;
            this.metroTextBoxTotalAportes.SelectionStart = 0;
            this.metroTextBoxTotalAportes.ShortcutsEnabled = true;
            this.metroTextBoxTotalAportes.Size = new System.Drawing.Size(181, 23);
            this.metroTextBoxTotalAportes.TabIndex = 11;
            this.metroTextBoxTotalAportes.UseSelectable = true;
            this.metroTextBoxTotalAportes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTotalAportes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelTotalPendienteAportes
            // 
            this.metroLabelTotalPendienteAportes.AutoSize = true;
            this.metroLabelTotalPendienteAportes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTotalPendienteAportes.Location = new System.Drawing.Point(3, 226);
            this.metroLabelTotalPendienteAportes.Name = "metroLabelTotalPendienteAportes";
            this.metroLabelTotalPendienteAportes.Size = new System.Drawing.Size(122, 20);
            this.metroLabelTotalPendienteAportes.TabIndex = 10;
            this.metroLabelTotalPendienteAportes.Text = "Total Pendiente:";
            // 
            // metroLabelTotalAportes
            // 
            this.metroLabelTotalAportes.AutoSize = true;
            this.metroLabelTotalAportes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTotalAportes.Location = new System.Drawing.Point(3, 190);
            this.metroLabelTotalAportes.Name = "metroLabelTotalAportes";
            this.metroLabelTotalAportes.Size = new System.Drawing.Size(129, 20);
            this.metroLabelTotalAportes.TabIndex = 9;
            this.metroLabelTotalAportes.Text = "Total de Aportes:";
            // 
            // metroTabPageAhorros
            // 
            this.metroTabPageAhorros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPageAhorros.Controls.Add(this.metroGridAhorros);
            this.metroTabPageAhorros.Controls.Add(this.metroTextBoxTotalAhorros);
            this.metroTabPageAhorros.Controls.Add(this.metroLabelTotalAhorros);
            this.metroTabPageAhorros.HorizontalScrollbarBarColor = true;
            this.metroTabPageAhorros.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageAhorros.HorizontalScrollbarSize = 10;
            this.metroTabPageAhorros.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageAhorros.Name = "metroTabPageAhorros";
            this.metroTabPageAhorros.Size = new System.Drawing.Size(674, 337);
            this.metroTabPageAhorros.TabIndex = 2;
            this.metroTabPageAhorros.Text = "Ahorros";
            this.metroTabPageAhorros.VerticalScrollbarBarColor = true;
            this.metroTabPageAhorros.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageAhorros.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxTotalAhorros
            // 
            // 
            // 
            // 
            this.metroTextBoxTotalAhorros.CustomButton.Image = null;
            this.metroTextBoxTotalAhorros.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.metroTextBoxTotalAhorros.CustomButton.Name = "";
            this.metroTextBoxTotalAhorros.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTotalAhorros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTotalAhorros.CustomButton.TabIndex = 1;
            this.metroTextBoxTotalAhorros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTotalAhorros.CustomButton.UseSelectable = true;
            this.metroTextBoxTotalAhorros.CustomButton.Visible = false;
            this.metroTextBoxTotalAhorros.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxTotalAhorros.Lines = new string[0];
            this.metroTextBoxTotalAhorros.Location = new System.Drawing.Point(156, 191);
            this.metroTextBoxTotalAhorros.MaxLength = 32767;
            this.metroTextBoxTotalAhorros.Name = "metroTextBoxTotalAhorros";
            this.metroTextBoxTotalAhorros.PasswordChar = '\0';
            this.metroTextBoxTotalAhorros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTotalAhorros.SelectedText = "";
            this.metroTextBoxTotalAhorros.SelectionLength = 0;
            this.metroTextBoxTotalAhorros.SelectionStart = 0;
            this.metroTextBoxTotalAhorros.ShortcutsEnabled = true;
            this.metroTextBoxTotalAhorros.Size = new System.Drawing.Size(181, 23);
            this.metroTextBoxTotalAhorros.TabIndex = 14;
            this.metroTextBoxTotalAhorros.UseSelectable = true;
            this.metroTextBoxTotalAhorros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTotalAhorros.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelTotalAhorros
            // 
            this.metroLabelTotalAhorros.AutoSize = true;
            this.metroLabelTotalAhorros.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTotalAhorros.Location = new System.Drawing.Point(3, 191);
            this.metroLabelTotalAhorros.Name = "metroLabelTotalAhorros";
            this.metroLabelTotalAhorros.Size = new System.Drawing.Size(130, 20);
            this.metroLabelTotalAhorros.TabIndex = 13;
            this.metroLabelTotalAhorros.Text = "Total de Ahorros:";
            // 
            // metroGridAhorros
            // 
            this.metroGridAhorros.AllowUserToResizeRows = false;
            this.metroGridAhorros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.metroGridAhorros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridAhorros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.metroGridAhorros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAhorros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGridAhorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAhorros.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridAhorros.EnableHeadersVisualStyles = false;
            this.metroGridAhorros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAhorros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAhorros.Location = new System.Drawing.Point(3, 3);
            this.metroGridAhorros.Name = "metroGridAhorros";
            this.metroGridAhorros.ReadOnly = true;
            this.metroGridAhorros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAhorros.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridAhorros.RowHeadersWidth = 51;
            this.metroGridAhorros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAhorros.RowTemplate.Height = 24;
            this.metroGridAhorros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridAhorros.Size = new System.Drawing.Size(666, 150);
            this.metroGridAhorros.TabIndex = 75;
            // 
            // metroGridAportes
            // 
            this.metroGridAportes.AllowUserToResizeRows = false;
            this.metroGridAportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.metroGridAportes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridAportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.metroGridAportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridAportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAportes.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridAportes.EnableHeadersVisualStyles = false;
            this.metroGridAportes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAportes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAportes.Location = new System.Drawing.Point(3, 3);
            this.metroGridAportes.Name = "metroGridAportes";
            this.metroGridAportes.ReadOnly = true;
            this.metroGridAportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridAportes.RowHeadersWidth = 51;
            this.metroGridAportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAportes.RowTemplate.Height = 24;
            this.metroGridAportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridAportes.Size = new System.Drawing.Size(666, 150);
            this.metroGridAportes.TabIndex = 76;
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
            this.metroGridCreditos.Location = new System.Drawing.Point(3, 3);
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
            this.metroGridCreditos.Size = new System.Drawing.Size(668, 150);
            this.metroGridCreditos.TabIndex = 76;
            // 
            // EstadoCta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(732, 568);
            this.Controls.Add(this.metroTabControlCreditos);
            this.Controls.Add(this.metroComboBoxAsociado);
            this.Controls.Add(this.metroLabelAsociado);
            this.Name = "EstadoCta";
            this.Text = "Estado de Cuenta";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.EstadoCta_Load);
            this.metroTabControlCreditos.ResumeLayout(false);
            this.metroTabPageCreditos.ResumeLayout(false);
            this.metroTabPageCreditos.PerformLayout();
            this.metroTabPageAportes.ResumeLayout(false);
            this.metroTabPageAportes.PerformLayout();
            this.metroTabPageAhorros.ResumeLayout(false);
            this.metroTabPageAhorros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAhorros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabelAsociado;
        private MetroFramework.Controls.MetroComboBox metroComboBoxAsociado;
        private MetroFramework.Controls.MetroTabControl metroTabControlCreditos;
        private MetroFramework.Controls.MetroTabPage metroTabPageCreditos;
        private MetroFramework.Controls.MetroTabPage metroTabPageAportes;
        private MetroFramework.Controls.MetroTabPage metroTabPageAhorros;
        private MetroFramework.Controls.MetroLabel metroLabelTotalPendienteCreditos;
        private MetroFramework.Controls.MetroLabel metroLabelStatusCreditos;
        private MetroFramework.Controls.MetroLabel metroLabelSaldoCreditos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTotalPendienteCreditos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxStatusCreditos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSaldoCreditos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTotalPendienteAportes;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTotalAportes;
        private MetroFramework.Controls.MetroLabel metroLabelTotalPendienteAportes;
        private MetroFramework.Controls.MetroLabel metroLabelTotalAportes;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTotalAhorros;
        private MetroFramework.Controls.MetroLabel metroLabelTotalAhorros;
        private MetroFramework.Controls.MetroGrid metroGridAhorros;
        private MetroFramework.Controls.MetroGrid metroGridCreditos;
        private MetroFramework.Controls.MetroGrid metroGridAportes;
    }
}