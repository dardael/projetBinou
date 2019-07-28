using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Interne {
    public class ReductionTempsProduction {
        public int nbDossier { get; set; }
        public int nbHeuresPayees { get; set; }
        public double nbHeureMoyenneParDossier { get { return nbDossier > 0 ? nbHeuresPayees / (double)nbDossier : 0; } }
    }
}
