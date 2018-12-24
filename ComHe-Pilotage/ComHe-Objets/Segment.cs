using System;

namespace ComHe_Objets {

    /// <summary>
    /// Defines the <see cref="Segment" />
    /// </summary> 

    [Serializable]
    public class Segment {
        public string nom { get; set; }
        public enumTypeSegment typeSegment { get; set; }
        public double caFromLM { get; set; }
        public double txMarge { get; set; }
        public double txRetention { get; set; }
        public double marge { get; set; }
        public double txMultiplicateur { get; set; }
        public double clv { get; set; }
        public Segment() {

        }

        public Segment(string nom, enumTypeSegment typeSegment, double caFromLM, double txMarge, double txRetention, double marge, double txMultiplicateur, double clv) {
            this.nom = nom;
            this.typeSegment = typeSegment;
            this.caFromLM = caFromLM;
            this.txMarge = txMarge;
            this.txRetention = txRetention;
            this.marge = marge;
            this.txMultiplicateur = txMultiplicateur;
            this.clv = clv;
        }
    }
}
