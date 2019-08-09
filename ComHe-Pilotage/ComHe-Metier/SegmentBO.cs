using ComHe_Objets;
using ComHe_Outils;
using System.Collections.Generic;

namespace ComHe_Metier {
    public class SegmentBO {
        public static Segment clonerSegment(Segment segmentOriginal) {
            Segment segmentClone = Cloneur.Clone(segmentOriginal);
            segmentClone.generateNewGuid();
            return segmentClone;
        }
        public static Segment returnSegmentMoyen(List<Segment> segments) {
            Segment segmentMoyen = new Segment();
            segmentMoyen.nom = "Moyenne";
            if (segments != null && segments.Count > 0) {
                double ca = 0;
                double marge = 0;
                double retention = 0;
                double actualisation = 0;
                double caPriceSensibility = 0;
                double caAchatsCroises = 0;
                double caWACC = 0;
                double caRecommandation = 0;
                double coutAcquisition = 0;
                bool modeExpert = false;
                foreach (Segment s in segments) {
                    caAchatsCroises += s.caAchatsCroises;
                    caPriceSensibility += s.caSensibilitePricePremium;
                    caRecommandation += s.caRecommendation;
                    caWACC += s.caWACC;
                    ca += s.caFromLM;
                    marge += s.txMarge;
                    retention += enumTxRetentionMethods.getDoubleFromCode(s.txRetention);
                    actualisation += enumTxActualisationMethods.getDoubleFromCode(s.txActualisation);
                    coutAcquisition += s.coutAcquisition;
                    modeExpert = s.modeExpert;
                }
                segmentMoyen.modeExpert = modeExpert;
                segmentMoyen.caFromLM = ca / segments.Count;
                segmentMoyen.caAchatsCroises = caAchatsCroises / segments.Count;
                segmentMoyen.caSensibilitePricePremium = caPriceSensibility / segments.Count;
                segmentMoyen.caRecommendation = caRecommandation / segments.Count;
                segmentMoyen.caWACC = caWACC / segments.Count;
                segmentMoyen.txMarge = marge / segments.Count;
                segmentMoyen.txActualisation = enumTxActualisationMethods.getCodeFromDouble(actualisation / segments.Count);
                segmentMoyen.txRetention = enumTxRetentionMethods.getCodeFromDouble(retention / segments.Count);
                segmentMoyen.coutAcquisition = coutAcquisition / segments.Count;
            }
            return segmentMoyen;
        }
    }
}
