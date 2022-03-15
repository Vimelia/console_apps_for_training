// See https://aka.ms/new-console-template for more information
using System;

namespace dongu
{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Lüften sayı giriniz ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("---------------------------");
            
            // 1 ile 1000 arasındaki sayıların tek ve çift toplamlarını ekrana yazdırın.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 1)
                {
                    tekToplam += i;
                }
                if(i % 2 == 0)
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("Tek sayıların toplamı : " + tekToplam);
            Console.WriteLine("Çift sayıların toplamı : " + ciftToplam);
            Console.WriteLine("---------------------------");
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------");
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}
