using ComHe_Objets;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;

namespace ComHe_Pilotage {
    public partial class frmPrincipale : XtraForm {
        public FicheTravail fiche { get; set; }
        public frmPrincipale() {
            InitializeComponent();
            grdSegmentation.DataSource = new List<Segment>();
            pmcGestionFichesDeTravail.ficheTravailCouranteChanged += new EventHandler(pmcGestionFichesDeTravail_ficheTravailCouranteChanged);
            pmcGestionFichesDeTravail.Load += pmcGestionFichesDeTravail_ficheTravailCouranteChanged;
        }
        private void gererChangementFicheCourante() {
            populateGridSegmentation();
            populateChSegmentationCLV();
        }
        private void pmcGestionFichesDeTravail_ficheTravailCouranteChanged(object sender, EventArgs e) {
            fiche = pmcGestionFichesDeTravail.ficheCourante;
            gererChangementFicheCourante();
        }
        private void populateGridSegmentation() {
            grdSegmentation.DataSource = new List<Segment>(fiche.segments);
            grdSegmentation.Refresh();
        }
        private void populateChSegmentationCLV() {
            chSegmentation.DataSource = new List<Segment>(fiche.segments);
            chSegmentation.Refresh();
        }
        private void btAjouterSegment_Click(object sender, EventArgs e) {
            ((List<Segment>)grdSegmentation.DataSource).Add(new Segment());
            grdSegmentation.RefreshDataSource();
        }


    }
}
