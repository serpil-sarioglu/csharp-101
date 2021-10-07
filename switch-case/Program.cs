using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("1. ay Ocak");
                    break;
                case 2:
                    Console.WriteLine("2. ay Şubat");
                    break;
                case 3:
                    Console.WriteLine("3. ay Mart");
                    break;
                case 10:
                    Console.WriteLine("10. ay Ekim");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi!");
                    break;
            }

            // Birden fazla koşulda aynı ifadenin çalışması gereken durumlarda switch-case karar yapıları kullanılır. 
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindeyiz.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindeyiz.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindeyiz.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindeyiz.");
                    break;
                default:
                    break;

            }
        }
    }
}
