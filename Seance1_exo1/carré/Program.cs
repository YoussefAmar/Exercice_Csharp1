using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_carré
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour");

            int i, a = 0, b = 0;

            for (i = 0; a < 10; i++)
            {

                b = (a * a);

                Console.WriteLine("Carré de : " + a.ToString() + " vaut : " + b.ToString());

                a = a + 1;

                Console.ReadLine();

            }
        }
    }
}