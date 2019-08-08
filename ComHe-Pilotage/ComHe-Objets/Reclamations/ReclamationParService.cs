using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Reclamations {
    public class ReclamationParService {
        public int nbReclamations { get; set; }
        public String service { get; set; }
        public Guid id { get; } = new Guid();
    }
}
