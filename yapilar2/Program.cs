// See https://aka.ms/new-console-template for more information
using System;

namespace yapilar2
{
    class Program{
        public static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //İlk iki ay kontrolü
            switch (month)
            {
                case 1:
                    Console.WriteLine("İlk ay");
                    break;
                case 2:
                    Console.WriteLine("İkinci ay");
                    break;
                default:
                    Console.WriteLine("Başvuru geçti");
                    break;
            }
            //Kış aylarında olduğunu bulma
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış aylarında");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar aylarında");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz aylarında");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar aylarında");
                    break;
                default:
                    Console.WriteLine("Başvuru geçti");
                    break;
            }

        }
    }
}

