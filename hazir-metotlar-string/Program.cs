using System;

namespace hazir_metotlar_string
{
    class Program
    {
        public static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";
            string degisken3 = "dersimiz CSharp, Hoşgeldiniz!";

            // Length
            Console.WriteLine(degisken.Length);

            // ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            /*
            degisken>degisken2 = 1
            degisken=degisken2 = 0
            degisken<degisken2 -1
            */

            // Compore, ComporeTo
            Console.WriteLine(degisken.CompareTo(degisken3));//1
            Console.WriteLine(String.Compare(degisken, degisken3, true));//0
            Console.WriteLine(String.Compare(degisken, degisken3, false));//1

            // Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Serpil"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            // Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            // PadLeft, PadRight;
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            // Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            // Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            // Split
            Console.WriteLine(degisken.Split(' ')[1]);
            /* Split Kullanımına Örnek
             * https://docs.microsoft.com/tr-tr/dotnet/api/system.stringsplitoptions?view=net-5.0#code-try-2

            string s2 = "[stop]" +
            "ONE[stop][stop]" +
            "TWO[stop][stop][stop]" +
            "THREE[stop][stop]";

            string[] stringSeparators = new string[] { "[stop]" };

            string[] result;

            result = s2.Split(stringSeparators, StringSplitOptions.None);
            Show(result);

            result = s2.Split(stringSeparators, 2, StringSplitOptions.None);
            Show(result);

            result = s2.Split(stringSeparators, 2, StringSplitOptions.RemoveEmptyEntries);
            Show(result);
            */

            // Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));

            // Hackerrank Challenges|
            // Task: Read a string, S, and print its integer value; if  cannot be converted to an integer, print Bad String.
            FirstChallangeSolve();
            // Task: Given a string, S, of length N that is indexed from  0 to N-1, print its even-indexed and odd-indexed characters as 2 space-separated strings on a single line
            SecondChallengeSolve();

        }

        // public static void Show(string[] entries)
        // {
        //     Console.WriteLine($"The return value contains these {entries.Length} elements:");
        //     foreach (string entry in entries)
        //     {
        //         Console.Write($"<{entry}>");
        //     }
        //     Console.Write("\n\n");
        // }
        public static void FirstChallangeSolve()
        {
            Console.Write("Lütfen bir ifade giriniz: ");
            string S = Console.ReadLine();
            bool result = int.TryParse(S, out int outS);
            if (result)
            {
                Console.WriteLine(outS);
            }
            else
            {
                Console.WriteLine("Bad String");
            }
        }
        public static void SecondChallengeSolve()
        {
            Console.Write("Lütfen test edilecek durum sayısını giriniz: ");
            int testCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                Console.Write("Lütfen bir ifade giriniz: ");
                char[] inputString = Console.ReadLine().ToCharArray();

                //Print even chars
                for (int j = 0; j < inputString.Length; j += 2)
                {
                    Console.Write(inputString[j]);
                }
                Console.Write(" ");

                //Print odd chars
                for (int j = 1; j < inputString.Length; j += 2)
                {
                    Console.Write(inputString[j]);
                }
                Console.WriteLine();
            }
        }
    }
}