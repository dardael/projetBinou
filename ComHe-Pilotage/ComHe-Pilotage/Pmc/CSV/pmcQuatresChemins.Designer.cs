namespace ComHe_Pilotage {
    partial class pmcQuatresChemins {
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
            this.lcPrincipal = new DevExpress.XtraLayout.LayoutControl();
            this.grQuatresChemins = new DevExpress.XtraVerticalGrid.VGridControl();
            this.lcGrQuatresChemins = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.segmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbEchelle = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.rownom = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownoteBoucheAOreille = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownoteReductionCouts = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownoteAugmentationDepensesAchatsCroises = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownotePricePremium = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTotal = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).BeginInit();
            this.lcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grQuatresChemins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGrQuatresChemins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEchelle)).BeginInit();
            this.SuspendLayout();
            // 
            // lcPrincipal
            // 
            this.lcPrincipal.Controls.Add(this.grQuatresChemins);
            this.lcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lcPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.lcPrincipal.Name = "lcPrincipal";
            this.lcPrincipal.Root = this.lcGrQuatresChemins;
            this.lcPrincipal.Size = new System.Drawing.Size(751, 393);
            this.lcPrincipal.TabIndex = 0;
            this.lcPrincipal.Text = "layoutControl1";
            // 
            // grQuatresChemins
            // 
            this.grQuatresChemins.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.grQuatresChemins.DataSource = this.segmentBindingSource;
            this.grQuatresChemins.Location = new System.Drawing.Point(3, 3);
            this.grQuatresChemins.Margin = new System.Windows.Forms.Padding(0);
            this.grQuatresChemins.Name = "grQuatresChemins";
            this.grQuatresChemins.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbEchelle});
            this.grQuatresChemins.RowHeaderWidth = 272;
            this.grQuatresChemins.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rownom,
            this.rownoteBoucheAOreille,
            this.rownoteReductionCouts,
            this.rownoteAugmentationDepensesAchatsCroises,
            this.rownotePricePremium,
            this.rowTotal});
            this.grQuatresChemins.Size = new System.Drawing.Size(745, 387);
            this.grQuatresChemins.TabIndex = 4;
            this.grQuatresChemins.CustomDrawRowValueCell += new DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventHandler(this.grQuatresChemins_CustomDrawRowValueCell);
            // 
            // lcGrQuatresChemins
            // 
            this.lcGrQuatresChemins.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcGrQuatresChemins.GroupBordersVisible = false;
            this.lcGrQuatresChemins.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lcGrQuatresChemins.Location = new System.Drawing.Point(0, 0);
            this.lcGrQuatresChemins.Name = "lcGrQuatresChemins";
            this.lcGrQuatresChemins.OptionsItemText.TextToControlDistance = 4;
            this.lcGrQuatresChemins.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcGrQuatresChemins.Size = new System.Drawing.Size(751, 393);
            this.lcGrQuatresChemins.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grQuatresChemins;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(751, 393);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // segmentBindingSource
            // 
            this.segmentBindingSource.DataSource = typeof(ComHe_Objets.Segment);
            // 
            // cbEchelle
            // 
            this.cbEchelle.AutoHeight = false;
            this.cbEchelle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEchelle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cbEchelle.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cbEchelle.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbEchelle.Name = "cbEchelle";
            // 
            // rownom
            // 
            this.rownom.Name = "rownom";
            this.rownom.Properties.Caption = "Nom";
            this.rownom.Properties.FieldName = "nom";
            this.rownom.Properties.ReadOnly = true;
            // 
            // rownoteBoucheAOreille
            // 
            this.rownoteBoucheAOreille.Name = "rownoteBoucheAOreille";
            this.rownoteBoucheAOreille.Properties.Caption = "Bouche à oreille";
            this.rownoteBoucheAOreille.Properties.FieldName = "noteBoucheAOreille";
            this.rownoteBoucheAOreille.Properties.RowEdit = this.cbEchelle;
            // 
            // rownoteReductionCouts
            // 
            this.rownoteReductionCouts.Name = "rownoteReductionCouts";
            this.rownoteReductionCouts.Properties.Caption = "Réduction des coûts";
            this.rownoteReductionCouts.Properties.FieldName = "noteReductionCouts";
            this.rownoteReductionCouts.Properties.RowEdit = this.cbEchelle;
            // 
            // rownoteAugmentationDepensesAchatsCroises
            // 
            this.rownoteAugmentationDepensesAchatsCroises.Name = "rownoteAugmentationDepensesAchatsCroises";
            this.rownoteAugmentationDepensesAchatsCroises.Properties.Caption = "Augmentation des dépenses/achats croisés";
            this.rownoteAugmentationDepensesAchatsCroises.Properties.FieldName = "noteAugmentationDepensesAchatsCroises";
            this.rownoteAugmentationDepensesAchatsCroises.Properties.RowEdit = this.cbEchelle;
            // 
            // rownotePricePremium
            // 
            this.rownotePricePremium.Height = 22;
            this.rownotePricePremium.Name = "rownotePricePremium";
            this.rownotePricePremium.Properties.Caption = "Price premium";
            this.rownotePricePremium.Properties.FieldName = "notePricePremium";
            this.rownotePricePremium.Properties.RowEdit = this.cbEchelle;
            // 
            // rowTotal
            // 
            this.rowTotal.Name = "rowTotal";
            this.rowTotal.Properties.Caption = "Total";
            this.rowTotal.Properties.FieldName = "totalQuatreChemins";
            this.rowTotal.Properties.ReadOnly = true;
            // 
            // pmcQuatresChemins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "pmcQuatresChemins";
            this.Size = new System.Drawing.Size(751, 393);
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).EndInit();
            this.lcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grQuatresChemins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGrQuatresChemins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEchelle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcPrincipal;
        private DevExpress.XtraLayout.LayoutControlGroup lcGrQuatresChemins;
        private DevExpress.XtraVerticalGrid.VGridControl grQuatresChemins;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource segmentBindingSource;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownom;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownoteBoucheAOreille;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownoteReductionCouts;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownoteAugmentationDepensesAchatsCroises;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownotePricePremium;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbEchelle;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTotal;
    }
}
