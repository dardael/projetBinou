using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace ComHe_Pilotage.Pmc.TableauDeBord {
    public partial class pmcTableauDeBord : pmcParentUtilisantFicheDeTravail {
        public pmcTableauDeBord() {
            InitializeComponent();
            pmcQuestionnaireNoteSegment1.adapaterAffichage("NPS", "Si un proche avait besoin d'un professionnel de l'expertise comptable, lui recommanderiez vous votre cabinet ?", fiche);
            pmcQuestionnaireNoteSegment1.PassageModeTableauDebord();
            pmcLoyatyModel1.PassageModeTableauDebord();
            pmcGestionReclamation1.PassageModeTableauDebord();
            pmcSegmentation1.PassageModeTableauDebord();
        }
        protected override void gererChangementFicheCourante() {
            pmcGestionReclamation1.fiche = fiche;
            pmcLoyatyModel1.fiche = fiche;
            pmcQuestionnaireNoteSegment1.fiche = fiche;
            pmcSegmentation1.fiche = fiche;
            populateCaChart();
        }
        private void populateCaChart() {
            chCa.Series.Clear();
            Series s = new Series("Evolution du CA", ViewType.Bar);
            s.Points.Add(new SeriesPoint("CA N-2", this.fiche.indicateursFinanciers.croissanceCA.caAvantAvant));
            s.Points.Add(new SeriesPoint("CA N-1", this.fiche.indicateursFinanciers.croissanceCA.caAvant));
            s.Points.Add(new SeriesPoint("CA N", fiche.indicateursFinanciers.croissanceCA.ca));
            chCa.Series.Add(s);
            Series s2 = new Series("Evolution du CA", ViewType.Line);
            s2.Points.Add(new SeriesPoint("CA N-2", this.fiche.indicateursFinanciers.croissanceCA.caAvantAvant));
            s2.Points.Add(new SeriesPoint("CA N-1", this.fiche.indicateursFinanciers.croissanceCA.caAvant));
            s2.Points.Add(new SeriesPoint("CA N", fiche.indicateursFinanciers.croissanceCA.ca));
            chCa.Series.Add(s2);
        }
        private void chCa_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = e.SeriesPoint.Argument;
        }
    }
}
