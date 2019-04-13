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
    }
}
