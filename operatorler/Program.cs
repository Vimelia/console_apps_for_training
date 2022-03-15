// See https://aka.ms/new-console-template for more information
using System;

namespace operatorler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**** Atama Ve İşlemli Atama Operatörleri  ****");
            //Atama ve İşlemleri
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("******* Mantıksal Operatörler ****");
            //Mantıksal Operatöler || && !

            bool isSucces = true;
            bool isCompleted = false;

            if(isSucces && isCompleted)
                Console.WriteLine("Perfect");
            
            if(!isSucces || isCompleted)
                Console.WriteLine("Poor you!");
            
            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            //İlişkisel Operatörler <, >, <=, >=, ==, !=
            Console.WriteLine(sonuc);
            sonuc = a > b ;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <=b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("******* Aritmetik Operatörler ****");
            //Aritmetik Operatöler /,*,+,-,%

        }
    }
}

