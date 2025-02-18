using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class EstadoFinancieroHoy
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
            this.metroTextBoxIngresos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelIngresos = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEgresos = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEgresos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelLiquidez = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxLiquidez = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
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
            this.metroTextBoxIngresos.Location = new System.Drawing.Point(42, 169);
            this.metroTextBoxIngresos.MaxLength = 32767;
            this.metroTextBoxIngresos.Multiline = true;
            this.metroTextBoxIngresos.Name = "metroTextBoxIngresos";
            this.metroTextBoxIngresos.PasswordChar = '\0';
            this.metroTextBoxIngresos.ReadOnly = true;
            this.metroTextBoxIngresos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxIngresos.SelectedText = "";
            this.metroTextBoxIngresos.SelectionLength = 0;
            this.metroTextBoxIngresos.SelectionStart = 0;
            this.metroTextBoxIngresos.ShortcutsEnabled = true;
            this.metroTextBoxIngresos.Size = new System.Drawing.Size(214, 35);
            this.metroTextBoxIngresos.TabIndex = 39;
            this.metroTextBoxIngresos.UseSelectable = true;
            this.metroTextBoxIngresos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIngresos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelIngresos
            // 
            this.metroLabelIngresos.AutoSize = true;
            this.metroLabelIngresos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelIngresos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelIngresos.Location = new System.Drawing.Point(97, 132);
            this.metroLabelIngresos.Name = "metroLabelIngresos";
            this.metroLabelIngresos.Size = new System.Drawing.Size(84, 25);
            this.metroLabelIngresos.TabIndex = 40;
            this.metroLabelIngresos.Text = "Ingresos";
            // 
            // metroLabelEgresos
            // 
            this.metroLabelEgresos.AutoSize = true;
            this.metroLabelEgresos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelEgresos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelEgresos.Location = new System.Drawing.Point(358, 132);
            this.metroLabelEgresos.Name = "metroLabelEgresos";
            this.metroLabelEgresos.Size = new System.Drawing.Size(77, 25);
            this.metroLabelEgresos.TabIndex = 42;
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
            this.metroTextBoxEgresos.Location = new System.Drawing.Point(303, 169);
            this.metroTextBoxEgresos.MaxLength = 32767;
            this.metroTextBoxEgresos.Multiline = true;
            this.metroTextBoxEgresos.Name = "metroTextBoxEgresos";
            this.metroTextBoxEgresos.PasswordChar = '\0';
            this.metroTextBoxEgresos.ReadOnly = true;
            this.metroTextBoxEgresos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEgresos.SelectedText = "";
            this.metroTextBoxEgresos.SelectionLength = 0;
            this.metroTextBoxEgresos.SelectionStart = 0;
            this.metroTextBoxEgresos.ShortcutsEnabled = true;
            this.metroTextBoxEgresos.Size = new System.Drawing.Size(214, 35);
            this.metroTextBoxEgresos.TabIndex = 41;
            this.metroTextBoxEgresos.UseSelectable = true;
            this.metroTextBoxEgresos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEgresos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelLiquidez
            // 
            this.metroLabelLiquidez.AutoSize = true;
            this.metroLabelLiquidez.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelLiquidez.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelLiquidez.Location = new System.Drawing.Point(604, 132);
            this.metroLabelLiquidez.Name = "metroLabelLiquidez";
            this.metroLabelLiquidez.Size = new System.Drawing.Size(83, 25);
            this.metroLabelLiquidez.TabIndex = 44;
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
            this.metroTextBoxLiquidez.Location = new System.Drawing.Point(549, 169);
            this.metroTextBoxLiquidez.MaxLength = 32767;
            this.metroTextBoxLiquidez.Multiline = true;
            this.metroTextBoxLiquidez.Name = "metroTextBoxLiquidez";
            this.metroTextBoxLiquidez.PasswordChar = '\0';
            this.metroTextBoxLiquidez.ReadOnly = true;
            this.metroTextBoxLiquidez.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLiquidez.SelectedText = "";
            this.metroTextBoxLiquidez.SelectionLength = 0;
            this.metroTextBoxLiquidez.SelectionStart = 0;
            this.metroTextBoxLiquidez.ShortcutsEnabled = true;
            this.metroTextBoxLiquidez.Size = new System.Drawing.Size(214, 35);
            this.metroTextBoxLiquidez.TabIndex = 43;
            this.metroTextBoxLiquidez.UseSelectable = true;
            this.metroTextBoxLiquidez.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLiquidez.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EstadoFinancieroHoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.metroLabelLiquidez);
            this.Controls.Add(this.metroTextBoxLiquidez);
            this.Controls.Add(this.metroLabelEgresos);
            this.Controls.Add(this.metroTextBoxEgresos);
            this.Controls.Add(this.metroLabelIngresos);
            this.Controls.Add(this.metroTextBoxIngresos);
            this.Name = "EstadoFinancieroHoy";
            this.Resizable = false;
            this.Text = "Estado Financiero al Día";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.EstadoFinancieroHoy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxIngresos;
        private MetroFramework.Controls.MetroLabel metroLabelIngresos;
        private MetroFramework.Controls.MetroLabel metroLabelEgresos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEgresos;
        private MetroFramework.Controls.MetroLabel metroLabelLiquidez;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLiquidez;
    }
}