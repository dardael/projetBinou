﻿namespace ComHe_Pilotage {
    partial class pmcQuestionnaireNoteSegment {
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
            this.pnPrincipal = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.segmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grNotation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne0NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne1NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne2NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne3NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne4NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne5NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne6NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne7NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne8NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne9NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne10NPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne0CES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne1CES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne2CES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne3CES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne4CES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPersonne5CES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbQuestion = new DevExpress.XtraEditors.LabelControl();
            this.lcGridNotation = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGridNotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.gridControl1);
            this.pnPrincipal.Controls.Add(this.lbQuestion);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Root = this.lcGridNotation;
            this.pnPrincipal.Size = new System.Drawing.Size(957, 376);
            this.pnPrincipal.TabIndex = 0;
            this.pnPrincipal.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.segmentBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(16, 38);
            this.gridControl1.MainView = this.grNotation;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(925, 322);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grNotation});
            // 
            // segmentBindingSource
            // 
            this.segmentBindingSource.DataSource = typeof(ComHe_Objets.Segment);
            // 
            // grNotation
            // 
            this.grNotation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom,
            this.colnbPersonne0NPS,
            this.colnbPersonne1NPS,
            this.colnbPersonne2NPS,
            this.colnbPersonne3NPS,
            this.colnbPersonne4NPS,
            this.colnbPersonne5NPS,
            this.colnbPersonne6NPS,
            this.colnbPersonne7NPS,
            this.colnbPersonne8NPS,
            this.colnbPersonne9NPS,
            this.colnbPersonne10NPS,
            this.colnbPersonne0CES,
            this.colnbPersonne1CES,
            this.colnbPersonne2CES,
            this.colnbPersonne3CES,
            this.colnbPersonne4CES,
            this.colnbPersonne5CES});
            this.grNotation.GridControl = this.gridControl1;
            this.grNotation.Name = "grNotation";
            this.grNotation.OptionsView.ShowGroupPanel = false;
            // 
            // colnom
            // 
            this.colnom.Caption = "Segment";
            this.colnom.FieldName = "nom";
            this.colnom.Name = "colnom";
            this.colnom.OptionsColumn.AllowEdit = false;
            this.colnom.OptionsColumn.ReadOnly = true;
            this.colnom.Visible = true;
            this.colnom.VisibleIndex = 0;
            // 
            // colnbPersonne0NPS
            // 
            this.colnbPersonne0NPS.Caption = "0";
            this.colnbPersonne0NPS.FieldName = "nbPersonne0NPS";
            this.colnbPersonne0NPS.Name = "colnbPersonne0NPS";
            this.colnbPersonne0NPS.Visible = true;
            this.colnbPersonne0NPS.VisibleIndex = 1;
            // 
            // colnbPersonne1NPS
            // 
            this.colnbPersonne1NPS.Caption = "1";
            this.colnbPersonne1NPS.FieldName = "nbPersonne1NPS";
            this.colnbPersonne1NPS.Name = "colnbPersonne1NPS";
            this.colnbPersonne1NPS.Visible = true;
            this.colnbPersonne1NPS.VisibleIndex = 2;
            // 
            // colnbPersonne2NPS
            // 
            this.colnbPersonne2NPS.Caption = "2";
            this.colnbPersonne2NPS.FieldName = "nbPersonne2NPS";
            this.colnbPersonne2NPS.Name = "colnbPersonne2NPS";
            this.colnbPersonne2NPS.Visible = true;
            this.colnbPersonne2NPS.VisibleIndex = 3;
            // 
            // colnbPersonne3NPS
            // 
            this.colnbPersonne3NPS.Caption = "3";
            this.colnbPersonne3NPS.FieldName = "nbPersonne3NPS";
            this.colnbPersonne3NPS.Name = "colnbPersonne3NPS";
            this.colnbPersonne3NPS.Visible = true;
            this.colnbPersonne3NPS.VisibleIndex = 4;
            // 
            // colnbPersonne4NPS
            // 
            this.colnbPersonne4NPS.Caption = "4";
            this.colnbPersonne4NPS.FieldName = "nbPersonne4NPS";
            this.colnbPersonne4NPS.Name = "colnbPersonne4NPS";
            this.colnbPersonne4NPS.Visible = true;
            this.colnbPersonne4NPS.VisibleIndex = 5;
            // 
            // colnbPersonne5NPS
            // 
            this.colnbPersonne5NPS.Caption = "5";
            this.colnbPersonne5NPS.FieldName = "nbPersonne5NPS";
            this.colnbPersonne5NPS.Name = "colnbPersonne5NPS";
            this.colnbPersonne5NPS.Visible = true;
            this.colnbPersonne5NPS.VisibleIndex = 6;
            // 
            // colnbPersonne6NPS
            // 
            this.colnbPersonne6NPS.Caption = "6";
            this.colnbPersonne6NPS.FieldName = "nbPersonne6NPS";
            this.colnbPersonne6NPS.Name = "colnbPersonne6NPS";
            this.colnbPersonne6NPS.Visible = true;
            this.colnbPersonne6NPS.VisibleIndex = 7;
            // 
            // colnbPersonne7NPS
            // 
            this.colnbPersonne7NPS.Caption = "7";
            this.colnbPersonne7NPS.FieldName = "nbPersonne7NPS";
            this.colnbPersonne7NPS.Name = "colnbPersonne7NPS";
            this.colnbPersonne7NPS.Visible = true;
            this.colnbPersonne7NPS.VisibleIndex = 8;
            // 
            // colnbPersonne8NPS
            // 
            this.colnbPersonne8NPS.Caption = "8";
            this.colnbPersonne8NPS.FieldName = "nbPersonne8NPS";
            this.colnbPersonne8NPS.Name = "colnbPersonne8NPS";
            this.colnbPersonne8NPS.Visible = true;
            this.colnbPersonne8NPS.VisibleIndex = 9;
            // 
            // colnbPersonne9NPS
            // 
            this.colnbPersonne9NPS.Caption = "9";
            this.colnbPersonne9NPS.FieldName = "nbPersonne9NPS";
            this.colnbPersonne9NPS.Name = "colnbPersonne9NPS";
            this.colnbPersonne9NPS.Visible = true;
            this.colnbPersonne9NPS.VisibleIndex = 10;
            // 
            // colnbPersonne10NPS
            // 
            this.colnbPersonne10NPS.Caption = "10";
            this.colnbPersonne10NPS.FieldName = "nbPersonne10NPS";
            this.colnbPersonne10NPS.Name = "colnbPersonne10NPS";
            this.colnbPersonne10NPS.Visible = true;
            this.colnbPersonne10NPS.VisibleIndex = 11;
            // 
            // colnbPersonne0CES
            // 
            this.colnbPersonne0CES.Caption = "0";
            this.colnbPersonne0CES.FieldName = "nbPersonne0CES";
            this.colnbPersonne0CES.Name = "colnbPersonne0CES";
            this.colnbPersonne0CES.Visible = true;
            this.colnbPersonne0CES.VisibleIndex = 12;
            // 
            // colnbPersonne1CES
            // 
            this.colnbPersonne1CES.Caption = "1";
            this.colnbPersonne1CES.FieldName = "nbPersonne1CES";
            this.colnbPersonne1CES.Name = "colnbPersonne1CES";
            this.colnbPersonne1CES.Visible = true;
            this.colnbPersonne1CES.VisibleIndex = 13;
            // 
            // colnbPersonne2CES
            // 
            this.colnbPersonne2CES.Caption = "2";
            this.colnbPersonne2CES.FieldName = "nbPersonne2CES";
            this.colnbPersonne2CES.Name = "colnbPersonne2CES";
            this.colnbPersonne2CES.Visible = true;
            this.colnbPersonne2CES.VisibleIndex = 14;
            // 
            // colnbPersonne3CES
            // 
            this.colnbPersonne3CES.Caption = "3";
            this.colnbPersonne3CES.FieldName = "nbPersonne3CES";
            this.colnbPersonne3CES.Name = "colnbPersonne3CES";
            this.colnbPersonne3CES.Visible = true;
            this.colnbPersonne3CES.VisibleIndex = 15;
            // 
            // colnbPersonne4CES
            // 
            this.colnbPersonne4CES.Caption = "4";
            this.colnbPersonne4CES.FieldName = "nbPersonne4CES";
            this.colnbPersonne4CES.Name = "colnbPersonne4CES";
            this.colnbPersonne4CES.Visible = true;
            this.colnbPersonne4CES.VisibleIndex = 16;
            // 
            // colnbPersonne5CES
            // 
            this.colnbPersonne5CES.Caption = "5";
            this.colnbPersonne5CES.FieldName = "nbPersonne5CES";
            this.colnbPersonne5CES.Name = "colnbPersonne5CES";
            this.colnbPersonne5CES.Visible = true;
            this.colnbPersonne5CES.VisibleIndex = 17;
            // 
            // lbQuestion
            // 
            this.lbQuestion.Location = new System.Drawing.Point(16, 16);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(75, 16);
            this.lbQuestion.StyleController = this.pnPrincipal;
            this.lbQuestion.TabIndex = 4;
            this.lbQuestion.Text = "labelControl1";
            // 
            // lcGridNotation
            // 
            this.lcGridNotation.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcGridNotation.GroupBordersVisible = false;
            this.lcGridNotation.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.lcGridNotation.Location = new System.Drawing.Point(0, 0);
            this.lcGridNotation.Name = "lcGridNotation";
            this.lcGridNotation.OptionsItemText.TextToControlDistance = 4;
            this.lcGridNotation.Size = new System.Drawing.Size(957, 376);
            this.lcGridNotation.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lbQuestion;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(931, 22);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(931, 328);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // pmcQuestionnaireNoteSegment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnPrincipal);
            this.Name = "pmcQuestionnaireNoteSegment";
            this.Size = new System.Drawing.Size(957, 376);
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGridNotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl pnPrincipal;
        private DevExpress.XtraLayout.LayoutControlGroup lcGridNotation;
        private DevExpress.XtraEditors.LabelControl lbQuestion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grNotation;
        private DevExpress.XtraGrid.Columns.GridColumn colnom;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne0NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne1NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne2NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne3NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne4NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne5NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne6NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne7NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne8NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne9NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne10NPS;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne0CES;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne1CES;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne2CES;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne3CES;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne4CES;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPersonne5CES;
        private System.Windows.Forms.BindingSource segmentBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}