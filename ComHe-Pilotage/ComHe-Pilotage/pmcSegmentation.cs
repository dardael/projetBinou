using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComHe_Objets;
using ComHe_Metier;
using DevExpress.XtraCharts;
using System.Linq;
using System.ComponentModel;
using System.Data;

namespace ComHe_Pilotage {
    public partial class pmcSegmentation : UserControl {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        private FicheTravail ficheCourante;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        public FicheTravail fiche {
            set {
                ficheCourante = value;
                gererChangementFicheCourante();
            }
            get {
                return ficheCourante;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        public event EventHandler dataChanged;
        public pmcSegmentation() {
            InitializeComponent();
            grdSegmentation.DataSource = new List<Segment>();
            chSegmentation.DataSource = new List<Segment>();

        }
        private void gererChangementFicheCourante() {
            if (ficheCourante != null) {
                populateGridSegmentation();
                populateGridSegmentationMoyen();
                populateChSegmentationCLV();
            }
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
            ficheCourante.segments.Add(new Segment());
            gererChangementFicheCourante();
        }

        private void btGrSegmentationSuppr_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            Segment segmentCourant = (Segment)grdSegmentation.GetRecordObject(grdSegmentation.FocusedRecord);
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) {
                ficheCourante.segments.Remove(segmentCourant);
                gererChangementFicheCourante();
            }
            else {
                Segment segCopie = SegmentBO.clonerSegment(segmentCourant);
                segCopie.nom += "(Copie " + ficheCourante.segments.Where(x => x.nom != null && x.nom.StartsWith(segCopie.nom)).Count().ToString() + ")";
                ficheCourante.segments.Add(segCopie);
                gererChangementFicheCourante();
            }
        }

        private void chSegmentation_CustomDrawAxisLabel(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e) {
            AxisBase axis = e.Item.Axis;
            try {
                if (axis is AxisX) {
                    string value = (string)e.Item.AxisValue;
                    e.Item.Text = ficheCourante.segments.Where(fiche => fiche.id.ToString() == value).First().nom;
                }
            }
            catch {
                //gerer erreur 
            }
        }

        private void grdSegmentation_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e) {
            populateGridSegmentationMoyen();
            dataChanged(sender, e);
        }

        private void chSegmentation_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            foreach (CrosshairElementGroup element in e.CrosshairElementGroups) {
                foreach (CrosshairElement elt in element.CrosshairElements) {
                    SeriesPoint currentPoint = elt.SeriesPoint;
                    if (currentPoint.Tag.GetType() == typeof(Segment)) {
                        Segment rowView = (Segment)currentPoint.Tag;
                        string s = (elt.Series.Name == "CLV" ? "CLV: " + rowView.clv : "CLV Chiffre d'affaires: " + rowView.clvSansTxMarge);
                        elt.LabelElement.Text = s;
                        element.HeaderElement.Text = rowView.nom;
                    }
                }
            }
        }
    }
}
