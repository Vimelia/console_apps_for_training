// See https://aka.ms/new-console-template for more information
using System;

namespace hatayonetimi
{
    class Program{
        public static void Main(string[] args)
        {
            try
            {
                //çalıştırılacak işlem buradadır
                Console.WriteLine("Bir sayı girin:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı:"+ sayi);
            }
            catch (Exception ex)
            {
                //Kullanıcı hatada burayı alır
                Console.WriteLine("Hata:"+ ex.Message.ToString());
            }
            //finally
            //{
                //Kullanıcı her türlü bu mesajı alır
                //Console.WriteLine("İşlem Tamamlandı.");
            //}
            try
            {
                int a = int.Parse(null);
                int b = int.Parse("str");
                int c = int.Parse("-2000000000000");
            }
            catch(ArgumentNullException exc)
            {
                Console.WriteLine("Boş değer girdin");
                Console.WriteLine(exc);
            }
            catch(FormatException exce)
            {
                Console.WriteLine("Veri tipi uygunsuz");
                Console.WriteLine(exce);
            }
            catch(OverflowException excep){
                Console.WriteLine("Büyük veya küçük değer girdiniz.");
                Console.WriteLine(excep);
            }
        }
    }
}

