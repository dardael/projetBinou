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
            this.lcSatisfactionModel = new DevExpress.XtraLayout.LayoutControl();
            this.trSatisfactionModel = new DevExpress.XtraTreeList.TreeList();
            this.colnom = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repoBtAjout = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colpoids = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colisSupprimable = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dimensionSatisfactionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lcgSatisfactionModel = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcSatisfactionModel)).BeginInit();
            this.lcSatisfactionModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trSatisfactionModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtAjout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSatisfactionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSatisfactionModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcSatisfactionModel
            // 
            this.lcSatisfactionModel.Controls.Add(this.trSatisfactionModel);
            this.lcSatisfactionModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcSatisfactionModel.Location = new System.Drawing.Point(0, 0);
            this.lcSatisfactionModel.Name = "lcSatisfactionModel";
            this.lcSatisfactionModel.Root = this.lcgSatisfactionModel;
            this.lcSatisfactionModel.Size = new System.Drawing.Size(913, 542);
            this.lcSatisfactionModel.TabIndex = 0;
            this.lcSatisfactionModel.Text = "layoutControl1";
            // 
            // trSatisfactionModel
            // 
            this.trSatisfactionModel.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colnom,
            this.colpoids,
            this.colisSupprimable});
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
            this.trSatisfactionModel.Size = new System.Drawing.Size(907, 536);
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
            // colisSupprimable
            // 
            this.colisSupprimable.FieldName = "isSupprimable";
            this.colisSupprimable.Name = "colisSupprimable";
            this.colisSupprimable.Width = 177;
            // 
            // dimensionSatisfactionModelBindingSource
            // 
            this.dimensionSatisfactionModelBindingSource.DataSource = typeof(ComHe_Objets.DimensionSatisfactionModel);
            // 
            // lcgSatisfactionModel
            // 
            this.lcgSatisfactionModel.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgSatisfactionModel.GroupBordersVisible = false;
            this.lcgSatisfactionModel.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lcgSatisfactionModel.Location = new System.Drawing.Point(0, 0);
            this.lcgSatisfactionModel.Name = "lcgSatisfactionModel";
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
            this.layoutControlItem1.Size = new System.Drawing.Size(913, 542);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.trSatisfactionModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtAjout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSatisfactionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSatisfactionModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcSatisfactionModel;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSatisfactionModel;
        private DevExpress.XtraTreeList.TreeList trSatisfactionModel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnom;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colpoids;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colisSupprimable;
        private System.Windows.Forms.BindingSource dimensionSatisfactionModelBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtAjout;
    }
}
