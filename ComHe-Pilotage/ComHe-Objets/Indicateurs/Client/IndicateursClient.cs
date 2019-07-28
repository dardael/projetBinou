using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Client {
    public class IndicateursClient {
        public TauxClientsInsatisfaits tauxClientsInsatisfaits { get; set; }
        public TauxDeRecommandation tauxDeRecommandation { get; set; }
        public TauxDeRetentionClient tauxDeRetentionClient { get; set; }
        public double montantIndemnitesFinancieres { get; set; }
        public int nbReclamations { get; set; }
    }
}
