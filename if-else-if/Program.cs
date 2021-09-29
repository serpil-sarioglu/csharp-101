using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydın!");
            else if (time <= 18)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("İyi Geceler!");

            string sonuc = time <= 18 ? "Merhaba, İyi Günler!" : "Merhaba, İyi Geceler!";

            sonuc = time >= 6 && time < 11 ? "Günaydın :D" : time <= 18 ? "İyi Günler :D" : "İyi Geceler :D";
            Console.WriteLine(sonuc);

            //Hackkerrank|Day 3: Intro to Conditional Statements: N sayısının tek olma durumlarında weird çift olma durumlarında not weird yazılmasını sağlayan kodu yazınız.
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            if (N % 2 != 0)
                Console.WriteLine("Weird");
            else
            {
                if (N >= 2 && N <= 5)
                    Console.WriteLine("Not Weird");
                else if (N >= 6 && N <= 20)
                    Console.WriteLine("Weird");
                else if (N > 20)
                    Console.WriteLine("Not Weird");
            }

        }
    }
}
