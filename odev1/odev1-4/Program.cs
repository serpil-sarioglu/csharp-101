using System;

namespace odev1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Lütfen bir cümle giriniz: ");
            string ifade = Console.ReadLine();

            string[] kelimeDizisi = ifade.Split(" ");
            int kelimeSayisi = kelimeDizisi.Length;

            string harfDizisi = string.Join("", kelimeDizisi);

            char[] harf = harfDizisi.ToCharArray();
            int harfSayisi = harf.Length;

            Console.WriteLine("Girilen cümledeki toplam kelime sayısı: {0}", kelimeSayisi);
            Console.WriteLine("Girilen cümledeki toplam harf sayısı: {0}", harfSayisi);
        }
    }
}
