using System;

namespace ModelGry
{
    public class Gra
    {
        // inner types
        public enum Odpowiedz {ZaMalo = -1, Trafiono = 0, ZaDuzo = 1}
        public enum StanGry { Trwa, Odgadnieta, Poddana }

        //fields
        public readonly int ZakresOd;
        public readonly int ZakresDo;
        //---
        private readonly int wylosowana;
        public int? Wylosowana
        {
            get
            {
                if (Stan == StanGry.Poddana || Stan == StanGry.Odgadnieta)
                    return wylosowana;
                else
                    return null;
            }
            //set { }
        }
        //--

        public int LicznikRuchow { get; private set; } = 0;
        //historia gry

        public StanGry Stan { get; private set; }

        public Gra(int a, int b)
        {
            ZakresOd = Math.Min(a,b);
            ZakresDo = Math.Max(a,b);
            //losowanie
            wylosowana = Losuj(ZakresOd, ZakresDo);
            //LicznikRuchow = 0;
            Stan = StanGry.Trwa;
        }

        public Odpowiedz Ocena( int propozycja )
        {
            LicznikRuchow++;
            if (propozycja < wylosowana)
                return Odpowiedz.ZaMalo;
            else if (propozycja > wylosowana)
                return Odpowiedz.ZaDuzo;
            else
            {
                Stan = StanGry.Odgadnieta;
                return Odpowiedz.Trafiono;
            }
        }

        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }

        public static int Losuj(int a = 1, int b = 100)
        {
            if (a > b)
            { //swap a<-->b
                int tmp = a;
                a = b;
                b = tmp;
            }
            Random generator = new Random();
            return generator.Next(a, b + 1);
        }

    }// koniec klasy

}