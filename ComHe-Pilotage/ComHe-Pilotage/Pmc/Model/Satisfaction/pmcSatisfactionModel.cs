using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using ComHe_Objets;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraCharts;

namespace ComHe_Pilotage {
    public partial class pmcSatisfactionModel : pmcParentUtilisantFicheDeTravail {
        public pmcSatisfactionModel() {
            InitializeComponent();
        }
        protected override void gererChangementFicheCourante() {
            if (fiche != null) {
                if (fiche.dimensionsSatisfactionModel == null || fiche.dimensionsSatisfactionModel.Count() == 0) {
                    fiche.dimensionsSatisfactionModel = new List<DimensionSatisfactionModel>();
                    fiche.dimensionsSatisfactionModel.Add(new DimensionSatisfactionModel(Guid.Empty, "Satisfaction Globale", 1, false, 1, 0));

                }
                populateTreeList();
                populateChSatisfaction();
            }
        }
        private void populateTreeList() {
            trSatisfactionModel.RootValue = ficheCourante.dimensionsSatisfactionModel.Where(delegate (DimensionSatisfactionModel dim) {
                return !dim.isSupprimable;
            }).FirstOrDefault().parent;
            trSatisfactionModel.BeginUpdate();
            try {
                trSatisfactionModel.DataSource = ficheCourante.dimensionsSatisfactionModel;
            }
            finally {
                trSatisfactionModel.EndUpdate();
                trSatisfactionModel.RefreshDataSource();
                trSatisfactionModel.ExpandAll();
            }
        }
        private void populateChSatisfaction() {
            chSatisfactionModel.DataSource = new List<DimensionSatisfactionModel>(ficheCourante.dimensionsSatisfactionModel.Where(delegate (DimensionSatisfactionModel dim) { return dim.lvl == 1; }));
            chSatisfactionModel.Refresh();
        }
        private void repoBtAjout_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            DimensionSatisfactionModel dimensionCourante = (DimensionSatisfactionModel)trSatisfactionModel.GetDataRecordByNode(trSatisfactionModel.FocusedNode);
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete && dimensionCourante.isSupprimable) {
                supprimerNode(dimensionCourante);
            }
            else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus) {
                int nbEnfant = fiche.dimensionsSatisfactionModel.Where(delegate (DimensionSatisfactionModel dim) { return dim.parent.Equals(dimensionCourante.id); }).Count();
                DimensionSatisfactionModel dimEnfant = new DimensionSatisfactionModel(dimensionCourante.id, "Domaine" + ficheCourante.dimensionsSatisfactionModel.IndexOf(dimensionCourante) + (nbEnfant + 1), 1 - fiche.dimensionsSatisfactionModel.Where(delegate (DimensionSatisfactionModel dim) { return dim.parent.Equals(dimensionCourante.id); }).Sum(delegate (DimensionSatisfactionModel dim) { return dim.poids; }), true, 1 - fiche.dimensionsSatisfactionModel.Where(delegate (DimensionSatisfactionModel dim) { return dim.parent.Equals(dimensionCourante.id); }).Sum(delegate (DimensionSatisfactionModel dim) { return dim.satisfaction; }), dimensionCourante.lvl + 1);
                ficheCourante.dimensionsSatisfactionModel.Add(dimEnfant);
            }
            gererChangementFicheCourante();
            trSatisfactionModel.FocusedNode.Expanded = true;
        }
        private void supprimerNode(DimensionSatisfactionModel dimension) {
            List<DimensionSatisfactionModel> enfants = fiche.dimensionsSatisfactionModel.Where(delegate (DimensionSatisfactionModel dim) { return dim.parent.Equals(dimension.id); }).ToList();
            if (enfants.Count() > 0) {
                enfants.ForEach(delegate (DimensionSatisfactionModel child) {
                    supprimerNode(child);
                });
            }
            ficheCourante.dimensionsSatisfactionModel.Remove(dimension);
        }
        private void chSatisfaction_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            foreach (CrosshairElementGroup element in e.CrosshairElementGroups) {
                foreach (CrosshairElement elt in element.CrosshairElements) {
                    SeriesPoint currentPoint = elt.SeriesPoint;
                    if (currentPoint.Tag.GetType() == typeof(Segment)) {
                        DimensionSatisfactionModel rowView = (DimensionSatisfactionModel)currentPoint.Tag;
                        string s = "Poids: " + rowView.poids + "    Satisfaction: " + rowView.satisfaction;
                        elt.LabelElement.Text = s;
                        element.HeaderElement.Text = rowView.nom;
                    }
                }
            }
        }

        private void chSatisfactionModel_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = ((DimensionSatisfactionModel)e.SeriesPoint.Tag).nom;
        }

    }
}
