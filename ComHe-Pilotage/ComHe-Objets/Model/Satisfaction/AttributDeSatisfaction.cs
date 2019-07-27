using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    public class AttributDeSatisfaction {
        public String nom { get; set; }
        private Guid _id = Guid.NewGuid();
        public Guid id { get { return _id; } }
        public Double impactSurSatisfaction { get; set; }
        public Double impactSurInsatisfaction { get; set; }
        public Double impactSurInsatisfactionAAfficher {
            get {
                return impactSurInsatisfaction * (-1);
            }
        }
    }
}
