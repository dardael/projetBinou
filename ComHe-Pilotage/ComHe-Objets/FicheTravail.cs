using System;
using System.Collections.Generic;
using System.Linq;

namespace ComHe_Objets {
    [Serializable]
    public class FicheTravail {
        private Guid _id = Guid.NewGuid();
        public Guid id { get { return _id; } }
        public string nom { get; set; }
        public List<Segment> segments { get; set; }
        public List<Reclamation> reclamations { get; set; }
        public List<FormationCollaborateur> formations { get; set; }
        public List<AttributDeSatisfaction> attibutsDeSatisfaction { get; set; }
        public List<DimensionSatisfactionModel> dimensionsSatisfactionModel {
            get {
                return _dimensionsSatisfactionModel;
            }
            set { _dimensionsSatisfactionModel = value; }
        }
        private List<DimensionSatisfactionModel> _dimensionsSatisfactionModel;
        public double scoreCESMoyen {
            get {
                if (segments != null && segments.Count > 0) {
                    return segments.Average(x => x.scoreCES);
                }
                else {
                    return 0;
                }
            }
        }
        public double scoreNPSMoyen {
            get {
                if (segments != null && segments.Count > 0) {
                    return segments.Average(x => x.scoreNPS);
                }
                else {
                    return 0;
                }
            }
        }
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
