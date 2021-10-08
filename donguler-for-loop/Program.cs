using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ekrandan girilen sayıya kadar olan tek sayılar ekrana yazdırıldı.");
            // Console.Write("Lütfen bir sayı giriniz: ");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= sayac; i++)
            // {
            //     if (i % 2 == 1)
            //         Console.WriteLine(i);
            // }

            Console.WriteLine("1 ile 1000 arasındaki tek ve çift sayıların toplamı hesaplanarak ekrana yazdırıldı.");
            // int tekToplam = 0;
            // int ciftToplam = 0;

            // for (int i = 1; i <= 1000; i++)
            // {
            //     if (i % 2 == 1)
            //         tekToplam += i;
            //     else
            //         ciftToplam += i;
            // }
            // Console.WriteLine("Tek Toplam = " + tekToplam);
            // Console.WriteLine("Çift Toplam = " + ciftToplam);

            Console.WriteLine("Döngü içinde break, continue kullanımı");
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            for (; ; )// Sonsuz döngü
            {
                char ch = Convert.ToChar(Console.ReadLine());
                int intVal = int.Parse(ch.ToString());
                if (intVal == 7)
                    break;
            }

            // HackerRank Challenges| Day 5 Loops 
            int n0 = Convert.ToInt32(Console.ReadLine().Trim());
            if (n0 >= 2 && n0 <= 20)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int multiplyResult = n0 * i;
                    Console.WriteLine(n0 + " x " + i + " = " + multiplyResult);
                }
            }
            // HackerRank Challenges| Staircase 
            int n1 = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 1; i <= n1; i++)
            {
                for (int j = i; j < n1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

        }
    }
}
