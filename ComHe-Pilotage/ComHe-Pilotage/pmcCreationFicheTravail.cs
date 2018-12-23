using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ComHe_Objets;

namespace ComHe_Pilotage {
    public partial class pmcCreationFicheTravail : XtraUserControl {
        public event EventHandler btAnnulerClick;
        public event EventHandler btAjouterClick;
        public FicheTravail ficheTravailCourante { get; set; }
        public pmcCreationFicheTravail() {
            InitializeComponent();
        }

        private void btSauvegarder_Click(object sender, EventArgs e) {
            ficheTravailCourante.nom = (string)this.txtSaisieNomFicheTravail.EditValue;
            this.btAjouterClick(sender, e);
        }

        private void btAnnuler_Click(object sender, EventArgs e) {
            this.btAnnulerClick(sender, e);
        }
        public void addFicheTravailCourante(FicheTravail ficheTravailCourante) {
            if (ficheTravailCourante != null) {
                this.ficheTravailCourante = ficheTravailCourante;
                this.txtSaisieNomFicheTravail.EditValue = ficheTravailCourante.nom;
            }
            else {
                this.ficheTravailCourante = new FicheTravail();
            }
        }
        public FicheTravail returnFicheDeTravail() {
            return ficheTravailCourante;
        }
    }
}
