using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComHe_Objets;

namespace ComHe_Pilotage {
    public partial class pmcIndicateursFinanciers : pmcParentUtilisantFicheDeTravail {
        public pmcIndicateursFinanciers() {
            InitializeComponent();
        }
        protected override void gererChangementFicheCourante() {
            if (this.fiche != null) {
                if (this.fiche.indicateursFinanciers == null) {
                    this.fiche.indicateursFinanciers = new IndicateursFinanciers();
                }
                if (this.fiche.indicateursFinanciers.croissanceCA == null) {
                    this.fiche.indicateursFinanciers.croissanceCA = new CroissanceCA();
                }
                if (this.fiche.indicateursFinanciers.evaluationCabinet == null) {
                    this.fiche.indicateursFinanciers.evaluationCabinet = new EvaluationCabinet();
                }
                if (this.fiche.indicateursFinanciers.mesureAchatsCroises == null) {
                    this.fiche.indicateursFinanciers.mesureAchatsCroises = new MesureAchatsCroises();
                }
                if (this.fiche.indicateursFinanciers.mesureReductionCout == null) {
                    this.fiche.indicateursFinanciers.mesureReductionCout = new MesureReductionCout();
                }
                if (this.fiche.indicateursFinanciers.performanceActivite == null) {
                    this.fiche.indicateursFinanciers.performanceActivite = new PerformanceActivite();
                }
                gererDataSourceTextEdit();
            }
        }
        private void gererDataSourceTextEdit() {
            gererDataSourceTextEditCroissance();
            gererDataSourceTextEditEvaluation();
            gererDataSourceTextEditMesureAchats();
            gererDataSourceTextEditMesureCouts();
            gererDataSourceTextEditPerf();
            this.Refresh();
        }
        private void gererDataSourceTextEditCroissance() {
            txtCa.DataBindings.Clear();
            txtCa.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.croissanceCA, "ca", true);
            txtCaAvant.DataBindings.Clear();
            txtCaAvant.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.croissanceCA, "caAvant", true);
            txtEcart.DataBindings.Clear();
            txtEcart.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.croissanceCA, "ecart", true);
            txtVariation.DataBindings.Clear();
            txtVariation.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.croissanceCA, "variation", true);
        }
        private void gererDataSourceTextEditPerf() {
            txtCaPerf.DataBindings.Clear();
            txtBudget.DataBindings.Clear();
            txtEcartPerf.DataBindings.Clear();
            txtCaPerf.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.performanceActivite, "ca", true);
            txtBudget.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.performanceActivite, "budget", true);
            txtEcartPerf.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.performanceActivite, "ecart", true);
        }
        private void gererDataSourceTextEditMesureAchats() {
            txtCaExep.DataBindings.Clear();
            txtCaTrad.DataBindings.Clear();
            txtRatio.DataBindings.Clear();
            txtCaExep.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.mesureAchatsCroises, "caExeptionnel", true);
            txtCaTrad.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.mesureAchatsCroises, "caTrad", true);
            txtRatio.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.mesureAchatsCroises, "ratio", true);
        }
        private void gererDataSourceTextEditMesureCouts() {
            txtSurCa.DataBindings.Clear();
            txtNbHeuresPayes.DataBindings.Clear();
            txtCaReduc.DataBindings.Clear();
            txtCaReduc.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.mesureReductionCout, "ca", true);
            txtNbHeuresPayes.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.mesureReductionCout, "nbHeure", true);
            txtSurCa.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.mesureReductionCout, "ratio", true);
        }
        private void gererDataSourceTextEditEvaluation() {
            txtPortefeuilleClient.DataBindings.Clear();
            txtCoef.DataBindings.Clear();
            txtPortefeuilleClient.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.evaluationCabinet, "portefeuilleClient", true);
            txtCoef.DataBindings.Add("EditValue", this.fiche.indicateursFinanciers.evaluationCabinet, "coef", true);
        }
    }
}
