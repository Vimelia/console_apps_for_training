// See https://aka.ms/new-console-template for more information
using System;

namespace tipdonusumleri
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Implicit Conversion(Bilinçsiz Dönüşüm)
            Console.WriteLine("******* Implicit Conversion");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: " +d);

            long h = d;
            Console.WriteLine("h: " +h);
            
            float i = h;
            Console.WriteLine("i: " +i);

            string e = "Vi";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g"+g);

            //Explicit Conversion(Bilinçli Dönüşüm)
            Console.WriteLine("******* Explicit Conversion");
            int x = 14;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            float v = 10.3f;
            byte z = (byte)w;
            Console.WriteLine("z: "+z);

            //ToString Method
            Console.WriteLine("******* ToDtring Method");
            int xx = 6 ;
            string yy = xx.ToString();
            Console.WriteLine("yy:" +yy);

            string zz= 12.5f.ToString();
            Console.WriteLine("zz:"+zz);

            //System.Convert
            Console.WriteLine("******* System.Convert");
            string s1="10", s2="20";
            int sayi1,sayi2,Toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1+sayi2;
            Console.WriteLine("Toplam: "+Toplam);

            //Parse
            Console.WriteLine("******* Parse Method");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string met1 = "10";
            string met2 = "10.25";
            int rak1;
            double rak2;

            rak1 = Int32.Parse(met1);
            rak2 = Double.Parse(met2);
            Console.WriteLine("Rakam:"+ rak1);
            Console.WriteLine("Double: "+rak2);
        }
    }
}

