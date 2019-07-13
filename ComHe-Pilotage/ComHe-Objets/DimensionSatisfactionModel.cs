using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    public class DimensionSatisfactionModel {
        public Guid parent { get; set; }
        public List<DimensionSatisfactionModel> enfants {
            get {
                if (_enfants == null) {
                    _enfants = new List<DimensionSatisfactionModel>();
                }
                return _enfants;
            }
            set {
                _enfants = value;
            }
        }
        private List<DimensionSatisfactionModel> _enfants;
        public String nom { get; set; }
        public Double poids { get; set; }
        public Boolean isSupprimable { get; set; }
        private Guid _id = Guid.NewGuid();
        public Guid id { get { return _id; } }
        public DimensionSatisfactionModel() {

        }
        public DimensionSatisfactionModel(Guid parent, String nom, Double poids, Boolean isSupprimable) {
            this.parent = parent;
            this.nom = nom;
            this.poids = poids;
            this.isSupprimable = isSupprimable;
        }
    }
}
