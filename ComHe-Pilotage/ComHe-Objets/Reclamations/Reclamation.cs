using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Reclamations {
    public class Reclamation {
        private Guid _id = Guid.NewGuid();
        public Guid id { get { return _id; } }
        public DateTime dateLitige { get; set; }
        public String collaborateur { get; set; }
        public String client { get; set; }
        public String numeroClient { get; set; }
        public String service { get; set; }
        public String motifInsatisfaction { get; set; }
        public String actionCorrective { get; set; }
        public String motifLegitime { get; set; }
        public double montantIndemnite { get; set; }
        public String verbatimClient { get; set; }
    }
}
