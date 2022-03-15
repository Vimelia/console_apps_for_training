// See https://aka.ms/new-console-template for more information
using System;

namespace yapilar
{
    class Program{
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            //If-Else
            if(time>=6 && time<11)
                Console.WriteLine("Sabah Uykusu");
            else if(time<=18)
                Console.WriteLine("Öğle Uykusu");
            else
                Console.WriteLine("Gece Uykusu");

            //Ternary If-Else
            string sonuc = time==12 ? "Öğle Vakti" : "Öğle Değil";
            Console.WriteLine(sonuc);

            //Ternary If- Else If -Else
            string yemekye = time<12 && time>7 ?"Kahvaltı" : time<=15 ? "Öğle Yemeği":"Yemek vakti değil";
            Console.WriteLine(yemekye);
        }
    }
}

