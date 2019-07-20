namespace ComHe_Pilotage {
    partial class pmcComplaintModel {
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
            this.lcComplaintModel = new DevExpress.XtraLayout.LayoutControl();
            this.trComplaintModel = new DevExpress.XtraTreeList.TreeList();
            this.collibelle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colvaleur = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repoPbNbPersonne = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.itemComplaintModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lciComplaintModel = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcComplaintModel)).BeginInit();
            this.lcComplaintModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trComplaintModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPbNbPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemComplaintModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciComplaintModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcComplaintModel
            // 
            this.lcComplaintModel.Controls.Add(this.trComplaintModel);
            this.lcComplaintModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcComplaintModel.Location = new System.Drawing.Point(0, 0);
            this.lcComplaintModel.Name = "lcComplaintModel";
            this.lcComplaintModel.Root = this.lciComplaintModel;
            this.lcComplaintModel.Size = new System.Drawing.Size(873, 508);
            this.lcComplaintModel.TabIndex = 0;
            this.lcComplaintModel.Text = "layoutControl1";
            // 
            // trComplaintModel
            // 
            this.trComplaintModel.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.collibelle,
            this.colvaleur});
            this.trComplaintModel.DataSource = this.itemComplaintModelBindingSource;
            this.trComplaintModel.KeyFieldName = "id";
            this.trComplaintModel.Location = new System.Drawing.Point(3, 3);
            this.trComplaintModel.Name = "trComplaintModel";
            this.trComplaintModel.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.trComplaintModel.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.trComplaintModel.ParentFieldName = "idParent";
            this.trComplaintModel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoPbNbPersonne});
            this.trComplaintModel.Size = new System.Drawing.Size(867, 502);
            this.trComplaintModel.TabIndex = 4;
            // 
            // collibelle
            // 
            this.collibelle.Caption = "Cas";
            this.collibelle.FieldName = "libelle";
            this.collibelle.Name = "collibelle";
            this.collibelle.OptionsColumn.ReadOnly = true;
            this.collibelle.Visible = true;
            this.collibelle.VisibleIndex = 0;
            this.collibelle.Width = 141;
            // 
            // colvaleur
            // 
            this.colvaleur.Caption = "% de personnes";
            this.colvaleur.FieldName = "valeur";
            this.colvaleur.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvaleur.Name = "colvaleur";
            this.colvaleur.Visible = true;
            this.colvaleur.VisibleIndex = 1;
            this.colvaleur.Width = 141;
            // 
            // repoPbNbPersonne
            // 
            this.repoPbNbPersonne.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repoPbNbPersonne.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repoPbNbPersonne.Name = "repoPbNbPersonne";
            this.repoPbNbPersonne.Step = 1;
            this.repoPbNbPersonne.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            // 
            // itemComplaintModelBindingSource
            // 
            this.itemComplaintModelBindingSource.DataSource = typeof(ComHe_Objets.ItemComplaintModel);
            // 
            // lciComplaintModel
            // 
            this.lciComplaintModel.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lciComplaintModel.GroupBordersVisible = false;
            this.lciComplaintModel.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lciComplaintModel.Location = new System.Drawing.Point(0, 0);
            this.lciComplaintModel.Name = "lciComplaintModel";
            this.lciComplaintModel.OptionsItemText.TextToControlDistance = 4;
            this.lciComplaintModel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciComplaintModel.Size = new System.Drawing.Size(873, 508);
            this.lciComplaintModel.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.trComplaintModel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(873, 508);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // pmcComplaintModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcComplaintModel);
            this.Name = "pmcComplaintModel";
            this.Size = new System.Drawing.Size(873, 508);
            ((System.ComponentModel.ISupportInitialize)(this.lcComplaintModel)).EndInit();
            this.lcComplaintModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trComplaintModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPbNbPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemComplaintModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciComplaintModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcComplaintModel;
        private DevExpress.XtraLayout.LayoutControlGroup lciComplaintModel;
        private DevExpress.XtraTreeList.TreeList trComplaintModel;
        private System.Windows.Forms.BindingSource itemComplaintModelBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn collibelle;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colvaleur;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repoPbNbPersonne;
    }
}
