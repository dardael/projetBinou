using System;
using System.Collections.Generic;

namespace ComHe_Objets {
    [Serializable]
    public class FicheTravail {
        public string nom { get; set; }
        public List<Segment> segments { get; set; }
        public FicheTravail(List<Segment> segments) {
            this.segments = segments;
        }
        public FicheTravail(string nom, List<Segment> segments) {
            this.segments = segments;
            this.nom = nom;
        }
        public FicheTravail() {
        }
    }
}
