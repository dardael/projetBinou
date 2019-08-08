using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComHe_Objets.Reclamations;

namespace ComHe_Pilotage.Pmc.Reclamation {
    public partial class pmcIncidenceService : pmcParentUtilisantFicheDeTravail {
        public pmcIncidenceService() {
            InitializeComponent();
        }
        protected override void gererChangementFicheCourante() {
            if (ficheCourante != null && ficheCourante.reclamations != null) {
                populateGridIncidence();
                populateChIncidence();
            }
        }
        private void populateGridIncidence() {
            if (ficheCourante != null) {
                gcIncidenceParService.DataSource = new List<ReclamationParService>(ficheCourante.reclamationsParServices);
                gcIncidenceParService.Refresh();
            }
        }
        private void populateChIncidence() {
            chIncidenceParService.DataSource = new List<ReclamationParService>(ficheCourante.reclamationsParServices);
            chIncidenceParService.Series[0].DataSource = new List<ReclamationParService>(ficheCourante.reclamationsParServices);
            chIncidenceParService.Refresh();
        }

        private void chIncidenceParService_CustomDrawSeriesPoint(object sender, DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs e) {
            e.LegendText = e.SeriesPoint.Argument;
        }
    }
}
