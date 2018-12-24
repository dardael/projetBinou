namespace ComHe_Pilotage {
    partial class pmcSegmentation {
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
            this.pnTabPgSegmentation = new DevExpress.XtraLayout.LayoutControl();
            this.btAjouterSegment = new DevExpress.XtraEditors.SimpleButton();
            this.grdSegmentation = new DevExpress.XtraVerticalGrid.VGridControl();
            this.chSegmentation = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.segmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rowNom = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowtypeSegment = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowcaFromLM = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowtxMarge = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowtxRetention = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowtxActualisation = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmarge = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowtxMultiplicateur = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowclv = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.pnTabPgSegmentation)).BeginInit();
            this.pnTabPgSegmentation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSegmentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSegmentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTabPgSegmentation
            // 
            this.pnTabPgSegmentation.Controls.Add(this.btAjouterSegment);
            this.pnTabPgSegmentation.Controls.Add(this.grdSegmentation);
            this.pnTabPgSegmentation.Controls.Add(this.chSegmentation);
            this.pnTabPgSegmentation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTabPgSegmentation.Location = new System.Drawing.Point(0, 0);
            this.pnTabPgSegmentation.Name = "pnTabPgSegmentation";
            this.pnTabPgSegmentation.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(906, 167, 879, 434);
            this.pnTabPgSegmentation.Root = this.layoutControlGroup1;
            this.pnTabPgSegmentation.Size = new System.Drawing.Size(823, 565);
            this.pnTabPgSegmentation.TabIndex = 8;
            this.pnTabPgSegmentation.Text = "layoutControl1";
            // 
            // btAjouterSegment
            // 
            this.btAjouterSegment.Location = new System.Drawing.Point(16, 16);
            this.btAjouterSegment.MaximumSize = new System.Drawing.Size(140, 24);
            this.btAjouterSegment.MinimumSize = new System.Drawing.Size(140, 24);
            this.btAjouterSegment.Name = "btAjouterSegment";
            this.btAjouterSegment.Size = new System.Drawing.Size(140, 24);
            this.btAjouterSegment.StyleController = this.pnTabPgSegmentation;
            this.btAjouterSegment.TabIndex = 7;
            this.btAjouterSegment.Text = "Ajouter un segment";
            this.btAjouterSegment.Click += new System.EventHandler(this.btAjouterSegment_Click);
            // 
            // grdSegmentation
            // 
            this.grdSegmentation.AllowDrop = true;
            this.grdSegmentation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grdSegmentation.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.grdSegmentation.DataSource = this.segmentBindingSource;
            this.grdSegmentation.Location = new System.Drawing.Point(16, 49);
            this.grdSegmentation.MaximumSize = new System.Drawing.Size(0, 300);
            this.grdSegmentation.Name = "grdSegmentation";
            this.grdSegmentation.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.grdSegmentation.OptionsLayout.Columns.AddNewColumns = true;
            this.grdSegmentation.OptionsLayout.Columns.RemoveOldColumns = true;
            this.grdSegmentation.RowHeaderWidth = 155;
            this.grdSegmentation.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowNom,
            this.rowtypeSegment,
            this.rowcaFromLM,
            this.rowtxMarge,
            this.rowtxRetention,
            this.rowtxActualisation,
            this.rowmarge,
            this.rowtxMultiplicateur,
            this.rowclv});
            this.grdSegmentation.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways;
            this.grdSegmentation.Size = new System.Drawing.Size(791, 149);
            this.grdSegmentation.TabIndex = 4;
            // 
            // chSegmentation
            // 
            this.chSegmentation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chSegmentation.AppearanceNameSerializable = "Light";
            xyDiagram1.AxisX.Title.Text = "Segments";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "CLV";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chSegmentation.Diagram = xyDiagram1;
            this.chSegmentation.Legend.MarkerVisible = false;
            this.chSegmentation.Legend.TextVisible = false;
            this.chSegmentation.Location = new System.Drawing.Point(16, 204);
            this.chSegmentation.Name = "chSegmentation";
            this.chSegmentation.PaletteName = "Default";
            series1.ArgumentDataMember = "nom";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "clv";
            this.chSegmentation.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chSegmentation.SeriesTemplate.ArgumentDataMember = "nom";
            this.chSegmentation.SeriesTemplate.ValueDataMembersSerializable = "clv";
            this.chSegmentation.Size = new System.Drawing.Size(791, 345);
            this.chSegmentation.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(823, 565);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chSegmentation;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 188);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(797, 351);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.grdSegmentation;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 155);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(26, 155);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(797, 155);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btAjouterSegment;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(147, 33);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(147, 33);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(797, 33);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // segmentBindingSource
            // 
            this.segmentBindingSource.DataSource = typeof(ComHe_Objets.Segment);
            // 
            // rowNom
            // 
            this.rowNom.Name = "rowNom";
            this.rowNom.Properties.Caption = "Nom";
            this.rowNom.Properties.FieldName = "nom";
            // 
            // rowtypeSegment
            // 
            this.rowtypeSegment.Name = "rowtypeSegment";
            this.rowtypeSegment.Properties.Caption = "type Segment";
            this.rowtypeSegment.Properties.FieldName = "typeSegment";
            this.rowtypeSegment.Visible = false;
            // 
            // rowcaFromLM
            // 
            this.rowcaFromLM.Name = "rowcaFromLM";
            this.rowcaFromLM.Properties.Caption = "CA selon LM";
            this.rowcaFromLM.Properties.FieldName = "caFromLM";
            // 
            // rowtxMarge
            // 
            this.rowtxMarge.Name = "rowtxMarge";
            this.rowtxMarge.Properties.Caption = "Tx de marge retenu";
            this.rowtxMarge.Properties.FieldName = "txMarge";
            // 
            // rowtxRetention
            // 
            this.rowtxRetention.Name = "rowtxRetention";
            this.rowtxRetention.Properties.Caption = "Tx de retention";
            this.rowtxRetention.Properties.FieldName = "txRetention";
            // 
            // rowtxActualisation
            // 
            this.rowtxActualisation.Name = "rowtxActualisation";
            this.rowtxActualisation.Properties.Caption = "Tx d\'actualisation";
            this.rowtxActualisation.Properties.FieldName = "txActualisation";
            // 
            // rowmarge
            // 
            this.rowmarge.Name = "rowmarge";
            this.rowmarge.Properties.Caption = "Marge";
            this.rowmarge.Properties.FieldName = "marge";
            this.rowmarge.Properties.ReadOnly = true;
            // 
            // rowtxMultiplicateur
            // 
            this.rowtxMultiplicateur.Name = "rowtxMultiplicateur";
            this.rowtxMultiplicateur.Properties.Caption = "Tx multiplicateur";
            this.rowtxMultiplicateur.Properties.FieldName = "txMultiplicateur";
            this.rowtxMultiplicateur.Properties.ReadOnly = true;
            // 
            // rowclv
            // 
            this.rowclv.Name = "rowclv";
            this.rowclv.Properties.Caption = "CLV";
            this.rowclv.Properties.FieldName = "clv";
            this.rowclv.Properties.ReadOnly = true;
            // 
            // pmcSegmentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTabPgSegmentation);
            this.Name = "pmcSegmentation";
            this.Size = new System.Drawing.Size(823, 565);
            ((System.ComponentModel.ISupportInitialize)(this.pnTabPgSegmentation)).EndInit();
            this.pnTabPgSegmentation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSegmentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSegmentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl pnTabPgSegmentation;
        private DevExpress.XtraEditors.SimpleButton btAjouterSegment;
        private DevExpress.XtraVerticalGrid.VGridControl grdSegmentation;
        private DevExpress.XtraCharts.ChartControl chSegmentation;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource segmentBindingSource;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNom;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowtypeSegment;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowcaFromLM;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowtxMarge;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowtxRetention;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowtxActualisation;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmarge;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowtxMultiplicateur;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowclv;
    }
}
