namespace ComHe_Pilotage.Pmc.TableauDeBord {
    partial class pmcTableauDeBord {
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
            this.lcPrincipal = new DevExpress.XtraLayout.LayoutControl();
            this.pmcSegmentation1 = new ComHe_Pilotage.pmcSegmentation();
            this.pmcGestionReclamation1 = new ComHe_Pilotage.pmcGestionReclamation();
            this.pmcQuestionnaireNoteSegment1 = new ComHe_Pilotage.pmcQuestionnaireNoteSegment();
            this.pmcLoyatyModel1 = new ComHe_Pilotage.pmcLoyatyModel();
            this.lcgPrincipal = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLoyaltyModel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNPS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciReclamation = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCLV = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).BeginInit();
            this.lcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLoyaltyModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReclamation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // lcPrincipal
            // 
            this.lcPrincipal.Controls.Add(this.pmcSegmentation1);
            this.lcPrincipal.Controls.Add(this.pmcGestionReclamation1);
            this.lcPrincipal.Controls.Add(this.pmcQuestionnaireNoteSegment1);
            this.lcPrincipal.Controls.Add(this.pmcLoyatyModel1);
            this.lcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lcPrincipal.Name = "lcPrincipal";
            this.lcPrincipal.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1076, 263, 312, 437);
            this.lcPrincipal.Root = this.lcgPrincipal;
            this.lcPrincipal.Size = new System.Drawing.Size(834, 548);
            this.lcPrincipal.TabIndex = 0;
            this.lcPrincipal.Text = "layoutControl1";
            // 
            // pmcSegmentation1
            // 
            this.pmcSegmentation1.Location = new System.Drawing.Point(426, 274);
            this.pmcSegmentation1.Name = "pmcSegmentation1";
            this.pmcSegmentation1.Size = new System.Drawing.Size(405, 251);
            this.pmcSegmentation1.TabIndex = 7;
            // 
            // pmcGestionReclamation1
            // 
            this.pmcGestionReclamation1.Location = new System.Drawing.Point(3, 274);
            this.pmcGestionReclamation1.Name = "pmcGestionReclamation1";
            this.pmcGestionReclamation1.Size = new System.Drawing.Size(411, 251);
            this.pmcGestionReclamation1.TabIndex = 6;
            // 
            // pmcQuestionnaireNoteSegment1
            // 
            this.pmcQuestionnaireNoteSegment1.Location = new System.Drawing.Point(425, 3);
            this.pmcQuestionnaireNoteSegment1.Name = "pmcQuestionnaireNoteSegment1";
            this.pmcQuestionnaireNoteSegment1.Size = new System.Drawing.Size(406, 239);
            this.pmcQuestionnaireNoteSegment1.TabIndex = 5;
            // 
            // pmcLoyatyModel1
            // 
            this.pmcLoyatyModel1.Location = new System.Drawing.Point(3, 3);
            this.pmcLoyatyModel1.Name = "pmcLoyatyModel1";
            this.pmcLoyatyModel1.Size = new System.Drawing.Size(410, 239);
            this.pmcLoyatyModel1.TabIndex = 4;
            // 
            // lcgPrincipal
            // 
            this.lcgPrincipal.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgPrincipal.GroupBordersVisible = false;
            this.lcgPrincipal.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLoyaltyModel,
            this.lciNPS,
            this.lciReclamation,
            this.lciCLV,
            this.splitterItem1,
            this.splitterItem2,
            this.splitterItem3});
            this.lcgPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lcgPrincipal.Name = "Root";
            this.lcgPrincipal.OptionsItemText.TextToControlDistance = 4;
            this.lcgPrincipal.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgPrincipal.Size = new System.Drawing.Size(834, 548);
            this.lcgPrincipal.TextVisible = false;
            // 
            // lciLoyaltyModel
            // 
            this.lciLoyaltyModel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciLoyaltyModel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciLoyaltyModel.Control = this.pmcLoyatyModel1;
            this.lciLoyaltyModel.Location = new System.Drawing.Point(0, 0);
            this.lciLoyaltyModel.Name = "lciLoyaltyModel";
            this.lciLoyaltyModel.Size = new System.Drawing.Size(416, 265);
            this.lciLoyaltyModel.Text = "Loyalty Model";
            this.lciLoyaltyModel.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.lciLoyaltyModel.TextSize = new System.Drawing.Size(77, 16);
            // 
            // lciNPS
            // 
            this.lciNPS.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciNPS.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciNPS.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lciNPS.Control = this.pmcQuestionnaireNoteSegment1;
            this.lciNPS.Location = new System.Drawing.Point(422, 0);
            this.lciNPS.Name = "lciNPS";
            this.lciNPS.Size = new System.Drawing.Size(412, 265);
            this.lciNPS.Text = "NPS";
            this.lciNPS.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.lciNPS.TextSize = new System.Drawing.Size(77, 16);
            // 
            // lciReclamation
            // 
            this.lciReclamation.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciReclamation.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciReclamation.Control = this.pmcGestionReclamation1;
            this.lciReclamation.Location = new System.Drawing.Point(0, 271);
            this.lciReclamation.Name = "lciReclamation";
            this.lciReclamation.Size = new System.Drawing.Size(417, 277);
            this.lciReclamation.Text = "Réclamations";
            this.lciReclamation.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.lciReclamation.TextSize = new System.Drawing.Size(77, 16);
            // 
            // lciCLV
            // 
            this.lciCLV.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciCLV.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciCLV.Control = this.pmcSegmentation1;
            this.lciCLV.Location = new System.Drawing.Point(423, 271);
            this.lciCLV.Name = "lciCLV";
            this.lciCLV.Size = new System.Drawing.Size(411, 277);
            this.lciCLV.Text = "CLV";
            this.lciCLV.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.lciCLV.TextSize = new System.Drawing.Size(77, 16);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 265);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(834, 6);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(416, 0);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(6, 265);
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.Location = new System.Drawing.Point(417, 271);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(6, 277);
            // 
            // pmcTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcPrincipal);
            this.Name = "pmcTableauDeBord";
            this.Size = new System.Drawing.Size(834, 548);
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).EndInit();
            this.lcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLoyaltyModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReclamation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcPrincipal;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPrincipal;
        private pmcSegmentation pmcSegmentation1;
        private pmcGestionReclamation pmcGestionReclamation1;
        private pmcQuestionnaireNoteSegment pmcQuestionnaireNoteSegment1;
        private pmcLoyatyModel pmcLoyatyModel1;
        private DevExpress.XtraLayout.LayoutControlItem lciLoyaltyModel;
        private DevExpress.XtraLayout.LayoutControlItem lciNPS;
        private DevExpress.XtraLayout.LayoutControlItem lciReclamation;
        private DevExpress.XtraLayout.LayoutControlItem lciCLV;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem3;
    }
}
