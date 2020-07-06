using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Seance2_exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arme Default = new Arme();

            Arme Lance = new Arme("Lance");

            Arme Epee = new Arme("Epee");

            Arme Arc = new Arme("Arc");

            Personnage Roy = new Personnage("Roy",30,Epee);

            Roy.lecture();

            Personnage Lancer = new Personnage("Lancer",Lance);

            Lancer.lecture();

            Personnage Robin = new Personnage("Robin",Arc);

            Robin.lecture();

            Personnage Link = new Personnage(1, Default);

            Link.lecture();

            Console.ReadLine();

            Roy.damage();
            Lancer.heal();
            Robin.heal();
            Robin.damage();
            Link.heal();

            Console.ReadLine();

            Lancer.SeProtege();
            Robin.SeDeplace();
            Link.SeDeplace();
            Link.SeDeplace();

            Console.ReadLine();

            Console.WriteLine(Roy.attaque(Robin));

            ArrayList Groupe = new ArrayList();
            Groupe.Add(Roy);
            Groupe.Add(Lancer);
            Groupe.Add(Robin);
            Groupe.Add(Link);

            foreach (Personnage element in Groupe)
            {
                Console.WriteLine(element.nom +" se lève : ");

                element.SePresente();

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
