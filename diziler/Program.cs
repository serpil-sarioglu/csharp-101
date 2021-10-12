using System;

namespace diziler
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            // Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle dizi kullanımı

            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program yazıldı.

            // Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            // int diziUzunlugu = int.Parse(Console.ReadLine());
            // int[] sayiDizisi = new int[diziUzunlugu];

            // for (int i = 0; i < diziUzunlugu; i++)
            // {
            //     Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
            //     sayiDizisi[i] = int.Parse(Console.ReadLine());
            // }

            // int toplam = 0;
            // foreach (var sayi in sayiDizisi)
            // {
            //     toplam += sayi;
            // }
            // Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);

            /*
            float ilk = 1, son = 6;
            float sonuc = ilk / son;
            Console.WriteLine("{0:0.000000}", sonuc);
            */

            // HackerRank Challenge| PlusMinus 
            // Ekrandan girilen dizi elemanlarında kaç tane sıfır, negatif, pozitif elaman varsa sayısı bulunur, bulunan her bir sayıyı dizinin eleman sayısına oranlayan program. 
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Result.plusMinus(arr);
        }

        class Result
        {
            public static void plusMinus(int[] arr)
            {
                float positiveCount = 0, negativeCount = 0, zeroCount = 0;
                foreach (var item in arr)
                {

                    if (item < 0)
                        negativeCount++;
                    else if (item > 0)
                        positiveCount++;
                    else
                        zeroCount++;
                }
                Console.WriteLine("{0:0.000000}", (positiveCount / arr.Length));
                Console.WriteLine("{0:0.000000}", (negativeCount / arr.Length));
                Console.WriteLine("{0:0.000000}", (zeroCount / arr.Length));
            }
        }
    }
}
