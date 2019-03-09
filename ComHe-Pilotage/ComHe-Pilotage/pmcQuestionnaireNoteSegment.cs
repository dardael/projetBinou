using System;
using System.ComponentModel;
using System.Windows.Forms;
using ComHe_Objets;
using DevExpress.XtraGrid.Views.Base;

namespace ComHe_Pilotage {
    public partial class pmcQuestionnaireNoteSegment : UserControl {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        private FicheTravail ficheCourante;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        public FicheTravail fiche {
            set {
                ficheCourante = value;
                gererChangementFicheCourante();
            }
            get {
                return ficheCourante;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        private string _question = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        public string question {
            set {
                _question = value;
                gererChangementQuestion();
            }
            get {
                return _question;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
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
        private void gererChangementFicheCourante() {
            if (fiche != null) {
                populateGridNotation();
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

        private void gridControl1_Click(object sender, EventArgs e) {

        }
    }
}
