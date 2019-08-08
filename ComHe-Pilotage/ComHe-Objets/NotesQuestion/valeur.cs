using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.NotesQuestion {
    public class Valeur {
        public Valeur(Note note, int nb) {
            this.note = note;
            this.nb = nb;
        }
        public Valeur() {
        }
        public Note note { get; set; }
        public int nb { get; set; }

    }
}
