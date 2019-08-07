using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComHe_Objets.Indicateurs.Client;
using ComHe_Objets;

namespace ComHe_Pilotage.Pmc.Indicateurs.Clients {
    public partial class pmcIndicateursClients : pmcParentUtilisantFicheDeTravail {
        public pmcIndicateursClients() {
            InitializeComponent();
        }
        protected override void gererChangementFicheCourante() {
            if (this.fiche != null) {
                if (this.fiche.indicateursClient == null) {
                    this.fiche.indicateursClient = new IndicateursClient();
                }
                if (this.fiche.indicateursClient.tauxClientsInsatisfaits == null) {
                    this.fiche.indicateursClient.tauxClientsInsatisfaits = new TauxClientsInsatisfaits();
                }
                if (this.fiche.indicateursClient.tauxDeRecommandation == null) {
                    this.fiche.indicateursClient.tauxDeRecommandation = new TauxDeRecommandation();
                }
                if (this.fiche.indicateursClient.tauxDeRetentionClient == null) {
                    this.fiche.indicateursClient.tauxDeRetentionClient = new TauxDeRetentionClient();
                }
                this.fiche.indicateursClient.nbReclamations = fiche.reclamations != null ? fiche.reclamations.Count : 0;
                this.fiche.indicateursClient.montantIndemnitesFinancieres = fiche.reclamations != null ? fiche.reclamations.Sum(delegate (Reclamation x) { return x.montantIndemnite; }) : 0;
                this.fiche.indicateursClient.tauxClientsInsatisfaits.nbClientsInsatisfaits = fiche.loyaltyModel.Sum(delegate (ItemLoyaltyModel x) {
                    return x != null && x.noteSatisfaction < 8 ? x.nbPersonnes : 0;
                });
                this.fiche.indicateursClient.tauxClientsInsatisfaits.nbClientsTotal = fiche.loyaltyModel.Sum(delegate (ItemLoyaltyModel x) {
                    return x != null ? x.nbPersonnes : 0;
                });
                gererDataSourceTextEdit();
            }
        }
        private void gererDataSourceTextEdit() {
            gererDataSourceTextEditCoutsGestion();
            gererDataSourceTextEditNbDossiersOuverts();
            gererDataSourceTextEditTauxClientsInsatisfaits();
            gererDataSourceTextEditTauxRetentionClient();
            gererDataSourceTextEditTxRecommandation();
            this.Refresh();
        }
        private void gererDataSourceTextEditTxRecommandation() {
            txtNbRecommandation.DataBindings.Clear();
            txtNbProspect.DataBindings.Clear();
            txtRatioRecommandation.DataBindings.Clear();
            txtNbRecommandation.DataBindings.Add("EditValue", this.fiche.indicateursClient.tauxDeRecommandation, "nbRecommandations", true);
            txtNbProspect.DataBindings.Add("EditValue", this.fiche.indicateursClient.tauxDeRecommandation, "nbProspect", true);
            txtRatioRecommandation.DataBindings.Add("EditValue", this.fiche.indicateursClient.tauxDeRecommandation, "ratio", true);
        }
        private void gererDataSourceTextEditTauxRetentionClient() {
            txtNbClientFinPeriode.DataBindings.Clear();
            txtNbNvxClients.DataBindings.Clear();
            txtVariationRetentionClient.DataBindings.Clear();
            txtNbClientFinPeriode.DataBindings.Add("EditValue", this.fiche.indicateursClient.tauxDeRetentionClient, "nbClientsFinPeriode", true);
            txtNbNvxClients.DataBindings.Add("EditValue", this.fiche.indicateursClient.tauxDeRetentionClient, "nbNvxClients", true);
            txtVariationRetentionClient.DataBindings.Add("EditValue", this.fiche.indicateursClient.tauxDeRetentionClient, "variation", true);
        }
        private void gererDataSourceTextEditCoutsGestion() {
            txtMontantIndemnitesFinancieres.DataBindings.Clear();
            txtMontantIndemnitesFinancieres.DataBindings.Add("EditValue", this.fiche.indicateursClient, "montantIndemnitesFinancieres", true);
        }
        private void gererDataSourceTextEditNbDossiersOuverts() {
            txtNbReclamations.DataBindings.Clear();
            txtNbReclamations.DataBindings.Add("EditValue", this.fiche.indicateursClient, "nbReclamations", true);
        }
        private void gererDataSourceTextEditTauxClientsInsatisfaits() {
            txtNbClientsInsatisfaits.DataBindings.Clear();
            txtNbClientsTotal.DataBindings.Clear();
            txtRatioClientsInsatisfaits.DataBindings.Clear();
            txtNbClientsInsatisfaits.DataBindings.Add("EditValue", this.fiche.indicateursClient.tauxClientsInsatisfaits, "nbClientsInsatisfaits", true);
            txtNbClientsTotal.DataBindings.Add("EditValue", this.fiche.indicateursClient.tauxClientsInsatisfaits, "nbClientsTotal", true);
            txtRatioClientsInsatisfaits.DataBindings.Add("EditValue", this.fiche.indicateursClient.tauxClientsInsatisfaits, "ratio", true);
        }
    }
}
