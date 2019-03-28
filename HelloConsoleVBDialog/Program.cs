using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HelloConsoleVBDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interaction.MsgBox("Aplikacja na powitanie!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Tytuł okienka");

            string imie = Interaction.InputBox("Wprowadz imie", "Okienko imię");
            Console.WriteLine("Podano imię " + imie);

            string nazwisko = Interaction.InputBox("Wprowadz nazwisko", "Okienko nazwisko");
            Console.WriteLine("Podano nazwisko " + nazwisko);

            Interaction.MsgBox("Witaj " + imie + " " + nazwisko);
            Interaction.MsgBox(string.Format("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko));

            int wiek = Convert.ToInt32(Interaction.InputBox("Wprowadz wiek ", "Okienko wiek"));

            if (wiek > 0 && wiek < 67)
            {

                Interaction.MsgBox("Do emerytury zostało Ci " + (67 - wiek) + "lat", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko Emerytura");
            }
            else if (wiek < 0)
            {
                Interaction.MsgBox("Błędne dane!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
            }
            else
            {
                Interaction.MsgBox("Jesteś emerytem", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
            }
        }
    }
}
