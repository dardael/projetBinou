using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComHe_Objets.Indicateurs.Interne;

namespace ComHe_Pilotage.Pmc.Indicateurs.Interne {
    public partial class pmcIndicateursInternes : pmcParentUtilisantFicheDeTravail {
        public pmcIndicateursInternes() {
            InitializeComponent();
        }
        protected override void gererChangementFicheCourante() {
            if (this.fiche != null) {
                if (this.fiche.indicateursInternes == null) {
                    this.fiche.indicateursInternes = new IndicateursInternes();
                }
                if (this.fiche.indicateursInternes.defaillanceCabinet == null) {
                    this.fiche.indicateursInternes.defaillanceCabinet = new DefaillanceCabinet();
                }
                if (this.fiche.indicateursInternes.defaillanceControleFiscal == null) {
                    this.fiche.indicateursInternes.defaillanceControleFiscal = new DefaillanceControleFiscal();
                }
                if (this.fiche.indicateursInternes.nbDossierParCollaborateur == null) {
                    this.fiche.indicateursInternes.nbDossierParCollaborateur = new NbDossierParCollaborateur();
                }
                if (this.fiche.indicateursInternes.reductionTempsProduction == null) {
                    this.fiche.indicateursInternes.reductionTempsProduction = new ReductionTempsProduction();
                }
                if (this.fiche.indicateursInternes.tauxDossiersNonRentables == null) {
                    this.fiche.indicateursInternes.tauxDossiersNonRentables = new TauxDossiersNonRentables();
                }
                if (this.fiche.indicateursInternes.tauxRemonteesReclamation == null) {
                    this.fiche.indicateursInternes.tauxRemonteesReclamation = new TauxRemonteesReclamation();
                }
                if (this.fiche.indicateursInternes.tauxRetardDepotDossier == null) {
                    this.fiche.indicateursInternes.tauxRetardDepotDossier = new TauxRetardDepotDossier();
                }
                if (this.fiche.indicateursInternes.tauxSatisfaction == null) {
                    this.fiche.indicateursInternes.tauxSatisfaction = new TauxSatisfaction();
                }
                this.fiche.indicateursInternes.tauxRemonteesReclamation.nbReclamation = this.fiche.reclamations.Count;
                gererDataSourceTextEdit();
            }
        }
        private void gererDataSourceTextEdit() {
            gererDataSourceTextEditDefaillanceCabinet();
            gererDataSourceTextEditDefaillanceRedressement();
            gererDataSourceTextEditNbDossier();
            gererDataSourceTextEditReduction();
            gererDataSourceTextEditRemonte();
            gererDataSourceTextEditRentable();
            gererDataSourceTextEditRetard();
            gererDataSourceTextEditSatisfaction();
            this.Refresh();
        }
        private void gererDataSourceTextEditRetard() {
            txtRetardNbDossierRetard.DataBindings.Clear();
            txtRetardNbDossierRetard.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxRetardDepotDossier, "nbDossierRetard", true);
            txtRetardNbDossierTotal.DataBindings.Clear();
            txtRetardNbDossierTotal.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxRetardDepotDossier, "nbDossier", true);
            txtRetardRatio.DataBindings.Clear();
            txtRetardRatio.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxRetardDepotDossier, "NbDossierRetardMoyen", true);
        }
        private void gererDataSourceTextEditDefaillanceCabinet() {
            txtDefaillanceCabinetNbDossiersTransmis.DataBindings.Clear();
            txtDefaillanceCabinetNbDossiersTransmisAvant.DataBindings.Clear();
            txtDefaillanceCabinetNbDossiersTransmisAvantAvant.DataBindings.Clear();
            txtDefaillanceCabinetPrejudice.DataBindings.Clear();
            txtDefaillanceCabinetPrejudiceAvant.DataBindings.Clear();
            txtDefaillanceCabinetPrejudiceAvantAvant.DataBindings.Clear();
            txtDefaillanceCabinetNbDossiersTransmis.DataBindings.Add("EditValue", this.fiche.indicateursInternes.defaillanceCabinet, "nbDossierTransmis", true);
            txtDefaillanceCabinetNbDossiersTransmisAvant.DataBindings.Add("EditValue", this.fiche.indicateursInternes.defaillanceCabinet, "nbDossierTransmisAvant", true);
            txtDefaillanceCabinetNbDossiersTransmisAvantAvant.DataBindings.Add("EditValue", this.fiche.indicateursInternes.defaillanceCabinet, "nbDossierTransmisAvantAvant", true);
            txtDefaillanceCabinetPrejudice.DataBindings.Add("EditValue", this.fiche.indicateursInternes.defaillanceCabinet, "montantPrejudice", true);
            txtDefaillanceCabinetPrejudiceAvant.DataBindings.Add("EditValue", this.fiche.indicateursInternes.defaillanceCabinet, "montantPrejudiceAvant", true);
            txtDefaillanceCabinetPrejudiceAvantAvant.DataBindings.Add("EditValue", this.fiche.indicateursInternes.defaillanceCabinet, "montantPrejudiceAvantAvant", true);
        }
        private void gererDataSourceTextEditDefaillanceRedressement() {
            txtDefaillanceNbDossiersRedressement.DataBindings.Clear();
            txtDefaillanceNbOuverture.DataBindings.Clear();
            txtDefaillanceRatio.DataBindings.Clear();
            txtDefaillanceNbDossiersRedressement.DataBindings.Add("EditValue", this.fiche.indicateursInternes.defaillanceControleFiscal, "nbDossierRedressement", true);
            txtDefaillanceNbOuverture.DataBindings.Add("EditValue", this.fiche.indicateursInternes.defaillanceControleFiscal, "nbDossierOuverture", true);
            txtDefaillanceRatio.DataBindings.Add("EditValue", this.fiche.indicateursInternes.defaillanceControleFiscal, "ratio", true);
        }
        private void gererDataSourceTextEditRentable() {
            txtRentableNbDossierTotal.DataBindings.Clear();
            txtDossierNonRentableRatio.DataBindings.Clear();
            txtRentableNbDossierInf.DataBindings.Clear();
            txtRentableNbDossierInfBudget.DataBindings.Clear();
            txtDossierNonRentableRatioBudget.DataBindings.Clear();
            txtDossierNonRentableRatio.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxDossiersNonRentables, "ratio", true);
            txtRentableNbDossierInf.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxDossiersNonRentables, "nbDossiersInf", true);
            txtDossierNonRentableRatioBudget.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxDossiersNonRentables, "ratioBudget", true);
            txtRentableNbDossierInfBudget.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxDossiersNonRentables, "nbDossiersInfBudget", true);
            txtRentableNbDossierTotal.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxDossiersNonRentables, "nbDossiers", true);
        }
        private void gererDataSourceTextEditNbDossier() {
            txtNbDossierMoyenne.DataBindings.Clear();
            txtNbDossierNbCollaborateur.DataBindings.Clear();
            txtNbDossierNbDossier.DataBindings.Clear();
            txtNbDossierMoyenne.DataBindings.Add("EditValue", this.fiche.indicateursInternes.nbDossierParCollaborateur, "moyenne", true);
            txtNbDossierNbCollaborateur.DataBindings.Add("EditValue", this.fiche.indicateursInternes.nbDossierParCollaborateur, "nbCollaborateurs", true);
            txtNbDossierNbDossier.DataBindings.Add("EditValue", this.fiche.indicateursInternes.nbDossierParCollaborateur, "nbDossier", true);
        }
        private void gererDataSourceTextEditReduction() {
            txtReducMoyen.DataBindings.Clear();
            txtReducNbDossierTotal.DataBindings.Clear();
            txtReducNbHeures.DataBindings.Clear();
            txtReducMoyen.DataBindings.Add("EditValue", this.fiche.indicateursInternes.reductionTempsProduction, "nbHeureMoyenneParDossier", true);
            txtReducNbDossierTotal.DataBindings.Add("EditValue", this.fiche.indicateursInternes.reductionTempsProduction, "nbDossier", true);
            txtReducNbHeures.DataBindings.Add("EditValue", this.fiche.indicateursInternes.reductionTempsProduction, "nbHeuresPayees", true);
        }
        private void gererDataSourceTextEditRemonte() {
            txtRemonteMoyen.DataBindings.Clear();
            txtRemonteNbDossierTotal.DataBindings.Clear();
            txtRemonteNbReclamations.DataBindings.Clear();
            txtRemonteMoyen.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxRemonteesReclamation, "nbReclaParDossier", true);
            txtRemonteNbDossierTotal.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxRemonteesReclamation, "nbDossier", true);
            txtRemonteNbReclamations.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxRemonteesReclamation, "nbReclamation", true);
        }
        private void gererDataSourceTextEditSatisfaction() {
            txtSatisfactionNbClientsSatisfait.DataBindings.Clear();
            txtSatisfactionNbClientsTotal.DataBindings.Clear();
            txtSatisfactionRatio.DataBindings.Clear();
            txtSatisfactionNbClientsSatisfait.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxSatisfaction, "nbClientsSatisfaits", true);
            txtSatisfactionNbClientsTotal.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxSatisfaction, "nbClientsTotal", true);
            txtSatisfactionRatio.DataBindings.Add("EditValue", this.fiche.indicateursInternes.tauxSatisfaction, "ratio", true);
        }

        private void txtRetardNbDossierTotal_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursInternes.nbDossierParCollaborateur.nbDossier = Convert.ToInt32(txtRetardNbDossierTotal.EditValue);
            this.fiche.indicateursInternes.tauxDossiersNonRentables.nbDossiers = Convert.ToInt32(txtRetardNbDossierTotal.EditValue);
            this.fiche.indicateursInternes.tauxRemonteesReclamation.nbDossier = Convert.ToInt32(txtRetardNbDossierTotal.EditValue);
            this.fiche.indicateursInternes.reductionTempsProduction.nbDossier = Convert.ToInt32(txtRetardNbDossierTotal.EditValue);
            this.fiche.indicateursInternes.tauxRetardDepotDossier.nbDossier = Convert.ToInt32(txtRetardNbDossierTotal.EditValue);
            txtNbDossierNbDossier.EditValue = Convert.ToInt32(txtRetardNbDossierTotal.EditValue);
            txtRemonteNbDossierTotal.EditValue = Convert.ToInt32(txtRetardNbDossierTotal.EditValue);
            txtRentableNbDossierTotal.EditValue = Convert.ToInt32(txtRetardNbDossierTotal.EditValue);
            txtReducNbDossierTotal.EditValue = Convert.ToInt32(txtRetardNbDossierTotal.EditValue);
            this.fiche = fiche;
        }
    }
}
