using ComHe_Objets;
using ComHe_Outils;
using System;
using System.Collections.Generic;

namespace ComHe_Metier {
    public class LoyaltyModelBO {
        public static List<ItemLoyaltyModel> getLoyaltyModel() {
            List<ItemLoyaltyModel> loyaltyModel = new List<ItemLoyaltyModel>();
            for (int satisfaction = 0; satisfaction < 11; satisfaction++) {
                for (int loyaute = 0; loyaute < 11; loyaute++) {
                    loyaltyModel.Add(new ItemLoyaltyModel(satisfaction, loyaute, 0));
                }
            }
            return loyaltyModel;
        }
    }
}
