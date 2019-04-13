namespace ComHe_Pilotage {
    partial class pmcGestionReclamation {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pmcGestionReclamation));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lcPrincipal = new DevExpress.XtraLayout.LayoutControl();
            this.btAjouterReclamation = new DevExpress.XtraEditors.SimpleButton();
            this.grReclamation = new DevExpress.XtraGrid.GridControl();
            this.reclamationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvReclamations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldateLitige = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcollaborateur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumeroClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colservice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmotifInsatisfaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmotifLegitime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCbOuiNon = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colactionCorrective = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCbAvoirNonPrevu = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colmontantIndemnite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colverbatimClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBtSupprimer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.lcgGrReclamations = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).BeginInit();
            this.lcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grReclamation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclamationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReclamations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCbOuiNon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCbAvoirNonPrevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtSupprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGrReclamations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcPrincipal
            // 
            this.lcPrincipal.Controls.Add(this.btAjouterReclamation);
            this.lcPrincipal.Controls.Add(this.grReclamation);
            this.lcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lcPrincipal.Name = "lcPrincipal";
            this.lcPrincipal.Root = this.lcgGrReclamations;
            this.lcPrincipal.Size = new System.Drawing.Size(1010, 430);
            this.lcPrincipal.TabIndex = 0;
            this.lcPrincipal.Text = "layoutControl1";
            // 
            // btAjouterReclamation
            // 
            this.btAjouterReclamation.Location = new System.Drawing.Point(16, 16);
            this.btAjouterReclamation.Name = "btAjouterReclamation";
            this.btAjouterReclamation.Size = new System.Drawing.Size(182, 27);
            this.btAjouterReclamation.StyleController = this.lcPrincipal;
            this.btAjouterReclamation.TabIndex = 7;
            this.btAjouterReclamation.Text = "Ajouter une réclamation";
            this.btAjouterReclamation.Click += new System.EventHandler(this.btAjouterReclamation_Click);
            // 
            // grReclamation
            // 
            this.grReclamation.DataSource = this.reclamationBindingSource;
            this.grReclamation.Location = new System.Drawing.Point(16, 49);
            this.grReclamation.MainView = this.gvReclamations;
            this.grReclamation.Name = "grReclamation";
            this.grReclamation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCbOuiNon,
            this.repoCbAvoirNonPrevu,
            this.repoBtSupprimer});
            this.grReclamation.Size = new System.Drawing.Size(978, 365);
            this.grReclamation.TabIndex = 4;
            this.grReclamation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReclamations});
            // 
            // reclamationBindingSource
            // 
            this.reclamationBindingSource.DataSource = typeof(ComHe_Objets.Reclamation);
            // 
            // gvReclamations
            // 
            this.gvReclamations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldateLitige,
            this.colcollaborateur,
            this.colclient,
            this.colnumeroClient,
            this.colservice,
            this.colmotifInsatisfaction,
            this.colmotifLegitime,
            this.colactionCorrective,
            this.colmontantIndemnite,
            this.colverbatimClient,
            this.colactions});
            this.gvReclamations.GridControl = this.grReclamation;
            this.gvReclamations.Name = "gvReclamations";
            // 
            // coldateLitige
            // 
            this.coldateLitige.Caption = "Date";
            this.coldateLitige.DisplayFormat.FormatString = "d";
            this.coldateLitige.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldateLitige.FieldName = "dateLitige";
            this.coldateLitige.Name = "coldateLitige";
            this.coldateLitige.Visible = true;
            this.coldateLitige.VisibleIndex = 0;
            this.coldateLitige.Width = 93;
            // 
            // colcollaborateur
            // 
            this.colcollaborateur.Caption = "Collaborateur";
            this.colcollaborateur.FieldName = "collaborateur";
            this.colcollaborateur.Name = "colcollaborateur";
            this.colcollaborateur.Visible = true;
            this.colcollaborateur.VisibleIndex = 1;
            this.colcollaborateur.Width = 93;
            // 
            // colclient
            // 
            this.colclient.Caption = "Client";
            this.colclient.FieldName = "client";
            this.colclient.Name = "colclient";
            this.colclient.Visible = true;
            this.colclient.VisibleIndex = 2;
            this.colclient.Width = 93;
            // 
            // colnumeroClient
            // 
            this.colnumeroClient.Caption = "N° client";
            this.colnumeroClient.FieldName = "numeroClient";
            this.colnumeroClient.Name = "colnumeroClient";
            this.colnumeroClient.Visible = true;
            this.colnumeroClient.VisibleIndex = 3;
            this.colnumeroClient.Width = 93;
            // 
            // colservice
            // 
            this.colservice.Caption = "Service";
            this.colservice.FieldName = "service";
            this.colservice.Name = "colservice";
            this.colservice.Visible = true;
            this.colservice.VisibleIndex = 4;
            this.colservice.Width = 93;
            // 
            // colmotifInsatisfaction
            // 
            this.colmotifInsatisfaction.Caption = "Motif de l\'insatisfaction";
            this.colmotifInsatisfaction.FieldName = "motifInsatisfaction";
            this.colmotifInsatisfaction.Name = "colmotifInsatisfaction";
            this.colmotifInsatisfaction.Visible = true;
            this.colmotifInsatisfaction.VisibleIndex = 5;
            this.colmotifInsatisfaction.Width = 93;
            // 
            // colmotifLegitime
            // 
            this.colmotifLegitime.Caption = "Motif légitime";
            this.colmotifLegitime.ColumnEdit = this.repoCbOuiNon;
            this.colmotifLegitime.FieldName = "motifLegitime";
            this.colmotifLegitime.Name = "colmotifLegitime";
            this.colmotifLegitime.Visible = true;
            this.colmotifLegitime.VisibleIndex = 7;
            this.colmotifLegitime.Width = 93;
            // 
            // repoCbOuiNon
            // 
            this.repoCbOuiNon.AutoHeight = false;
            this.repoCbOuiNon.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCbOuiNon.Items.AddRange(new object[] {
            "OUI",
            "NON"});
            this.repoCbOuiNon.Name = "repoCbOuiNon";
            // 
            // colactionCorrective
            // 
            this.colactionCorrective.Caption = "Action corrective";
            this.colactionCorrective.ColumnEdit = this.repoCbAvoirNonPrevu;
            this.colactionCorrective.FieldName = "actionCorrective";
            this.colactionCorrective.Name = "colactionCorrective";
            this.colactionCorrective.Visible = true;
            this.colactionCorrective.VisibleIndex = 6;
            this.colactionCorrective.Width = 93;
            // 
            // repoCbAvoirNonPrevu
            // 
            this.repoCbAvoirNonPrevu.AutoHeight = false;
            this.repoCbAvoirNonPrevu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCbAvoirNonPrevu.Items.AddRange(new object[] {
            "AVOIR",
            "NON PREVUE"});
            this.repoCbAvoirNonPrevu.Name = "repoCbAvoirNonPrevu";
            // 
            // colmontantIndemnite
            // 
            this.colmontantIndemnite.Caption = "Montant de l\'indemnisation";
            this.colmontantIndemnite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmontantIndemnite.FieldName = "montantIndemnite";
            this.colmontantIndemnite.Name = "colmontantIndemnite";
            this.colmontantIndemnite.Visible = true;
            this.colmontantIndemnite.VisibleIndex = 8;
            this.colmontantIndemnite.Width = 93;
            // 
            // colverbatimClient
            // 
            this.colverbatimClient.Caption = "Verbatim client";
            this.colverbatimClient.FieldName = "verbatimClient";
            this.colverbatimClient.Name = "colverbatimClient";
            this.colverbatimClient.Visible = true;
            this.colverbatimClient.VisibleIndex = 9;
            this.colverbatimClient.Width = 101;
            // 
            // colactions
            // 
            this.colactions.ColumnEdit = this.repoBtSupprimer;
            this.colactions.MaxWidth = 100;
            this.colactions.Name = "colactions";
            this.colactions.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colactions.Visible = true;
            this.colactions.VisibleIndex = 10;
            this.colactions.Width = 20;
            // 
            // repoBtSupprimer
            // 
            this.repoBtSupprimer.AutoHeight = false;
            this.repoBtSupprimer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repoBtSupprimer.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repoBtSupprimer.Name = "repoBtSupprimer";
            this.repoBtSupprimer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoBtSupprimer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoBtSupprimer_ButtonClick);
            // 
            // lcgGrReclamations
            // 
            this.lcgGrReclamations.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgGrReclamations.GroupBordersVisible = false;
            this.lcgGrReclamations.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.lcgGrReclamations.Location = new System.Drawing.Point(0, 0);
            this.lcgGrReclamations.Name = "lcgGrReclamations";
            this.lcgGrReclamations.OptionsItemText.TextToControlDistance = 4;
            this.lcgGrReclamations.Size = new System.Drawing.Size(1010, 430);
            this.lcgGrReclamations.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grReclamation;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(984, 371);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btAjouterReclamation;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(188, 33);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(188, 33);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(188, 33);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(188, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(106, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(796, 33);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pmcGestionReclamation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcPrincipal);
            this.Name = "pmcGestionReclamation";
            this.Size = new System.Drawing.Size(1010, 430);
            ((System.ComponentModel.ISupportInitialize)(this.lcPrincipal)).EndInit();
            this.lcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grReclamation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclamationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReclamations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCbOuiNon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCbAvoirNonPrevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtSupprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGrReclamations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcPrincipal;
        private DevExpress.XtraLayout.LayoutControlGroup lcgGrReclamations;
        private DevExpress.XtraGrid.GridControl grReclamation;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReclamations;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource reclamationBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldateLitige;
        private DevExpress.XtraGrid.Columns.GridColumn colcollaborateur;
        private DevExpress.XtraGrid.Columns.GridColumn colclient;
        private DevExpress.XtraGrid.Columns.GridColumn colnumeroClient;
        private DevExpress.XtraGrid.Columns.GridColumn colservice;
        private DevExpress.XtraGrid.Columns.GridColumn colmotifInsatisfaction;
        private DevExpress.XtraGrid.Columns.GridColumn colmotifLegitime;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repoCbOuiNon;
        private DevExpress.XtraGrid.Columns.GridColumn colactionCorrective;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repoCbAvoirNonPrevu;
        private DevExpress.XtraGrid.Columns.GridColumn colmontantIndemnite;
        private DevExpress.XtraGrid.Columns.GridColumn colverbatimClient;
        private DevExpress.XtraGrid.Columns.GridColumn colactions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtSupprimer;
        private DevExpress.XtraEditors.SimpleButton btAjouterReclamation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
