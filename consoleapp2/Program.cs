// See https://aka.ms/new-console-template for more information
using System;

namespace consoleapp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b = 5;       //1 byte
            sbyte c = 5;       //1 byte

            short s = 5;      //2 byte 
            ushort us = 5;    //2 byte   

            Int16 i16 = 2;       //2 byte
            int i = 2;           //4 byte
            Int32 i32 = 2;       //4 byte
            Int64 i64 = 2;       //8 byte

            uint ui = 2;         //4 byte
            long l = 4;          //8 byte
            ulong ul = 4;        //8 byte

            //Reel Sayılar
            float f  = 5;         //4 byte
            double d  = 5;         //8 byte
            decimal de  = 5;      //16 byte

            char ch = '2';          //2 byte
            string ist = "Vays";    //sınırsız
            
            bool b1 = true;
            bool b2 = false;
            
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            string dtx = dt.ToString("dd.mm.yyyy");
            string hour = DateTime.Now.ToString("HH:mm");

            object o1= "x";
            object o2= 'y';
            object o3= 4;
            object o4= 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Vi";
            string namep = "Vimelia";
            string fulln = str1 + " " + namep;

            //integer tanımlama
            int intger = 5;
            int xx = intger * i;

            //boolean
            bool bool1 = 10<11;

            //değişken dönüşümleri
            string str2 = "2";
            //string dönüşümü
            string yenid = str2 + intger.ToString();
            Console.WriteLine(yenid);
            //int dönüşümü
            int i3 = xx - Convert.ToInt32(intger); 
            Console.WriteLine(i3);
            //Parse
            int i4 = xx - int.Parse(str2); 
            Console.WriteLine(i4);
        }
    }
}
