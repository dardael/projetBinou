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
            txtDefaillanceNb.DataBindings.Add("EditValue", this.fiche.indicateursFormations.defaillance, "nbReclamationNonRemontees", true);
        }
        private void gererDataSourceTextEditInnovation() {
            txtInnovationNb.DataBindings.Clear();
            txtInnovationNb.DataBindings.Add("EditValue", this.fiche.indicateursFormations.innovation, "nbInitiativesCollaborateurs", true);
        }
        private void gererDataSourceTextEditInsatisfaction() {
            txtInsatisfactionNbDetectes.DataBindings.Clear();
            txtInsatisfactionNbConserve.DataBindings.Clear();
            txtInsatisfactionRatio.DataBindings.Clear();
            txtInsatisfactionNbDetectes.DataBindings.Add("EditValue", this.fiche.indicateursFormations.caInsatisfactionRecuperee, "nbClientsInsatisfaitsDetectes", true);
            txtInsatisfactionNbConserve.DataBindings.Add("EditValue", this.fiche.indicateursFormations.caInsatisfactionRecuperee, "nbClientsInsatisfaitsConserves", true);
            txtInsatisfactionRatio.DataBindings.Add("EditValue", this.fiche.indicateursFormations.caInsatisfactionRecuperee, "ratio", true);
        }
        private void gererDataSourceTextEditFormation() {
            txtFormationNb.DataBindings.Clear();
            txtFormationBudget.DataBindings.Clear();
            txtFormationEcart.DataBindings.Clear();
            txtFormationNb.DataBindings.Add("EditValue", this.fiche.indicateursFormations.suiviFormation, "nbFormationSuivi", true);
            txtFormationBudget.DataBindings.Add("EditValue", this.fiche.indicateursFormations.suiviFormation, "budget", true);
            txtFormationEcart.DataBindings.Add("EditValue", this.fiche.indicateursFormations.suiviFormation, "ecart", true);
        }
    }
}
