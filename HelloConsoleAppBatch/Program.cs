using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleAppBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie = "";
            string nazwisko = "";
            int wiek;

            if(args.Length == 0)
            {
                Console.WriteLine("Wprowadz imie: ");
                imie = Console.ReadLine();

                Console.WriteLine("Wprowadz nazwisko: ");
                nazwisko = Console.ReadLine();

                Console.WriteLine("Wprowadz wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Witaj " + imie + " " + nazwisko);

                if (wiek > 0 && wiek < 67)
                {
                    Console.WriteLine("Do emerytury zostało Ci {0} lat.", 67 - wiek);
                }
                else if (wiek < 0)
                {
                    Console.WriteLine("Błędne dane!");
                }
                else
                {
                    Console.WriteLine("Jesteś emerytem");
                }
            }

            else if(args.Length == 1)
            {
                imie = args[0];

                Console.Write("Wprowadz nazwisko: ");
                nazwisko = Console.ReadLine();

                Console.Write("Wprowadz wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Witaj " + imie + " " + nazwisko);

                if (wiek > 0 && wiek < 67)
                {
                    Console.WriteLine("Do emerytury zostało Ci {0} lat.", 67 - wiek);
                }
                else if (wiek < 0)
                {
                    Console.WriteLine("Błędne dane!");
                }
                else
                {
                    Console.WriteLine("Jesteś emerytem");
                }
            }

            else if(args.Length == 2)
            {
                imie = args[0];
                nazwisko = args[1];

                Console.Write("Wprowadz wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Witaj " + imie + " " + nazwisko);

                if (wiek > 0 && wiek < 67)
                {
                    Console.WriteLine("Do emerytury zostało Ci {0} lat.", 67 - wiek);
                }
                else if (wiek < 0)
                {
                    Console.WriteLine("Błędne dane!");
                }
                else
                {
                    Console.WriteLine("Jesteś emerytem");
                }
            }

            else if(args.Length >= 3)
            {
                imie = args[0];
                nazwisko = args[1];
                wiek = Convert.ToInt32(args[2]);

                if (wiek > 0 && wiek < 67)
                {
                    Console.WriteLine("Do emerytury zostało Ci {0} lat.", 67 - wiek);
                }
                else if (wiek < 0)
                {
                    Console.WriteLine("Błędne dane!");
                }
                else
                {
                    Console.WriteLine("Jesteś emerytem");
                }
            }
        }
    }
}
