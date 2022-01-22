using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ** Söz Dizimi **
            class SinifAdi
            {
                [Erişim Belirleyici] [Veri Tipi] OzellikAdı;
                [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
                {
                    //Metot Komutları
                }
            }

            ** Erişim Belirleyiciler **
            1- Public: Her yerden erişilebilir.
            2- Private: Sadece tanımlandığı sınıf içerisinden erişilebilir.
            3- Internal: Sadece bulunduğu proje içerisinden erişilebilir.
            4- Protected: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

            */

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 1;
            calisan1.Departman = "Muhasebe";
            calisan1.CalisanBilgileri();

            Console.WriteLine("-*-*-*-*-*-*-");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 2;
            calisan2.Departman = "Pazarlama";
            calisan2.CalisanBilgileri();

            // Hackerrank Challenge | 
            // T: test senayo sayısıdır. Girilen yaş argümanına göre kontrol ve metotlara ait işlem yaptırılır.
            Console.Write("Test senaryo sayısını giriniz: ");
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                Console.Write("Yaşınızı giriniz: ");
                int age = int.Parse(Console.ReadLine());
                Person p = new Person(age);
                p.amIOld();

                for (int j = 0; j < 3; j++)
                    p.yearPasses();

                p.amIOld();
                Console.WriteLine();
            }
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }

    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
                age = initialAge;
        }

        public void amIOld()
        {
            if (age < 13)
                Console.WriteLine("You are young.");
            else if (age >= 13 && age < 18)
                Console.WriteLine("You are a teenager.");
            else
                Console.WriteLine("You are old.");
        }

        public void yearPasses()
        {
            age = age + 1;
        }
    }
}
