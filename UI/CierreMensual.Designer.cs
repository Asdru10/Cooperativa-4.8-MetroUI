using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class CierreMensual
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
            this.metroLabelLiquidez = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxLiquidez = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelEgresos = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEgresos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelIngresos = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxIngresos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelMes = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAnno = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxMes = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxAnno = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonObtener = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabelLiquidez
            // 
            this.metroLabelLiquidez.AutoSize = true;
            this.metroLabelLiquidez.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelLiquidez.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelLiquidez.Location = new System.Drawing.Point(582, 238);
            this.metroLabelLiquidez.Name = "metroLabelLiquidez";
            this.metroLabelLiquidez.Size = new System.Drawing.Size(83, 25);
            this.metroLabelLiquidez.TabIndex = 51;
            this.metroLabelLiquidez.Text = "Liquidez";
            // 
            // metroTextBoxLiquidez
            // 
            // 
            // 
            // 
            this.metroTextBoxLiquidez.CustomButton.Image = null;
            this.metroTextBoxLiquidez.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.metroTextBoxLiquidez.CustomButton.Name = "";
            this.metroTextBoxLiquidez.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxLiquidez.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLiquidez.CustomButton.TabIndex = 1;
            this.metroTextBoxLiquidez.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLiquidez.CustomButton.UseSelectable = true;
            this.metroTextBoxLiquidez.CustomButton.Visible = false;
            this.metroTextBoxLiquidez.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxLiquidez.Lines = new string[0];
            this.metroTextBoxLiquidez.Location = new System.Drawing.Point(527, 266);
            this.metroTextBoxLiquidez.MaxLength = 32767;
            this.metroTextBoxLiquidez.Name = "metroTextBoxLiquidez";
            this.metroTextBoxLiquidez.PasswordChar = '\0';
            this.metroTextBoxLiquidez.ReadOnly = true;
            this.metroTextBoxLiquidez.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLiquidez.SelectedText = "";
            this.metroTextBoxLiquidez.SelectionLength = 0;
            this.metroTextBoxLiquidez.SelectionStart = 0;
            this.metroTextBoxLiquidez.ShortcutsEnabled = true;
            this.metroTextBoxLiquidez.Size = new System.Drawing.Size(214, 35);
            this.metroTextBoxLiquidez.TabIndex = 50;
            this.metroTextBoxLiquidez.UseSelectable = true;
            this.metroTextBoxLiquidez.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLiquidez.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelEgresos
            // 
            this.metroLabelEgresos.AutoSize = true;
            this.metroLabelEgresos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelEgresos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelEgresos.Location = new System.Drawing.Point(342, 238);
            this.metroLabelEgresos.Name = "metroLabelEgresos";
            this.metroLabelEgresos.Size = new System.Drawing.Size(77, 25);
            this.metroLabelEgresos.TabIndex = 49;
            this.metroLabelEgresos.Text = "Egresos";
            // 
            // metroTextBoxEgresos
            // 
            // 
            // 
            // 
            this.metroTextBoxEgresos.CustomButton.Image = null;
            this.metroTextBoxEgresos.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.metroTextBoxEgresos.CustomButton.Name = "";
            this.metroTextBoxEgresos.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxEgresos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEgresos.CustomButton.TabIndex = 1;
            this.metroTextBoxEgresos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEgresos.CustomButton.UseSelectable = true;
            this.metroTextBoxEgresos.CustomButton.Visible = false;
            this.metroTextBoxEgresos.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxEgresos.Lines = new string[0];
            this.metroTextBoxEgresos.Location = new System.Drawing.Point(282, 266);
            this.metroTextBoxEgresos.MaxLength = 32767;
            this.metroTextBoxEgresos.Name = "metroTextBoxEgresos";
            this.metroTextBoxEgresos.PasswordChar = '\0';
            this.metroTextBoxEgresos.ReadOnly = true;
            this.metroTextBoxEgresos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEgresos.SelectedText = "";
            this.metroTextBoxEgresos.SelectionLength = 0;
            this.metroTextBoxEgresos.SelectionStart = 0;
            this.metroTextBoxEgresos.ShortcutsEnabled = true;
            this.metroTextBoxEgresos.Size = new System.Drawing.Size(214, 35);
            this.metroTextBoxEgresos.TabIndex = 48;
            this.metroTextBoxEgresos.UseSelectable = true;
            this.metroTextBoxEgresos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEgresos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelIngresos
            // 
            this.metroLabelIngresos.AutoSize = true;
            this.metroLabelIngresos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelIngresos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelIngresos.Location = new System.Drawing.Point(97, 238);
            this.metroLabelIngresos.Name = "metroLabelIngresos";
            this.metroLabelIngresos.Size = new System.Drawing.Size(84, 25);
            this.metroLabelIngresos.TabIndex = 47;
            this.metroLabelIngresos.Text = "Ingresos";
            // 
            // metroTextBoxIngresos
            // 
            // 
            // 
            // 
            this.metroTextBoxIngresos.CustomButton.Image = null;
            this.metroTextBoxIngresos.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.metroTextBoxIngresos.CustomButton.Name = "";
            this.metroTextBoxIngresos.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxIngresos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxIngresos.CustomButton.TabIndex = 1;
            this.metroTextBoxIngresos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxIngresos.CustomButton.UseSelectable = true;
            this.metroTextBoxIngresos.CustomButton.Visible = false;
            this.metroTextBoxIngresos.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxIngresos.Lines = new string[0];
            this.metroTextBoxIngresos.Location = new System.Drawing.Point(36, 266);
            this.metroTextBoxIngresos.MaxLength = 32767;
            this.metroTextBoxIngresos.Name = "metroTextBoxIngresos";
            this.metroTextBoxIngresos.PasswordChar = '\0';
            this.metroTextBoxIngresos.ReadOnly = true;
            this.metroTextBoxIngresos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxIngresos.SelectedText = "";
            this.metroTextBoxIngresos.SelectionLength = 0;
            this.metroTextBoxIngresos.SelectionStart = 0;
            this.metroTextBoxIngresos.ShortcutsEnabled = true;
            this.metroTextBoxIngresos.Size = new System.Drawing.Size(214, 35);
            this.metroTextBoxIngresos.TabIndex = 46;
            this.metroTextBoxIngresos.UseSelectable = true;
            this.metroTextBoxIngresos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIngresos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelMes
            // 
            this.metroLabelMes.AutoSize = true;
            this.metroLabelMes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelMes.Location = new System.Drawing.Point(160, 89);
            this.metroLabelMes.Name = "metroLabelMes";
            this.metroLabelMes.Size = new System.Drawing.Size(47, 25);
            this.metroLabelMes.TabIndex = 52;
            this.metroLabelMes.Text = "Mes";
            // 
            // metroLabelAnno
            // 
            this.metroLabelAnno.AutoSize = true;
            this.metroLabelAnno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAnno.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAnno.Location = new System.Drawing.Point(372, 89);
            this.metroLabelAnno.Name = "metroLabelAnno";
            this.metroLabelAnno.Size = new System.Drawing.Size(47, 25);
            this.metroLabelAnno.TabIndex = 53;
            this.metroLabelAnno.Text = "Año";
            // 
            // metroComboBoxMes
            // 
            this.metroComboBoxMes.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBoxMes.FormattingEnabled = true;
            this.metroComboBoxMes.ItemHeight = 29;
            this.metroComboBoxMes.Location = new System.Drawing.Point(85, 117);
            this.metroComboBoxMes.Name = "metroComboBoxMes";
            this.metroComboBoxMes.Size = new System.Drawing.Size(192, 35);
            this.metroComboBoxMes.TabIndex = 54;
            this.metroComboBoxMes.UseSelectable = true;
            this.metroComboBoxMes.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxMes_SelectedIndexChanged);
            // 
            // metroComboBoxAnno
            // 
            this.metroComboBoxAnno.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBoxAnno.FormattingEnabled = true;
            this.metroComboBoxAnno.ItemHeight = 29;
            this.metroComboBoxAnno.Location = new System.Drawing.Point(331, 117);
            this.metroComboBoxAnno.Name = "metroComboBoxAnno";
            this.metroComboBoxAnno.Size = new System.Drawing.Size(131, 35);
            this.metroComboBoxAnno.TabIndex = 55;
            this.metroComboBoxAnno.UseSelectable = true;
            // 
            // metroButtonObtener
            // 
            this.metroButtonObtener.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonObtener.Location = new System.Drawing.Point(531, 117);
            this.metroButtonObtener.Name = "metroButtonObtener";
            this.metroButtonObtener.Size = new System.Drawing.Size(93, 38);
            this.metroButtonObtener.TabIndex = 56;
            this.metroButtonObtener.Text = "Obtener";
            this.metroButtonObtener.UseSelectable = true;
            this.metroButtonObtener.Click += new System.EventHandler(this.metroButtonObtener_Click);
            // 
            // CierreMensual
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(774, 360);
            this.Controls.Add(this.metroButtonObtener);
            this.Controls.Add(this.metroComboBoxAnno);
            this.Controls.Add(this.metroComboBoxMes);
            this.Controls.Add(this.metroLabelAnno);
            this.Controls.Add(this.metroLabelMes);
            this.Controls.Add(this.metroLabelLiquidez);
            this.Controls.Add(this.metroTextBoxLiquidez);
            this.Controls.Add(this.metroLabelEgresos);
            this.Controls.Add(this.metroTextBoxEgresos);
            this.Controls.Add(this.metroLabelIngresos);
            this.Controls.Add(this.metroTextBoxIngresos);
            this.Name = "CierreMensual";
            this.Text = "Cierre Mensual";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.CierreMensual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabelLiquidez;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLiquidez;
        private MetroFramework.Controls.MetroLabel metroLabelEgresos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEgresos;
        private MetroFramework.Controls.MetroLabel metroLabelIngresos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIngresos;
        private MetroFramework.Controls.MetroLabel metroLabelMes;
        private MetroFramework.Controls.MetroLabel metroLabelAnno;
        private MetroFramework.Controls.MetroComboBox metroComboBoxMes;
        private MetroFramework.Controls.MetroComboBox metroComboBoxAnno;
        private MetroFramework.Controls.MetroButton metroButtonObtener;
    }
}