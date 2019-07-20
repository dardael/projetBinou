using ComHe_Objets;
using ComHe_Outils;
using System;
using System.Collections.Generic;

namespace ComHe_Metier {
    public class ComplaintModelBO {
        public static List<ItemComplaintModel> getTreeComplaintModel() {
            List<ItemComplaintModel> arbre = new List<ItemComplaintModel>();
            ItemComplaintModel lvl1 = createAddAndReturnItem("lvl1", Guid.Empty, "Problème avec XXX", 100, false, arbre);
            ItemComplaintModel lvl21 = createAddAndReturnItem("lvl11", lvl1.id, "Non", 0, true, arbre);
            ItemComplaintModel lvl22 = createAddAndReturnItem("lvl12", lvl1.id, "Oui", 0, true, arbre);
            ItemComplaintModel lvl221 = createAddAndReturnItem("lvl221", lvl22.id, "Réclamation du client", 100, false, arbre);
            ItemComplaintModel lvl2211 = createAddAndReturnItem("lvl2211", lvl221.id, "Non", 0, true, arbre);
            ItemComplaintModel lvl2212 = createAddAndReturnItem("lvl2212", lvl221.id, "Oui", 0, true, arbre);
            ItemComplaintModel lvl22121 = createAddAndReturnItem("lvl22121", lvl2212.id, "Réponse de XXX", 100, false, arbre);
            ItemComplaintModel lvl221211 = createAddAndReturnItem("lvl221211", lvl22121.id, "Non", 0, true, arbre);
            ItemComplaintModel lvl221212 = createAddAndReturnItem("lvl221212", lvl22121.id, "Oui", 0, true, arbre);
            ItemComplaintModel lvl2212121 = createAddAndReturnItem("lvl2212121", lvl221212.id, "Satisfaction vis à vis de cette réclamation", 100, false, arbre);
            ItemComplaintModel lvl22121211 = createAddAndReturnItem("lvl22121211", lvl2212121.id, "Non", 0, true, arbre);
            ItemComplaintModel lvl22121212 = createAddAndReturnItem("lvl22121212", lvl2212121.id, "Oui", 0, true, arbre);
            return arbre;
        }
        private static ItemComplaintModel createAddAndReturnItem(string nom, Guid idParent, string libelle, int valeur, Boolean valeurModifiable, List<ItemComplaintModel> arbre) {
            ItemComplaintModel lvl = new ItemComplaintModel(nom, idParent, libelle, valeur, valeurModifiable);
            arbre.Add(lvl);
            return lvl;
        }
    }
}
