namespace ComHe_Pilotage {
    partial class frmPrincipale {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipale));
            this.tabPrincipal = new DevExpress.XtraTab.XtraTabControl();
            this.tabPgSegmentation = new DevExpress.XtraTab.XtraTabPage();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.tabPgTendances = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgLoyaltyModel = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgNPS = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgSatisfactionModel = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgComplaintModel = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgSynthese = new DevExpress.XtraTab.XtraTabPage();
            this.bsSegment = new System.Windows.Forms.BindingSource(this.components);
            this.btAjouterSegment = new System.Windows.Forms.Button();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabPrincipal)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.tabPgSegmentation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSegment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedTabPage = this.tabPgSegmentation;
            this.tabPrincipal.Size = new System.Drawing.Size(1290, 773);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPgSegmentation,
            this.tabPgTendances,
            this.tabPgLoyaltyModel,
            this.tabPgNPS,
            this.tabPgSatisfactionModel,
            this.tabPgComplaintModel,
            this.tabPgSynthese});
            // 
            // tabPgSegmentation
            // 
            this.tabPgSegmentation.Controls.Add(this.layoutControl1);
            this.tabPgSegmentation.Name = "tabPgSegmentation";
            this.tabPgSegmentation.Size = new System.Drawing.Size(1283, 739);
            this.tabPgSegmentation.Text = "Segmentation";
            // 
            // vGridControl1
            // 
            this.vGridControl1.AllowDrop = true;
            this.vGridControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vGridControl1.Location = new System.Drawing.Point(16, 49);
            this.vGridControl1.MaximumSize = new System.Drawing.Size(0, 300);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.vGridControl1.OptionsLayout.Columns.AddNewColumns = true;
            this.vGridControl1.OptionsLayout.Columns.RemoveOldColumns = true;
            this.vGridControl1.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways;
            this.vGridControl1.Size = new System.Drawing.Size(1251, 300);
            this.vGridControl1.TabIndex = 4;
            // 
            // tabPgTendances
            // 
            this.tabPgTendances.Name = "tabPgTendances";
            this.tabPgTendances.Size = new System.Drawing.Size(1283, 739);
            this.tabPgTendances.Text = "Tendances";
            // 
            // tabPgLoyaltyModel
            // 
            this.tabPgLoyaltyModel.Name = "tabPgLoyaltyModel";
            this.tabPgLoyaltyModel.Size = new System.Drawing.Size(1283, 739);
            this.tabPgLoyaltyModel.Text = "Loyalty model";
            // 
            // tabPgNPS
            // 
            this.tabPgNPS.Name = "tabPgNPS";
            this.tabPgNPS.Size = new System.Drawing.Size(1283, 739);
            this.tabPgNPS.Text = "NPS";
            // 
            // tabPgSatisfactionModel
            // 
            this.tabPgSatisfactionModel.Name = "tabPgSatisfactionModel";
            this.tabPgSatisfactionModel.Size = new System.Drawing.Size(1283, 739);
            this.tabPgSatisfactionModel.Text = "SatisfactionModel";
            // 
            // tabPgComplaintModel
            // 
            this.tabPgComplaintModel.Name = "tabPgComplaintModel";
            this.tabPgComplaintModel.Size = new System.Drawing.Size(1283, 739);
            this.tabPgComplaintModel.Text = "Complaint model";
            // 
            // tabPgSynthese
            // 
            this.tabPgSynthese.Name = "tabPgSynthese";
            this.tabPgSynthese.Size = new System.Drawing.Size(1283, 739);
            this.tabPgSynthese.Text = "Synthèse";
            // 
            // bsSegment
            // 
            this.bsSegment.DataSource = typeof(ComHe_Objets.Segment);
            // 
            // btAjouterSegment
            // 
            this.btAjouterSegment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAjouterSegment.Location = new System.Drawing.Point(16, 16);
            this.btAjouterSegment.Name = "btAjouterSegment";
            this.btAjouterSegment.Size = new System.Drawing.Size(154, 24);
            this.btAjouterSegment.TabIndex = 5;
            this.btAjouterSegment.Text = "Ajouter un segment";
            this.btAjouterSegment.UseVisualStyleBackColor = true;
            this.btAjouterSegment.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chartControl1.AppearanceNameSerializable = "Light";
            this.chartControl1.DataSource = this.bsSegment;
            xyDiagram1.AxisX.Title.Text = "Segments";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "CLV";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.MarkerVisible = false;
            this.chartControl1.Legend.TextVisible = false;
            this.chartControl1.Location = new System.Drawing.Point(16, 361);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Default";
            series1.ArgumentDataMember = "nom";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "clv";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "nom";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "clv";
            this.chartControl1.Size = new System.Drawing.Size(1251, 362);
            this.chartControl1.TabIndex = 6;
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btAjouterSegment);
            this.layoutControl1.Controls.Add(this.vGridControl1);
            this.layoutControl1.Controls.Add(this.chartControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1497, 147, 879, 437);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1283, 739);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.simpleSeparator1,
            this.splitterItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1283, 739);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btAjouterSegment;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 30);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(26, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(160, 30);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chartControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 345);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1257, 368);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.vGridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1257, 306);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(0, 339);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(1257, 6);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 30);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(1257, 3);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(160, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1097, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1290, 773);
            this.Controls.Add(this.tabPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipale";
            this.Text = "ComHe-Pilotage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabPrincipal)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPgSegmentation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSegment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabPrincipal;
        private DevExpress.XtraTab.XtraTabPage tabPgSegmentation;
        private DevExpress.XtraTab.XtraTabPage tabPgTendances;
        private DevExpress.XtraTab.XtraTabPage tabPgLoyaltyModel;
        private DevExpress.XtraTab.XtraTabPage tabPgNPS;
        private DevExpress.XtraTab.XtraTabPage tabPgSatisfactionModel;
        private DevExpress.XtraTab.XtraTabPage tabPgComplaintModel;
        private DevExpress.XtraTab.XtraTabPage tabPgSynthese;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        public System.Windows.Forms.BindingSource bsSegment;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Button btAjouterSegment;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
    }
}

