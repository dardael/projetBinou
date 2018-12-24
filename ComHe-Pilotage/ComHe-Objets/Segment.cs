using System;

namespace ComHe_Objets {

    /// <summary>
    /// Defines the <see cref="Segment" />
    /// </summary> 

    [Serializable]
    public class Segment {
        public string nom { get; set; }
        public enumTypeSegment typeSegment { get; set; }
        public double caFromLM {
            get { return _caFromLM; }
            set {
                _caFromLM = value;
                calculDonneesPossibles();
            }
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

        public double _caFromLM;
        public double _txMarge;
        public enumTxRetention _txRetention = enumTxRetention.NR;
        public double _marge;
        public enumTxActualisation _txActualisation = enumTxActualisation.NR;
        private enumTxMultiplicateur _txMuliplicateur;
        private double _clv;
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
        }
    }
}
