using System;


namespace BMI_Application
{
    class Program
    {
        static void Main(string[] args)
        // BMI Application- 04.01.2021
        {
            {
                try
                {
                    Console.WriteLine("BMI HESAPLAMASI, VÜCUT BİLGİLERİNİZ İÇİN GEREKLİDİR. " +
                                  "\nGEREKLİ BİLGİLERİ GİREREK VÜCUT DURUMUNUZU DEĞERLENDİRİNİZ.");
                    Console.WriteLine("Lütfen boyunuzu giriniz(CM): ");
                    int boy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Şimdi kilonuzu giriniz: ");
                    int kilo = Convert.ToInt32(Console.ReadLine());
                    double sonuc = kilo / Math.Pow(boy / 100.0, 2);
                    Console.WriteLine($"Vücut kitle indeksiniz: {sonuc}");
                    if (sonuc < 18.5)
                    {
                        Console.WriteLine("Durumunuz:Zayıfsınız");
                    }
                    else if (sonuc >= 18.5 && sonuc <= 24.9)
                    {
                        Console.WriteLine("Durumunuz:Sağlıklı kilodasınız");
                    }
                    else if (sonuc >= 25 && sonuc <= 29.9)
                    {
                        Console.WriteLine("Durumunuz:Kilo durumunuz normalden fazladır");

                    }
                    else
                    {
                        Console.WriteLine("Durumunuz:Obezite söz konusu olduğu için doktora başvurunuz ");
                    }
                   
                }

                catch (FormatException)
                {
                    Console.WriteLine("Girdiğiniz değerlerden dolayı bir hata oluştu,tekrar deneyin.");
                   
                }
                Console.ReadLine();

            }
        }
    }
}
