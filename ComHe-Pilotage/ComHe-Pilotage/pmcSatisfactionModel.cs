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

namespace ComHe_Pilotage {
    public partial class pmcSatisfactionModel : pmcParentUtilisantFicheDeTravail {
        public pmcSatisfactionModel() {
            InitializeComponent();
        }
        protected override void gererChangementFicheCourante() {
            if (fiche != null) {
                populateTreeList();
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
            }
        }
        private void repoBtAjout_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            DimensionSatisfactionModel dimensionCourante = (DimensionSatisfactionModel)trSatisfactionModel.GetDataRecordByNode(trSatisfactionModel.FocusedNode);
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete && dimensionCourante.isSupprimable) {
                supprimerNode(dimensionCourante);
            }
            else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus) {
                DimensionSatisfactionModel dimEnfant = new DimensionSatisfactionModel(dimensionCourante.id, "Domaine" + ficheCourante.dimensionsSatisfactionModel.IndexOf(dimensionCourante) + (dimensionCourante.enfants.Count + 1), 0, true);
                ficheCourante.dimensionsSatisfactionModel.Add(dimEnfant);
                dimensionCourante.enfants.Add(dimEnfant);
            }
            gererChangementFicheCourante();
            trSatisfactionModel.FocusedNode.Expanded = true;
        }
        private void supprimerNode(DimensionSatisfactionModel dimension) {
            if (dimension.enfants.Count > 0) {
                dimension.enfants.ForEach(delegate (DimensionSatisfactionModel child) {
                    supprimerNode(child);
                });
            }
            ficheCourante.dimensionsSatisfactionModel.Remove(dimension);
        }
    }


}
