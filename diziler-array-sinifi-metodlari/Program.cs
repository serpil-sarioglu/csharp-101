using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System;
namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array sınıfı, dizilerle yapılan işlemleri kolaylaştırmak için birtakım static hazır metotlar sunar.
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            // Sort 
            // Dizide küçükten büyüğe sıralama yapar.
            Console.WriteLine("Sırasız Dizi");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // Clear
            // Dizinin belirtilen elemanlarını varsayılan değerine getirir
            Console.WriteLine("Array Clear");
            // Dizide 2. indexten itibaren 2 elemanı sıfırlar.
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // Reverse
            // Dizi ters çevrilir
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // IndexOf
            // Dizinin elemanın indexini verir. 
            Console.WriteLine("Array IndexOf");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 17));

            // Resize
            // Dizi yeniden boyutlanır.
            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // // HackerRank Challenge| Birthday Cake Candles 
            // // Girilen dizideki en büyük elamandan kaç tane olduğunu bulup sayısını döndüren program
            // Console.Write("Lütfen dizi boyutunu giriniz: ");
            // int candlesCount = Convert.ToInt32(Console.ReadLine());
            // int[] candles = new int[candlesCount];
            // for (int i = 0; i < candlesCount; i++)
            // {
            //     Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
            //     candles[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // int result = Result.birthdayCakeCandles(candles);
            // Console.WriteLine(result);

            // // HackerRank Challenge| Simple Array Sum 
            // Console.Write("Lütfen dizi boyutunu giriniz: ");
            // int arCount = Convert.ToInt32(Console.ReadLine());
            // int[] ar = new int[arCount];
            // for (int i = 0; i < arCount; i++)
            // {
            //     Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
            //     ar[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // int result = Result.simpleArraySum(ar);
            // Console.WriteLine(result);

            // // HackerRank Challenge| Compare the Triplets 
            // // https://www.hackerrank.com/challenges/compare-the-triplets/problem

            Console.Write("Lütfen listenin boyutunu giriniz: ");
            int listCount = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            for (int i = 0; i < listCount; i++)
            {
                Console.WriteLine("Lütfen a listesi için {0}. sayı giriniz: ", i + 1);
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int i = 0; i < listCount; i++)
            {
                Console.WriteLine("Lütfen b listesi için {0}. sayıyı giriniz: ", i + 1);
                b.Add(Convert.ToInt32(Console.ReadLine()));
            }
            List<int> result = Result.compareTriplets(a, b);
            Console.WriteLine("SCORE:  [a]" + "\t" + "[b]");
            foreach (var item in result)
            {
                Console.Write("\t" + "[" + item + "]");
            }

        }
    }
    class Result
    {
        public static int birthdayCakeCandles(int[] candles)
        {
            int count = 0;
            int maxHeight = 0;
            for (int i = 0; i < candles.Length; i++)
            {
                // Dizideki en büyük sayı bulunur
                if (candles[i] > maxHeight)
                {
                    maxHeight = candles[i];
                    count = 0;
                }
                // Dizide bulunan en büyük sayının tekrar etme sayısı count a atanır
                if (candles[i] == maxHeight)
                    count++;
            }
            return count;
        }
        public static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;
            List<int> answer = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    alice++;
                if (a[i] < b[i])
                    bob++;
            }
            answer.Insert(0, alice);
            answer.Insert(1, bob);
            return answer;
        }
    }
}
