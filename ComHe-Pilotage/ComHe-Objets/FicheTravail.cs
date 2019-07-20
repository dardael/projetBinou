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
        public List<ItemComplaintModel> complaintModel { get; set; }
        public List<ItemLoyaltyModel> loyaltyModel { get; set; }
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
        public FicheTravail(string nom, List<Segment> segments, List<Reclamation> reclamations, List<FormationCollaborateur> formations, List<AttributDeSatisfaction> attibutsDeSatisfaction, List<DimensionSatisfactionModel> dimensionsSatisfactionModel, List<ItemLoyaltyModel> loyaltyModel, List<ItemComplaintModel> complaintModel) {
            this.segments = segments;
            this.nom = nom;
            this.reclamations = reclamations;
            this.attibutsDeSatisfaction = attibutsDeSatisfaction;
            this.dimensionsSatisfactionModel = dimensionsSatisfactionModel;
            this.formations = formations;
            this.complaintModel = complaintModel;
            this.loyaltyModel = loyaltyModel;
        }
        public FicheTravail(string nom, List<Segment> segments, List<Reclamation> reclamations, List<FormationCollaborateur> formations, List<AttributDeSatisfaction> attibutsDeSatisfaction, List<DimensionSatisfactionModel> dimensionsSatisfactionModel) {
            this.segments = segments;
            this.nom = nom;
            this.reclamations = reclamations;
            this.attibutsDeSatisfaction = attibutsDeSatisfaction;
            this.dimensionsSatisfactionModel = dimensionsSatisfactionModel;
            this.formations = formations;
        }
        public FicheTravail() {
        }
        public void generateNewGuid() {
            _id = Guid.NewGuid();
        }
    }
}
