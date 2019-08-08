namespace ComHe_Pilotage.Pmc.Reclamation {
    partial class pmcIncidenceService {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            this.reclamationParServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lcPrincipal = new DevExpress.XtraLayout.LayoutControl();
            this.chIncidenceParService = new DevExpress.XtraCharts.ChartControl();
            this.gcIncidenceParService = new DevExpress.XtraGrid.GridControl();
            this.gvIncidenceParService = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colservice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbReclamations = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lciPrincipal = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.reclamationParServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).BeginInit();
            this.lcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chIncidenceParService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIncidenceParService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIncidenceParService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // reclamationParServiceBindingSource
            // 
            this.reclamationParServiceBindingSource.DataSource = typeof(ComHe_Objets.Reclamations.ReclamationParService);
            // 
            // lcPrincipal
            // 
            this.lcPrincipal.Controls.Add(this.chIncidenceParService);
            this.lcPrincipal.Controls.Add(this.gcIncidenceParService);
            this.lcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lcPrincipal.Name = "lcPrincipal";
            this.lcPrincipal.Root = this.lciPrincipal;
            this.lcPrincipal.Size = new System.Drawing.Size(1026, 515);
            this.lcPrincipal.TabIndex = 0;
            this.lcPrincipal.Text = "layoutControl1";
            // 
            // chIncidenceParService
            // 
            xyDiagram1.AxisX.AutoScaleBreaks.Enabled = true;
            xyDiagram1.AxisX.MinorCount = 1;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.MinorCount = 1;
            xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chIncidenceParService.Diagram = xyDiagram1;
            this.chIncidenceParService.Location = new System.Drawing.Point(516, 3);
            this.chIncidenceParService.Name = "chIncidenceParService";
            series1.ArgumentDataMember = "service";
            series1.ColorDataMember = "id";
            series1.DataSource = this.reclamationParServiceBindingSource;
            series1.LegendText = "Nombre de réclamations";
            series1.Name = "serieNbParServices";
            series1.ValueDataMembersSerializable = "nbReclamations";
            sideBySideBarSeriesView1.ColorEach = true;
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            series1.View = sideBySideBarSeriesView1;
            this.chIncidenceParService.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chIncidenceParService.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.chIncidenceParService.Size = new System.Drawing.Size(507, 509);
            this.chIncidenceParService.TabIndex = 5;
            this.chIncidenceParService.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chIncidenceParService_CustomDrawSeriesPoint);
            // 
            // gcIncidenceParService
            // 
            this.gcIncidenceParService.DataSource = this.reclamationParServiceBindingSource;
            this.gcIncidenceParService.Location = new System.Drawing.Point(3, 3);
            this.gcIncidenceParService.MainView = this.gvIncidenceParService;
            this.gcIncidenceParService.Name = "gcIncidenceParService";
            this.gcIncidenceParService.Size = new System.Drawing.Size(507, 509);
            this.gcIncidenceParService.TabIndex = 4;
            this.gcIncidenceParService.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIncidenceParService});
            // 
            // gvIncidenceParService
            // 
            this.gvIncidenceParService.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colservice,
            this.colnbReclamations});
            this.gvIncidenceParService.GridControl = this.gcIncidenceParService;
            this.gvIncidenceParService.Name = "gvIncidenceParService";
            // 
            // colservice
            // 
            this.colservice.Caption = "Service";
            this.colservice.FieldName = "service";
            this.colservice.Name = "colservice";
            this.colservice.OptionsColumn.ReadOnly = true;
            this.colservice.Visible = true;
            this.colservice.VisibleIndex = 0;
            // 
            // colnbReclamations
            // 
            this.colnbReclamations.Caption = "Nombre de réclamations";
            this.colnbReclamations.FieldName = "nbReclamations";
            this.colnbReclamations.Name = "colnbReclamations";
            this.colnbReclamations.OptionsColumn.ReadOnly = true;
            this.colnbReclamations.Visible = true;
            this.colnbReclamations.VisibleIndex = 1;
            // 
            // lciPrincipal
            // 
            this.lciPrincipal.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lciPrincipal.GroupBordersVisible = false;
            this.lciPrincipal.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.lciPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lciPrincipal.Name = "lciPrincipal";
            this.lciPrincipal.OptionsItemText.TextToControlDistance = 4;
            this.lciPrincipal.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciPrincipal.Size = new System.Drawing.Size(1026, 515);
            this.lciPrincipal.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcIncidenceParService;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(513, 515);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chIncidenceParService;
            this.layoutControlItem2.Location = new System.Drawing.Point(513, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(513, 515);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // pmcIncidenceService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcPrincipal);
            this.Name = "pmcIncidenceService";
            this.Size = new System.Drawing.Size(1026, 515);
            ((System.ComponentModel.ISupportInitialize)(this.reclamationParServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).EndInit();
            this.lcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chIncidenceParService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIncidenceParService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIncidenceParService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcPrincipal;
        private DevExpress.XtraLayout.LayoutControlGroup lciPrincipal;
        private DevExpress.XtraCharts.ChartControl chIncidenceParService;
        private DevExpress.XtraGrid.GridControl gcIncidenceParService;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIncidenceParService;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource reclamationParServiceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colservice;
        private DevExpress.XtraGrid.Columns.GridColumn colnbReclamations;
    }
}
