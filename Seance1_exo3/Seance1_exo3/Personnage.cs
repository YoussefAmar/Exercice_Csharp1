using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance1_exo3
{
    class Personnage
    {
        public int Point_de_vie;
        private string arme = "Hache";
        public string nom;

        public Personnage()
        {

            this.nom = creation_nom();
            this.Point_de_vie = creation_vie();
        }

        public void damage()
        {
            Console.WriteLine();

            Console.WriteLine("Un ogre vous attaque, "+nom +" perd un point de vie");

            Point_de_vie--;

            Console.WriteLine("Il vous reste " + Point_de_vie.ToString() + " point de vie");

            Console.WriteLine();
        }

        public void heal()
        {
            Console.WriteLine();

            Console.WriteLine("Vous mangez une pomme, " +nom +" gagne 1 point de vie");

            Point_de_vie++;

            Console.WriteLine("Il vous reste " + Point_de_vie.ToString() + " point de vie");

            Console.WriteLine();

        }

        public string creation_nom()
        {
            Console.Write("Nom : ");

            string nom = Console.ReadLine();

            return (nom);

        }

        public int creation_vie()
        {
            Console.Write("Point de vie : ");

            int vie = Int32.Parse(Console.ReadLine());

            return (vie);
        }

        public void lecture()
        {
            
            Console.WriteLine();

            Console.WriteLine("Personnage : ");

            Console.WriteLine("Point de vie : " + Point_de_vie.ToString());
            Console.WriteLine("Nom : "+nom);
            Console.WriteLine("Votre arme par défaut : " + arme);

            Console.WriteLine();

        }
    }
}
