namespace UI
{
    partial class MensajeAUsuario
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
            this.metroLabelTexto = new MetroFramework.Controls.MetroLabel();
            this.metroButtonOk = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabelTexto
            // 
            this.metroLabelTexto.AutoSize = true;
            this.metroLabelTexto.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabelTexto.Location = new System.Drawing.Point(15, 60);
            this.metroLabelTexto.Name = "metroLabelTexto";
            this.metroLabelTexto.Size = new System.Drawing.Size(41, 20);
            this.metroLabelTexto.TabIndex = 0;
            this.metroLabelTexto.Text = "Texto";
            this.metroLabelTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButtonOk
            // 
            this.metroButtonOk.Location = new System.Drawing.Point(131, 162);
            this.metroButtonOk.Name = "metroButtonOk";
            this.metroButtonOk.Size = new System.Drawing.Size(75, 23);
            this.metroButtonOk.TabIndex = 1;
            this.metroButtonOk.Text = "Ok";
            this.metroButtonOk.UseSelectable = true;
            this.metroButtonOk.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // MensajeAUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(335, 231);
            this.ControlBox = false;
            this.Controls.Add(this.metroButtonOk);
            this.Controls.Add(this.metroLabelTexto);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Movable = false;
            this.Name = "MensajeAUsuario";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Titulo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MensajeAUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelTexto;
        private MetroFramework.Controls.MetroButton metroButtonOk;
    }
}