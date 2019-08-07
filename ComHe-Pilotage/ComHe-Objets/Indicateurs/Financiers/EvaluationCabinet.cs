using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    public class EvaluationCabinet {
        public double ca { get; set; }
        public double portefeuilleClient { get; set; }
        public double coef { get; set; }
        public double valoPotentielle { get { return ca * coef; } }
    }
}
