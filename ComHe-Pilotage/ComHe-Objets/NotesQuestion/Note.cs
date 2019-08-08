using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.NotesQuestion {
    public class Note {
        public Note(string valeur, bool isDetracteur, bool isPromoteur) {
            this.valeur = valeur;
            this.isDetracteur = isDetracteur;
            this.isPromoteur = isPromoteur;
        }
        public Note() {
        }
        public string valeur { get; set; }
        public Boolean isDetracteur { get; set; }
        public Boolean isPromoteur { get; set; }
    }
}
