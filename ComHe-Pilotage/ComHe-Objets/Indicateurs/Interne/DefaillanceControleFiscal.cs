using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Interne {
    public class DefaillanceControleFiscal {
        public int nbDossierRedressement { get; set; }
        public int nbDossierOuverture { get; set; }
        public double ratio { get { return nbDossierRedressement > 0 ? nbDossierOuverture / (double)nbDossierRedressement : 0; } }
    }
}
