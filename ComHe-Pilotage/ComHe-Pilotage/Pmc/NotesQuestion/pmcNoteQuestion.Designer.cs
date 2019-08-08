namespace ComHe_Pilotage.Pmc.NotesQuestion {
    partial class pmcNoteQuestion {
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
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange16 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange17 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange18 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            this.lcPrincipal = new DevExpress.XtraLayout.LayoutControl();
            this.gcQuestion = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.grQuestion = new DevExpress.XtraVerticalGrid.VGridControl();
            this.valeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rownote = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownb = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.lblQuestion = new DevExpress.XtraEditors.LabelControl();
            this.lcgPrincipal = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).BeginInit();
            this.lcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valeurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcPrincipal
            // 
            this.lcPrincipal.Controls.Add(this.gcQuestion);
            this.lcPrincipal.Controls.Add(this.grQuestion);
            this.lcPrincipal.Controls.Add(this.lblQuestion);
            this.lcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lcPrincipal.Name = "lcPrincipal";
            this.lcPrincipal.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(952, 240, 312, 437);
            this.lcPrincipal.Root = this.lcgPrincipal;
            this.lcPrincipal.Size = new System.Drawing.Size(826, 525);
            this.lcPrincipal.TabIndex = 0;
            this.lcPrincipal.Text = "layoutControl1";
            // 
            // gcQuestion
            // 
            this.gcQuestion.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gcQuestion.Location = new System.Drawing.Point(3, 266);
            this.gcQuestion.Name = "gcQuestion";
            this.gcQuestion.Size = new System.Drawing.Size(820, 256);
            this.gcQuestion.TabIndex = 6;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 808, 244);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            this.circularGauge1.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bg";
            this.arcScaleBackgroundLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.695F);
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style16;
            this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(250F, 179F);
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 9F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F);
            this.arcScaleComponent1.EndAngle = 0F;
            this.arcScaleComponent1.MajorTickCount = 3;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -13F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MinorTickCount = 2;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -9F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent1.MinValue = -1F;
            this.arcScaleComponent1.Name = "scale1";
            this.arcScaleComponent1.RadiusX = 98F;
            this.arcScaleComponent1.RadiusY = 98F;
            arcScaleRange16.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968");
            arcScaleRange16.EndThickness = 20F;
            arcScaleRange16.Name = "Range0";
            arcScaleRange16.ShapeOffset = 0F;
            arcScaleRange16.StartThickness = 20F;
            arcScaleRange16.StartValue = 0.3F;
            arcScaleRange17.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FED96D");
            arcScaleRange17.EndThickness = 20F;
            arcScaleRange17.EndValue = 0.3F;
            arcScaleRange17.Name = "Range1";
            arcScaleRange17.ShapeOffset = 0F;
            arcScaleRange17.StartThickness = 20F;
            arcScaleRange17.StartValue = -0.3F;
            arcScaleRange18.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EF8C75");
            arcScaleRange18.EndThickness = 20F;
            arcScaleRange18.EndValue = -0.3F;
            arcScaleRange18.Name = "Range2";
            arcScaleRange18.ShapeOffset = 0F;
            arcScaleRange18.StartThickness = 20F;
            arcScaleRange18.StartValue = -1F;
            this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange16,
            arcScaleRange17,
            arcScaleRange18});
            this.arcScaleComponent1.StartAngle = -180F;
            this.arcScaleComponent1.Value = 1F;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.EndOffset = 3F;
            this.arcScaleNeedleComponent1.Name = "needle";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleSpindleCapComponent1.Name = "circularGauge1_SpindleCap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(25F, 25F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // grQuestion
            // 
            this.grQuestion.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.grQuestion.DataSource = this.valeurBindingSource;
            this.grQuestion.Location = new System.Drawing.Point(3, 25);
            this.grQuestion.Name = "grQuestion";
            this.grQuestion.RowHeaderWidth = 150;
            this.grQuestion.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rownote,
            this.rownb});
            this.grQuestion.Size = new System.Drawing.Size(820, 229);
            this.grQuestion.TabIndex = 5;
            this.grQuestion.CellValueChanged += new DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(this.grQuestion_CellValueChanged);
            // 
            // valeurBindingSource
            // 
            this.valeurBindingSource.DataSource = typeof(ComHe_Objets.NotesQuestion.Valeur);
            // 
            // rownote
            // 
            this.rownote.Height = 16;
            this.rownote.Name = "rownote";
            this.rownote.Properties.Caption = "Note";
            this.rownote.Properties.FieldName = "note.valeur";
            this.rownote.Properties.ReadOnly = true;
            // 
            // rownb
            // 
            this.rownb.Name = "rownb";
            this.rownb.Properties.Caption = "Nombre de personnes";
            this.rownb.Properties.FieldName = "nb";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(3, 3);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(75, 16);
            this.lblQuestion.StyleController = this.lcPrincipal;
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "labelControl1";
            // 
            // lcgPrincipal
            // 
            this.lcgPrincipal.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgPrincipal.GroupBordersVisible = false;
            this.lcgPrincipal.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.splitterItem1});
            this.lcgPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lcgPrincipal.Name = "lcgPrincipal";
            this.lcgPrincipal.OptionsItemText.TextToControlDistance = 4;
            this.lcgPrincipal.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgPrincipal.Size = new System.Drawing.Size(826, 525);
            this.lcgPrincipal.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblQuestion;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(826, 22);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grQuestion;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(826, 235);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcQuestion;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 263);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(826, 262);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 257);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(826, 6);
            // 
            // pmcNoteQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcPrincipal);
            this.Name = "pmcNoteQuestion";
            this.Size = new System.Drawing.Size(826, 525);
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).EndInit();
            this.lcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valeurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcPrincipal;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPrincipal;
        private DevExpress.XtraGauges.Win.GaugeControl gcQuestion;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private DevExpress.XtraVerticalGrid.VGridControl grQuestion;
        private DevExpress.XtraEditors.LabelControl lblQuestion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private System.Windows.Forms.BindingSource valeurBindingSource;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownote;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownb;
    }
}
