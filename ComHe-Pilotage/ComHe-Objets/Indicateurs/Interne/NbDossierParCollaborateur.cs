using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Interne {
    public class NbDossierParCollaborateur {
        public int nbDossier { get; set; }
        public int nbCollaborateurs { get; set; }
        public double moyenne { get { return nbCollaborateurs > 0 ? nbDossier / (double)nbCollaborateurs : 0; } }
    }
}
