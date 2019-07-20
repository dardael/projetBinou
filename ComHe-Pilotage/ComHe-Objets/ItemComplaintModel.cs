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
        public string libelle { get; set; }
        public double valeur { get; set; }
        public Boolean valeurModifiable { get; set; }
        public ItemComplaintModel() {

        }
        public ItemComplaintModel(string nom, Guid idParent, string libelle, double valeur, Boolean valeurModifiable) {
            this.nom = nom;
            this.idParent = idParent;
            this.libelle = libelle;
            this.valeur = valeur;
            this.valeurModifiable = valeurModifiable;
            id = Guid.NewGuid();
        }
    }
}
