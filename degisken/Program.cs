using System;

namespace degisken
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Değişkenler case sensitive yani büyük küçük harf duyarlıdır.
            // Değişken isimleri rakamlarla başlayamaz.
            // Değişken isimleri boşluk içeremez. Yalnızca "_" ifadesi kullanılabilir.
            // Değişken isimlerinin arasında matematiksel ifadeler yani işlem operatörleri kullanılamaz.
            // Class namespace gibi özel isimler kullanılamaz.
            // Değişkenlerin her zaman bir değeri olmak zorundadır. Yoksa null tanımlanmalıdır. Ataması yapılmayan değişkenler kullanıldığında derleyici hata verir.


            // int deger = 2;


            // string degisken = null;
            // string Degisken = null;


            // int 3degisken = 3;
            // string class = "";


            // string degisken;


            // string degisken+veri = null;
            // string degisken_veri = null;

            String degisken = " "; // white space ataması

            byte b = 5;     // 1 byte
            sbyte c = 5;    // 1 byte

            short s = 5;    // 2 byte
            ushort us = 5;  // 2 byte

            Int16 i16 = 2;  // 2 byte
            int i = 2;      // 4 byte
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte

            uint ui = 2;    // 4 byte
            long l = 2;     // 8 byte
            ulong ul = 4;   // 8 byte

            // Reel Sayılar
            float f = 5;    // 4 byte 
            double d = 5;   // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2';  // 2 byte
            string str = "Sınırsız"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime d1 = DateTime.Now;

            // Her turlu veriyi objede saklayabiliriz.
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // String ifadeler
            // string str1 = "";
            // string str1 = null;
            string str1 = string.Empty;
            str1 = "Yeni Değer";

            string ad = "Serpil";
            string soyad = "Sarıoğlu";
            string tamIsim = ad + " " + soyad;

            // Integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean
            bool bool1 = 10 > 2;

            // Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            // Datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
