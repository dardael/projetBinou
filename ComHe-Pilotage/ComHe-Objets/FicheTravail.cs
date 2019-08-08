using ComHe_Objets.Indicateurs.Apprentissages;
using ComHe_Objets.Indicateurs.Client;
using ComHe_Objets.Indicateurs.Interne;
using ComHe_Objets.NotesQuestion;
using ComHe_Objets.Reclamations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComHe_Objets {
    [Serializable]
    public class FicheTravail {
        private Guid _id = Guid.NewGuid();
        public Guid id { get { return _id; } }
        public IndicateursFinanciers indicateursFinanciers { get; set; }
        public IndicateursClient indicateursClient { get; set; }
        public IndicateursInternes indicateursInternes { get; set; }
        public IndicateursFormations indicateursFormations { get; set; }
        public string nom { get; set; }
        public List<Segment> segments { get; set; }
        public List<Reclamation> reclamations { get; set; }
        public QuestionNotee ensemblePrestation { get; set; }
        public QuestionNotee qualitePrestation { get; set; }
        public QuestionNotee montantHonoraires { get; set; }
        public QuestionNotee engagementClient { get; set; }
        public QuestionNotee mesureSelling { get; set; }
        public QuestionNotee mesureQualite { get; set; }
        public QuestionNotee mesureEcoute { get; set; }
        private List<ReclamationParService> _reclamationsParServices;
        public List<ReclamationParService> reclamationsParServices {
            get {
                _reclamationsParServices = reclamations != null ? reclamations.GroupBy(
                    x => x.service,
                    x => x,
                    (x, y) => {
                        ReclamationParService reclam = new ReclamationParService();
                        reclam.service = x;
                        reclam.nbReclamations = y.Count();
                        return reclam;
                    }
                    ).ToList() : new List<ReclamationParService>();
                return _reclamationsParServices;
            }
            set {
                _reclamationsParServices = reclamations != null ? reclamations.GroupBy(
                    x => x.service,
                    x => x,
                    (x, y) => {
                        ReclamationParService reclam = new ReclamationParService();
                        reclam.service = x;
                        reclam.nbReclamations = y.Count();
                        return reclam;
                    }
                    ).ToList() : new List<ReclamationParService>();
            }
        }
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
            initialiserToutesQuestions();
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
            initialiserToutesQuestions();
        }
        public FicheTravail(string nom, List<Segment> segments, List<Reclamation> reclamations, List<FormationCollaborateur> formations, List<AttributDeSatisfaction> attibutsDeSatisfaction, List<DimensionSatisfactionModel> dimensionsSatisfactionModel) {
            this.segments = segments;
            this.nom = nom;
            this.reclamations = reclamations;
            this.attibutsDeSatisfaction = attibutsDeSatisfaction;
            this.dimensionsSatisfactionModel = dimensionsSatisfactionModel;
            this.formations = formations;
            initialiserToutesQuestions();
        }
        public FicheTravail() {
        }
        public void generateNewGuid() {
            _id = Guid.NewGuid();
        }
        public void initialiserToutesQuestions() {
            if (ensemblePrestation == null || ensemblePrestation.valeurs == null) {
                ensemblePrestation = returnQuestionInitialisee("Notation de la prestation dans son ensemble", new List<Note>() { new Note("1", true, false), new Note("2", true, false), new Note("3", false, false), new Note("4", false, false), new Note("5", false, true) });
                qualitePrestation = returnQuestionInitialisee("Qualite de la prestation", new List<Note>() { new Note("1", true, false), new Note("2", true, false), new Note("3", false, false), new Note("4", false, true) });
                montantHonoraires = returnQuestionInitialisee("Montant des honoraires", new List<Note>() { new Note("Trés élevés", true, false), new Note("Elevés", true, false), new Note("Adapteé", false, false), new Note("Bon marchés", false, true) });
                engagementClient = returnQuestionInitialisee("Mesure de l'engagement client", new List<Note>() { new Note("1", true, false), new Note("2", true, false), new Note("3", true, false), new Note("4", true, false), new Note("5", false, false), new Note("6", false, false), new Note("7", false, false), new Note("8", false, true), new Note("9", false, true), new Note("10", false, true) });
                mesureSelling = returnQuestionInitialisee("Mesure du cross-selling et up selling", new List<Note>() { new Note("1", true, false), new Note("2", true, false), new Note("3", false, false), new Note("4", false, true) });
                mesureQualite = returnQuestionInitialisee("Mesure de la qualité - Perception de la performance", new List<Note>() { new Note("1", true, false), new Note("2", true, false), new Note("3", false, false), new Note("4", false, true) });
                mesureEcoute = returnQuestionInitialisee("Mesure écoute client", new List<Note>() { new Note("1", true, false), new Note("2", true, false), new Note("3", false, false), new Note("4", false, true) });
            }
        }
        public QuestionNotee returnQuestionInitialisee(string question, List<Note> notesPossibles) {
            return new QuestionNotee(question, notesPossibles, new List<Valeur>()) { valeurs = notesPossibles.Select(x => new Valeur(x, 0)).ToList() };
        }
    }
}
