using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using ComHe_Objets;

namespace ComHe_Pilotage {
    public partial class frmSaisieFicheTravail : XtraForm {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public Boolean isAjoutOk { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public Boolean isNew { get; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public FicheTravail ficheTravail { get; }

        public frmSaisieFicheTravail(FicheTravail ficheTravail, Boolean isNew) {
            init();
            this.ficheTravail = ficheTravail;
            this.isNew = isNew;
            pmcCreationFicheTravail1.addFicheTravailCourante(ficheTravail);
        }
        private void init() {
            InitializeComponent();
            this.pmcCreationFicheTravail1.btAjouterClick += new EventHandler(pmcCreationFicheTravail1_btAjouterClick);
            this.pmcCreationFicheTravail1.btAnnulerClick += new EventHandler(pmcCreationFicheTravail1_btAnnulerClick);

        }

        protected void pmcCreationFicheTravail1_btAjouterClick(object sender, EventArgs e) {
            isAjoutOk = true;
            Close();
        }
        protected void pmcCreationFicheTravail1_btAnnulerClick(object sender, EventArgs e) {
            isAjoutOk = false;
            Close();
        }
    }
}