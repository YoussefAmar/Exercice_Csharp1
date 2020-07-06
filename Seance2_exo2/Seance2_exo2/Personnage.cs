using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance2_exo2
{
    class Personnage
    {
        public int Point_de_vie;
        Arme Arme_perso;
        public string arme;
        public string nom;
        static int NbPerso = 0;
        int g, b, d, h;


    public Personnage(Arme Arme_perso)
        {

            NbPerso++;

            this.arme = Arme_perso.nom;
            this.nom = "Link";
            this.Point_de_vie = 4;
        }

        public Personnage(string nom, Arme Arme_perso)
        {
            NbPerso++;

            this.nom = nom;
            this.arme = Arme_perso.nom;
            this.Point_de_vie = 4;

        }

        public Personnage(string nom, int Point_de_vie, Arme Arme_perso)
        {
            NbPerso++;
            this.Point_de_vie = Point_de_vie;
            this.nom = nom;
            this.arme = Arme_perso.nom;
            Console.WriteLine("Vous avez déjà choisis votre nom et vos point de vie");
        }

        public Personnage (int Point_de_vie, Arme Arme_perso)
        {
            NbPerso++;

            this.Point_de_vie = Point_de_vie;
            this.arme = Arme_perso.nom;
            this.nom = "Link";
        }
         

        public void damage()
        {
            Console.WriteLine();

            Console.WriteLine("Un ogre attaque, "+ nom + " perd un point de vie");

            Point_de_vie--;

            Console.WriteLine("Il reste " + Point_de_vie.ToString() + " point de vie à "+nom);

            Console.WriteLine();
        }

        public void heal()
        {
            Console.WriteLine();

            if (Point_de_vie == 1)
            {
                Console.WriteLine(nom +" mangez une pomme et gagne un bonus de vie");

                Point_de_vie++;

                Point_de_vie = (int)Math.Pow(Point_de_vie, Point_de_vie);
                Point_de_vie = (int)Math.Pow(Point_de_vie, 2);
            }
            else
            {
                Console.WriteLine(nom +" mange une pomme et gagne 1 point de vie");

                Point_de_vie++;
            }

            Console.WriteLine("Il reste " + Point_de_vie.ToString() + " point de vie à "+nom);

            Console.WriteLine();

        }

        public void lecture()
        {

            Console.WriteLine();

            Console.WriteLine("Personnage " + NbPerso.ToString()+" : ");

            Console.WriteLine("Point de vie : " + Point_de_vie.ToString()+" HP");
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Votre arme : "+arme);

            Console.WriteLine();

        }

        public string attaque (Personnage victime)
        {
            Console.WriteLine(nom+" attaque " + victime.nom);

            victime.Point_de_vie = victime.Point_de_vie - 2;

            Console.WriteLine(victime.nom + " possède encore " + victime.Point_de_vie + " HP");

            return ("Bien joué");

        }

        public void SeDeplace()
        {
            int choix = 0;

            Console.WriteLine();

            Console.WriteLine("Où "+nom +" voudrait aller : ");
            Console.WriteLine("1. A gauche");
            Console.WriteLine("2. A droite");
            Console.WriteLine("3. En haut");
            Console.WriteLine("4. En bas");

            do
            {

                choix = Int32.Parse(Console.ReadLine());

                switch (choix)
                {

                    case 1: g++; Console.WriteLine(nom+" avance à gauche de " + g.ToString() + " pas");Console.WriteLine(); break;

                    case 2: d++; Console.WriteLine(nom+" avance à droite de " + d.ToString() + " pas"); Console.WriteLine(); break;

                    case 3: h++; Console.WriteLine(nom+" avance tout droit de " + h.ToString() + " pas"); Console.WriteLine(); break;

                    case 4: b++; Console.WriteLine(nom+" recule de " + b.ToString() + " pas"); Console.WriteLine(); break;

                    default: choix = 0; Console.WriteLine("Veuillez entrez 1,2,3 ou 4"); Console.WriteLine(); break;

                }

                Console.WriteLine();

            } while (choix == 0);
        }

        public void SePresente()
        {
            Console.WriteLine();
            Console.WriteLine(nom + " se présente à tout le monde");
        }

        public void SeProtege()
        {
            Console.WriteLine();

            Console.WriteLine(nom + " se protège avec son/sa " + arme);
        }

    }
}