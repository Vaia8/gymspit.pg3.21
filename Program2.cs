﻿using System;
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

            string action = Console.ReadLine();
            bool action_success = int.TryParse(action, out action_result);

            while (!action_success || action_result > 4) ;
            {
                Console.WriteLine();
                Console.WriteLine("Chybné zadání, vyber operaci: ");
                Console.WriteLine("1 = sčítání");
                Console.WriteLine("2 = odečítání");
                Console.WriteLine("3 = násobení");
                Console.WriteLine("4 = dělení");

                action = ConsoleReadLine();


            Console.WriteLine();
            Console.WriteLine("Napiš číslo A: ");
            Console.WriteLine();

                string numA_result;
                bool numA_success = int.TryParse


            Console.WriteLine();
            Console.WriteLine("Napiš číslo B: ");
            Console.WriteLine();

                string numB_result;
                bool numB_success = int.TryParse


            switch (action_result)
                {
                    case 1:
                            Console.WriteLine("Výsledek je: " + numA_result + numB_result);
                            break;

                        case 2:
                            Console.WriteLine("Výsledek je: " + numA_result - numB_result);
                            break;

                        case 3:
                            Console.WriteLine("Výsledek je: " + numA_result * numB_result);
                            break;

                        case 4:
                            Console.WriteLine("Výsledek je: " + numA_result / numB_result);
                            break;
                }
            
        }
    }
}
