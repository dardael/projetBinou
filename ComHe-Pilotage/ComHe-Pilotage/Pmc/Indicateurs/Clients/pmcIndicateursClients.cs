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
using DevExpress.XtraCharts;

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
                this.fiche.indicateursClient.montantIndemnitesFinancieres = fiche.reclamations != null ? fiche.reclamations.Sum(delegate (ComHe_Objets.Reclamations.Reclamation x) { return x.montantIndemnite; }) : 0;
                this.fiche.indicateursClient.tauxClientsInsatisfaits.nbClientsInsatisfaits = fiche.loyaltyModel.Sum(delegate (ItemLoyaltyModel x) {
                    return x != null && x.noteSatisfaction < 8 ? x.nbPersonnes : 0;
                });
                this.fiche.indicateursClient.tauxClientsInsatisfaits.nbClientsTotal = fiche.loyaltyModel.Sum(delegate (ItemLoyaltyModel x) {
                    return x != null ? x.nbPersonnes : 0;
                });
                gererDataSourceTextEdit();
                populateInsatisfactionChart();
                populateRecommandationChart();
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
        private void populateInsatisfactionChart() {
            chInsatisfaits.Series.Clear();
            Series s = new Series("Insatisfaction", ViewType.Pie);
            s.Points.Add(new SeriesPoint("Clients insatisfaits", this.fiche.indicateursClient.tauxClientsInsatisfaits.nbClientsInsatisfaits));
            s.Points.Add(new SeriesPoint("Autres clients", this.fiche.indicateursClient.tauxClientsInsatisfaits.nbClientsTotal - this.fiche.indicateursClient.tauxClientsInsatisfaits.nbClientsInsatisfaits));
            chInsatisfaits.Series.Add(s);
        }
        private void populateRecommandationChart() {
            chRecommandation.Series.Clear();
            Series s = new Series("Recommandation", ViewType.Pie);
            s.Points.Add(new SeriesPoint("Prospects venues par la recommandation", this.fiche.indicateursClient.tauxDeRecommandation.nbRecommandations));
            s.Points.Add(new SeriesPoint("Autres prospects", this.fiche.indicateursClient.tauxDeRecommandation.nbProspect - this.fiche.indicateursClient.tauxDeRecommandation.nbRecommandations));
            chRecommandation.Series.Add(s);
        }
        private void chRecommandation_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = e.SeriesPoint.Argument;
        }
        private void chInsatisfaits_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = e.SeriesPoint.Argument;
        }

        private void txtNbRecommandation_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursClient.tauxDeRecommandation.nbRecommandations = Convert.ToInt32(txtNbRecommandation.EditValue);
            populateRecommandationChart();
        }

        private void txtNbProspect_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursClient.tauxDeRecommandation.nbProspect = Convert.ToInt32(txtNbProspect.EditValue);
            populateRecommandationChart();
        }

        private void txtNbClientsInsatisfaits_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursClient.tauxClientsInsatisfaits.nbClientsInsatisfaits = Convert.ToInt32(txtNbClientsInsatisfaits.EditValue);
            populateInsatisfactionChart();
        }

        private void txtNbClientsTotal_EditValueChanged(object sender, EventArgs e) {
            this.fiche.indicateursClient.tauxClientsInsatisfaits.nbClientsTotal = Convert.ToInt32(txtNbClientsTotal.EditValue);
            populateInsatisfactionChart();

        }
    }
}
