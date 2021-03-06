﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComHe_Objets;
using ComHe_Metier;
using DevExpress.XtraCharts;
using System.Linq;
using System.ComponentModel;
using System.Data;

namespace ComHe_Pilotage {
    public partial class pmcSegmentation : pmcParentUtilisantFicheDeTravail {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public event EventHandler dataChanged;
        private bool isModeTableauDeBord;
        public pmcSegmentation() {
            InitializeComponent();
            grdSegmentation.DataSource = new List<Segment>();
            chSegmentation.DataSource = new List<Segment>();

        }
        protected override void gererChangementFicheCourante() {
            if (ficheCourante != null) {
                if (!isModeTableauDeBord) {
                    ficheCourante.segments.ForEach(x => x.modeExpert = this.chkModeExpert.Checked);
                }
                populateGridSegmentation();
                populateGridSegmentationMoyen();
                populateChSegmentationCLV();
            }
            labelConclusion();
        }
        private void populateGridSegmentation() {
            if (ficheCourante != null && ficheCourante.segments != null) {
                grdSegmentation.DataSource = new List<Segment>(ficheCourante.segments);
                grdSegmentation.Refresh();
            }
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
            Segment s = new Segment();
            s.modeExpert = chkModeExpert.Checked;
            ficheCourante.segments.Add(s);
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
                segCopie.modeExpert = chkModeExpert.Checked;
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
            labelConclusion();
            chSegmentation.Refresh();
        }

        private void labelConclusion() {
            string text = "Conclusion de l'analyse: ";
            if (fiche != null && fiche.segments != null && fiche.segments.Any(x => {
                return x.clv > 0;
            })) {
                Segment segmentCLVMax = fiche.segments.OrderByDescending(x => {
                    return x.clv;
                }).First();
                text += "Perdre définitivement " + segmentCLVMax.nom + " reviendrait non pas a perdre " + segmentCLVMax.caFromLM + "€ mais à perdre " + segmentCLVMax.clvSansTxMarge + "€. L'ensemble des collaborateurs devrait considérer que ce client vaut " + segmentCLVMax.clvSansTxMarge + "€ et non " + segmentCLVMax.caFromLM + "€. Par conséquent, les politiques d'expérience client doivent se concentrer sur " + segmentCLVMax.nom + " au détriment des autres";
            }
            lbConclusion.Text = text;
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

        private void chkModeExpert_CheckedChanged(object sender, EventArgs e) {
            this.rowAchatsCroises.Visible = this.chkModeExpert.Checked;
            this.rowAchatsCroisesMoyen.Visible = this.chkModeExpert.Checked;
            this.rowCaRecommandation.Visible = this.chkModeExpert.Checked;
            this.rowCaRecommandationMoyen.Visible = this.chkModeExpert.Checked;
            this.rowCASensibilitePricePremium.Visible = this.chkModeExpert.Checked;
            this.rowCaSensibilitePricePremiumMoyen.Visible = this.chkModeExpert.Checked;
            this.rowcoutAcquisition.Visible = this.chkModeExpert.Checked;
            this.rowcoutAcquisitionMoyen.Visible = this.chkModeExpert.Checked;
            this.rowTotal.Visible = this.chkModeExpert.Checked;
            this.rowTotalMoyen.Visible = this.chkModeExpert.Checked;
            ficheCourante.segments.ForEach(x => x.modeExpert = this.chkModeExpert.Checked);
            chSegmentation.Refresh();
            labelConclusion();
        }

        public void PassageModeTableauDebord() {
            lciBtAjouterSegment.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciChkModeExpert.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciGrMoyenneSegmentation.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciGrSegmentation.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            splitterItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            splitterItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            isModeTableauDeBord = true;
        }
    }
}
