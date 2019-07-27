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
    public class pmcParentUtilisantFicheDeTravail : UserControl {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        protected FicheTravail ficheCourante;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
        protected virtual void gererChangementFicheCourante() {
        }
    }
}
