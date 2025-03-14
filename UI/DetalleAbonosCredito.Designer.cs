using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class DetalleAbonosCredito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroComboBoxAsociado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelAsociado = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCreditos = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDetallesAbonos = new MetroFramework.Controls.MetroLabel();
            this.metroGridCreditos = new MetroFramework.Controls.MetroGrid();
            this.metroGridAbonos = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAbonos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBoxAsociado
            // 
            this.metroComboBoxAsociado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBoxAsociado.FormattingEnabled = true;
            this.metroComboBoxAsociado.ItemHeight = 29;
            this.metroComboBoxAsociado.Location = new System.Drawing.Point(136, 97);
            this.metroComboBoxAsociado.Name = "metroComboBoxAsociado";
            this.metroComboBoxAsociado.Size = new System.Drawing.Size(379, 35);
            this.metroComboBoxAsociado.TabIndex = 44;
            this.metroComboBoxAsociado.UseSelectable = true;
            this.metroComboBoxAsociado.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxAsociado_SelectedIndexChanged);
            // 
            // metroLabelAsociado
            // 
            this.metroLabelAsociado.AutoSize = true;
            this.metroLabelAsociado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAsociado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAsociado.Location = new System.Drawing.Point(23, 97);
            this.metroLabelAsociado.Name = "metroLabelAsociado";
            this.metroLabelAsociado.Size = new System.Drawing.Size(95, 25);
            this.metroLabelAsociado.TabIndex = 43;
            this.metroLabelAsociado.Text = "Asociado:";
            // 
            // metroLabelCreditos
            // 
            this.metroLabelCreditos.AutoSize = true;
            this.metroLabelCreditos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelCreditos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelCreditos.Location = new System.Drawing.Point(23, 175);
            this.metroLabelCreditos.Name = "metroLabelCreditos";
            this.metroLabelCreditos.Size = new System.Drawing.Size(87, 25);
            this.metroLabelCreditos.TabIndex = 46;
            this.metroLabelCreditos.Text = "Creditos:";
            // 
            // metroLabelDetallesAbonos
            // 
            this.metroLabelDetallesAbonos.AutoSize = true;
            this.metroLabelDetallesAbonos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDetallesAbonos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelDetallesAbonos.Location = new System.Drawing.Point(23, 438);
            this.metroLabelDetallesAbonos.Name = "metroLabelDetallesAbonos";
            this.metroLabelDetallesAbonos.Size = new System.Drawing.Size(181, 25);
            this.metroLabelDetallesAbonos.TabIndex = 47;
            this.metroLabelDetallesAbonos.Text = "Detalles de Abonos:";
            // 
            // metroGridCreditos
            // 
            this.metroGridCreditos.AllowUserToResizeRows = false;
            this.metroGridCreditos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.metroGridCreditos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridCreditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridCreditos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.metroGridCreditos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGridCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCreditos.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridCreditos.EnableHeadersVisualStyles = false;
            this.metroGridCreditos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCreditos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCreditos.Location = new System.Drawing.Point(23, 203);
            this.metroGridCreditos.Name = "metroGridCreditos";
            this.metroGridCreditos.ReadOnly = true;
            this.metroGridCreditos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCreditos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridCreditos.RowHeadersWidth = 51;
            this.metroGridCreditos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCreditos.RowTemplate.Height = 24;
            this.metroGridCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.metroGridCreditos.Size = new System.Drawing.Size(966, 186);
            this.metroGridCreditos.TabIndex = 87;
            this.metroGridCreditos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridCreditos_CellClick);
            this.metroGridCreditos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridCreditos_CellContentClick);
            // 
            // metroGridAbonos
            // 
            this.metroGridAbonos.AllowUserToResizeRows = false;
            this.metroGridAbonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.metroGridAbonos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridAbonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAbonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.metroGridAbonos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAbonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGridAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAbonos.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGridAbonos.EnableHeadersVisualStyles = false;
            this.metroGridAbonos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAbonos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAbonos.Location = new System.Drawing.Point(23, 466);
            this.metroGridAbonos.Name = "metroGridAbonos";
            this.metroGridAbonos.ReadOnly = true;
            this.metroGridAbonos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAbonos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGridAbonos.RowHeadersWidth = 51;
            this.metroGridAbonos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAbonos.RowTemplate.Height = 24;
            this.metroGridAbonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.metroGridAbonos.Size = new System.Drawing.Size(792, 186);
            this.metroGridAbonos.TabIndex = 88;
            // 
            // DetalleAbonosCredito
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 669);
            this.Controls.Add(this.metroGridAbonos);
            this.Controls.Add(this.metroGridCreditos);
            this.Controls.Add(this.metroLabelDetallesAbonos);
            this.Controls.Add(this.metroLabelCreditos);
            this.Controls.Add(this.metroComboBoxAsociado);
            this.Controls.Add(this.metroLabelAsociado);
            this.Name = "DetalleAbonosCredito";
            this.Text = "Detalle de Abonos al Credito";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.DetalleAbonosCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAbonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroComboBoxAsociado;
        private MetroFramework.Controls.MetroLabel metroLabelAsociado;
        private MetroFramework.Controls.MetroLabel metroLabelCreditos;
        private MetroFramework.Controls.MetroLabel metroLabelDetallesAbonos;
        private MetroFramework.Controls.MetroGrid metroGridCreditos;
        private MetroFramework.Controls.MetroGrid metroGridAbonos;
    }
}