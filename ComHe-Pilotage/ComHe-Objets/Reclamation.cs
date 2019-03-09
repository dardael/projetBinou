using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    public class Reclamation {
        private Guid _id = Guid.NewGuid();
        public Guid id { get { return _id; } }
        public DateTime dateLitige { get; set; }
        public String collaborateur { get; set; }
        public String client { get; set; }
        public String numeroClient { get; set; }
        public String service { get; set; }
        public String motifInsatisfaction { get; set; }
        public enumActionCorrective actionCorrective { get; set; }
        public enumMotifInsatisfactionLegitime motifLegitime { get; set; }
        public double montantIndemnite { get; set; }
        public String verbatimClient { get; set; }
    }
}
