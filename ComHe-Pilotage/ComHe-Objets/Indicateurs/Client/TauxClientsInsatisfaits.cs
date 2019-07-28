using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Client {
    public class TauxClientsInsatisfaits {
        public int nbClientsInsatisfaits { get; set; }
        public int nbClientsTotal { get; set; }
        public double ratio { get { return nbClientsTotal > 0 ? nbClientsInsatisfaits / (double)nbClientsTotal : 0; } }
    }
}
