using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.Indicateurs.Client {
    public class TauxDeRetentionClient {
        public int nbClientsFinPeriode { get; set; }
        public int nbNvxClients { get; set; }
        public double variation { get { return nbClientsFinPeriode > 0 ? (nbClientsFinPeriode - nbNvxClients) / (double)nbClientsFinPeriode : 0; } }
    }
}
