using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance2_exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            voiture Peugeot = new voiture(1024,"Peugeot");
            voiture Audi = new voiture(1031,"Audi");
            voiture Golf = new voiture(1000,"Golf");
           
            Feu_de_signalisation Avroy = new Feu_de_signalisation(Peugeot);

            Feu_de_signalisation Sauveniere = new Feu_de_signalisation(2,Audi);

            Feu_de_signalisation Sohet = new Feu_de_signalisation(2, 5, 7,Golf);

            Console.WriteLine();
            Console.WriteLine("Nombre de feu : " + Feu_de_signalisation.NbFeu);

            Sohet.change();
            Sohet.change();
            Sohet.change();

            Avroy.change();
            Avroy.change();
            Avroy.change();

            Sauveniere.change();
            Sauveniere.change();
            Sauveniere.change();

            Sohet.clignote();
            Sohet.clignote(3);

            Console.ReadLine();
        }
    }
}

