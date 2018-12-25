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

            return segmentMoyen;
        }
    }
}
