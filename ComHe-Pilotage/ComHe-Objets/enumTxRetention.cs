using System;
using System.ComponentModel.DataAnnotations;

namespace ComHe_Objets {
    [Serializable]
    /// <summary>
    /// Defines the enumTypeSegment
    /// </summary>
    public enum enumTxRetention {
        [Display(Name = "Non renseigné")]
        NR,
        [Display(Name = "60%")]
        SOIXANTE,
        [Display(Name = "70%")]
        SOIXANTEDIX,
        [Display(Name = "80%")]
        QUATREVINGT,
        [Display(Name = "90%")]
        QUATREVINGTDIX
    }
    public static class enumTxRetentionMethods {
        public static string getStringFromCode(this enumTxRetention code) {
            switch (code) {
                case enumTxRetention.SOIXANTE: return "60%";
                case enumTxRetention.SOIXANTEDIX: return "70%";
                case enumTxRetention.QUATREVINGT: return "80%";
                case enumTxRetention.QUATREVINGTDIX: return "90%";
                default: return "";
            }

        }
        public static double getDoubleFromCode(this enumTxRetention code) {
            switch (code) {
                case enumTxRetention.SOIXANTE: return 0.6;
                case enumTxRetention.SOIXANTEDIX: return 0.7;
                case enumTxRetention.QUATREVINGT: return 0.8;
                case enumTxRetention.QUATREVINGTDIX: return 0.9;
                default: return 0;
            }

        }
    }

}
