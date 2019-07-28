using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Client {
    public class TauxDeRecommandation {
        public int nbRecommandations { get; set; }
        public int nbProspect { get; set; }
        public double ratio { get { return nbProspect > 0 ? nbRecommandations / (double)nbProspect : 0; } }
    }
}
