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
            DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipale));
            this.pmcGestionFichesDeTravail = new ComHe_Pilotage.pmcGestionFichesDeTravail();
            this.tabPrincipal = new DevExpress.XtraTab.XtraTabControl();
            this.tabPgSegmentation = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgTendances = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgLoyaltyModel = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgNPS = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgSatisfactionModel = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgComplaintModel = new DevExpress.XtraTab.XtraTabPage();
            this.tabPgSynthese = new DevExpress.XtraTab.XtraTabPage();
            this.pnPrincipal = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciTabPanePrincipal = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPrincipal)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTabPanePrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = this.pmcGestionFichesDeTravail;
            layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(1264, 50);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // pmcGestionFichesDeTravail
            // 
            this.pmcGestionFichesDeTravail.ficheCourante = ((ComHe_Objets.FicheTravail)(resources.GetObject("pmcGestionFichesDeTravail.ficheCourante")));
            this.pmcGestionFichesDeTravail.fichesTravail = ((System.Collections.Generic.List<ComHe_Objets.FicheTravail>)(resources.GetObject("pmcGestionFichesDeTravail.fichesTravail")));
            this.pmcGestionFichesDeTravail.Location = new System.Drawing.Point(16, 16);
            this.pmcGestionFichesDeTravail.Margin = new System.Windows.Forms.Padding(0);
            this.pmcGestionFichesDeTravail.Name = "pmcGestionFichesDeTravail";
            this.pmcGestionFichesDeTravail.Size = new System.Drawing.Size(1258, 44);
            this.pmcGestionFichesDeTravail.TabIndex = 4;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Location = new System.Drawing.Point(16, 66);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedTabPage = this.tabPgSegmentation;
            this.tabPrincipal.Size = new System.Drawing.Size(1258, 662);
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
            this.tabPgSegmentation.Name = "tabPgSegmentation";
            this.tabPgSegmentation.Size = new System.Drawing.Size(1251, 628);
            this.tabPgSegmentation.Text = "Segmentation";
            // 
            // tabPgTendances
            // 
            this.tabPgTendances.Name = "tabPgTendances";
            this.tabPgTendances.Size = new System.Drawing.Size(1251, 628);
            this.tabPgTendances.Text = "Tendances";
            // 
            // tabPgLoyaltyModel
            // 
            this.tabPgLoyaltyModel.Name = "tabPgLoyaltyModel";
            this.tabPgLoyaltyModel.Size = new System.Drawing.Size(1251, 628);
            this.tabPgLoyaltyModel.Text = "Loyalty model";
            // 
            // tabPgNPS
            // 
            this.tabPgNPS.Name = "tabPgNPS";
            this.tabPgNPS.Size = new System.Drawing.Size(1251, 628);
            this.tabPgNPS.Text = "NPS";
            // 
            // tabPgSatisfactionModel
            // 
            this.tabPgSatisfactionModel.Name = "tabPgSatisfactionModel";
            this.tabPgSatisfactionModel.Size = new System.Drawing.Size(1251, 628);
            this.tabPgSatisfactionModel.Text = "SatisfactionModel";
            // 
            // tabPgComplaintModel
            // 
            this.tabPgComplaintModel.Name = "tabPgComplaintModel";
            this.tabPgComplaintModel.Size = new System.Drawing.Size(1251, 628);
            this.tabPgComplaintModel.Text = "Complaint model";
            // 
            // tabPgSynthese
            // 
            this.tabPgSynthese.Name = "tabPgSynthese";
            this.tabPgSynthese.Size = new System.Drawing.Size(1251, 628);
            this.tabPgSynthese.Text = "Synthèse";
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.pmcGestionFichesDeTravail);
            this.pnPrincipal.Controls.Add(this.tabPrincipal);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 29);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(630, 526, 515, 437);
            this.pnPrincipal.Root = this.layoutControlGroup2;
            this.pnPrincipal.Size = new System.Drawing.Size(1290, 744);
            this.pnPrincipal.TabIndex = 7;
            this.pnPrincipal.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTabPanePrincipal,
            layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1290, 744);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // lciTabPanePrincipal
            // 
            this.lciTabPanePrincipal.Control = this.tabPrincipal;
            this.lciTabPanePrincipal.Location = new System.Drawing.Point(0, 50);
            this.lciTabPanePrincipal.Name = "lciTabPanePrincipal";
            this.lciTabPanePrincipal.Size = new System.Drawing.Size(1264, 668);
            this.lciTabPanePrincipal.TextSize = new System.Drawing.Size(0, 0);
            this.lciTabPanePrincipal.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skin";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1290, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 773);
            this.barDockControlBottom.Size = new System.Drawing.Size(1290, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 744);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1290, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 744);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1290, 773);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Blue";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipale";
            this.Text = "ComHe-Pilotage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPrincipal)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTabPanePrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraLayout.LayoutControl pnPrincipal;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciTabPanePrincipal;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private pmcGestionFichesDeTravail pmcGestionFichesDeTravail;
    }
}

