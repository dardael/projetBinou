using System;

namespace ComHe_Objets {

    /// <summary>
    /// Defines the <see cref="Segment" />
    /// </summary> 

    [Serializable]
    public class Segment {
        private Guid _id = Guid.NewGuid();
        public Guid id { get { return _id; } }
        public string nom { get; set; }
        public double caRecommendation { get; set; }
        public double caAchatsCroises { get; set; }
        public double caSensibilitePricePremium { get; set; }
        public double caWACC { get; set; }
        public double coutAcquisition { get; set; }
        public String totalQuatreChemins {
            get { return (noteBoucheAOreille + notePricePremium + noteReductionCouts + noteAugmentationDepensesAchatsCroises) + "/40"; }
        }
        public enumTypeSegment typeSegment { get; set; }
        public double caFromLM {
            get { return _caFromLM; }
            set {
                _caFromLM = value;
                calculDonneesPossibles();
            }
        }
        public void generateNewGuid() {
            _id = Guid.NewGuid();
        }
        public double txMarge {
            get { return _txMarge; }
            set {
                _txMarge = value;
                calculDonneesPossibles();
            }
        }
        public enumTxRetention txRetention {
            get { return _txRetention; }
            set {
                _txRetention = value;
                calculDonneesPossibles();
            }
        }
        public double marge {
            get { return _marge; }
        }
        public enumTxActualisation txActualisation {
            get { return _txActualisation; }
            set {
                _txActualisation = value;
                calculDonneesPossibles();
            }
        }
        public enumTxMultiplicateur txMultiplicateur {
            get {
                return _txMuliplicateur;
            }
        }

        public double clv {
            get {
                return _clv;
            }
        }
        public double clvSansTxMarge {
            get {
                return _clvSansTxMarge;
            }
        }

        public double _caFromLM;
        public double _txMarge;
        public enumTxRetention _txRetention = enumTxRetention.NR;
        public double _marge;
        public enumTxActualisation _txActualisation = enumTxActualisation.NR;
        private enumTxMultiplicateur _txMuliplicateur;
        private double _clv;
        private double _clvSansTxMarge;
        public int noteBoucheAOreille { get; set; }
        public int noteReductionCouts { get; set; }
        public int noteAugmentationDepensesAchatsCroises { get; set; }
        public int notePricePremium { get; set; }
        public int nbPersonne0NPS { get; set; }
        public int nbPersonne1NPS { get; set; }
        public int nbPersonne2NPS { get; set; }
        public int nbPersonne3NPS { get; set; }
        public int nbPersonne4NPS { get; set; }
        public int nbPersonne5NPS { get; set; }
        public int nbPersonne6NPS { get; set; }
        public int nbPersonne7NPS { get; set; }
        public int nbPersonne8NPS { get; set; }
        public int nbPersonne9NPS { get; set; }
        public int nbPersonne10NPS { get; set; }
        public int nbPersonne0CES { get; set; }
        public int nbPersonne1CES { get; set; }
        public int nbPersonne2CES { get; set; }
        public int nbPersonne3CES { get; set; }
        public int nbPersonne4CES { get; set; }
        public int nbPersonne5CES { get; set; }
        public double scoreNPS {
            get {
                int nbTotal = nbPersonne0NPS + nbPersonne1NPS + nbPersonne10NPS + nbPersonne2NPS + nbPersonne3NPS + nbPersonne4NPS + nbPersonne5NPS + nbPersonne6NPS + nbPersonne7NPS + nbPersonne8NPS + nbPersonne9NPS;
                if (nbTotal > 0) {
                    int nbDetracteur = nbPersonne0NPS + nbPersonne1NPS + nbPersonne2NPS + nbPersonne3NPS + nbPersonne4NPS + nbPersonne5NPS + nbPersonne6NPS;
                    int nbPromoteur = nbPersonne10NPS + nbPersonne9NPS;
                    return ((double)nbPromoteur / (double)nbTotal) - ((double)nbDetracteur / (double)nbTotal);
                }
                else {
                    return 0;
                }
            }
        }
        public double scoreCES {
            get {
                int nbTotal = nbPersonne0CES + nbPersonne1CES + nbPersonne2CES + nbPersonne3CES + nbPersonne4CES + nbPersonne5CES;
                if (nbTotal > 0) {
                    int nbDetracteur = nbPersonne0CES + nbPersonne1CES + nbPersonne2CES + nbPersonne3CES;
                    int nbPromoteur = nbPersonne5CES;
                    double value = ((double)nbPromoteur / (double)nbTotal) - ((double)nbDetracteur / (double)nbTotal);
                    return value;
                }
                else {
                    return 0;
                }
            }
        }
        public Segment() {

        }

        public Segment(string nom, enumTypeSegment typeSegment, double caFromLM, double txMarge, enumTxRetention txRetention, enumTxActualisation txActualisation) {
            this.nom = nom;
            this.typeSegment = typeSegment;
            this.caFromLM = caFromLM;
            this.txMarge = txMarge;
            this.txRetention = txRetention;
            this.txActualisation = txActualisation;
        }
        public void calculDonneesPossibles() {
            _marge = _caFromLM * txMarge;
            _txMuliplicateur = enumTxMultiplicateurMethods.getTxMargeFromTxRetentionEtTauxActualisation(_txActualisation, _txRetention);
            _clv = caFromLM * txMarge * enumTxMultiplicateurMethods.getDoubleFromCode(txMultiplicateur);
            _clvSansTxMarge = caFromLM * enumTxMultiplicateurMethods.getDoubleFromCode(txMultiplicateur);
        }
    }
}
