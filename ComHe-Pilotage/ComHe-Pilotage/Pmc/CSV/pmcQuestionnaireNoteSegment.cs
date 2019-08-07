using System;
using System.ComponentModel;
using System.Windows.Forms;
using ComHe_Objets;
using DevExpress.XtraGrid.Views.Base;

namespace ComHe_Pilotage {
    public partial class pmcQuestionnaireNoteSegment : pmcParentUtilisantFicheDeTravail {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _question;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string question {
            set {
                _question = value;
                gererChangementQuestion();
            }
            get {
                return _question;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _type;
        public pmcQuestionnaireNoteSegment() {
            InitializeComponent();
        }
        public void adapaterAffichage(String type, String question, FicheTravail fiche) {
            this._type = type;
            this.question = question;
            this.fiche = fiche;
            gererAffichageColonnes();
        }
        private void gererAffichageColonnes() {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((ColumnView)gridControl1.Views[0]).Columns) {
                if (!col.Name.Contains(_type) && col.Name != "colnom" && col.Caption != "Total") {
                    col.Visible = false;
                }
                if (col.Name == "colnom") {
                    col.Caption = "Segment";
                    col.OptionsColumn.ReadOnly = true;
                    col.OptionsColumn.AllowEdit = false;
                }
                else if (col.Name.Contains("score")) {
                    col.Caption = "Score " + _type + " moyen";
                    col.OptionsColumn.ReadOnly = true;
                    col.OptionsColumn.AllowEdit = false;
                    col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average;
                    col.SummaryItem.FieldName = col.FieldName;
                    col.SummaryItem.DisplayFormat = "Moyenne : {0:n3}";
                }
                else {
                    if (col.Name.Contains("10")) {
                        col.Caption = "10";
                    }
                    else if (col.Name.Contains("0")) {
                        col.Caption = "0";
                    }
                    else if (col.Name.Contains("1")) {
                        col.Caption = "1";
                    }
                    else if (col.Name.Contains("2")) {
                        col.Caption = "2";
                    }
                    else if (col.Name.Contains("3")) {
                        col.Caption = "3";
                    }
                    else if (col.Name.Contains("4")) {
                        col.Caption = "4";
                    }
                    else if (col.Name.Contains("5")) {
                        col.Caption = "5";
                    }
                    else if (col.Name.Contains("6")) {
                        col.Caption = "6";
                    }
                    else if (col.Name.Contains("7")) {
                        col.Caption = "7";
                    }
                    else if (col.Name.Contains("8")) {
                        col.Caption = "8";
                    }
                    else if (col.Name.Contains("9")) {
                        col.Caption = "9";
                    }
                    col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    col.SummaryItem.FieldName = col.FieldName;
                    col.SummaryItem.DisplayFormat = "Total : {0:n3}";
                }
            }
            gridControl1.Refresh();
        }
        protected override void gererChangementFicheCourante() {
            if (fiche != null) {
                populateGridNotation();
                populateGauge();
            }
        }
        private void gererChangementQuestion() {
            if (question != null) {
                this.lbQuestion.Text = question;
            }
        }
        private void populateGridNotation() {
            gridControl1.BeginUpdate();
            try {
                grNotation.Columns.Clear();
                gridControl1.DataSource = ficheCourante.segments;
            }
            finally {
                gridControl1.EndUpdate();
            }
            gererAffichageColonnes();
        }
        private void populateGauge() {
            double value = 0;
            if (_type == "NPS") {
                value = ficheCourante.scoreNPSMoyen;
            }
            else if (_type == "CES") {
                value = ficheCourante.scoreCESMoyen;
            }
            arcScaleComponent1.Value = (float)value;
            //this.arcScaleComponent1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ficheTravailBindingSource, "score" + _type + "Moyen", true));
        }

        private void grNotation_CellValueChanged(object sender, CellValueChangedEventArgs e) {
            populateGauge();
        }
        public void PassageModeTableauDebord() {
            lciGrQuestion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciLblQuestion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

        }
    }
}
