using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    public class MesureReductionCout {
        public int nbHeure { get; set; }
        public double ca { get; set; }
        public double ratio { get { return ca > 0 ? nbHeure / ca : 0; } }
    }
}
