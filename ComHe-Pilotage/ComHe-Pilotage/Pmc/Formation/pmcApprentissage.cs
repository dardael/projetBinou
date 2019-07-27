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
    //pas abstract sinon les implementation ne peuvent plus etre utilisée dans le constructeur vs studio
    public partial class pmcApprentissage : pmcParentUtilisantFicheDeTravail {
        public pmcApprentissage() {
            InitializeComponent();
        }
        protected override void gererChangementFicheCourante() {
            if (fiche != null) {
                populateGridFormations();
            }
        }
        private void populateGridFormations() {
            gcFormations.BeginUpdate();
            try {
                gcFormations.DataSource = ficheCourante.formations;
            }
            finally {
                gcFormations.EndUpdate();
            }
        }
        private void btAjouterFormation_Click(object sender, EventArgs e) {
            fiche.formations.Add(new FormationCollaborateur());
            gererChangementFicheCourante();
        }

        private void repoBtSupprimer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            FormationCollaborateur formationCourante = (FormationCollaborateur)gvFormations.GetRow(gvFormations.FocusedRowHandle);
            ficheCourante.formations.Remove(formationCourante);
            gererChangementFicheCourante();
        }
    }
}
