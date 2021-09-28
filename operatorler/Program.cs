using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atama ve İşlemli Atama Operatörleri");
            // Atama ve İşlemli Atama Operatörleri
            int x = 3;
            int y = 3;

            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("Mantıksal Operatörler");
            // Mantıksal Operatörler
            // ||, &&, !

            bool isSucess = true;
            bool isComplated = false;

            if (isSucess && isComplated)
                Console.WriteLine("Perfect!");

            if (isSucess || isComplated)
                Console.WriteLine("Great!");

            if (isSucess && !isComplated)
                Console.WriteLine("Fine!");

            Console.WriteLine("İlişkisel Operatörler");
            // İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;

            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("Aritmetik Operatörler");
            // Aritmetik Operatörler
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 += 1;
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            // % : mod alır
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
}
