using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Interne {
    public class TauxSatisfaction {
        public int nbClientsSatisfaits { get; set; }
        public int nbClientsTotal { get; set; }
        public double ratio { get { return nbClientsTotal > 0 ? nbClientsSatisfaits / (double)nbClientsTotal : 0; } }
    }
}
