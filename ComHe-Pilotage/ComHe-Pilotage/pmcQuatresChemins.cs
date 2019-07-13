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

namespace ComHe_Pilotage {
    public partial class pmcQuatresChemins : pmcParentUtilisantFicheDeTravail {
        public pmcQuatresChemins() {
            InitializeComponent();
            grQuatresChemins.DataSource = new List<Segment>();
        }
        protected override void gererChangementFicheCourante() {
            if (fiche != null) {
                populateGridQuatresChemins();
            }
        }
        private void populateGridQuatresChemins() {
            grQuatresChemins.DataSource = new List<Segment>(ficheCourante.segments);
            grQuatresChemins.Refresh();
        }

        private void grQuatresChemins_CustomDrawRowValueCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e) {
            try {
                if ((int)e.CellValue < 7) {
                    e.Appearance.BackColor = Color.Red;
                }
                else if ((int)e.CellValue < 9) {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else {
                    e.Appearance.BackColor = Color.Green;
                }
            }
            catch {

            }
        }
    }
}
