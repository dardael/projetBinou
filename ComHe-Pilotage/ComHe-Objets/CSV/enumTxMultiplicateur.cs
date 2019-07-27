using System;
using System.ComponentModel.DataAnnotations;

namespace ComHe_Objets {
    [Serializable]
    /// <summary>
    /// Defines the enumTypeSegment
    /// </summary>
    public enum enumTxMultiplicateur {
        [Display(Name = "Non renseigné")]
        NR,
        [Display(Name = "1.20")]
        CENTVINGT,
        [Display(Name = "1.15")]
        CENTQUINZE,
        [Display(Name = "1.11")]
        CENTONZE,
        [Display(Name = "1.07")]
        CENTSEPT,
        [Display(Name = "1.75")]
        CENTSOIXANTEQUINZE,
        [Display(Name = "1.67")]
        CENTSOIXANTESEPT,
        [Display(Name = "1.59")]
        CENTCINQUANTENEUF,
        [Display(Name = "1.52")]
        CENTCINQUANTEDEUX,
        [Display(Name = "2.67")]
        DEUXCENTSOIXANTESEPT,
        [Display(Name = "2.50")]
        DEUXCENTCINQUANTE,
        [Display(Name = "2.35")]
        DEUXCENTTRENTECINQ,
        [Display(Name = "2.22")]
        DEUXCENTVINGTDEUX,
        [Display(Name = "4.50")]
        QUATRECENTCINQUANTE,
        [Display(Name = "4.09")]
        QUATRECENTNEUF,
        [Display(Name = "3.75")]
        TROISCENTSOIXANTEQUINZE,
        [Display(Name = "3.46")]
        TROISCENTQUARANTESIX
    }
    public static class enumTxMultiplicateurMethods {
        public static double getDoubleFromCode(this enumTxMultiplicateur code) {
            switch (code) {
                case enumTxMultiplicateur.CENTVINGT: return 1.20;
                case enumTxMultiplicateur.CENTQUINZE: return 1.15;
                case enumTxMultiplicateur.CENTONZE: return 1.11;
                case enumTxMultiplicateur.CENTSEPT: return 1.07;
                case enumTxMultiplicateur.CENTSOIXANTEQUINZE: return 1.75;
                case enumTxMultiplicateur.CENTSOIXANTESEPT: return 1.67;
                case enumTxMultiplicateur.CENTCINQUANTENEUF: return 1.59;
                case enumTxMultiplicateur.CENTCINQUANTEDEUX: return 1.52;
                case enumTxMultiplicateur.DEUXCENTSOIXANTESEPT: return 1.67;
                case enumTxMultiplicateur.DEUXCENTCINQUANTE: return 2.50;
                case enumTxMultiplicateur.DEUXCENTTRENTECINQ: return 2.35;
                case enumTxMultiplicateur.DEUXCENTVINGTDEUX: return 2.22;
                case enumTxMultiplicateur.QUATRECENTCINQUANTE: return 4.50;
                case enumTxMultiplicateur.QUATRECENTNEUF: return 4.09;
                case enumTxMultiplicateur.TROISCENTSOIXANTEQUINZE: return 3.75;
                case enumTxMultiplicateur.TROISCENTQUARANTESIX: return 3.46;
                default: return 0;
            }
        }

        public static enumTxMultiplicateur getTxMargeFromTxRetentionEtTauxActualisation(enumTxActualisation txActu, enumTxRetention txRetention) {
            switch (txRetention) {
                case enumTxRetention.SOIXANTE:
                    switch (txActu) {
                        case enumTxActualisation.DIX: return enumTxMultiplicateur.CENTVINGT;
                        case enumTxActualisation.DOUZE: return enumTxMultiplicateur.CENTQUINZE;
                        case enumTxActualisation.QUATORZE: return enumTxMultiplicateur.CENTONZE;
                        case enumTxActualisation.SEIZE: return enumTxMultiplicateur.CENTSEPT;
                        default: return enumTxMultiplicateur.NR;
                    }
                case enumTxRetention.SOIXANTEDIX:
                    switch (txActu) {
                        case enumTxActualisation.DIX: return enumTxMultiplicateur.CENTSOIXANTEQUINZE;
                        case enumTxActualisation.DOUZE: return enumTxMultiplicateur.CENTSOIXANTESEPT;
                        case enumTxActualisation.QUATORZE: return enumTxMultiplicateur.CENTCINQUANTENEUF;
                        case enumTxActualisation.SEIZE: return enumTxMultiplicateur.CENTCINQUANTEDEUX;
                        default: return enumTxMultiplicateur.NR;
                    }
                case enumTxRetention.QUATREVINGT:
                    switch (txActu) {
                        case enumTxActualisation.DIX: return enumTxMultiplicateur.DEUXCENTSOIXANTESEPT;
                        case enumTxActualisation.DOUZE: return enumTxMultiplicateur.DEUXCENTCINQUANTE;
                        case enumTxActualisation.QUATORZE: return enumTxMultiplicateur.DEUXCENTTRENTECINQ;
                        case enumTxActualisation.SEIZE: return enumTxMultiplicateur.DEUXCENTVINGTDEUX;
                        default: return enumTxMultiplicateur.NR;
                    }
                case enumTxRetention.QUATREVINGTDIX:
                    switch (txActu) {
                        case enumTxActualisation.DIX: return enumTxMultiplicateur.QUATRECENTCINQUANTE;
                        case enumTxActualisation.DOUZE: return enumTxMultiplicateur.QUATRECENTNEUF;
                        case enumTxActualisation.QUATORZE: return enumTxMultiplicateur.TROISCENTSOIXANTEQUINZE;
                        case enumTxActualisation.SEIZE: return enumTxMultiplicateur.TROISCENTQUARANTESIX;
                        default: return enumTxMultiplicateur.NR;
                    }
                default: return enumTxMultiplicateur.NR;
            }

        }
    }

}
