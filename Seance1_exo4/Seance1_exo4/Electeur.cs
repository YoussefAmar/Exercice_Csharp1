using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance1_exo4
{
    class Electeur
    {
       public int bulletin_de_vote;
       public char sexe;
       public int vote;

        public Electeur()
        {
            this.sexe = choix();
            this.bulletin_de_vote = votage(this.sexe);
            this.vote = comptage(this.bulletin_de_vote, this.sexe);
        }

        public char choix()
        {
            char sex;

            do
            {
                Console.WriteLine("Êtes-vous un homme ou une femme (m ou f)?");
                Console.Write("Choix : ");

                sex = Char.Parse(Console.ReadLine());
            }

            while (sex != 'm' && sex != 'f');

            return (sex);

        }

       public int votage(char sexe)
        {
            int i = 0;

            do
            {
                Console.WriteLine();

                Console.WriteLine("Veuillez voter (1 pour Trump et 2 pour Hilary)");

                i = Int32.Parse(Console.ReadLine());
            }
            while (i != 1 && i != 2);

            return (i);

        }

        private int comptage(int i, char sexe)
        {
            if (i == 1)
            {
                if (sexe == 'm')
                    return (2);
                else return (1);
            }
            if (i == 2)
            {
                if (sexe == 'm')
                    return (-2);
                else return (-1);
            }

            else return (0);
        }

    }
}
