using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComHe_Objets.Indicateurs.Apprentissages;
using DevExpress.XtraCharts;

namespace ComHe_Pilotage.Pmc.Indicateurs.Apprentissage {
    public partial class pmcIndicateursApprentissage : pmcParentUtilisantFicheDeTravail {
        public pmcIndicateursApprentissage() {
            InitializeComponent();
        }
        protected override void gererChangementFicheCourante() {
            if (this.fiche != null) {
                if (this.fiche.indicateursFormations == null) {
                    this.fiche.indicateursFormations = new IndicateursFormations();
                }
                if (this.fiche.indicateursFormations.amarc == null) {
                    this.fiche.indicateursFormations.amarc = new Amarc();
                }
                if (this.fiche.indicateursFormations.caInsatisfactionRecuperee == null) {
                    this.fiche.indicateursFormations.caInsatisfactionRecuperee = new CAInsatisfactionRecupere();
                }
                if (this.fiche.indicateursFormations.defaillance == null) {
                    this.fiche.indicateursFormations.defaillance = new Defaillance();
                }
                if (this.fiche.indicateursFormations.innovation == null) {
                    this.fiche.indicateursFormations.innovation = new Innovation();
                }
                if (this.fiche.indicateursFormations.suiviFormation == null) {
                    this.fiche.indicateursFormations.suiviFormation = new SuiviFormation();
                }
                gererDataSourceTextEdit();
                populateAmarcChart();
                populateReclamationChart();
            }
        }
        private void gererDataSourceTextEdit() {
            gererDataSourceTextEditAmarc();
            gererDataSourceTextEditDefaillance();
            gererDataSourceTextEditFormation();
            gererDataSourceTextEditInnovation();
            gererDataSourceTextEditInsatisfaction();
            this.Refresh();
        }
        private void gererDataSourceTextEditAmarc() {
            txtAmarcNbSondes.DataBindings.Clear();
            txtAmarcnonRepondant.DataBindings.Clear();
            txtAmarcNbSondes.DataBindings.Add("EditValue", this.fiche.indicateursFormations.amarc, "nbMailsSondes", true);
            txtAmarcnonRepondant.DataBindings.Add("EditValue", this.fiche.indicateursFormations.amarc, "nbNonRepondant", true);
        }
        private void gererDataSourceTextEditDefaillance() {
            txtDefaillanceNb.DataBindings.Clear();
            txtDefaillanceNbAvant.DataBindings.Clear();
            txtDefaillanceNbAvantAvant.DataBindings.Clear();
            txtDefaillanceNb.DataBindings.Add("EditValue", this.fiche.indicateursFormations.defaillance, "nbReclamationNonRemontees", true);
            txtDefaillanceNbAvant.DataBindings.Add("EditValue", this.fiche.indicateursFormations.defaillance, "nbReclamationNonRemonteesAvant", true);
            txtDefaillanceNbAvantAvant.DataBindings.Add("EditValue", this.fiche.indicateursFormations.defaillance, "nbReclamationNonRemonteesAvantAvant", true);
        }
        private void gererDataSourceTextEditInnovation() {
            txtInnovationNb.DataBindings.Clear();
            txtInnovationNb.DataBindings.Add("EditValue", this.fiche.indicateursFormations.innovation, "nbInitiativesCollaborateurs", true);
        }
        private void gererDataSourceTextEditInsatisfaction() {
        }
        private void gererDataSourceTextEditFormation() {
            txtFormationNb.DataBindings.Clear();
            txtFormationBudget.DataBindings.Clear();
            txtFormationEcart.DataBindings.Clear();
            txtFormationNb.DataBindings.Add("EditValue", this.fiche.indicateursFormations.suiviFormation, "nbFormationSuivi", true);
            txtFormationBudget.DataBindings.Add("EditValue", this.fiche.indicateursFormations.suiviFormation, "budget", true);
            txtFormationEcart.DataBindings.Add("EditValue", this.fiche.indicateursFormations.suiviFormation, "ecart", true);
        }
        private void populateReclamationChart() {
            chNbReclamations.Series.Clear();
            Series s = new Series("Evolution du nombre de reclamations non remontées", ViewType.Bar);
            s.Points.Add(new SeriesPoint("Nombre de reclamations non remontées N-2", this.fiche.indicateursFormations.defaillance.nbReclamationNonRemonteesAvantAvant));
            s.Points.Add(new SeriesPoint("Nombre de reclamations non remontées N-1", this.fiche.indicateursFormations.defaillance.nbReclamationNonRemonteesAvant));
            s.Points.Add(new SeriesPoint("Nombre de reclamations non remontées N", fiche.indicateursFormations.defaillance.nbReclamationNonRemontees));
            chNbReclamations.Series.Add(s);
            Series s2 = new Series("Evolution du nombre de reclamations non remontées", ViewType.Line);
            s2.Points.Add(new SeriesPoint("Nombre de reclamations non remontées N-2", this.fiche.indicateursFormations.defaillance.nbReclamationNonRemonteesAvantAvant));
            s2.Points.Add(new SeriesPoint("Nombre de reclamations non remontées N-1", this.fiche.indicateursFormations.defaillance.nbReclamationNonRemonteesAvant));
            s2.Points.Add(new SeriesPoint("Nombre de reclamations non remontées N", fiche.indicateursFormations.defaillance.nbReclamationNonRemontees));
            chNbReclamations.Series.Add(s2);
        }
        private void populateAmarcChart() {
            chAmarc.Series.Clear();
            Series s = new Series("Nombre de mails ne répondant pas au référentiel AMARC / Nombre de mail sondés", ViewType.Pie);
            s.Points.Add(new SeriesPoint("Non répondant AMARC", this.fiche.indicateursFormations.amarc.nbNonRepondant));
            s.Points.Add(new SeriesPoint("Nombre de mails sondés", this.fiche.indicateursFormations.amarc.nbMailsSondes - this.fiche.indicateursFormations.amarc.nbNonRepondant));
            chAmarc.Series.Add(s);
        }

        private void txtAmarcnonRepondant_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursFormations.amarc.nbNonRepondant = Convert.ToInt32(txtAmarcnonRepondant.EditValue);
            populateAmarcChart();
        }

        private void txtAmarcNbSondes_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursFormations.amarc.nbMailsSondes = Convert.ToInt32(txtAmarcNbSondes.EditValue);
            populateAmarcChart();
        }

        private void txtDefaillanceNb_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursFormations.defaillance.nbReclamationNonRemontees = Convert.ToInt32(txtDefaillanceNb.EditValue);
            populateReclamationChart();
        }

        private void txtDefaillanceNbAvant_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursFormations.defaillance.nbReclamationNonRemonteesAvant = Convert.ToInt32(txtDefaillanceNbAvant.EditValue);
            populateReclamationChart();
        }

        private void txtDefaillanceNbAvantAvant_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursFormations.defaillance.nbReclamationNonRemonteesAvantAvant = Convert.ToInt32(txtDefaillanceNbAvantAvant.EditValue);
            populateReclamationChart();
        }

        private void chAmarc_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = e.SeriesPoint.Argument;
        }

        private void chNbReclamations_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = e.SeriesPoint.Argument;
        }
    }
}
