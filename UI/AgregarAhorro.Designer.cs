using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class AgregarAhorro
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
            this.metroTextBoxMonto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelMonto = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAgregar = new MetroFramework.Controls.MetroButton();
            this.metroGridAhorros = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAhorros)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBoxAsociado
            // 
            this.metroComboBoxAsociado.FormattingEnabled = true;
            this.metroComboBoxAsociado.ItemHeight = 24;
            this.metroComboBoxAsociado.Location = new System.Drawing.Point(139, 87);
            this.metroComboBoxAsociado.Name = "metroComboBoxAsociado";
            this.metroComboBoxAsociado.Size = new System.Drawing.Size(383, 30);
            this.metroComboBoxAsociado.TabIndex = 46;
            this.metroComboBoxAsociado.UseSelectable = true;
            // 
            // metroLabelAsociado
            // 
            this.metroLabelAsociado.AutoSize = true;
            this.metroLabelAsociado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAsociado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAsociado.Location = new System.Drawing.Point(23, 87);
            this.metroLabelAsociado.Name = "metroLabelAsociado";
            this.metroLabelAsociado.Size = new System.Drawing.Size(95, 25);
            this.metroLabelAsociado.TabIndex = 45;
            this.metroLabelAsociado.Text = "Asociado:";
            // 
            // metroTextBoxMonto
            // 
            // 
            // 
            // 
            this.metroTextBoxMonto.CustomButton.Image = null;
            this.metroTextBoxMonto.CustomButton.Location = new System.Drawing.Point(349, 1);
            this.metroTextBoxMonto.CustomButton.Name = "";
            this.metroTextBoxMonto.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMonto.CustomButton.TabIndex = 1;
            this.metroTextBoxMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMonto.CustomButton.UseSelectable = true;
            this.metroTextBoxMonto.CustomButton.Visible = false;
            this.metroTextBoxMonto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxMonto.Lines = new string[0];
            this.metroTextBoxMonto.Location = new System.Drawing.Point(139, 143);
            this.metroTextBoxMonto.MaxLength = 32767;
            this.metroTextBoxMonto.Multiline = true;
            this.metroTextBoxMonto.Name = "metroTextBoxMonto";
            this.metroTextBoxMonto.PasswordChar = '\0';
            this.metroTextBoxMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMonto.SelectedText = "";
            this.metroTextBoxMonto.SelectionLength = 0;
            this.metroTextBoxMonto.SelectionStart = 0;
            this.metroTextBoxMonto.ShortcutsEnabled = true;
            this.metroTextBoxMonto.Size = new System.Drawing.Size(383, 35);
            this.metroTextBoxMonto.TabIndex = 66;
            this.metroTextBoxMonto.UseSelectable = true;
            this.metroTextBoxMonto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMonto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelMonto
            // 
            this.metroLabelMonto.AutoSize = true;
            this.metroLabelMonto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMonto.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelMonto.Location = new System.Drawing.Point(23, 143);
            this.metroLabelMonto.Name = "metroLabelMonto";
            this.metroLabelMonto.Size = new System.Drawing.Size(74, 25);
            this.metroLabelMonto.TabIndex = 65;
            this.metroLabelMonto.Text = "Monto:";
            // 
            // metroButtonAgregar
            // 
            this.metroButtonAgregar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonAgregar.Location = new System.Drawing.Point(223, 210);
            this.metroButtonAgregar.Name = "metroButtonAgregar";
            this.metroButtonAgregar.Size = new System.Drawing.Size(93, 38);
            this.metroButtonAgregar.TabIndex = 73;
            this.metroButtonAgregar.Text = "Agregar";
            this.metroButtonAgregar.UseSelectable = true;
            this.metroButtonAgregar.Click += new System.EventHandler(this.metroButtonAgregar_Click);
            // 
            // metroGridAhorros
            // 
            this.metroGridAhorros.AllowUserToResizeRows = false;
            this.metroGridAhorros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.metroGridAhorros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridAhorros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAhorros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.metroGridAhorros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAhorros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridAhorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAhorros.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridAhorros.EnableHeadersVisualStyles = false;
            this.metroGridAhorros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAhorros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAhorros.Location = new System.Drawing.Point(23, 269);
            this.metroGridAhorros.Name = "metroGridAhorros";
            this.metroGridAhorros.ReadOnly = true;
            this.metroGridAhorros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAhorros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridAhorros.RowHeadersWidth = 51;
            this.metroGridAhorros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAhorros.RowTemplate.Height = 24;
            this.metroGridAhorros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridAhorros.Size = new System.Drawing.Size(499, 150);
            this.metroGridAhorros.TabIndex = 74;
            // 
            // AgregarAhorro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(552, 442);
            this.Controls.Add(this.metroGridAhorros);
            this.Controls.Add(this.metroButtonAgregar);
            this.Controls.Add(this.metroTextBoxMonto);
            this.Controls.Add(this.metroLabelMonto);
            this.Controls.Add(this.metroComboBoxAsociado);
            this.Controls.Add(this.metroLabelAsociado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarAhorro";
            this.Text = "Agregar Ahorro";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AgregarAhorro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAhorros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroComboBoxAsociado;
        private MetroFramework.Controls.MetroLabel metroLabelAsociado;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMonto;
        private MetroFramework.Controls.MetroLabel metroLabelMonto;
        private MetroFramework.Controls.MetroButton metroButtonAgregar;
        private MetroFramework.Controls.MetroGrid metroGridAhorros;
    }
}