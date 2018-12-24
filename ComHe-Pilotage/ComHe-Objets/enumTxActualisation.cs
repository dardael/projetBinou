using DevExpress.XtraLayout.Customization;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ComHe_Objets {
    [Serializable]
    /// <summary>
    /// Defines the enumTypeSegment
    /// </summary>
    public enum enumTxActualisation {
        [Display(Name = "Non renseigné")]
        NR,
        [Display(Name = "10%")]
        DIX,
        [Display(Name = "12%")]
        DOUZE,
        [Display(Name = "14%")]
        QUATORZE,
        [Display(Name = "16%")]
        SEIZE
    }
    public static class enumTxActualisationMethods {
        public static string getStringFromCode(this enumTxActualisation code) {
            switch (code) {
                case enumTxActualisation.DIX: return "10%";
                case enumTxActualisation.DOUZE: return "12%";
                case enumTxActualisation.QUATORZE: return "14%";
                case enumTxActualisation.SEIZE: return "16%";
                default: return "";
            }

        }
        public static double getDoubleFromCode(this enumTxActualisation code) {
            switch (code) {
                case enumTxActualisation.DIX: return 0.1;
                case enumTxActualisation.DOUZE: return 0.12;
                case enumTxActualisation.QUATORZE: return 0.14;
                case enumTxActualisation.SEIZE: return 0.16;
                default: return 0;
            }

        }
    }

}
