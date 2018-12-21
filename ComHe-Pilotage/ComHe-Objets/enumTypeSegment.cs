namespace ComHe_Objets {
    /// <summary>
    /// Defines the enumTypeSegment
    /// </summary>
    public enum enumTypeSegment {
        /// <summary>
        /// Defines the BNC
        /// </summary>
        BNC,
        /// <summary>
        /// Defines the INDIV
        /// </summary>
        INDIV,
        /// <summary>
        /// Defines the TPE_INF_500
        /// </summary>
        TPE_INF_500,
        /// <summary>
        /// Defines the TPE_SUP_500
        /// </summary>
        TPE_SUP_500,
        /// <summary>
        /// Defines the START_UP
        /// </summary>
        START_UP,
        /// <summary>
        /// Defines the TPE_RESTO
        /// </summary>
        TPE_RESTO,
        /// <summary>
        /// Defines the PME_SANS_CAC
        /// </summary>
        PME_SANS_CAC,
        /// <summary>
        /// Defines the PME_AVEC_CAC
        /// </summary>
        PME_AVEC_CAC
    }
    static class enumTypeSegmentMethods {
        public static string getStringFromCode(this enumTypeSegment code) {
            switch (code) {
                case enumTypeSegment.BNC: return "BNC";
                case enumTypeSegment.INDIV: return "Entreprise individuelle hors restaurateur";
                case enumTypeSegment.TPE_INF_500: return "TPE < 500 k€ de CA";
                case enumTypeSegment.TPE_SUP_500: return "TPE > 500 k€ de CA mais ne répondant pas la définition fiscale de la PME";
                case enumTypeSegment.START_UP: return "Start-UP";
                case enumTypeSegment.TPE_RESTO: return "TPE – Restaurateur";
                case enumTypeSegment.PME_SANS_CAC: return "PME sans CAC";
                case enumTypeSegment.PME_AVEC_CAC: return "PME groupe de sociétés avec CAC";
                default: return "";
            }

        }
    }

}
