using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz yinelemeli Metotlar
            // 3^4 = 3x3x3x3

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);//81

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3, 4));//81
            Console.WriteLine(instance.FibonacciSerisi(4));//f(4) = 3 (0,1,1,2,3,5,8,13,21,...) 

            // HackerRank Challenges| Recursive Method for Calculating Factorial
            Console.WriteLine(instance.Factorial(3));//6

            // Extension Metotlar
            // Extension metotlar static bir class içerisinde static bir metot olarak yazılmalılar.
            // Extension metotta tanımlı parametrelerden sadece 1 tanesi this ile tanımlanabilir.

            string ifade = "Serpil Sarıoğlu";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);//True

            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());//SerpilSarıoğlu

            Console.WriteLine(ifade.MakeUpperCase());//SERPİL SARIOĞLU
            Console.WriteLine(ifade.MakeLowerCase());//serpil sarıoğlu

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.SortArray();
            dizi.EkranaYazdir();//0 1 2 3 5 6 9

            int sayi = 5;
            Console.WriteLine(sayi.isEvenNumber());//False

            Console.WriteLine(ifade.GetFirstCharacter());//S
        }
    }
    public class Islemler
    {
        // Expo(3,4) çağrıldığında ne döner?
        // Expo(3,3) * 3;
        // Expo(3,2) * 3 * 3;
        // Expo(3,1) * 3 * 3 * 3;
        // 3 * 3 * 3 * 3 = 3^4; 
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;

            return Expo(sayi, us - 1) * sayi;
        }
        /*
        FibonacciSerisi(4) çağrıldığında ne döner?
        f(3)+f(2)
        f(2)+f(1)+f(1)+f(0)
        f(1)+f(0)+1+1+0
        1+0+1+1=3
        */
        public int FibonacciSerisi(int i)
        {
            if (i == 0)
                return 0;
            else if (i == 1)
                return 1;
            else
                return FibonacciSerisi(i - 1) + FibonacciSerisi(i - 2);
        }
        /*
        factorial(4) = ?
        factorial(3)*4
        factorial(2)*3*4
        factorial(1)*2*3*4
        1*2*3*4 = 4! = 24    
        */
        public int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            return Factorial(n - 1) * n;
        }

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
                Console.WriteLine(item);
        }
        public static bool isEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }

    }
}
