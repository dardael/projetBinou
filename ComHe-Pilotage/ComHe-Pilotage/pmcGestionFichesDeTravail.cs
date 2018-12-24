using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComHe_Objets;
using ComHe_Outils;

namespace ComHe_Pilotage {
    public partial class pmcGestionFichesDeTravail : UserControl {
        public List<FicheTravail> fichesTravail { get; set; }
        public FicheTravail ficheCourante {
            get;
            set;
        }
        private string fileName { get; } = "fichesDeTravail";
        private frmSaisieFicheTravail frmSaisieFicheTravail;
        public event EventHandler ficheTravailCouranteChanged;
        public pmcGestionFichesDeTravail() {
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
            InitializeComponent();
            populateCbFichesTravail();
        }
        private void populateCbFichesTravail() {
            cbChoixListeTravail.DataSource = new List<FicheTravail>(fichesTravail);
            cbChoixListeTravail.Refresh();
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
            this.ficheTravailCouranteChanged(sender, e);
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
