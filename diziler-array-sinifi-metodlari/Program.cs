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
        }
    }
}
