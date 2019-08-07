using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Apprentissages {
    public class CAInsatisfactionRecupere {
        public int nbClientsInsatisfaitsConserves { get; set; }
        public int nbClientsInsatisfaitsDetectes { get; set; }
        public double ratio {
            get {
                return nbClientsInsatisfaitsDetectes > 0 ? ((double)nbClientsInsatisfaitsConserves) / nbClientsInsatisfaitsDetectes : 0;
            }
        }
    }
}
