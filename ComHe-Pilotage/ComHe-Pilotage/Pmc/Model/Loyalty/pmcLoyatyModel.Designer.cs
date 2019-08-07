namespace ComHe_Pilotage {
    partial class pmcLoyatyModel {
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
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.itemLoyaltyModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lcPrincipal = new DevExpress.XtraLayout.LayoutControl();
            this.chLoyaltyModel = new DevExpress.XtraCharts.ChartControl();
            this.grLoyaltyModel = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldnoteLoyaute = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnoteSatisfaction = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnbPersonnes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repoNbPersonneEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lcgPrincipal = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGrLoyaltyModel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChLoyaltyModel = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.itemLoyaltyModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).BeginInit();
            this.lcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chLoyaltyModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grLoyaltyModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoNbPersonneEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrLoyaltyModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChLoyaltyModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemLoyaltyModelBindingSource
            // 
            this.itemLoyaltyModelBindingSource.DataSource = typeof(ComHe_Objets.ItemLoyaltyModel);
            // 
            // lcPrincipal
            // 
            this.lcPrincipal.Controls.Add(this.chLoyaltyModel);
            this.lcPrincipal.Controls.Add(this.grLoyaltyModel);
            this.lcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lcPrincipal.Name = "lcPrincipal";
            this.lcPrincipal.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(893, 247, 312, 437);
            this.lcPrincipal.Root = this.lcgPrincipal;
            this.lcPrincipal.Size = new System.Drawing.Size(1027, 529);
            this.lcPrincipal.TabIndex = 0;
            this.lcPrincipal.Text = "layoutControl1";
            // 
            // chLoyaltyModel
            // 
            this.chLoyaltyModel.DataSource = this.itemLoyaltyModelBindingSource;
            xyDiagram1.AxisX.AutoScaleBreaks.Enabled = true;
            xyDiagram1.AxisX.AutoScaleBreaks.MaxCount = 1;
            xyDiagram1.AxisX.MinorCount = 1;
            xyDiagram1.AxisX.NumericScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.Title.Text = "Echelle de satisfaction";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "% de certainement";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chLoyaltyModel.Diagram = xyDiagram1;
            this.chLoyaltyModel.Location = new System.Drawing.Point(3, 269);
            this.chLoyaltyModel.Name = "chLoyaltyModel";
            series1.ArgumentDataMember = "noteSatisfaction";
            series1.ColorDataMember = "id";
            series1.CrosshairLabelPattern = "Satisfaction: {A}\n% de certainement: {V}";
            series1.LegendText = "% De certainement";
            series1.Name = "serieLoyaute";
            series2.ArgumentDataMember = "noteSatisfaction";
            series2.ColorDataMember = "id";
            series2.CrosshairLabelPattern = "Satisfaction: {A}\n% de certainement: {V}";
            series2.LegendText = "% De certainement";
            series2.Name = "serieDroiteLoyaute";
            series2.View = lineSeriesView1;
            this.chLoyaltyModel.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chLoyaltyModel.Size = new System.Drawing.Size(1021, 257);
            this.chLoyaltyModel.TabIndex = 5;
            // 
            // grLoyaltyModel
            // 
            this.grLoyaltyModel.DataSource = this.itemLoyaltyModelBindingSource;
            this.grLoyaltyModel.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldnoteLoyaute,
            this.fieldnoteSatisfaction,
            this.fieldnbPersonnes});
            this.grLoyaltyModel.Location = new System.Drawing.Point(3, 3);
            this.grLoyaltyModel.Name = "grLoyaltyModel";
            this.grLoyaltyModel.OptionsCustomization.AllowDrag = false;
            this.grLoyaltyModel.OptionsCustomization.AllowFilter = false;
            this.grLoyaltyModel.OptionsCustomization.AllowSort = false;
            this.grLoyaltyModel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repoNbPersonneEdit});
            this.grLoyaltyModel.Size = new System.Drawing.Size(1021, 254);
            this.grLoyaltyModel.TabIndex = 4;
            this.grLoyaltyModel.EditValueChanged += new DevExpress.XtraPivotGrid.EditValueChangedEventHandler(this.grLoyaltyModel_EditValueChanged);
            // 
            // fieldnoteLoyaute
            // 
            this.fieldnoteLoyaute.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldnoteLoyaute.AreaIndex = 0;
            this.fieldnoteLoyaute.Caption = "Note de la loyauté";
            this.fieldnoteLoyaute.FieldName = "noteLoyaute";
            this.fieldnoteLoyaute.Name = "fieldnoteLoyaute";
            this.fieldnoteLoyaute.Options.ReadOnly = true;
            // 
            // fieldnoteSatisfaction
            // 
            this.fieldnoteSatisfaction.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldnoteSatisfaction.AreaIndex = 0;
            this.fieldnoteSatisfaction.Caption = "Note de satisfaction";
            this.fieldnoteSatisfaction.FieldName = "noteSatisfaction";
            this.fieldnoteSatisfaction.Name = "fieldnoteSatisfaction";
            this.fieldnoteSatisfaction.Options.ReadOnly = true;
            // 
            // fieldnbPersonnes
            // 
            this.fieldnbPersonnes.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldnbPersonnes.AreaIndex = 0;
            this.fieldnbPersonnes.Caption = "Nombre de personnes";
            this.fieldnbPersonnes.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldnbPersonnes.FieldEdit = this.repoNbPersonneEdit;
            this.fieldnbPersonnes.FieldName = "nbPersonnes";
            this.fieldnbPersonnes.Name = "fieldnbPersonnes";
            // 
            // repoNbPersonneEdit
            // 
            this.repoNbPersonneEdit.AutoHeight = false;
            this.repoNbPersonneEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoNbPersonneEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repoNbPersonneEdit.IsFloatValue = false;
            this.repoNbPersonneEdit.Mask.EditMask = "N00";
            this.repoNbPersonneEdit.Name = "repoNbPersonneEdit";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // lcgPrincipal
            // 
            this.lcgPrincipal.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgPrincipal.GroupBordersVisible = false;
            this.lcgPrincipal.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGrLoyaltyModel,
            this.lciChLoyaltyModel,
            this.splitterItem1});
            this.lcgPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lcgPrincipal.Name = "lcgPrincipal";
            this.lcgPrincipal.OptionsItemText.TextToControlDistance = 4;
            this.lcgPrincipal.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgPrincipal.Size = new System.Drawing.Size(1027, 529);
            this.lcgPrincipal.TextVisible = false;
            // 
            // lciGrLoyaltyModel
            // 
            this.lciGrLoyaltyModel.Control = this.grLoyaltyModel;
            this.lciGrLoyaltyModel.Location = new System.Drawing.Point(0, 0);
            this.lciGrLoyaltyModel.Name = "lciGrLoyaltyModel";
            this.lciGrLoyaltyModel.Size = new System.Drawing.Size(1027, 260);
            this.lciGrLoyaltyModel.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrLoyaltyModel.TextVisible = false;
            // 
            // lciChLoyaltyModel
            // 
            this.lciChLoyaltyModel.Control = this.chLoyaltyModel;
            this.lciChLoyaltyModel.Location = new System.Drawing.Point(0, 266);
            this.lciChLoyaltyModel.Name = "lciChLoyaltyModel";
            this.lciChLoyaltyModel.Size = new System.Drawing.Size(1027, 263);
            this.lciChLoyaltyModel.TextSize = new System.Drawing.Size(0, 0);
            this.lciChLoyaltyModel.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 260);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(1027, 6);
            // 
            // pmcLoyatyModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcPrincipal);
            this.Name = "pmcLoyatyModel";
            this.Size = new System.Drawing.Size(1027, 529);
            ((System.ComponentModel.ISupportInitialize)(this.itemLoyaltyModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).EndInit();
            this.lcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLoyaltyModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grLoyaltyModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoNbPersonneEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrLoyaltyModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChLoyaltyModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcPrincipal;
        private DevExpress.XtraPivotGrid.PivotGridControl grLoyaltyModel;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPrincipal;
        private DevExpress.XtraLayout.LayoutControlItem lciGrLoyaltyModel;
        private System.Windows.Forms.BindingSource itemLoyaltyModelBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnoteLoyaute;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnoteSatisfaction;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnbPersonnes;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repoNbPersonneEdit;
        private DevExpress.XtraCharts.ChartControl chLoyaltyModel;
        private DevExpress.XtraLayout.LayoutControlItem lciChLoyaltyModel;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}
