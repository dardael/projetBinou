using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Interne {
    public class DefaillanceCabinet {
        public int nbDossierTransmis { get; set; }
        public int nbDossierTransmisAvant { get; set; }
        public int nbDossierTransmisAvantAvant { get; set; }
        public double montantPrejudice { get; set; }
        public double montantPrejudiceAvant { get; set; }
        public double montantPrejudiceAvantAvant { get; set; }
    }
}
