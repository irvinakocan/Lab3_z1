using System;

namespace Lab3_z1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaRijeci = new List<string>();

            Console.WriteLine("Unesite spisak riječi (razdvojenih razmakom): ");
            string unos = Console.ReadLine();
            string[] pojedinacneRijeci = unos.Split(" ");

            foreach (var rijec in pojedinacneRijeci)
                listaRijeci.Add(rijec);


            // uklanjanje dupliranih rijeci
            listaRijeci.RemoveAll(rijec1 =>
                listaRijeci.Where(rijec2 => rijec1 == rijec2).ToList().Count > 1);

            // popis svih unesenih riječi bez ispisivanja duplikata
            foreach (var rijec in listaRijeci)
                Console.WriteLine(rijec);


        }
    }
}