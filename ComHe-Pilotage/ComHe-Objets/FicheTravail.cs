using System;
using System.Collections.Generic;

namespace ComHe_Objets {
    [Serializable]
    public class FicheTravail {
        private Guid _id = Guid.NewGuid();
        public Guid id { get { return _id; } }
        public string nom { get; set; }
        public List<Segment> segments { get; set; }
        public List<Reclamation> reclamations { get; set; }
        public FicheTravail(List<Segment> segments, List<Reclamation> reclamations) {
            this.segments = segments;
            this.reclamations = reclamations;
        }
        public FicheTravail(string nom, List<Segment> segments, List<Reclamation> reclamations) {
            this.segments = segments;
            this.nom = nom;
            this.reclamations = reclamations;
        }
        public FicheTravail() {
        }
        public void generateNewGuid() {
            _id = Guid.NewGuid();
        }
    }
}
