using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComHe_Objets;

namespace ComHe_Pilotage {
    public partial class pmcSegmentation : UserControl {
        private FicheTravail ficheCourante;
        public FicheTravail fiche {
            set {
                ficheCourante = value;
                gererChangementFicheCourante();
            }
            get {
                return ficheCourante;
            }
        }
        public pmcSegmentation() {
            InitializeComponent();
            grdSegmentation.DataSource = new List<Segment>();
            chSegmentation.DataSource = new List<Segment>();

        }
        private void gererChangementFicheCourante() {
            populateGridSegmentation();
            populateChSegmentationCLV();
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
    }
}
