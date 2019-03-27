using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Program na powitanie.");

            string imie = "";
            string nazwisko = "";
            int wiek;
            /*
            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);
            
            Console.Write("Wprowadz wiek: ");
            //int wiek = Console.ReadLine();
            */
            if (args.Length == 0)
            {
                Console.WriteLine("Brak danych");
            }
            else if (args.Length == 1)
            {
                imie = args[0];
                Console.WriteLine("Witaj" + imie);
            }
            else if (args.Length == 2)
            {
                imie = args[0];
                nazwisko = args[1];
                Console.WriteLine("Witaj" + imie + " " + nazwisko);
            }
            else if (args.Length >= 3)
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
