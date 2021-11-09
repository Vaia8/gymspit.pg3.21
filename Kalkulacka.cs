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
                        Console.WriteLine("V�sledek je: " + (numberA + numberB));
                        break;

                    case 2:
                        Console.WriteLine("V�sledek je: " + (numberA - numberB));
                        break;

                    case 3:
                        Console.WriteLine("V�sledek je: " + (numberA * numberB));
                        break;

                    case 4:
                        if (numberB == 0)
                        {
                            Console.WriteLine("Nelze d�lit nulou");
                        }
                        else
                        {
                            Console.WriteLine("V�sledek je: " + (numberA / numberB));
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
                    Console.WriteLine("Chybn� zad�n�, vyber operaci: ");
                    Console.WriteLine();
                }
                Console.WriteLine("Vyber operaci: ");
                Console.WriteLine("1 = s��t�n�");
                Console.WriteLine("2 = ode��t�n�");
                Console.WriteLine("3 = n�soben�");
                Console.WriteLine("4 = d�len�");
                Console.WriteLine("5 = odej�t");
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
            Console.WriteLine("Zadej ��slo " + name + ":");
            Console.WriteLine();
            int number;
            string s = Console.ReadLine();
            bool actionSuccess = int.TryParse(s, out number);
            while (!actionSuccess)
            {
                Console.WriteLine();
                Console.WriteLine("Neplatn� zad�n� ��sla, opakujte zad�n�: ");
                s = Console.ReadLine();
                actionSuccess = int.TryParse(s, out number);
            }
            return number;
        }

    } 
}
