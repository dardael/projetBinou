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
                foreach (Segment s in segments) {
                    ca += s.caFromLM;
                    marge += s.txMarge;
                    retention += enumTxRetentionMethods.getDoubleFromCode(s.txRetention);
                    actualisation += enumTxActualisationMethods.getDoubleFromCode(s.txActualisation);
                }
                segmentMoyen.caFromLM = ca / segments.Count;
                segmentMoyen.txMarge = marge / segments.Count;
                segmentMoyen.txActualisation = enumTxActualisationMethods.getCodeFromDouble(actualisation / segments.Count);
                segmentMoyen.txRetention = enumTxRetentionMethods.getCodeFromDouble(retention / segments.Count);
            }
            return segmentMoyen;
        }
    }
}
