using ComHe_Objets;
using ComHe_Outils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComHe_Pilotage {
    public partial class frmPrincipale : XtraForm {
        public List<FicheTravail> fichesTravail { get; set; }
        public FicheTravail ficheCourante { get; set; }
        private string fileName { get; } = "fichesDeTravail";
        private frmSaisieFicheTravail frmSaisieFicheTravail;
        public frmPrincipale() {
            InitializeComponent();
            grdSegmentation.DataSource = new List<Segment>();
            fichesTravail = (List<FicheTravail>)GestionFichierXML.LoadFromXML(new List<FicheTravail>().GetType(), fileName);
            if (fichesTravail == null || fichesTravail.Count == 0) {
                fichesTravail = new List<FicheTravail>();
                if (ficheCourante == null) {
                    ficheCourante = new FicheTravail("Nouvelle fiche de travail", new List<Segment>());
                }
                fichesTravail.Add(ficheCourante);
            }
            else {
                ficheCourante = fichesTravail[0];
            }
            populateCbFichesTravail();
            gererChangementFicheCourante();
        }
        private void gererChangementFicheCourante() {
            populateGridSegmentation();
            populateChSegmentationCLV();
        }
        private void populateCbFichesTravail() {
            cbChoixListeTravail.DataSource = new List<FicheTravail>(fichesTravail);
            cbChoixListeTravail.Refresh();
        }
        private void populateGridSegmentation() {
            grdSegmentation.DataSource = new List<Segment>(ficheCourante.segments);
            grdSegmentation.Refresh();
        }
        private void populateChSegmentationCLV() {
            chSegmentation.DataSource = new List<Segment>(ficheCourante.segments);
            chSegmentation.Refresh();
        }
        private void btAjouterSegment_Click(object sender, EventArgs e) {
            ((List<Segment>)grdSegmentation.DataSource).Add(new Segment());
            grdSegmentation.RefreshDataSource();
        }

        private void btNouveauFicheDeTravail_Click(object sender, EventArgs e) {
            callFrmNewFicheDeTravail(null);
        }
        public void callFrmNewFicheDeTravail(FicheTravail ficheTravail) {
            FicheTravail ficheTravailFonction;
            if (ficheTravail != null) {
                ficheTravailFonction = ficheTravail;
            }
            else {
                ficheTravailFonction = new FicheTravail("Fiche de travail", new List<Segment>());
            }
            frmSaisieFicheTravail = new frmSaisieFicheTravail(ficheTravailFonction, ficheTravail == null);
            frmSaisieFicheTravail.FormClosing += frmSaisieFicheTravail_FormClosing;
            frmSaisieFicheTravail.ShowDialog();
        }
        private void frmSaisieFicheTravail_FormClosing(object sender, FormClosingEventArgs e) {
            gererFermetureModificationFicheTravail((frmSaisieFicheTravail)sender);
        }
        private void gererFermetureModificationFicheTravail(frmSaisieFicheTravail frmSaisieFicheTravail) {
            if (frmSaisieFicheTravail.isAjoutOk) {
                ficheCourante = frmSaisieFicheTravail.ficheTravail;
                if (frmSaisieFicheTravail.isNew) {
                    fichesTravail.Add(ficheCourante);
                    populateCbFichesTravail();
                    cbChoixListeTravail.SelectedItem = frmSaisieFicheTravail.ficheTravail;
                }
                else {
                    populateCbFichesTravail();
                }

            }
        }

        private void btRenommerFicheTravail_Click(object sender, EventArgs e) {
            callFrmNewFicheDeTravail(ficheCourante);
        }

        private void btSaveFicheTravail_Click(object sender, EventArgs e) {
            GestionFichierXML.SaveToXml(this.fichesTravail, fichesTravail.GetType(), fileName);
        }

        private void cbChoixListeTravail_SelectedIndexChanged(object sender, EventArgs e) {
            ficheCourante = (FicheTravail)cbChoixListeTravail.SelectedItem;
            gererChangementFicheCourante();
        }

        private void btDupliquerFicheTravail_Click(object sender, EventArgs e) {
            FicheTravail ficheTemp = Cloneur.Clone(ficheCourante);
            ficheTemp.nom = ficheTemp.nom + "-copie";
            fichesTravail.Add(ficheTemp);
            populateCbFichesTravail();
            cbChoixListeTravail.SelectedItem = ficheTemp;
        }

        private void btSupprimerFicheTravail_Click(object sender, EventArgs e) {
            if (ficheCourante != null) {
                fichesTravail.Remove(ficheCourante);
                populateCbFichesTravail();
            }
        }
    }
}
