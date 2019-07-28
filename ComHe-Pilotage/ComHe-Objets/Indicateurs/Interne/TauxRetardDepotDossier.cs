using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Interne {
    public class TauxRetardDepotDossier {
        public int nbDossier { get; set; }
        public int nbDossierRetard { get; set; }
        public double NbDossierRetardMoyen { get { return nbDossier > 0 ? nbDossierRetard / (double)nbDossier : 0; } }
    }
}
