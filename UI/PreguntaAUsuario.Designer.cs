namespace UI
{
    partial class PreguntaAUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreguntaAUsuario));
            this.pictureBoxIcono = new System.Windows.Forms.PictureBox();
            this.metroButtonSi = new MetroFramework.Controls.MetroButton();
            this.metroLabelTexto = new MetroFramework.Controls.MetroLabel();
            this.metroButtonNo = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcono
            // 
            this.pictureBoxIcono.Image = global::UI.Properties.Resources.pregunta;
            this.pictureBoxIcono.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcono.InitialImage")));
            this.pictureBoxIcono.Location = new System.Drawing.Point(13, 95);
            this.pictureBoxIcono.Name = "pictureBoxIcono";
            this.pictureBoxIcono.Size = new System.Drawing.Size(56, 56);
            this.pictureBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIcono.TabIndex = 5;
            this.pictureBoxIcono.TabStop = false;
            // 
            // metroButtonSi
            // 
            this.metroButtonSi.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonSi.Location = new System.Drawing.Point(87, 198);
            this.metroButtonSi.Name = "metroButtonSi";
            this.metroButtonSi.Size = new System.Drawing.Size(68, 33);
            this.metroButtonSi.TabIndex = 4;
            this.metroButtonSi.Text = "Sí";
            this.metroButtonSi.UseSelectable = true;
            this.metroButtonSi.Click += new System.EventHandler(this.metroButtonSi_Click);
            // 
            // metroLabelTexto
            // 
            this.metroLabelTexto.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelTexto.Location = new System.Drawing.Point(87, 60);
            this.metroLabelTexto.Name = "metroLabelTexto";
            this.metroLabelTexto.Size = new System.Drawing.Size(241, 126);
            this.metroLabelTexto.TabIndex = 3;
            this.metroLabelTexto.Text = "Texto";
            this.metroLabelTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelTexto.WrapToLine = true;
            // 
            // metroButtonNo
            // 
            this.metroButtonNo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonNo.Location = new System.Drawing.Point(205, 198);
            this.metroButtonNo.Name = "metroButtonNo";
            this.metroButtonNo.Size = new System.Drawing.Size(68, 33);
            this.metroButtonNo.TabIndex = 6;
            this.metroButtonNo.Text = "No";
            this.metroButtonNo.UseSelectable = true;
            this.metroButtonNo.Click += new System.EventHandler(this.metroButtonNo_Click);
            // 
            // PreguntaAUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(351, 240);
            this.ControlBox = false;
            this.Controls.Add(this.metroButtonNo);
            this.Controls.Add(this.pictureBoxIcono);
            this.Controls.Add(this.metroButtonSi);
            this.Controls.Add(this.metroLabelTexto);
            this.Name = "PreguntaAUsuario";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Titulo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PreguntaAUsuario_FormClosed);
            this.Load += new System.EventHandler(this.PreguntaAUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcono;
        private MetroFramework.Controls.MetroButton metroButtonSi;
        private MetroFramework.Controls.MetroLabel metroLabelTexto;
        private MetroFramework.Controls.MetroButton metroButtonNo;
    }
}