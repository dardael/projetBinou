using ComHe_Objets;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ComHe_Pilotage {
    public partial class frmPrincipale : XtraForm {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public FicheTravail fiche { get; set; }
        public frmPrincipale() {
            InitializeComponent();
            pmcNPS.adapaterAffichage("NPS", "Si un proche avait besoin d'un professionnel de l'expertise comptable, lui recommanderiez vous votre cabinet ?", fiche);
            pmcCES.adapaterAffichage("CES", "A combien évaluez vous l'effort que vous avez fourni pour disposer de vos comptes annuels ?", fiche);
            pmcGestionFichesDeTravail.ficheTravailCouranteChanged += new EventHandler(pmcGestionFichesDeTravail_ficheTravailCouranteChanged);
            pmcSegmentation1.dataChanged += new EventHandler(pmcSegmentation_dataChanged);
            pmcGestionFichesDeTravail.Load += pmcGestionFichesDeTravail_ficheTravailCouranteChanged;
            pmcIndicateursFinanciers1.dataChanged += new EventHandler(IndicateursFinanciers_dataChanged);
            this.Refresh();
            pmcTraitementReclamationClient1.switchToVisualisation();
        }

        private void pmcGestionFichesDeTravail_ficheTravailCouranteChanged(object sender, EventArgs e) {
            fiche = pmcGestionFichesDeTravail.ficheCourante;
            if (fiche != null) {
                propagerFiche(fiche);
            }
        }
        private void pmcSegmentation_dataChanged(object sender, EventArgs e) {
            propagerFiche(pmcSegmentation1.fiche);

        }
        private void IndicateursFinanciers_dataChanged(object sender, EventArgs e) {
            pmcTableauDeBord1.fiche = fiche;
        }
        private void propagerFiche(FicheTravail fiche) {
            pmcSegmentation1.fiche = fiche;
            pmcQuatresChemins1.fiche = fiche;
            pmcNPS.fiche = fiche;
            pmcCES.fiche = fiche;
            pmcGestionReclamation1.fiche = fiche;
            pmcApprentissage1.fiche = fiche;
            pmcAttributsDeSatisfaction1.fiche = fiche;
            pmcSatisfactionModel1.fiche = fiche;
            pmcTraitementReclamationClient1.fiche = fiche;
            pmcLoyatyModel1.fiche = fiche;
            pmcComplaintModel1.fiche = fiche;
            pmcIndicateursFinanciers1.fiche = fiche;
            pmcIndicateursClients1.fiche = fiche;
            pmcIndicateursInternes1.fiche = fiche;
            pmcIndicateursApprentissage1.fiche = fiche;
            pmcTableauDeBord1.fiche = fiche;
            pmcIncidenceService1.fiche = fiche;
            fiche.initialiserToutesQuestions();
            pmcEnsemblePrestation.questionNotee = fiche.ensemblePrestation;
            pmcQualitePrestation.questionNotee = fiche.qualitePrestation;
            pmcHonoraires.questionNotee = fiche.montantHonoraires;
            pmcMesureEngagmentClient.questionNotee = fiche.engagementClient;
            pmcMesureEcouteClient.questionNotee = fiche.mesureEcoute;
            pmcMesureSelling.questionNotee = fiche.mesureSelling;
            pmcMesureQualite.questionNotee = fiche.mesureQualite;
        }

        private void tabPgIncidenceParService_Enter(object sender, EventArgs e) {
            pmcIncidenceService1.fiche = this.fiche;
        }
    }
}
