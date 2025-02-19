using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class AgregarAsociado
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
            this.metroTextBoxCedula = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelCapitalCredito = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelNombre = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPrimerApellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelPrimerApellido = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxSegundoApellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelSegundoApellido = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeFechaNacimento = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelFechaNacimiento = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAgregar = new MetroFramework.Controls.MetroButton();
            this.metroGridAsociados = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAsociados)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxCedula
            // 
            // 
            // 
            // 
            this.metroTextBoxCedula.CustomButton.Image = null;
            this.metroTextBoxCedula.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.metroTextBoxCedula.CustomButton.Name = "";
            this.metroTextBoxCedula.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxCedula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCedula.CustomButton.TabIndex = 1;
            this.metroTextBoxCedula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCedula.CustomButton.UseSelectable = true;
            this.metroTextBoxCedula.CustomButton.Visible = false;
            this.metroTextBoxCedula.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxCedula.Lines = new string[0];
            this.metroTextBoxCedula.Location = new System.Drawing.Point(278, 85);
            this.metroTextBoxCedula.MaxLength = 32767;
            this.metroTextBoxCedula.Multiline = true;
            this.metroTextBoxCedula.Name = "metroTextBoxCedula";
            this.metroTextBoxCedula.PasswordChar = '\0';
            this.metroTextBoxCedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCedula.SelectedText = "";
            this.metroTextBoxCedula.SelectionLength = 0;
            this.metroTextBoxCedula.SelectionStart = 0;
            this.metroTextBoxCedula.ShortcutsEnabled = true;
            this.metroTextBoxCedula.Size = new System.Drawing.Size(335, 35);
            this.metroTextBoxCedula.TabIndex = 54;
            this.metroTextBoxCedula.UseSelectable = true;
            this.metroTextBoxCedula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCedula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelCapitalCredito
            // 
            this.metroLabelCapitalCredito.AutoSize = true;
            this.metroLabelCapitalCredito.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelCapitalCredito.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelCapitalCredito.Location = new System.Drawing.Point(52, 85);
            this.metroLabelCapitalCredito.Name = "metroLabelCapitalCredito";
            this.metroLabelCapitalCredito.Size = new System.Drawing.Size(75, 25);
            this.metroLabelCapitalCredito.TabIndex = 53;
            this.metroLabelCapitalCredito.Text = "Cédula:";
            // 
            // metroTextBoxNombre
            // 
            // 
            // 
            // 
            this.metroTextBoxNombre.CustomButton.Image = null;
            this.metroTextBoxNombre.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.metroTextBoxNombre.CustomButton.Name = "";
            this.metroTextBoxNombre.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre.CustomButton.Visible = false;
            this.metroTextBoxNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxNombre.Lines = new string[0];
            this.metroTextBoxNombre.Location = new System.Drawing.Point(278, 132);
            this.metroTextBoxNombre.MaxLength = 32767;
            this.metroTextBoxNombre.Multiline = true;
            this.metroTextBoxNombre.Name = "metroTextBoxNombre";
            this.metroTextBoxNombre.PasswordChar = '\0';
            this.metroTextBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre.SelectedText = "";
            this.metroTextBoxNombre.SelectionLength = 0;
            this.metroTextBoxNombre.SelectionStart = 0;
            this.metroTextBoxNombre.ShortcutsEnabled = true;
            this.metroTextBoxNombre.Size = new System.Drawing.Size(335, 35);
            this.metroTextBoxNombre.TabIndex = 56;
            this.metroTextBoxNombre.UseSelectable = true;
            this.metroTextBoxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelNombre
            // 
            this.metroLabelNombre.AutoSize = true;
            this.metroLabelNombre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelNombre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelNombre.Location = new System.Drawing.Point(52, 132);
            this.metroLabelNombre.Name = "metroLabelNombre";
            this.metroLabelNombre.Size = new System.Drawing.Size(86, 25);
            this.metroLabelNombre.TabIndex = 55;
            this.metroLabelNombre.Text = "Nombre:";
            // 
            // metroTextBoxPrimerApellido
            // 
            // 
            // 
            // 
            this.metroTextBoxPrimerApellido.CustomButton.Image = null;
            this.metroTextBoxPrimerApellido.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.metroTextBoxPrimerApellido.CustomButton.Name = "";
            this.metroTextBoxPrimerApellido.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxPrimerApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrimerApellido.CustomButton.TabIndex = 1;
            this.metroTextBoxPrimerApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrimerApellido.CustomButton.UseSelectable = true;
            this.metroTextBoxPrimerApellido.CustomButton.Visible = false;
            this.metroTextBoxPrimerApellido.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxPrimerApellido.Lines = new string[0];
            this.metroTextBoxPrimerApellido.Location = new System.Drawing.Point(278, 182);
            this.metroTextBoxPrimerApellido.MaxLength = 32767;
            this.metroTextBoxPrimerApellido.Multiline = true;
            this.metroTextBoxPrimerApellido.Name = "metroTextBoxPrimerApellido";
            this.metroTextBoxPrimerApellido.PasswordChar = '\0';
            this.metroTextBoxPrimerApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrimerApellido.SelectedText = "";
            this.metroTextBoxPrimerApellido.SelectionLength = 0;
            this.metroTextBoxPrimerApellido.SelectionStart = 0;
            this.metroTextBoxPrimerApellido.ShortcutsEnabled = true;
            this.metroTextBoxPrimerApellido.Size = new System.Drawing.Size(335, 35);
            this.metroTextBoxPrimerApellido.TabIndex = 58;
            this.metroTextBoxPrimerApellido.UseSelectable = true;
            this.metroTextBoxPrimerApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrimerApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelPrimerApellido
            // 
            this.metroLabelPrimerApellido.AutoSize = true;
            this.metroLabelPrimerApellido.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelPrimerApellido.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelPrimerApellido.Location = new System.Drawing.Point(52, 182);
            this.metroLabelPrimerApellido.Name = "metroLabelPrimerApellido";
            this.metroLabelPrimerApellido.Size = new System.Drawing.Size(149, 25);
            this.metroLabelPrimerApellido.TabIndex = 57;
            this.metroLabelPrimerApellido.Text = "Primer Apellido:";
            // 
            // metroTextBoxSegundoApellido
            // 
            // 
            // 
            // 
            this.metroTextBoxSegundoApellido.CustomButton.Image = null;
            this.metroTextBoxSegundoApellido.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.metroTextBoxSegundoApellido.CustomButton.Name = "";
            this.metroTextBoxSegundoApellido.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxSegundoApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSegundoApellido.CustomButton.TabIndex = 1;
            this.metroTextBoxSegundoApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSegundoApellido.CustomButton.UseSelectable = true;
            this.metroTextBoxSegundoApellido.CustomButton.Visible = false;
            this.metroTextBoxSegundoApellido.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxSegundoApellido.Lines = new string[0];
            this.metroTextBoxSegundoApellido.Location = new System.Drawing.Point(278, 233);
            this.metroTextBoxSegundoApellido.MaxLength = 32767;
            this.metroTextBoxSegundoApellido.Multiline = true;
            this.metroTextBoxSegundoApellido.Name = "metroTextBoxSegundoApellido";
            this.metroTextBoxSegundoApellido.PasswordChar = '\0';
            this.metroTextBoxSegundoApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSegundoApellido.SelectedText = "";
            this.metroTextBoxSegundoApellido.SelectionLength = 0;
            this.metroTextBoxSegundoApellido.SelectionStart = 0;
            this.metroTextBoxSegundoApellido.ShortcutsEnabled = true;
            this.metroTextBoxSegundoApellido.Size = new System.Drawing.Size(335, 35);
            this.metroTextBoxSegundoApellido.TabIndex = 60;
            this.metroTextBoxSegundoApellido.UseSelectable = true;
            this.metroTextBoxSegundoApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSegundoApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelSegundoApellido
            // 
            this.metroLabelSegundoApellido.AutoSize = true;
            this.metroLabelSegundoApellido.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelSegundoApellido.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelSegundoApellido.Location = new System.Drawing.Point(52, 233);
            this.metroLabelSegundoApellido.Name = "metroLabelSegundoApellido";
            this.metroLabelSegundoApellido.Size = new System.Drawing.Size(168, 25);
            this.metroLabelSegundoApellido.TabIndex = 59;
            this.metroLabelSegundoApellido.Text = "Segundo Apellido:";
            // 
            // metroDateTimeFechaNacimento
            // 
            this.metroDateTimeFechaNacimento.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.metroDateTimeFechaNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFechaNacimento.Location = new System.Drawing.Point(278, 290);
            this.metroDateTimeFechaNacimento.MinimumSize = new System.Drawing.Size(0, 35);
            this.metroDateTimeFechaNacimento.Name = "metroDateTimeFechaNacimento";
            this.metroDateTimeFechaNacimento.Size = new System.Drawing.Size(182, 35);
            this.metroDateTimeFechaNacimento.TabIndex = 61;
            // 
            // metroLabelFechaNacimiento
            // 
            this.metroLabelFechaNacimiento.AutoSize = true;
            this.metroLabelFechaNacimiento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelFechaNacimiento.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelFechaNacimiento.Location = new System.Drawing.Point(52, 290);
            this.metroLabelFechaNacimiento.Name = "metroLabelFechaNacimiento";
            this.metroLabelFechaNacimiento.Size = new System.Drawing.Size(195, 25);
            this.metroLabelFechaNacimiento.TabIndex = 62;
            this.metroLabelFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // metroButtonAgregar
            // 
            this.metroButtonAgregar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonAgregar.Location = new System.Drawing.Point(278, 358);
            this.metroButtonAgregar.Name = "metroButtonAgregar";
            this.metroButtonAgregar.Size = new System.Drawing.Size(93, 38);
            this.metroButtonAgregar.TabIndex = 63;
            this.metroButtonAgregar.Text = "Agregar";
            this.metroButtonAgregar.UseSelectable = true;
            this.metroButtonAgregar.Click += new System.EventHandler(this.metroButtonAgregar_Click);
            // 
            // metroGridAsociados
            // 
            this.metroGridAsociados.AllowUserToResizeRows = false;
            this.metroGridAsociados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.metroGridAsociados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridAsociados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAsociados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.metroGridAsociados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAsociados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAsociados.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridAsociados.EnableHeadersVisualStyles = false;
            this.metroGridAsociados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAsociados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAsociados.Location = new System.Drawing.Point(52, 430);
            this.metroGridAsociados.Name = "metroGridAsociados";
            this.metroGridAsociados.ReadOnly = true;
            this.metroGridAsociados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAsociados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridAsociados.RowHeadersWidth = 51;
            this.metroGridAsociados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAsociados.RowTemplate.Height = 24;
            this.metroGridAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridAsociados.Size = new System.Drawing.Size(561, 150);
            this.metroGridAsociados.TabIndex = 73;
            // 
            // AgregarAsociado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(662, 610);
            this.Controls.Add(this.metroGridAsociados);
            this.Controls.Add(this.metroButtonAgregar);
            this.Controls.Add(this.metroDateTimeFechaNacimento);
            this.Controls.Add(this.metroLabelFechaNacimiento);
            this.Controls.Add(this.metroTextBoxSegundoApellido);
            this.Controls.Add(this.metroLabelSegundoApellido);
            this.Controls.Add(this.metroTextBoxPrimerApellido);
            this.Controls.Add(this.metroLabelPrimerApellido);
            this.Controls.Add(this.metroTextBoxNombre);
            this.Controls.Add(this.metroLabelNombre);
            this.Controls.Add(this.metroTextBoxCedula);
            this.Controls.Add(this.metroLabelCapitalCredito);
            this.Name = "AgregarAsociado";
            this.Text = "Agregar Asociado";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AgregarAsociado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAsociados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox metroTextBoxCedula;
        private MetroFramework.Controls.MetroLabel metroLabelCapitalCredito;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre;
        private MetroFramework.Controls.MetroLabel metroLabelNombre;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrimerApellido;
        private MetroFramework.Controls.MetroLabel metroLabelPrimerApellido;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSegundoApellido;
        private MetroFramework.Controls.MetroLabel metroLabelSegundoApellido;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFechaNacimento;
        private MetroFramework.Controls.MetroLabel metroLabelFechaNacimiento;
        private MetroFramework.Controls.MetroButton metroButtonAgregar;
        private MetroFramework.Controls.MetroGrid metroGridAsociados;
    }
}