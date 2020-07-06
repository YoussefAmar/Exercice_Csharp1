using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance1_exo4
{
    class Participant
    {
        public string nom;
        private int valeur;
        public Participant(int valeur)
        {
            if(valeur >= 0)
            this.nom = "Trump";

            if (valeur <= 0)
                this.nom = "Hilary";

            if(valeur == 0)

                this.nom = "Personne";

        }
        public void gagnant(string nom)
        {
            Console.WriteLine();

            Console.WriteLine("Le gagnant est " + nom);

            Console.ReadLine();

        }
    }

     
}
