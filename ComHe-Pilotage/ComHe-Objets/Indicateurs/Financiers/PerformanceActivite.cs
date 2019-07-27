using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    public class PerformanceActivite {
        public double ca { get; set; }
        public double budget { get; set; }
        public double ecart { get { return ca - budget; } }
    }
}
