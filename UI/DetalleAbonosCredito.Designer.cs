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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroComboBoxAsociado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelAsociado = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCreditos = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDetallesAbonos = new MetroFramework.Controls.MetroLabel();
            this.metroGridCreditos = new MetroFramework.Controls.MetroGrid();
            this.metroGridAbonos = new MetroFramework.Controls.MetroGrid();
            this.metroButtonEditar = new MetroFramework.Controls.MetroButton();
            this.metroButtonEliminar = new MetroFramework.Controls.MetroButton();
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGridCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCreditos.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGridCreditos.EnableHeadersVisualStyles = false;
            this.metroGridCreditos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCreditos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCreditos.Location = new System.Drawing.Point(23, 203);
            this.metroGridCreditos.Name = "metroGridCreditos";
            this.metroGridCreditos.ReadOnly = true;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAbonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGridAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAbonos.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGridAbonos.EnableHeadersVisualStyles = false;
            this.metroGridAbonos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAbonos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAbonos.Location = new System.Drawing.Point(23, 466);
            this.metroGridAbonos.Name = "metroGridAbonos";
            this.metroGridAbonos.ReadOnly = true;
            this.metroGridAbonos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAbonos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGridAbonos.RowHeadersWidth = 51;
            this.metroGridAbonos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAbonos.RowTemplate.Height = 24;
            this.metroGridAbonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.metroGridAbonos.Size = new System.Drawing.Size(792, 186);
            this.metroGridAbonos.TabIndex = 88;
            this.metroGridAbonos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridAbonos_CellClick);
            // 
            // metroButtonEditar
            // 
            this.metroButtonEditar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonEditar.Location = new System.Drawing.Point(877, 466);
            this.metroButtonEditar.Name = "metroButtonEditar";
            this.metroButtonEditar.Size = new System.Drawing.Size(93, 38);
            this.metroButtonEditar.TabIndex = 90;
            this.metroButtonEditar.Text = "Editar";
            this.metroButtonEditar.UseSelectable = true;
            this.metroButtonEditar.Click += new System.EventHandler(this.metroButtonEditar_Click);
            // 
            // metroButtonEliminar
            // 
            this.metroButtonEliminar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonEliminar.Location = new System.Drawing.Point(877, 614);
            this.metroButtonEliminar.Name = "metroButtonEliminar";
            this.metroButtonEliminar.Size = new System.Drawing.Size(93, 38);
            this.metroButtonEliminar.TabIndex = 89;
            this.metroButtonEliminar.Text = "Eliminar";
            this.metroButtonEliminar.UseSelectable = true;
            this.metroButtonEliminar.Click += new System.EventHandler(this.metroButtonEliminar_Click);
            // 
            // DetalleAbonosCredito
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 669);
            this.Controls.Add(this.metroButtonEditar);
            this.Controls.Add(this.metroButtonEliminar);
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
        private MetroFramework.Controls.MetroButton metroButtonEditar;
        private MetroFramework.Controls.MetroButton metroButtonEliminar;
    }
}