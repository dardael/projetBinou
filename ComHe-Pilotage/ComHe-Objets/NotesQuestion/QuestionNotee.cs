using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComHe_Objets.NotesQuestion {
    public class QuestionNotee {
        public string question;

        public QuestionNotee(string question, List<Note> notesPossibles, List<Valeur> valeurs) {
            this.question = question;
            this.notesPossibles = notesPossibles;
            this.valeurs = valeurs;
        }
        public QuestionNotee() {
        }

        public List<Note> notesPossibles { get; set; }
        public List<Valeur> valeurs { get; set; }
        public double score {
            get {
                if (valeurs != null) {
                    int nbTotal = valeurs.Sum(x => x.nb);
                    if (nbTotal > 0) {
                        int nbDetracteur = valeurs.Where(x => x.note.isDetracteur).Sum(x => x.nb);
                        int nbPromoteur = valeurs.Where(x => x.note.isPromoteur).Sum(x => x.nb);
                        return ((double)nbPromoteur / (double)nbTotal) - ((double)nbDetracteur / (double)nbTotal);
                    }
                    else {
                        return 0;
                    }
                }
                else {
                    return 0;
                }
            }
        }

    }
}
