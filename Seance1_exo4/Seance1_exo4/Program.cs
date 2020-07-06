using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance1_exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeur_gagnant = 0;

             Electeur A = new Electeur();
             Electeur B = new Electeur();
             Electeur C = new Electeur();
             Electeur D = new Electeur();

            valeur_gagnant = A.vote + B.vote + C.vote + D.vote;
           
            Participant Winner = new Participant(valeur_gagnant);

            Winner.gagnant(Winner.nom);
          
        }
    }
}
