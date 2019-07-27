using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComHe_Objets;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ComHe_Pilotage {
    public partial class pmcGestionReclamation : pmcParentUtilisantFicheDeTravail {
        public pmcGestionReclamation() {
            InitializeComponent();
        }
        protected override void gererChangementFicheCourante() {
            populateGrid();
            populateChart();
        }
        private void populateGrid() {
            grReclamation.BeginUpdate();
            try {
                grReclamation.DataSource = ficheCourante.reclamations;
            }
            finally {
                grReclamation.EndUpdate();
            }
        }
        private void populateChart() {
            chReclamations.DataSource = new List<Reclamation>(ficheCourante.reclamations);
            chReclamations.Refresh();
        }
        private void btAjouterReclamation_Click(object sender, EventArgs e) {
            fiche.reclamations.Add(new Reclamation());
            gererChangementFicheCourante();
        }

        private void repoBtSupprimer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            Reclamation reclamationCourante = (Reclamation)gvReclamations.GetRow(gvReclamations.FocusedRowHandle);
            ficheCourante.reclamations.Remove(reclamationCourante);
            gererChangementFicheCourante();
        }

        private void gvReclamations_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            if (e.Column.Name == colactionCorrective.Name) {
                GridViewInfo viewInfo = gvReclamations.GetViewInfo() as GridViewInfo;
                GridCellInfo cellInfo = viewInfo.GetGridCellInfo(e.RowHandle, e.Column);
                cellInfo.Appearance.BeginUpdate();
                if ((String)e.Value == "AVOIR") {
                    cellInfo.Appearance.BackColor = Color.White;
                    cellInfo.Appearance.BackColor2 = Color.White;
                }
                else {
                    cellInfo.Appearance.BackColor = Color.Gray;
                    cellInfo.Appearance.BackColor2 = Color.Gray;

                }
                cellInfo.Appearance.EndUpdate();
            }
        }

        /// <summary>
        /// On Passe tous en read only, on affiche la colonne année , on groupe par collaborateur
        /// </summary>
        public void switchToVisualisation() {
            btAjouterReclamation.Hide();
            lciBtAjouterReclamation.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciEmptySpaceDroiteBtAjouterReclamation.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            colannee.Visible = true;
            colactions.Visible = false;
            colclient.OptionsColumn.ReadOnly = true;
            colcollaborateur.OptionsColumn.ReadOnly = true;
            coldateLitige.OptionsColumn.ReadOnly = true;
            colactionCorrective.OptionsColumn.ReadOnly = true;
            colmontantIndemnite.OptionsColumn.ReadOnly = true;
            colmotifInsatisfaction.OptionsColumn.ReadOnly = true;
            colmotifLegitime.OptionsColumn.ReadOnly = true;
            colnumeroClient.OptionsColumn.ReadOnly = true;
            colservice.OptionsColumn.ReadOnly = true;
            colverbatimClient.OptionsColumn.ReadOnly = true;
            this.gvReclamations.GroupCount = 1;
            this.gvReclamations.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colcollaborateur, DevExpress.Data.ColumnSortOrder.Ascending)});
            grReclamation.Refresh();
        }
    }
}
