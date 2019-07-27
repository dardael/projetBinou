using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    [Serializable]
    public class DimensionSatisfactionModel {
        public Guid parent { get; set; }
        public String nom { get; set; }
        public Double poids { get; set; }
        public Boolean isSupprimable { get; set; }
        public Guid id { get; set; }
        public int lvl { get; set; }
        public double satisfaction { get; set; }
        public DimensionSatisfactionModel() {

        }
        public DimensionSatisfactionModel(Guid parent, String nom, Double poids, Boolean isSupprimable, double satisfaction, int lvl) {
            this.parent = parent;
            this.nom = nom;
            this.poids = poids;
            this.isSupprimable = isSupprimable;
            this.lvl = lvl;
            this.satisfaction = satisfaction;
            this.id = Guid.NewGuid();
        }
    }
}
