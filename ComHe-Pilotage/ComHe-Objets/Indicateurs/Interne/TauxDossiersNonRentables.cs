using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Interne {
    public class TauxDossiersNonRentables {
        public int nbDossiers { get; set; }
        public int nbDossiersInf { get; set; }
        public double ratio { get { return nbDossiers > 0 ? nbDossiersInf / (double)nbDossiers : 0; } }
    }
}
