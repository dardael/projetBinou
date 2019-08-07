using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    public class CroissanceCA {
        public double ca { get; set; }
        public double caAvant { get; set; }
        public double caAvantAvant { get; set; }
        public double ecart {
            get {
                return ca - caAvant;
            }
        }
        public double variation {
            get {
                return caAvant > 0 ? ecart / caAvant : 0;
            }
        }
    }
}
