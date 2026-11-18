using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Program
{
    internal class Program
    {
        static void Kiir(List<object> sor)
        {
            int i = 0;

            for (int szam = 1; szam <= 20; szam++)
            {
                if (i < sor.Count && Convert.ToInt16(sor[i]) == szam)
                {
                    Console.Write($"{sor[i],4}");
                    i++;
                }
                else
                {
                    Console.Write($"{"X",4}");
                }
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<object> sor_egy = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<object> sor_ketto = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<object> sor_harom = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<object> sor_negy = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<object> sor_ot = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<object> sor_hat = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<object> sor_het = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<object> sor_nyolc = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<object> sor_kilenc = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<object> sor_tiz = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            List<object> foglalt_sor_egy = new List<object> { };
            List<object> foglalt_sor_ketto = new List<object> { };
            List<object> foglalt_sor_harom = new List<object> { };
            List<object> foglalt_sor_negy = new List<object> { };
            List<object> foglalt_sor_ot = new List<object> { };
            List<object> foglalt_sor_hat = new List<object> { };
            List<object> foglalt_sor_het = new List<object> { };
            List<object> foglalt_sor_nyolc = new List<object> { };
            List<object> foglalt_sor_kilenc = new List<object> { };
            List<object> foglalt_sor_tiz = new List<object> { };

            for (int i = 0; i < 6; i++)
            {
                int hely = rnd.Next(sor_egy.Count);
                foglalt_sor_egy.Add(sor_egy[hely]);
                sor_egy.Remove(sor_egy[hely]);

                hely = rnd.Next(sor_ketto.Count);
                foglalt_sor_ketto.Add(sor_ketto[hely]);
                sor_ketto.Remove(sor_ketto[hely]);

                hely = rnd.Next(sor_harom.Count);
                foglalt_sor_harom.Add(sor_harom[hely]);
                sor_harom.Remove(sor_harom[hely]);

                hely = rnd.Next(sor_negy.Count);
                foglalt_sor_negy.Add(sor_negy[hely]);
                sor_negy.Remove(sor_negy[hely]);

                hely = rnd.Next(sor_ot.Count);
                foglalt_sor_ot.Add(sor_ot[hely]);
                sor_ot.Remove(sor_ot[hely]);

                hely = rnd.Next(sor_hat.Count);
                foglalt_sor_hat.Add(sor_hat[hely]);
                sor_hat.Remove(sor_hat[hely]);

                hely = rnd.Next(sor_het.Count);
                foglalt_sor_het.Add(sor_het[hely]);
                sor_het.Remove(sor_het[hely]);

                hely = rnd.Next(sor_nyolc.Count);
                foglalt_sor_nyolc.Add(sor_nyolc[hely]);
                sor_nyolc.Remove(sor_nyolc[hely]);

                hely = rnd.Next(sor_kilenc.Count);
                foglalt_sor_kilenc.Add(sor_kilenc[hely]);
                sor_kilenc.Remove(sor_kilenc[hely]);

                hely = rnd.Next(sor_tiz.Count);
                foglalt_sor_tiz.Add(sor_tiz[hely]);
                sor_tiz.Remove(sor_tiz[hely]);
            }
            Console.WriteLine("A foglalt helyek 'X'-el lesznek jelölve.");

            Console.Write("1. Sor  | ");
            Kiir(sor_egy);
            Console.Write("2. Sor  | ");
            Kiir(sor_ketto);
            Console.Write("3. Sor  | ");
            Kiir(sor_harom);
            Console.Write("4. Sor  | ");
            Kiir(sor_negy);
            Console.Write("5. Sor  | ");
            Kiir(sor_ot);
            Console.Write("6. Sor  | ");
            Kiir(sor_hat);
            Console.Write("7. Sor  | ");
            Kiir(sor_het);
            Console.Write("8. Sor  | ");
            Kiir(sor_nyolc);
            Console.Write("9. Sor  | ");
            Kiir(sor_kilenc);
            Console.Write("10. Sor | ");
            Kiir(sor_tiz);

        }
            
    }
}