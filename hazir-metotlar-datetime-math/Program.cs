using System;
using System.Globalization;
namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);//19.10.2021 17:02:00
            Console.WriteLine(DateTime.Now.Date);//19.10.2021 00:00:00
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.ToLongDateString());//19 Ekim 2021 Salı
            Console.WriteLine(DateTime.Now.ToShortDateString());//19.10.2021
            Console.WriteLine(DateTime.Now.ToLongTimeString());//17:02:00
            Console.WriteLine(DateTime.Now.ToShortTimeString());//17:02

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//19
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Sal
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Salı

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            Console.WriteLine("Math Kütüphanesi");
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//25
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3));//23
            Console.WriteLine(Math.Round(22.3));//22
            Console.WriteLine(Math.Round(22.7));//23
            Console.WriteLine(Math.Floor(22.7));//22

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(3, 4));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Log(9));// 9 un e tabanındaki logaritmik karşılığını getirir
            Console.WriteLine(Math.Exp(3));// e üzeri 3 ü verir
            Console.WriteLine(Math.Log10(10));// 10 sayısının log 10 tabanındaki karşılığı

            // Hackerrank Challenges| 

            // Task(Time Conversion)
            // Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
            // Note:  12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
            //        12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
            Console.Write("Saati 12 saatlik AM/PM zaman formatında giriniz(hh:mm:ssAM ya da hh:mm:ssPM): ");
            string s = Console.ReadLine();
            Console.WriteLine(timeConversionFirst(s));
            Console.WriteLine(timeConversionSecond(s));

            // Task(Day 17: More Exceptions)
            // Write a Calculator class with a single method: int power(int,int). 
            // The power method takes two integers, n and p, as parameters and returns the integer result of n^p.
            // If either n or p is negative, then the method must throw an exception with the message: n and p should be non-negative.
            Calculator myCalculator = new Calculator();
            Console.Write("Enter a number: ");
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                // string[] num = Console.ReadLine().Split();
                // int n = int.Parse(num[0]);
                // int p = int.Parse(num[1]);
                string[] num = new string[2];
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write("{0}. number: ", i + 1);
                    num[i] = Console.ReadLine();
                }
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);

                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            static string timeConversionFirst(string s)
            {
                DateTime dt = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
                return $"{dt:HH:mm:ss}";
            }
            static string timeConversionSecond(string s)
            {
                string[] timeArr = s.Split(":");
                string AMPM = timeArr[2].Substring(2, 2);
                int hh, mm, ss;
                hh = int.Parse(timeArr[0]);
                mm = int.Parse(timeArr[1]);
                ss = int.Parse(timeArr[2].Substring(0, 2));

                string checkPM = "PM", checkAM = "AM";
                if (AMPM.Equals(checkAM) && hh == 12)
                    hh = 0;
                else if (AMPM.Equals(checkPM) && hh < 12)
                    hh += 12;

                string time = String.Format("{0:D2}:{1:D2}:{2:D2}", hh, mm, ss);
                return time;
            }
        }
    }
    class Calculator
    {
        public int power(int n, int p)
        {
            double n1 = Convert.ToDouble(n);
            double p1 = Convert.ToDouble(p);
            if (n1 < 0 || p1 < 0)
            {
                throw new Exception("n and p should be non-negative");

            }
            int result = Convert.ToInt32(Math.Pow(n1, p1));
            return result;
        }
    }

}