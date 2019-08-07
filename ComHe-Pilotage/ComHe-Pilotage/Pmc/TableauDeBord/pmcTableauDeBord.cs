using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComHe_Pilotage.Pmc.TableauDeBord {
    public partial class pmcTableauDeBord : pmcParentUtilisantFicheDeTravail {
        public pmcTableauDeBord() {
            InitializeComponent();
            pmcQuestionnaireNoteSegment1.adapaterAffichage("NPS", "Si un proche avait besoin d'un professionnel de l'expertise comptable, lui recommanderiez vous votre cabinet ?", fiche);
            pmcQuestionnaireNoteSegment1.PassageModeTableauDebord();
            pmcLoyatyModel1.PassageModeTableauDebord();
            pmcGestionReclamation1.PassageModeTableauDebord();
            pmcSegmentation1.PassageModeTableauDebord();
        }
        protected override void gererChangementFicheCourante() {
            pmcGestionReclamation1.fiche = fiche;
            pmcLoyatyModel1.fiche = fiche;
            pmcQuestionnaireNoteSegment1.fiche = fiche;
            pmcSegmentation1.fiche = fiche;
        }
    }
}
