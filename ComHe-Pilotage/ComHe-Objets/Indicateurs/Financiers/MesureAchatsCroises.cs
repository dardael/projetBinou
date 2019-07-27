using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    public class MesureAchatsCroises {
        public double caExeptionnel { get; set; }
        public double caTrad { get; set; }
        public double ratio { get { return caTrad > 0 ? caExeptionnel / caTrad : 0; } }
    }
}
