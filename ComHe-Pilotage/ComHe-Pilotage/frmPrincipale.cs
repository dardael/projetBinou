using ComHe_Objets;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ComHe_Pilotage {
    public partial class frmPrincipale : XtraForm {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        public FicheTravail fiche { get; set; }
        public frmPrincipale() {
            InitializeComponent();
            pmcGestionFichesDeTravail.ficheTravailCouranteChanged += new EventHandler(pmcGestionFichesDeTravail_ficheTravailCouranteChanged);
            pmcGestionFichesDeTravail.Load += pmcGestionFichesDeTravail_ficheTravailCouranteChanged;
        }

        private void pmcGestionFichesDeTravail_ficheTravailCouranteChanged(object sender, EventArgs e) {
            fiche = pmcGestionFichesDeTravail.ficheCourante;
            pmcSegmentation1.fiche = fiche;
        }



    }
}
