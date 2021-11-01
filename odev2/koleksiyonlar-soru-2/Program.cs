using System;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesini ve en küçük 3 tanesini bulan,
            // her iki grubun kendi içerisinde ortalamalarını alan ve
            // bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int[] numbers = new int[20];
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Lütfen {0}. pozitif tam sayıyı giriniz: ", i + 1);
                    string strNumber = Console.ReadLine();
                    int number = Convert.ToInt32(strNumber);
                    if (number < 0)
                    {
                        Console.WriteLine("Hata oluştu! Lütfen pozitif bir tam sayı giriniz.");
                        break;
                    }
                    else
                        numbers[i] = number;
                }
            }
            catch (FormatException exc)
            {

                Console.WriteLine("Hata oluştu! " + exc.Message);
            }

            Array.Sort(numbers);
            Console.WriteLine("Küçükten büyüğe sıralı liste: ");
            foreach (var number in numbers)
                Console.Write(number + " ");
            Console.WriteLine();

            int[] minThreeNumberList = new int[3];
            int[] maxThreeNumberList = new int[3];
            int minThreeNumberTotal = 0;
            int maxThreeNumberTotal = 0;

            for (int i = 0; i < 3; i++)
            {
                minThreeNumberList[i] = numbers[i];
                minThreeNumberTotal += minThreeNumberList[i];
            }

            for (int i = numbers.Length - 1; i > numbers.Length - 4; i--)
            {
                maxThreeNumberList[(numbers.Length - 1) - i] = numbers[i];
                maxThreeNumberTotal += maxThreeNumberList[(numbers.Length - 1) - i];
            }

            double avgMinThreeNumber = (double)minThreeNumberTotal / minThreeNumberList.Length;
            double avgMaxThreeNumber = (double)maxThreeNumberTotal / maxThreeNumberList.Length;

            Console.WriteLine("En küçük üç sayının ortalaması: {0} En büyük üç sayının ortalaması: {1}", avgMinThreeNumber, avgMaxThreeNumber);
            Console.WriteLine("Bulunan ortalamaların toplamı: {0}", (avgMinThreeNumber + avgMaxThreeNumber));
        }
    }
}
