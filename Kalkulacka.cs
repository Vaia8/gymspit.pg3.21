using System;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int operation = ReadOperation();

               /* if (operation == 5)
                {
                    return;
                }
                */
                Console.WriteLine();
                Console.WriteLine("Zadej číslo A: ");
                Console.WriteLine();

                int numberA;
                string s = Console.ReadLine();
                bool actionSuccess = int.TryParse(s, out numberA);

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
                        if (numberB < 1)
                        {
                            Console.WriteLine("Nelze dělit nulou");
                        }
                        else Console.WriteLine("Výsledek je: " + (numberA / numberB));
                        break;
                }
            }
            Console.WriteLine("Pro ukončení zmáčkněte enter.");
            Console.ReadLine();


        }
        static int ReadOperation()
            {
            int operation = 0;
            bool actionSuccess = true;
            while (!actionSuccess || operation > 5 || operation < 1)
            {
                Console.WriteLine();
                if (!actionSuccess || operation > 5 || operation < 1)
                   {
                    Console.WriteLine("Chybné zadání, vyber operaci: ");
                }
                    PrintOperationInstruction();
                    string s = Console.ReadLine();
                    actionSuccess = int.TryParse(s, out operation);
                
            }
            if (operation == 5)
            {
                System.Environment.Exit(0);
            }
            return operation;

        }
        static void PrintOperationInstruction ()
        {
            Console.WriteLine();
            Console.WriteLine("Vyber operaci: ");
            Console.WriteLine("1 = sčítání");
            Console.WriteLine("2 = odečítání");
            Console.WriteLine("3 = násobení");
            Console.WriteLine("4 = dělení");
            Console.WriteLine("5 = odejít");
        }
    }
}
