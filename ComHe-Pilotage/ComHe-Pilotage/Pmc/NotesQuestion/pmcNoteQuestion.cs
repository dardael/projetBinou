using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComHe_Objets.NotesQuestion;

namespace ComHe_Pilotage.Pmc.NotesQuestion {
    public partial class pmcNoteQuestion : UserControl {
        private QuestionNotee _questionNotee;
        public QuestionNotee questionNotee {
            get {
                return _questionNotee;
            }
            set {
                _questionNotee = value;
                gererChangementQuestionNoteCourante();
            }
        }
        public pmcNoteQuestion() {
            InitializeComponent();
        }
        public void gererChangementQuestionNoteCourante() {
            if (questionNotee != null) {
                lblQuestion.Text = _questionNotee.question;
                grQuestion.DataSource = _questionNotee.valeurs;
                populateGauge();
                grQuestion.Refresh();
            }
        }
        private void populateGauge() {
            arcScaleComponent1.Value = (float)_questionNotee.score;
        }

        private void grQuestion_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e) {
            populateGauge();
        }
    }
}
