using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Interne {
    public class TauxRemonteesReclamation {
        public int nbDossier { get; set; }
        public int nbReclamation { get; set; }
        public double nbReclaParDossier { get { return nbDossier > 0 ? nbReclamation / (double)nbDossier : 0; } }
    }
}
