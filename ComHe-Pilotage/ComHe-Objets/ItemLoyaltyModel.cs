using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    [Serializable]
    public class ItemLoyaltyModel {
        public Guid id { get; set; }
        public int noteSatisfaction { get; set; }
        public int noteLoyaute { get; set; }
        public int nbPersonnes { get; set; }
        public ItemLoyaltyModel() {

        }
        public ItemLoyaltyModel(int noteSatisfaction, int noteLoyaute, int nbPersonnes) {
            this.noteSatisfaction = noteSatisfaction;
            this.noteLoyaute = noteLoyaute;
            this.nbPersonnes = nbPersonnes;
            id = Guid.NewGuid();
        }
    }
}
