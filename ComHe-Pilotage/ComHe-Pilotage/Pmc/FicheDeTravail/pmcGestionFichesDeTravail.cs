using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComHe_Objets;
using ComHe_Outils;
using System.ComponentModel;
using ComHe_Metier;

namespace ComHe_Pilotage {
    public partial class pmcGestionFichesDeTravail : UserControl {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public List<FicheTravail> fichesTravail {
            get;
            set;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public FicheTravail ficheCourante {
            get;
            set;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        private string fileName { get; } = "fichesDeTravailData";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        private frmSaisieFicheTravail frmSaisieFicheTravail;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public event EventHandler ficheTravailCouranteChanged;
        public pmcGestionFichesDeTravail() {
            InitializeComponent();
            fichesTravail = (List<FicheTravail>)GestionFichierXML.LoadFromXML(new List<FicheTravail>().GetType(), fileName);
            if (fichesTravail == null || fichesTravail.Count == 0) {
                fichesTravail = new List<FicheTravail>();
                if (ficheCourante == null) {
                    ficheCourante = new FicheTravail("Nouvelle fiche de travail", new List<Segment>(), new List<Reclamation>(), new List<FormationCollaborateur>(), new List<AttributDeSatisfaction>(), new List<DimensionSatisfactionModel>(), LoyaltyModelBO.getLoyaltyModel(), ComplaintModelBO.getTreeComplaintModel());
                }
                fichesTravail.Add(ficheCourante);
            }
            else {
                ficheCourante = fichesTravail[0];
            }
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
                ficheTravailFonction = new FicheTravail("Fiche de travail", new List<Segment>(), new List<Reclamation>(), new List<FormationCollaborateur>(), new List<AttributDeSatisfaction>(), new List<DimensionSatisfactionModel>(), LoyaltyModelBO.getLoyaltyModel(), ComplaintModelBO.getTreeComplaintModel());
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
                    alertControl1.Show(this.ParentForm, "Nouvelle fiche de travail créée", "La fiche de travail " + ficheCourante.nom + " a été correctement créée");
                }
                else {
                    populateCbFichesTravail();
                    alertControl1.Show(this.ParentForm, "Fiche de travail renommée", "La fiche de travail " + ficheCourante.nom + " a été correctement renommée");
                }
                cbChoixListeTravail.SelectedItem = frmSaisieFicheTravail.ficheTravail;

            }
        }

        private void btRenommerFicheTravail_Click(object sender, EventArgs e) {
            callFrmNewFicheDeTravail(ficheCourante);
        }

        private void btSaveFicheTravail_Click(object sender, EventArgs e) {
            GestionFichierXML.SaveToXml(this.fichesTravail, fichesTravail.GetType(), fileName);
            alertControl1.Show(this.ParentForm, "Fichier sauvergardé", "Le fichier est correctement sauvegardé");
        }

        private void cbChoixListeTravail_SelectedIndexChanged(object sender, EventArgs e) {
            ficheCourante = (FicheTravail)cbChoixListeTravail.SelectedItem;
            this.ficheTravailCouranteChanged(sender, e);
            alertControl1.Show(this.ParentForm, "Nouvelle fiche de travail chargée", "La fiche de travail " + ficheCourante.nom + " a été correctement chargée");
        }

        private void btDupliquerFicheTravail_Click(object sender, EventArgs e) {
            FicheTravail ficheTemp = Cloneur.Clone(ficheCourante);
            ficheTemp.nom = ficheTemp.nom + "-copie";
            ficheTemp.generateNewGuid();
            fichesTravail.Add(ficheTemp);
            populateCbFichesTravail();
            cbChoixListeTravail.SelectedItem = ficheTemp;
            ficheCourante = ficheTemp;
            alertControl1.Show(this.ParentForm, "Nouvelle fiche de travail créée", "La fiche de travail " + ficheCourante.nom + " a été correctement dupliquée");
        }

        private void btSupprimerFicheTravail_Click(object sender, EventArgs e) {
            if (ficheCourante != null) {
                fichesTravail.Remove(ficheCourante);
                populateCbFichesTravail();
            }
        }

        private void cbChoixListeTravail_SelectedIndexChanged_1(object sender, EventArgs e) {
            ficheCourante = (FicheTravail)cbChoixListeTravail.SelectedItem;
            ficheTravailCouranteChanged(sender, e);
        }
    }
}
