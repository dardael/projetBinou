using ComHe_Objets;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;

namespace ComHe_Pilotage {
    public partial class frmPrincipale : XtraForm {
        public FicheTravail fiche { get; set; }
        public frmPrincipale() {
            InitializeComponent();
            pmcGestionFichesDeTravail.ficheTravailCouranteChanged += new EventHandler(pmcGestionFichesDeTravail_ficheTravailCouranteChanged);
            pmcGestionFichesDeTravail.Load += pmcGestionFichesDeTravail_ficheTravailCouranteChanged;
        }

        private void pmcGestionFichesDeTravail_ficheTravailCouranteChanged(object sender, EventArgs e) {
            fiche = pmcGestionFichesDeTravail.ficheCourante;
        }



    }
}
