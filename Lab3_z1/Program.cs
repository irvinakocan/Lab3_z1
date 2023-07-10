using System;

namespace Lab3_z1
{
    class Program
    {
        static string sortirajRijecPoAbecedi(string rijec)
        {
            if (rijec.Length < 2)
                return rijec;

            char[] s = new char[rijec.Length];
            for (int i = 0; i < s.Length; i++)
                s[i] = rijec[i];

            for(int i = 0; i < s.Length - 1; i++)
                for(int j = i + 1; j < s.Length; j++)
                    if (s[i] > s[j])
                    {
                        var pomocni = s[i];
                        s[i] = s[j];
                        s[j] = pomocni;
                    }

            return string.Concat(s);
        }

        static void Main(string[] args)
        {
            List<string> listaRijeci = new List<string>();

            Console.WriteLine("Unesite spisak riječi (razdvojenih razmakom): ");
            string unos = Console.ReadLine();
            string[] pojedinacneRijeci = unos.Split(" ");

            foreach (var rijec in pojedinacneRijeci)
                if(rijec != "")
                    listaRijeci.Add(rijec);


            // uklanjanje dupliranih rijeci
            listaRijeci.RemoveAll(rijec1 =>
                listaRijeci.Where(rijec2 => rijec1 == rijec2).ToList().Count > 1);


            // prva i posljednja riječ iz spiska po abecednom poretku
            if(listaRijeci.Count > 0)
            {
                Console.WriteLine("\nPrva i posljednja rijec iz spiska po abecednom poretku: " +
                "\n {0} \n {1}",
                sortirajRijecPoAbecedi(listaRijeci[0]),
                sortirajRijecPoAbecedi(listaRijeci[listaRijeci.Count - 1]));
            }

            // popis svih unesenih riječi bez ispisivanja duplikata
            if (listaRijeci.Count > 0)
                Console.WriteLine("\nPopis svih unesenih riječi, bez duplikata:");
            foreach (var rijec in listaRijeci)
                Console.WriteLine(rijec);
            
        }
    }
}