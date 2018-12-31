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
    public partial class pmcQuatresChemins : UserControl {
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
        public pmcQuatresChemins() {
            InitializeComponent();
            grQuatresChemins.DataSource = new List<Segment>();
        }
        private void gererChangementFicheCourante() {
            if (fiche != null) {
                populateGridQuatresChemins();
            }
        }
        private void populateGridQuatresChemins() {
            grQuatresChemins.DataSource = new List<Segment>(ficheCourante.segments);
            grQuatresChemins.Refresh();
        }
    }
}
