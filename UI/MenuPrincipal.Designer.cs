using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.asociadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ahorroExtraordinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeCuentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonoACréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeAbonosACréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeCréditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosFinancierosAlDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asociadosToolStripMenuItem,
            this.créditosToolStripMenuItem,
            this.contabilidadToolStripMenuItem,
            this.notificacionexToolStripMenuItem,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(803, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // asociadosToolStripMenuItem
            // 
            this.asociadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.estadoDeCuentaToolStripMenuItem,
            this.ahorroExtraordinarioToolStripMenuItem,
            this.estadoDeCuentaToolStripMenuItem1});
            this.asociadosToolStripMenuItem.Name = "asociadosToolStripMenuItem";
            this.asociadosToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.asociadosToolStripMenuItem.Text = "Asociados";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // estadoDeCuentaToolStripMenuItem
            // 
            this.estadoDeCuentaToolStripMenuItem.Name = "estadoDeCuentaToolStripMenuItem";
            this.estadoDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.estadoDeCuentaToolStripMenuItem.Text = "Aporte Mensual";
            this.estadoDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.estadoDeCuentaToolStripMenuItem_Click);
            // 
            // ahorroExtraordinarioToolStripMenuItem
            // 
            this.ahorroExtraordinarioToolStripMenuItem.Name = "ahorroExtraordinarioToolStripMenuItem";
            this.ahorroExtraordinarioToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.ahorroExtraordinarioToolStripMenuItem.Text = "Ahorro Extraordinario";
            this.ahorroExtraordinarioToolStripMenuItem.Click += new System.EventHandler(this.ahorroExtraordinarioToolStripMenuItem_Click);
            // 
            // estadoDeCuentaToolStripMenuItem1
            // 
            this.estadoDeCuentaToolStripMenuItem1.Name = "estadoDeCuentaToolStripMenuItem1";
            this.estadoDeCuentaToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.estadoDeCuentaToolStripMenuItem1.Text = "Estado de Cuenta";
            this.estadoDeCuentaToolStripMenuItem1.Click += new System.EventHandler(this.estadoDeCuentaToolStripMenuItem1_Click);
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaSolicitudToolStripMenuItem,
            this.abonoACréditoToolStripMenuItem,
            this.detalleDeAbonosACréditoToolStripMenuItem,
            this.reporteDeCréditosToolStripMenuItem});
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.créditosToolStripMenuItem.Text = "Créditos";
            // 
            // nuevaSolicitudToolStripMenuItem
            // 
            this.nuevaSolicitudToolStripMenuItem.Name = "nuevaSolicitudToolStripMenuItem";
            this.nuevaSolicitudToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.nuevaSolicitudToolStripMenuItem.Text = "Nueva Solicitud";
            this.nuevaSolicitudToolStripMenuItem.Click += new System.EventHandler(this.nuevaSolicitudToolStripMenuItem_Click);
            // 
            // abonoACréditoToolStripMenuItem
            // 
            this.abonoACréditoToolStripMenuItem.Name = "abonoACréditoToolStripMenuItem";
            this.abonoACréditoToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.abonoACréditoToolStripMenuItem.Text = "Abono a Crédito";
            this.abonoACréditoToolStripMenuItem.Click += new System.EventHandler(this.abonoACréditoToolStripMenuItem_Click_1);
            // 
            // detalleDeAbonosACréditoToolStripMenuItem
            // 
            this.detalleDeAbonosACréditoToolStripMenuItem.Name = "detalleDeAbonosACréditoToolStripMenuItem";
            this.detalleDeAbonosACréditoToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.detalleDeAbonosACréditoToolStripMenuItem.Text = "Detalle de Abonos a Crédito";
            this.detalleDeAbonosACréditoToolStripMenuItem.Click += new System.EventHandler(this.detalleDeAbonosACréditoToolStripMenuItem_Click);
            // 
            // reporteDeCréditosToolStripMenuItem
            // 
            this.reporteDeCréditosToolStripMenuItem.Name = "reporteDeCréditosToolStripMenuItem";
            this.reporteDeCréditosToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.reporteDeCréditosToolStripMenuItem.Text = "Reporte de Créditos";
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreMensualToolStripMenuItem,
            this.cieToolStripMenuItem,
            this.estadosFinancierosAlDíaToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            // 
            // cierreMensualToolStripMenuItem
            // 
            this.cierreMensualToolStripMenuItem.Name = "cierreMensualToolStripMenuItem";
            this.cierreMensualToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.cierreMensualToolStripMenuItem.Text = "Cierre Mensual";
            this.cierreMensualToolStripMenuItem.Click += new System.EventHandler(this.cierreMensualToolStripMenuItem_Click);
            // 
            // cieToolStripMenuItem
            // 
            this.cieToolStripMenuItem.Name = "cieToolStripMenuItem";
            this.cieToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.cieToolStripMenuItem.Text = "Cierre Anual";
            this.cieToolStripMenuItem.Click += new System.EventHandler(this.cieToolStripMenuItem_Click);
            // 
            // estadosFinancierosAlDíaToolStripMenuItem
            // 
            this.estadosFinancierosAlDíaToolStripMenuItem.Name = "estadosFinancierosAlDíaToolStripMenuItem";
            this.estadosFinancierosAlDíaToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.estadosFinancierosAlDíaToolStripMenuItem.Text = "Estados financieros al día";
            this.estadosFinancierosAlDíaToolStripMenuItem.Click += new System.EventHandler(this.estadosFinancierosAlDíaToolStripMenuItem_Click);
            // 
            // notificacionexToolStripMenuItem
            // 
            this.notificacionexToolStripMenuItem.Name = "notificacionexToolStripMenuItem";
            this.notificacionexToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.notificacionexToolStripMenuItem.Text = "Notificaciones";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(82, 24);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(65, 24);
            this.helpMenu.Text = "Ay&uda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.contentsToolStripMenuItem.Text = "&Contenido";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.searchToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(215, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(20, 651);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(803, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "Nuevo";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "Abrir";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printToolStripButton.Text = "Imprimir";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printPreviewToolStripButton.Text = "Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "Ayuda";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(20, 90);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(803, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(843, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem asociadosToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem estadoDeCuentaToolStripMenuItem;
        private ToolStripMenuItem ahorroExtraordinarioToolStripMenuItem;
        private ToolStripMenuItem estadoDeCuentaToolStripMenuItem1;
        private ToolStripMenuItem créditosToolStripMenuItem;
        private ToolStripMenuItem nuevaSolicitudToolStripMenuItem;
        private ToolStripMenuItem reporteDeCréditosToolStripMenuItem;
        private ToolStripMenuItem contabilidadToolStripMenuItem;
        private ToolStripMenuItem cierreMensualToolStripMenuItem;
        private ToolStripMenuItem cieToolStripMenuItem;
        private ToolStripMenuItem estadosFinancierosAlDíaToolStripMenuItem;
        private ToolStripMenuItem notificacionexToolStripMenuItem;
        private ToolStripMenuItem abonoACréditoToolStripMenuItem;
        private ToolStripMenuItem detalleDeAbonosACréditoToolStripMenuItem;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton printToolStripButton;
        private ToolStripButton printPreviewToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton helpToolStripButton;
        private ToolStrip toolStrip;
        private ToolStripMenuItem transaccionesToolStripMenuItem;
    }
}



