namespace ComHe_Pilotage {
    partial class pmcApprentissage {
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
            this.lcApprentissage = new DevExpress.XtraLayout.LayoutControl();
            this.btAjouterFormation = new DevExpress.XtraEditors.SimpleButton();
            this.gcFormations = new DevExpress.XtraGrid.GridControl();
            this.formationCollaborateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvFormations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompetences = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcoutsRattaches = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBtSupprimer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.lcgApprentissage = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcApprentissage)).BeginInit();
            this.lcApprentissage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFormations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationCollaborateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtSupprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgApprentissage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcApprentissage
            // 
            this.lcApprentissage.Controls.Add(this.btAjouterFormation);
            this.lcApprentissage.Controls.Add(this.gcFormations);
            this.lcApprentissage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcApprentissage.Location = new System.Drawing.Point(0, 0);
            this.lcApprentissage.Margin = new System.Windows.Forms.Padding(0);
            this.lcApprentissage.Name = "lcApprentissage";
            this.lcApprentissage.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(905, 263, 312, 437);
            this.lcApprentissage.Root = this.lcgApprentissage;
            this.lcApprentissage.Size = new System.Drawing.Size(1015, 545);
            this.lcApprentissage.TabIndex = 0;
            this.lcApprentissage.Text = "layoutControl1";
            // 
            // btAjouterFormation
            // 
            this.btAjouterFormation.Location = new System.Drawing.Point(3, 3);
            this.btAjouterFormation.Name = "btAjouterFormation";
            this.btAjouterFormation.Size = new System.Drawing.Size(147, 27);
            this.btAjouterFormation.StyleController = this.lcApprentissage;
            this.btAjouterFormation.TabIndex = 5;
            this.btAjouterFormation.Text = "Ajouter une formation";
            this.btAjouterFormation.Click += new System.EventHandler(this.btAjouterFormation_Click);
            // 
            // gcFormations
            // 
            this.gcFormations.DataSource = this.formationCollaborateurBindingSource;
            this.gcFormations.Location = new System.Drawing.Point(3, 36);
            this.gcFormations.MainView = this.gvFormations;
            this.gcFormations.Margin = new System.Windows.Forms.Padding(0);
            this.gcFormations.Name = "gcFormations";
            this.gcFormations.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBtSupprimer});
            this.gcFormations.Size = new System.Drawing.Size(1009, 506);
            this.gcFormations.TabIndex = 4;
            this.gcFormations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFormations});
            // 
            // formationCollaborateurBindingSource
            // 
            this.formationCollaborateurBindingSource.DataSource = typeof(ComHe_Objets.FormationCollaborateur);
            // 
            // gvFormations
            // 
            this.gvFormations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom,
            this.coldate,
            this.colcompetences,
            this.colcoutsRattaches,
            this.colAction});
            this.gvFormations.GridControl = this.gcFormations;
            this.gvFormations.Name = "gvFormations";
            // 
            // colnom
            // 
            this.colnom.Caption = "Collaborateur";
            this.colnom.FieldName = "nom";
            this.colnom.Name = "colnom";
            this.colnom.Visible = true;
            this.colnom.VisibleIndex = 0;
            this.colnom.Width = 242;
            // 
            // coldate
            // 
            this.coldate.Caption = "Date de la formation";
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 1;
            this.coldate.Width = 242;
            // 
            // colcompetences
            // 
            this.colcompetences.Caption = "Compétences";
            this.colcompetences.FieldName = "competences";
            this.colcompetences.Name = "colcompetences";
            this.colcompetences.Visible = true;
            this.colcompetences.VisibleIndex = 2;
            this.colcompetences.Width = 242;
            // 
            // colcoutsRattaches
            // 
            this.colcoutsRattaches.Caption = "Couts rattachés";
            this.colcoutsRattaches.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcoutsRattaches.FieldName = "coutsRattaches";
            this.colcoutsRattaches.Name = "colcoutsRattaches";
            this.colcoutsRattaches.Visible = true;
            this.colcoutsRattaches.VisibleIndex = 3;
            this.colcoutsRattaches.Width = 242;
            // 
            // colAction
            // 
            this.colAction.Caption = "Actions";
            this.colAction.ColumnEdit = this.repoBtSupprimer;
            this.colAction.Name = "colAction";
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 4;
            this.colAction.Width = 30;
            // 
            // repoBtSupprimer
            // 
            this.repoBtSupprimer.AutoHeight = false;
            this.repoBtSupprimer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repoBtSupprimer.Name = "repoBtSupprimer";
            this.repoBtSupprimer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoBtSupprimer_ButtonClick);
            // 
            // lcgApprentissage
            // 
            this.lcgApprentissage.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgApprentissage.GroupBordersVisible = false;
            this.lcgApprentissage.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.lcgApprentissage.Location = new System.Drawing.Point(0, 0);
            this.lcgApprentissage.Name = "Root";
            this.lcgApprentissage.OptionsItemText.TextToControlDistance = 4;
            this.lcgApprentissage.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgApprentissage.Size = new System.Drawing.Size(1015, 545);
            this.lcgApprentissage.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcFormations;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1015, 512);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btAjouterFormation;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(153, 33);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(153, 33);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(153, 33);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(153, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(862, 33);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(862, 33);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(862, 33);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pmcApprentissage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcApprentissage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "pmcApprentissage";
            this.Size = new System.Drawing.Size(1015, 545);
            ((System.ComponentModel.ISupportInitialize)(this.lcApprentissage)).EndInit();
            this.lcApprentissage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFormations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationCollaborateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtSupprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgApprentissage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcApprentissage;
        private DevExpress.XtraLayout.LayoutControlGroup lcgApprentissage;
        private DevExpress.XtraGrid.GridControl gcFormations;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFormations;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource formationCollaborateurBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnom;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colcompetences;
        private DevExpress.XtraGrid.Columns.GridColumn colcoutsRattaches;
        private DevExpress.XtraEditors.SimpleButton btAjouterFormation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtSupprimer;
    }
}
