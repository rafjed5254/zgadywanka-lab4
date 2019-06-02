using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        /// <summary>
        /// Generuje liczbę pseudolosową z podanego zakresu
        /// </summary>
        /// <param name="a">dowolna liczba</param>
        /// <param name="b">dowolna liczba mniejsza od int.MaxValue</param>
        /// <returns>liczba pseudolosowa z podanego zakresu</returns>
        static int Losuj(int a = 1, int b = 100)
        {
            if( a > b )
            { //swap a<-->b
                int tmp = a;
                a = b;
                b = tmp;
            }
            Random generator = new Random();
            return generator.Next(a, b+1);
        }

        static int WczytajLiczbe( string prompt = "Podaj liczbę (lub X aby zakończyć): " )
        {
            int propozycja = 0;
            while (true)
            {
                Console.Write( prompt );
                string tekst = Console.ReadLine();
                if (tekst.ToLower() == "x")
                    throw new OperationCanceledException("wprowadzono X");

                try
                {
                    propozycja = Convert.ToInt32(tekst);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby! Spróbuj jeszcze raz.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba nie mieści się w rejestrze!");
                    continue;
                }
            }

            return propozycja;
        }

        static string Ocena( int liczba )
        {
            if (liczba < wylosowana)
                return "za mało";
            else if (liczba > wylosowana)
                return "za dużo";
            else
                return "trafiono";
        }

        static int wylosowana;

        static void Main(string[] args)
        {
            int min = WczytajLiczbe("Podaj dolny zakres: ");
            int max = WczytajLiczbe("Podaj górny zakres: ");
            wylosowana = Losuj(min, max);
            Console.WriteLine($"Wylosowałem liczbę od {min} do {max}. \n Odgadnij ją");
#if(DEBUG)
            Console.WriteLine(wylosowana);
#endif
            do
            {
                int propozycja = 0;
                try
                {
                    propozycja = WczytajLiczbe("Podaj swoją prop. (lub X): ");
                }
                catch(OperationCanceledException)
                {
                    Console.WriteLine("Szkoda, że się żegnamy. Wyjście awaryjne.");
                    return;
                }

                Console.WriteLine($"Przyjąłem wartość {propozycja}");

                string wynik = Ocena(propozycja);
                Console.WriteLine(wynik);
                if (wynik == "trafiono")
                    break;
            }
            while (true);

            Console.WriteLine("Koniec gry");
        } //koniec Main
    }
}
