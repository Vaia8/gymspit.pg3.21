using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyber operaci: ");
            Console.WriteLine("1 = sčítání");
            Console.WriteLine("2 = odečítání");
            Console.WriteLine("3 = násobení");
            Console.WriteLine("4 = dělení");
            Console.WriteLine("5 = odejít");

            int operation;
            string s = Console.ReadLine();
            bool actionSuccess = int.TryParse(s, out operation);
            while (operation !=5) {
            while (!actionSuccess || operation > 4 || operation < 1)
            {
                Console.WriteLine();
                Console.WriteLine("Chybné zadání, vyber operaci: ");
                Console.WriteLine("1 = sčítání");
                Console.WriteLine("2 = odečítání");
                Console.WriteLine("3 = násobení");
                Console.WriteLine("4 = dělení");

                s = Console.ReadLine();
                actionSuccess = int.TryParse(s, out operation);
            }

            Console.WriteLine();
            Console.WriteLine("Zadej číslo A: ");
            Console.WriteLine();

            int numberA;
            s = Console.ReadLine();
            actionSuccess = int.TryParse(s, out numberA);

            while (!actionSuccess)
            {
                Console.WriteLine();
                Console.WriteLine("Neplatné zadání čísla, prosím zadej číslo A: ");
                s = Console.ReadLine();
                actionSuccess = int.TryParse(s, out numberA);

            }

            Console.WriteLine();
            Console.WriteLine("Zadej číslo B: ");
            Console.WriteLine();

            int numberB;
            s = Console.ReadLine();
            actionSuccess = int.TryParse(s, out numberB);

            while (!actionSuccess)
            {
                Console.WriteLine();
                Console.WriteLine("Neplatné zadání čísla, prosím zadej číslo B: ");
                s = Console.ReadLine();
                actionSuccess = int.TryParse(s, out numberB);
            }

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Výsledek je: " + (numberA + numberB));
                    break;

                case 2:
                    Console.WriteLine("Výsledek je: " + (numberA - numberB));
                    break;

                case 3:
                    Console.WriteLine("Výsledek je: " + (numberA * numberB));
                    break;

                case 4:
                        if (numberB = 0) {
                            Console.WriteLine("Nelze dělit nulou");
                        }
                    else Console.WriteLine("Výsledek je: " + (numberA / numberB));
                    break;
            }
            }
            Console.WriteLine("Pro ukončení zmáčkněte enter.");
            Console.ReadLine();
            
            
        }
    }
}
