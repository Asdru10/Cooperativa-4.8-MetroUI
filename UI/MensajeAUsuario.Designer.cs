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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeAUsuario));
            this.metroLabelTexto = new MetroFramework.Controls.MetroLabel();
            this.metroButtonOk = new MetroFramework.Controls.MetroButton();
            this.pictureBoxIcono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelTexto
            // 
            this.metroLabelTexto.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelTexto.Location = new System.Drawing.Point(92, 60);
            this.metroLabelTexto.Name = "metroLabelTexto";
            this.metroLabelTexto.Size = new System.Drawing.Size(241, 126);
            this.metroLabelTexto.TabIndex = 0;
            this.metroLabelTexto.Text = "Texto";
            this.metroLabelTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelTexto.WrapToLine = true;
            this.metroLabelTexto.Click += new System.EventHandler(this.metroLabelTexto_Click);
            // 
            // metroButtonOk
            // 
            this.metroButtonOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonOk.Location = new System.Drawing.Point(138, 198);
            this.metroButtonOk.Name = "metroButtonOk";
            this.metroButtonOk.Size = new System.Drawing.Size(68, 33);
            this.metroButtonOk.TabIndex = 1;
            this.metroButtonOk.Text = "Ok";
            this.metroButtonOk.UseSelectable = true;
            this.metroButtonOk.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // pictureBoxIcono
            // 
            this.pictureBoxIcono.Image = global::UI.Properties.Resources.pregunta;
            this.pictureBoxIcono.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcono.InitialImage")));
            this.pictureBoxIcono.Location = new System.Drawing.Point(18, 95);
            this.pictureBoxIcono.Name = "pictureBoxIcono";
            this.pictureBoxIcono.Size = new System.Drawing.Size(56, 56);
            this.pictureBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIcono.TabIndex = 2;
            this.pictureBoxIcono.TabStop = false;
            // 
            // MensajeAUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(351, 240);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxIcono);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelTexto;
        private MetroFramework.Controls.MetroButton metroButtonOk;
        private System.Windows.Forms.PictureBox pictureBoxIcono;
    }
}