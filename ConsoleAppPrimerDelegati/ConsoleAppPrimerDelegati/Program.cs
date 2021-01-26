using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrimerDelegati
{
    class Program
    { 
        ///1. definiraj si tip delegat
        //public delegate bool FunkcijaZaNize(string s);

        ///2. napiši metodo, ki sprejme tega delegata kot parameter
        public static List<string> DelajOperacijeNadNizi(string[] m, Func<string, bool> mojaFunkcija)
        {
            List<string> rezultat = new List<string>();
            foreach (var s in m)
            {
                if (mojaFunkcija(s))
                {
                    rezultat.Add(s);
                }
            }
            return rezultat;
        }

        ///3. napiši metode, ki so tipa FunkcijaZaNize
        //public static bool ZačneZA(string s)
        //{
        //    return s.StartsWith("A");
        //}
        public static bool KončaZN(string s)
        {
            return s.EndsWith("n");
        }

        static void Main(string[] args)
        {
            string[] mojiNizi = { "Adam", "Alan", "Bob", "Steve", "Jim", "Aiden"};

            //FunkcijaZaNize an = delegate (string s) { return s.StartsWith("A"); };

            //List<string> aji = DelajOperacijeNadNizi(mojiNizi, delegate (string s) { return s.StartsWith("A"); }); //uporaba anonimnih metod
            //List<string> nji = DelajOperacijeNadNizi(mojiNizi, KončaZN);

            ///anonimna koda z lambda izrazom
            List<string> aji = DelajOperacijeNadNizi(mojiNizi, s => s.StartsWith("A"));
            List<string> nji = DelajOperacijeNadNizi(mojiNizi, s => s.EndsWith("n"));

            foreach (var x in aji)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }


    }
}
