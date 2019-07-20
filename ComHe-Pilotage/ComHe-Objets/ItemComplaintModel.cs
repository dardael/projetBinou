using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets {
    [Serializable]
    public class ItemComplaintModel {
        public Guid id { get; set; }
        public string nom { get; set; }
        public Guid idParent { get; set; }
        public string libelle;
        public double valeur;
        public ItemComplaintModel() {

        }
        public ItemComplaintModel(string nom, Guid idParent, string libelle, double valeur) {
            this.nom = nom;
            this.idParent = idParent;
            this.libelle = libelle;
            this.valeur = valeur;
            id = Guid.NewGuid();
        }
    }
}
