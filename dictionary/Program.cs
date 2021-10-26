using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections.Generic namespace
            // Dictionary, key-value pairlerden oluşuyor.
            // key uniqe olmalıdır.

            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Çalışkan");

            // Dizinin elemanlarına erişim
            Console.WriteLine("* Dizinin elemanlarına erişim *");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            // Count
            Console.WriteLine("* Count *");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine("* Contains *");
            Console.WriteLine(kullanicilar.ContainsKey(12));//Çıktı: True
            Console.WriteLine(kullanicilar.ContainsValue("Serpil Sarıoğlu"));//Çıktı: False

            // Remove
            Console.WriteLine("* Remove *");
            kullanicilar.Remove(12, out string value);
            Console.WriteLine(value);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            // Keys
            Console.WriteLine("* Keys *");
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);

            // Values
            Console.WriteLine("* Values *");
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);

            #region challenge
            // HackerRank Challenges| Day 8: Dictionaries and Maps
            // https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem

            // Console.Write("Satır sayısını giriniz: ");
            // int n = int.Parse(Console.ReadLine());
            // Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write("{0}. satır için isim ve telefon numarasının arasında boşluk olacak şekilde giriniz: ", i + 1);
            //     string[] line = Console.ReadLine().Split(' ');// line burada iki elemanlı string dizi olur.
            //     phoneBook[line[0]] = line[1];// phoneBook KeyValuPair tutar.
            //     // phoneBook.Add(line[0], line[1]);
            // }

            // CheckName(phoneBook);
            #endregion
        }
        static void CheckName(Dictionary<string, string> phoneBook)
        {
            string name;
            Console.WriteLine("Telefon rehberinde kontrol edilecek isim giriniz: ");
            while ((name = Console.ReadLine()) != null && name.Length > 0)
            {
                if (phoneBook.ContainsKey(name))
                    Console.WriteLine(name + "=" + phoneBook[name]);
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}
