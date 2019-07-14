namespace ComHe_Pilotage {
    partial class pmcSatisfactionModel {
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
            DevExpress.XtraCharts.Strip strip1 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions1 = new DevExpress.XtraCharts.HatchFillOptions();
            DevExpress.XtraCharts.Strip strip2 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions2 = new DevExpress.XtraCharts.HatchFillOptions();
            DevExpress.XtraCharts.Strip strip3 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions3 = new DevExpress.XtraCharts.HatchFillOptions();
            DevExpress.XtraCharts.Strip strip4 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions4 = new DevExpress.XtraCharts.HatchFillOptions();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView2 = new DevExpress.XtraCharts.PointSeriesView();
            this.lcSatisfactionModel = new DevExpress.XtraLayout.LayoutControl();
            this.chSatisfactionModel = new DevExpress.XtraCharts.ChartControl();
            this.dimensionSatisfactionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trSatisfactionModel = new DevExpress.XtraTreeList.TreeList();
            this.colnom = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repoBtAjout = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colpoids = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colsatisfaction = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lcgSatisfactionModel = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcSatisfactionModel)).BeginInit();
            this.lcSatisfactionModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chSatisfactionModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSatisfactionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trSatisfactionModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtAjout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSatisfactionModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcSatisfactionModel
            // 
            this.lcSatisfactionModel.Controls.Add(this.chSatisfactionModel);
            this.lcSatisfactionModel.Controls.Add(this.trSatisfactionModel);
            this.lcSatisfactionModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcSatisfactionModel.Location = new System.Drawing.Point(0, 0);
            this.lcSatisfactionModel.Name = "lcSatisfactionModel";
            this.lcSatisfactionModel.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(952, 260, 312, 437);
            this.lcSatisfactionModel.Root = this.lcgSatisfactionModel;
            this.lcSatisfactionModel.Size = new System.Drawing.Size(913, 542);
            this.lcSatisfactionModel.TabIndex = 0;
            this.lcSatisfactionModel.Text = "layoutControl1";
            // 
            // chSatisfactionModel
            // 
            this.chSatisfactionModel.DataSource = this.dimensionSatisfactionModelBindingSource;
            strip1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(185)))), ((int)(((byte)(183)))));
            strip1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.SolidDiamond;
            strip1.FillStyle.Options = hatchFillOptions1;
            strip1.MaxLimit.AxisValueSerializable = "0.5";
            strip1.MinLimit.AxisValueSerializable = "0";
            strip1.Name = "Faiblesse";
            strip1.Tag = "Faiblesse";
            strip2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            strip2.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            hatchFillOptions2.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            strip2.FillStyle.Options = hatchFillOptions2;
            strip2.MaxLimit.AxisValueSerializable = "1";
            strip2.MinLimit.AxisValueSerializable = "0.5";
            strip2.Name = "Force";
            strip2.Tag = "Force";
            xyDiagram1.AxisX.Strips.AddRange(new DevExpress.XtraCharts.Strip[] {
            strip1,
            strip2});
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "1";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "0";
            xyDiagram1.AxisX.VisualRange.SideMarginsValue = 0D;
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "1";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "0";
            strip3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(148)))));
            strip3.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions3.HatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent30;
            strip3.FillStyle.Options = hatchFillOptions3;
            strip3.MaxLimit.AxisValueSerializable = "1";
            strip3.MinLimit.AxisValueSerializable = "0.5";
            strip3.Name = "Prioritaire";
            strip3.Tag = "Prioritaire";
            strip4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            strip4.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions4.HatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent30;
            strip4.FillStyle.Options = hatchFillOptions4;
            strip4.MaxLimit.AxisValueSerializable = "0.5";
            strip4.MinLimit.AxisValueSerializable = "0";
            strip4.Name = "Secondaire";
            strip4.Tag = "Secondaire";
            xyDiagram1.AxisY.Strips.AddRange(new DevExpress.XtraCharts.Strip[] {
            strip3,
            strip4});
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "1";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.VisualRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "1";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0";
            this.chSatisfactionModel.Diagram = xyDiagram1;
            this.chSatisfactionModel.Location = new System.Drawing.Point(465, 3);
            this.chSatisfactionModel.Name = "chSatisfactionModel";
            series1.ArgumentDataMember = "satisfaction";
            series1.ColorDataMember = "id";
            series1.Name = "Satisfaction/Poids";
            series1.ValueDataMembersSerializable = "poids";
            pointSeriesView1.ColorEach = true;
            series1.View = pointSeriesView1;
            this.chSatisfactionModel.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chSatisfactionModel.SeriesTemplate.ArgumentDataMember = "satisfaction";
            this.chSatisfactionModel.SeriesTemplate.ColorDataMember = "id";
            this.chSatisfactionModel.SeriesTemplate.ValueDataMembersSerializable = "poids";
            this.chSatisfactionModel.SeriesTemplate.View = pointSeriesView2;
            this.chSatisfactionModel.Size = new System.Drawing.Size(445, 536);
            this.chSatisfactionModel.TabIndex = 5;
            this.chSatisfactionModel.CustomDrawCrosshair += new DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(this.chSatisfaction_CustomDrawCrosshair);
            this.chSatisfactionModel.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chSatisfactionModel_CustomDrawSeriesPoint);
            // 
            // dimensionSatisfactionModelBindingSource
            // 
            this.dimensionSatisfactionModelBindingSource.DataSource = typeof(ComHe_Objets.DimensionSatisfactionModel);
            // 
            // trSatisfactionModel
            // 
            this.trSatisfactionModel.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colnom,
            this.colpoids,
            this.colsatisfaction});
            this.trSatisfactionModel.DataSource = this.dimensionSatisfactionModelBindingSource;
            this.trSatisfactionModel.KeyFieldName = "id";
            this.trSatisfactionModel.Location = new System.Drawing.Point(3, 3);
            this.trSatisfactionModel.Name = "trSatisfactionModel";
            this.trSatisfactionModel.OptionsBehavior.PopulateServiceColumns = true;
            this.trSatisfactionModel.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.trSatisfactionModel.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.trSatisfactionModel.ParentFieldName = "parent";
            this.trSatisfactionModel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBtAjout});
            this.trSatisfactionModel.Size = new System.Drawing.Size(450, 536);
            this.trSatisfactionModel.TabIndex = 4;
            // 
            // colnom
            // 
            this.colnom.Caption = "Nom";
            this.colnom.ColumnEdit = this.repoBtAjout;
            this.colnom.FieldName = "nom";
            this.colnom.Name = "colnom";
            this.colnom.Visible = true;
            this.colnom.VisibleIndex = 0;
            this.colnom.Width = 178;
            // 
            // repoBtAjout
            // 
            this.repoBtAjout.AutoHeight = false;
            this.repoBtAjout.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repoBtAjout.Name = "repoBtAjout";
            this.repoBtAjout.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoBtAjout_ButtonClick);
            // 
            // colpoids
            // 
            this.colpoids.Caption = "Poids";
            this.colpoids.FieldName = "poids";
            this.colpoids.Name = "colpoids";
            this.colpoids.Visible = true;
            this.colpoids.VisibleIndex = 1;
            this.colpoids.Width = 177;
            // 
            // colsatisfaction
            // 
            this.colsatisfaction.Caption = "Satisfaction";
            this.colsatisfaction.FieldName = "satisfaction";
            this.colsatisfaction.Name = "colsatisfaction";
            this.colsatisfaction.Visible = true;
            this.colsatisfaction.VisibleIndex = 2;
            // 
            // lcgSatisfactionModel
            // 
            this.lcgSatisfactionModel.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgSatisfactionModel.GroupBordersVisible = false;
            this.lcgSatisfactionModel.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.lcgSatisfactionModel.Location = new System.Drawing.Point(0, 0);
            this.lcgSatisfactionModel.Name = "Root";
            this.lcgSatisfactionModel.OptionsItemText.TextToControlDistance = 4;
            this.lcgSatisfactionModel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgSatisfactionModel.Size = new System.Drawing.Size(913, 542);
            this.lcgSatisfactionModel.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.trSatisfactionModel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(456, 542);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chSatisfactionModel;
            this.layoutControlItem2.Location = new System.Drawing.Point(462, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(451, 542);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(456, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 542);
            // 
            // pmcSatisfactionModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcSatisfactionModel);
            this.Name = "pmcSatisfactionModel";
            this.Size = new System.Drawing.Size(913, 542);
            ((System.ComponentModel.ISupportInitialize)(this.lcSatisfactionModel)).EndInit();
            this.lcSatisfactionModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(strip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSatisfactionModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSatisfactionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trSatisfactionModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtAjout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSatisfactionModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcSatisfactionModel;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSatisfactionModel;
        private DevExpress.XtraTreeList.TreeList trSatisfactionModel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnom;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colpoids;
        private System.Windows.Forms.BindingSource dimensionSatisfactionModelBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtAjout;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colsatisfaction;
        private DevExpress.XtraCharts.ChartControl chSatisfactionModel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}
