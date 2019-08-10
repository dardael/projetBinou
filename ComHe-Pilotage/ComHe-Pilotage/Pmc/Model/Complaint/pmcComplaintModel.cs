using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComHe_Metier;

namespace ComHe_Pilotage {
    public partial class pmcComplaintModel : pmcParentUtilisantFicheDeTravail {
        public pmcComplaintModel() {
            InitializeComponent();
            trComplaintModel.RootValue = Guid.Empty;
        }
        protected override void gererChangementFicheCourante() {
            if (fiche != null && (fiche.complaintModel == null || fiche.complaintModel.Count != 13 || !fiche.complaintModel.Any(x => x.nom == "lvl1111"))) {
                fiche.complaintModel = ComplaintModelBO.getTreeComplaintModel();
            }
            populateTreeList();
        }
        private void populateTreeList() {
            trComplaintModel.RootValue = Guid.Empty;
            trComplaintModel.BeginUpdate();
            try {
                trComplaintModel.DataSource = ficheCourante.complaintModel;
            }
            finally {
                trComplaintModel.EndUpdate();
                trComplaintModel.RefreshDataSource();
                trComplaintModel.ExpandAll();
            }
        }
    }
}
