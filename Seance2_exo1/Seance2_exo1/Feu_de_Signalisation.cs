using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance2_exo1
{
    class Feu_de_signalisation
    {

        public int couleur = 0;
        public int position;
        public int hauteur;
        public static int NbFeu = 0;

        voiture voiture_feu;

        public Feu_de_signalisation(voiture voiture_feu)
        {
            NbFeu++;
            this.voiture_feu = voiture_feu;
            couleur = 2;
            position = 45;
            hauteur = 7;

        }

        public Feu_de_signalisation(int couleur, voiture voiture_feu)
        {
            NbFeu++;
            this.voiture_feu = voiture_feu;
            this.couleur = couleur;
            this.position = 45;
            this.hauteur = 7;

        }

        public Feu_de_signalisation(int couleur, int position, int hauteur, voiture voiture_feu)
        {
            NbFeu++;
            this.voiture_feu = voiture_feu;
            this.couleur = couleur;
            this.position = position;
            this.hauteur = hauteur;

        }


        public void change()
        {
            couleur = couleur + 1;

            if (couleur == 4) couleur = 1;

            if (couleur == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("O");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Le feu est vert, vous pouvez avancer");

                this.voiture_feu.demarre();

                Console.WriteLine("La "+voiture_feu.marque+" "+ voiture_feu.numchassis.ToString() +" est "+voiture_feu.etat);
            }

            if (couleur == 3)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("O");

                Console.ForegroundColor = ConsoleColor.White;
            }

            if (couleur == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("O");

                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public void clignote()
        {

            for (int i = 0; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("O");
            }
        }

        public void clignote(int a)
        {
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < a; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O");
            }
        }


    }
}
