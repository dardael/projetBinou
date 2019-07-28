using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Interne {
    public class IndicateursInternes {
        public DefaillanceCabinet defaillanceCabinet { get; set; }
        public DefaillanceControleFiscal defaillanceControleFiscal { get; set; }
        public NbDossierParCollaborateur nbDossierParCollaborateur { get; set; }
        public ReductionTempsProduction reductionTempsProduction { get; set; }
        public TauxDossiersNonRentables tauxDossiersNonRentables { get; set; }
        public TauxRemonteesReclamation tauxRemonteesReclamation { get; set; }
        public TauxRetardDepotDossier tauxRetardDepotDossier { get; set; }
        public TauxSatisfaction tauxSatisfaction { get; set; }
    }
}
