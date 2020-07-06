using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance1_exo3
{
    class Program
    {
        static void Main(string[] args)
        {

             Personnage A = new Personnage();

            A.lecture();

            Personnage B = new Personnage();

            B.lecture();

            Personnage C = new Personnage();

            C.lecture();

            A.damage();
            B.heal();
            C.heal();
            C.damage();

            Console.ReadLine();
        }
    }
}
