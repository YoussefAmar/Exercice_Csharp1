using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace tableau_entier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            int[] vecteur = new int[10];

            int a, i, cpt, h = 0, v = 0;

            Console.WriteLine("Veuillez entrez dix valeurs ( 1 pour descendre ou 2 pour aller à droite)");

            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Encore : " + (10 - i).ToString() + " à ajouter");
                    a = Int32.Parse(Console.ReadLine());
                }
                while (a != 1 && a != 2);

                vecteur[i] = a;

            }

            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {

                if (vecteur[i] == 1)
                {

                    tab[h] = 1;

                    for (cpt = 0; cpt < 10; cpt++)

                    {
                        Console.Write(" ");
                        Console.Write(tab[cpt]);
                        Console.Write(" ");

                        if (h > 0)
                        {
                            tab[h - v] = 0;

                        }
                    }

                    Console.WriteLine();
                }

                else if (vecteur[i] == 2)
                {
                    v = v + 1;
                    h = h + 1;
                    tab[h] = 1;

                    for (cpt = 0; cpt < 10; cpt++)

                    {
                        Console.Write(" ");
                        Console.Write(tab[cpt]);
                        Console.Write(" ");

                        if (h > 0)
                        {
                            tab[h - v] = 0;

                        }
                    }
                }


            }
            Console.ReadLine();
        }
    }
}

