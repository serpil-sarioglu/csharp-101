using System;
using System.Collections.Generic;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        // Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri
        // bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string cumle = Console.ReadLine();
            char[] cumleHarflerDizisi = cumle.ToLower().ToCharArray();

            char[] sesliHarflerDizisi = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            List<char> cumleSesliHarfListesi = new List<char>();

            for (int i = 0; i < cumleHarflerDizisi.Length; i++)
            {
                for (int j = 0; j < sesliHarflerDizisi.Length; j++)
                {
                    if (cumleHarflerDizisi[i] == sesliHarflerDizisi[j])
                        cumleSesliHarfListesi.Add(cumleHarflerDizisi[i]);
                }
            }

            cumleSesliHarfListesi.Sort();
            Console.WriteLine("Cümle içerisindeki sesli harflerin sıralanarak yazılması: ");

            foreach (char harf in cumleSesliHarfListesi)
                Console.Write(harf + " ");
        }
    }
}
