using ComHe_Objets;
using ComHe_Outils;
using System;
using System.Collections.Generic;

namespace ComHe_Metier {
    public class ComplaintModelBO {
        public static List<ItemComplaintModel> getTreeComplaintModel() {
            List<ItemComplaintModel> arbre = new List<ItemComplaintModel>();
            ItemComplaintModel lvl1 = new ItemComplaintModel("lvl1", Guid.Empty, "100 Clients", 100);
            ItemComplaintModel lvl21 = new ItemComplaintModel("lvl1", Guid.Empty, "100 Clients", 100);
            ItemComplaintModel lvl22 = new ItemComplaintModel("lvl1", Guid.Empty, "100 Clients", 100);
            return arbre;
        }
    }
}
