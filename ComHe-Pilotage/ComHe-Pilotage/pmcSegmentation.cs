using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComHe_Objets;
using ComHe_Outils;
using ComHe_Metier;
using DevExpress.XtraCharts;
using System.Linq;

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
            populateGridSegmentationMoyen();
            populateChSegmentationCLV();
        }
        private void populateGridSegmentation() {
            grdSegmentation.DataSource = new List<Segment>(ficheCourante.segments);
            grdSegmentation.Refresh();
        }
        private void populateGridSegmentationMoyen() {
            grdSegmentationMoyen.DataSource = new List<Segment>(new List<Segment> { SegmentBO.returnSegmentMoyen(ficheCourante.segments) });
            grdSegmentationMoyen.Refresh();
        }
        private void populateChSegmentationCLV() {
            chSegmentation.DataSource = new List<Segment>(ficheCourante.segments);
            chSegmentation.Refresh();
        }
        private void btAjouterSegment_Click(object sender, EventArgs e) {
            ((List<Segment>)grdSegmentation.DataSource).Add(new Segment());
            grdSegmentation.RefreshDataSource();
        }

        private void btGrSegmentationSuppr_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            Segment segmentCourant = (Segment)grdSegmentation.GetRecordObject(grdSegmentation.FocusedRecord);
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) {
                ficheCourante.segments.Remove(segmentCourant);
                gererChangementFicheCourante();
            }
            else {
                Segment segCopie = SegmentBO.clonerSegment(segmentCourant);
                segCopie.nom += "(Copie " + ficheCourante.segments.Where(x => x.nom.StartsWith(segCopie.nom)).Count().ToString() + ")";
                ficheCourante.segments.Add(segCopie);
                gererChangementFicheCourante();
            }
        }

        private void chSegmentation_CustomDrawAxisLabel(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e) {
            AxisBase axis = e.Item.Axis;
            if (axis is AxisX) {
                string value = (string)e.Item.AxisValue;
                e.Item.Text = ficheCourante.segments.Where(fiche => fiche.id.ToString() == value).First().nom;
            }
        }
    }
}
