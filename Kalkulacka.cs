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

                int numberA = ReadNumber("A");

                int numberB = ReadNumber("B");

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
                        if (numberB == 0)
                        {
                            Console.WriteLine("Nelze dìlit nulou");
                        }
                        else
                        {
                            Console.WriteLine("Výsledek je: " + (numberA / numberB));
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
        static int ReadOperation()
        {
            bool firstEntry = true;
            int operation = 1;
            bool actionSuccess = true;
            while (!actionSuccess || operation > 5 || operation < 1 || firstEntry)
            {
                firstEntry = false;
                if (!actionSuccess || operation > 5 || operation < 1)
                {
                    Console.WriteLine("Chybné zadání, vyber operaci: ");
                    Console.WriteLine();
                }
                Console.WriteLine("Vyber operaci: ");
                Console.WriteLine("1 = sèítání");
                Console.WriteLine("2 = odeèítání");
                Console.WriteLine("3 = násobení");
                Console.WriteLine("4 = dìlení");
                Console.WriteLine("5 = odejít");
                string s = Console.ReadLine();
                actionSuccess = int.TryParse(s, out operation);

            }
            if (operation == 5)
            {
                System.Environment.Exit(0);
            }
            return operation;

        }
        static int ReadNumber(string name)
        {
            
            Console.WriteLine();
            Console.WriteLine("Zadej èíslo " + name + ":");
            Console.WriteLine();
            int number;
            string s = Console.ReadLine();
            bool actionSuccess = int.TryParse(s, out number);
            while (!actionSuccess)
            {
                Console.WriteLine();
                Console.WriteLine("Neplatné zadání èísla, opakujte zadání: ");
                s = Console.ReadLine();
                actionSuccess = int.TryParse(s, out number);
            }
            return number;
        }

    } 
}
