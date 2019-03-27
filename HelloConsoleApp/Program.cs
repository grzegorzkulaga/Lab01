using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Program na powitanie.");

            string imie;
            Console.Write("Wprowadz Imię: ");
            imie = Console.ReadLine();

            string nazwisko;
            Console.Write("Wprowadz Nazwisko: ");
            nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);
            */
            Console.Write("Wprowadz wiek: ");
            //int wiek = Console.ReadLine();
            int wiek = Convert.ToInt32(Console.ReadLine());

            if(wiek > 0 && wiek < 67)
            {
                Console.WriteLine("Do emerytury zostało Ci {0} lat.", 67 - wiek);
            }
            else if(wiek < 0)
            {
                Console.WriteLine("Błędne dane!");
            }

        }
    }
}
