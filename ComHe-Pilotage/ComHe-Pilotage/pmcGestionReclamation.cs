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
    public partial class pmcGestionReclamation : UserControl {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private FicheTravail ficheCourante;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public FicheTravail fiche {
            set {
                ficheCourante = value;
                gererChangementFicheCourante();
            }
            get {
                return ficheCourante;
            }
        }
        public pmcGestionReclamation() {
            InitializeComponent();
        }
        private void gererChangementFicheCourante() {
            populateGrid();
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
    }
}
