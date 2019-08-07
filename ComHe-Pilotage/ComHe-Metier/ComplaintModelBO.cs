using ComHe_Objets;
using ComHe_Outils;
using System;
using System.Collections.Generic;

namespace ComHe_Metier {
    public class ComplaintModelBO {
        public static List<ItemComplaintModel> getTreeComplaintModel() {
            List<ItemComplaintModel> arbre = new List<ItemComplaintModel>();
            ItemComplaintModel lvl1 = createAddAndReturnItem("lvl1", Guid.Empty, "100 clients insatisfaits", 100, false, arbre);
            ItemComplaintModel lvl11 = createAddAndReturnItem("lvl11", lvl1.id, "Nombre de plaignant", 0, true, arbre);
            ItemComplaintModel lvl111 = createAddAndReturnItem("lvl111", lvl11.id, "Se plaignent", 0, true, arbre);
            ItemComplaintModel lvl112 = createAddAndReturnItem("lvl112", lvl11.id, "Ne ne plaignent pas", 0, true, arbre);
            ItemComplaintModel lvl1111 = createAddAndReturnItem("lvl1111", lvl111.id, "Cas réglés", 0, true, arbre);
            ItemComplaintModel lvl1112 = createAddAndReturnItem("lvl1112", lvl111.id, "Cas non réglés", 0, true, arbre);
            ItemComplaintModel lvl1121 = createAddAndReturnItem("lvl1121", lvl112.id, "Cas réglés", 0, true, arbre);
            ItemComplaintModel lvl1122 = createAddAndReturnItem("lvl1122", lvl112.id, "Cas non réglés", 0, true, arbre);
            ItemComplaintModel lvl11121 = createAddAndReturnItem("lvl11121", lvl1112.id, "Clients perdus", 0, true, arbre);
            ItemComplaintModel lvl11122 = createAddAndReturnItem("lvl11122", lvl1112.id, "Clients récupérés", 0, true, arbre);
            return arbre;
        }
        private static ItemComplaintModel createAddAndReturnItem(string nom, Guid idParent, string libelle, int valeur, Boolean valeurModifiable, List<ItemComplaintModel> arbre) {
            ItemComplaintModel lvl = new ItemComplaintModel(nom, idParent, libelle, valeur, valeurModifiable);
            arbre.Add(lvl);
            return lvl;
        }
    }
}
