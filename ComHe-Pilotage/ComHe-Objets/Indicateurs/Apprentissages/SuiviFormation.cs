using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Apprentissages {
    public class SuiviFormation {
        public int nbFormationSuivi { get; set; }
        public double budget { get; set; }
        public double ecart {
            get {
                return budget - nbFormationSuivi;
            }
        }
    }
}
