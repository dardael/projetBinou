namespace ComHe_Pilotage {
    partial class pmcAttributsDeSatisfaction {
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
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView2 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView3 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.attributDeSatisfactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lcAttributsDeSatisfaction = new DevExpress.XtraLayout.LayoutControl();
            this.chAttributsDeSatisfaction = new DevExpress.XtraCharts.ChartControl();
            this.gcAttributsDeSatisfaction = new DevExpress.XtraGrid.GridControl();
            this.gvAttributsDeSatisfaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimpactSurSatisfaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimpactSurInsatisfaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBtSupprimer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btAjouterAttributDeSatisfaction = new DevExpress.XtraEditors.SimpleButton();
            this.lcgAttributsDeSatisfaction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBtAjouterAttributsDeSatisfaction = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.attributDeSatisfactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcAttributsDeSatisfaction)).BeginInit();
            this.lcAttributsDeSatisfaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chAttributsDeSatisfaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAttributsDeSatisfaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttributsDeSatisfaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtSupprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAttributsDeSatisfaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtAjouterAttributsDeSatisfaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // attributDeSatisfactionBindingSource
            // 
            this.attributDeSatisfactionBindingSource.DataSource = typeof(ComHe_Objets.AttributDeSatisfaction);
            // 
            // lcAttributsDeSatisfaction
            // 
            this.lcAttributsDeSatisfaction.Controls.Add(this.chAttributsDeSatisfaction);
            this.lcAttributsDeSatisfaction.Controls.Add(this.gcAttributsDeSatisfaction);
            this.lcAttributsDeSatisfaction.Controls.Add(this.btAjouterAttributDeSatisfaction);
            this.lcAttributsDeSatisfaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcAttributsDeSatisfaction.Location = new System.Drawing.Point(0, 0);
            this.lcAttributsDeSatisfaction.Margin = new System.Windows.Forms.Padding(0);
            this.lcAttributsDeSatisfaction.Name = "lcAttributsDeSatisfaction";
            this.lcAttributsDeSatisfaction.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(355, 244, 312, 437);
            this.lcAttributsDeSatisfaction.Root = this.lcgAttributsDeSatisfaction;
            this.lcAttributsDeSatisfaction.Size = new System.Drawing.Size(1020, 546);
            this.lcAttributsDeSatisfaction.TabIndex = 0;
            this.lcAttributsDeSatisfaction.Text = "layoutControl1";
            // 
            // chAttributsDeSatisfaction
            // 
            this.chAttributsDeSatisfaction.DataSource = this.attributDeSatisfactionBindingSource;
            xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.PaneLayoutDirection = DevExpress.XtraCharts.PaneLayoutDirection.Horizontal;
            xyDiagram1.Rotated = true;
            this.chAttributsDeSatisfaction.Diagram = xyDiagram1;
            this.chAttributsDeSatisfaction.Location = new System.Drawing.Point(518, 36);
            this.chAttributsDeSatisfaction.Name = "chAttributsDeSatisfaction";
            series1.ArgumentDataMember = "id";
            series1.ColorDataMember = "id";
            series1.Name = "Satisfaction";
            series1.ValueDataMembersSerializable = "impactSurSatisfaction";
            stackedBarSeriesView1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(187)))), ((int)(((byte)(89)))));
            stackedBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(187)))), ((int)(((byte)(89)))));
            stackedBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            series1.View = stackedBarSeriesView1;
            series2.ArgumentDataMember = "id";
            series2.ColorDataMember = "id";
            series2.Name = "Insatisfaction";
            series2.ValueDataMembersSerializable = "impactSurInsatisfactionAAfficher";
            series2.View = stackedBarSeriesView2;
            this.chAttributsDeSatisfaction.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chAttributsDeSatisfaction.SeriesTemplate.ArgumentDataMember = "id";
            this.chAttributsDeSatisfaction.SeriesTemplate.ColorDataMember = "id";
            this.chAttributsDeSatisfaction.SeriesTemplate.ValueDataMembersSerializable = "impactSurSatisfaction";
            this.chAttributsDeSatisfaction.SeriesTemplate.View = stackedBarSeriesView3;
            this.chAttributsDeSatisfaction.Size = new System.Drawing.Size(499, 507);
            this.chAttributsDeSatisfaction.TabIndex = 6;
            this.chAttributsDeSatisfaction.CustomDrawCrosshair += new DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(this.chAttributsDeSatisfaction_CustomDrawCrosshair);
            this.chAttributsDeSatisfaction.CustomDrawAxisLabel += new DevExpress.XtraCharts.CustomDrawAxisLabelEventHandler(this.chAttributsDeSatisfaction_CustomDrawAxisLabel);
            // 
            // gcAttributsDeSatisfaction
            // 
            this.gcAttributsDeSatisfaction.DataSource = this.attributDeSatisfactionBindingSource;
            this.gcAttributsDeSatisfaction.Location = new System.Drawing.Point(3, 36);
            this.gcAttributsDeSatisfaction.MainView = this.gvAttributsDeSatisfaction;
            this.gcAttributsDeSatisfaction.Name = "gcAttributsDeSatisfaction";
            this.gcAttributsDeSatisfaction.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBtSupprimer});
            this.gcAttributsDeSatisfaction.Size = new System.Drawing.Size(503, 507);
            this.gcAttributsDeSatisfaction.TabIndex = 5;
            this.gcAttributsDeSatisfaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAttributsDeSatisfaction});
            // 
            // gvAttributsDeSatisfaction
            // 
            this.gvAttributsDeSatisfaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom,
            this.colimpactSurSatisfaction,
            this.colimpactSurInsatisfaction,
            this.colActions});
            this.gvAttributsDeSatisfaction.GridControl = this.gcAttributsDeSatisfaction;
            this.gvAttributsDeSatisfaction.Name = "gvAttributsDeSatisfaction";
            // 
            // colnom
            // 
            this.colnom.Caption = "Attributs";
            this.colnom.FieldName = "nom";
            this.colnom.Name = "colnom";
            this.colnom.Visible = true;
            this.colnom.VisibleIndex = 0;
            this.colnom.Width = 154;
            // 
            // colimpactSurSatisfaction
            // 
            this.colimpactSurSatisfaction.Caption = "Impact sur la satisfaction";
            this.colimpactSurSatisfaction.FieldName = "impactSurSatisfaction";
            this.colimpactSurSatisfaction.Name = "colimpactSurSatisfaction";
            this.colimpactSurSatisfaction.Visible = true;
            this.colimpactSurSatisfaction.VisibleIndex = 1;
            this.colimpactSurSatisfaction.Width = 154;
            // 
            // colimpactSurInsatisfaction
            // 
            this.colimpactSurInsatisfaction.Caption = "Impact sur l\'insatisfaction";
            this.colimpactSurInsatisfaction.FieldName = "impactSurInsatisfaction";
            this.colimpactSurInsatisfaction.Name = "colimpactSurInsatisfaction";
            this.colimpactSurInsatisfaction.Visible = true;
            this.colimpactSurInsatisfaction.VisibleIndex = 2;
            this.colimpactSurInsatisfaction.Width = 145;
            // 
            // colActions
            // 
            this.colActions.Caption = "Actions";
            this.colActions.ColumnEdit = this.repoBtSupprimer;
            this.colActions.MinWidth = 40;
            this.colActions.Name = "colActions";
            this.colActions.Visible = true;
            this.colActions.VisibleIndex = 3;
            this.colActions.Width = 40;
            // 
            // repoBtSupprimer
            // 
            this.repoBtSupprimer.AutoHeight = false;
            this.repoBtSupprimer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repoBtSupprimer.Name = "repoBtSupprimer";
            this.repoBtSupprimer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoBtSupprimer_ButtonClick);
            // 
            // btAjouterAttributDeSatisfaction
            // 
            this.btAjouterAttributDeSatisfaction.Location = new System.Drawing.Point(3, 3);
            this.btAjouterAttributDeSatisfaction.Name = "btAjouterAttributDeSatisfaction";
            this.btAjouterAttributDeSatisfaction.Size = new System.Drawing.Size(129, 27);
            this.btAjouterAttributDeSatisfaction.StyleController = this.lcAttributsDeSatisfaction;
            this.btAjouterAttributDeSatisfaction.TabIndex = 4;
            this.btAjouterAttributDeSatisfaction.Text = "Ajouter";
            this.btAjouterAttributDeSatisfaction.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // lcgAttributsDeSatisfaction
            // 
            this.lcgAttributsDeSatisfaction.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgAttributsDeSatisfaction.GroupBordersVisible = false;
            this.lcgAttributsDeSatisfaction.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBtAjouterAttributsDeSatisfaction,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.splitterItem1});
            this.lcgAttributsDeSatisfaction.Location = new System.Drawing.Point(0, 0);
            this.lcgAttributsDeSatisfaction.Name = "Root";
            this.lcgAttributsDeSatisfaction.OptionsItemText.TextToControlDistance = 4;
            this.lcgAttributsDeSatisfaction.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgAttributsDeSatisfaction.Size = new System.Drawing.Size(1020, 546);
            this.lcgAttributsDeSatisfaction.TextVisible = false;
            // 
            // lciBtAjouterAttributsDeSatisfaction
            // 
            this.lciBtAjouterAttributsDeSatisfaction.Control = this.btAjouterAttributDeSatisfaction;
            this.lciBtAjouterAttributsDeSatisfaction.Location = new System.Drawing.Point(0, 0);
            this.lciBtAjouterAttributsDeSatisfaction.MaxSize = new System.Drawing.Size(135, 33);
            this.lciBtAjouterAttributsDeSatisfaction.MinSize = new System.Drawing.Size(135, 33);
            this.lciBtAjouterAttributsDeSatisfaction.Name = "lciBtAjouterAttributsDeSatisfaction";
            this.lciBtAjouterAttributsDeSatisfaction.Size = new System.Drawing.Size(135, 33);
            this.lciBtAjouterAttributsDeSatisfaction.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtAjouterAttributsDeSatisfaction.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtAjouterAttributsDeSatisfaction.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(135, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(885, 33);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcAttributsDeSatisfaction;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(509, 513);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chAttributsDeSatisfaction;
            this.layoutControlItem1.Location = new System.Drawing.Point(515, 33);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(505, 513);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(509, 33);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 513);
            // 
            // pmcAttributsDeSatisfaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcAttributsDeSatisfaction);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "pmcAttributsDeSatisfaction";
            this.Size = new System.Drawing.Size(1020, 546);
            ((System.ComponentModel.ISupportInitialize)(this.attributDeSatisfactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcAttributsDeSatisfaction)).EndInit();
            this.lcAttributsDeSatisfaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAttributsDeSatisfaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAttributsDeSatisfaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttributsDeSatisfaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtSupprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAttributsDeSatisfaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtAjouterAttributsDeSatisfaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcAttributsDeSatisfaction;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAttributsDeSatisfaction;
        private DevExpress.XtraGrid.GridControl gcAttributsDeSatisfaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAttributsDeSatisfaction;
        private DevExpress.XtraEditors.SimpleButton btAjouterAttributDeSatisfaction;
        private DevExpress.XtraLayout.LayoutControlItem lciBtAjouterAttributsDeSatisfaction;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource attributDeSatisfactionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnom;
        private DevExpress.XtraGrid.Columns.GridColumn colimpactSurSatisfaction;
        private DevExpress.XtraGrid.Columns.GridColumn colimpactSurInsatisfaction;
        private DevExpress.XtraGrid.Columns.GridColumn colActions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtSupprimer;
        private DevExpress.XtraCharts.ChartControl chAttributsDeSatisfaction;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}
