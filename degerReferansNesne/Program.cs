using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degerReferansNesne
{
    class Program
    {
        static void Main(string[] args)
        {
            bankaKarti worldkart = new bankaKarti();
            worldkart.KartNo = "1234";
            worldkart.Bakiye = 500;

            bankaKarti bonuskart = new bankaKarti();
            bonuskart.KartNo = "9876";
            bonuskart.Bakiye = 6500;

            Console.WriteLine("---World kart---");
            Console.WriteLine("Kart no= "+ worldkart.KartNo);
            Console.WriteLine("Bakiye= "+worldkart.Bakiye);
            Console.WriteLine("---Bonus kart---");
            Console.WriteLine("Kart no= " + bonuskart.KartNo);
            Console.WriteLine("Bakiye= " + bonuskart.Bakiye);

            worldkart.Bakiye = bonuskart.Bakiye;
            Console.WriteLine("DEĞER ATAMASI YAPILDI");
            Console.WriteLine("---World kart---");
            Console.WriteLine("Kart no= " + worldkart.KartNo);
            Console.WriteLine("Bakiye= " + worldkart.Bakiye);
            Console.WriteLine("---Bonus kart---");
            Console.WriteLine("Kart no= " + bonuskart.KartNo);
            Console.WriteLine("Bakiye= " + bonuskart.Bakiye);

            worldkart = bonuskart;//komle kart ve bakiye bilgilerini atar ve bir daha değiştirilemez.
            // Bu yüzden yapılmaması gerekir.
            Console.WriteLine("REFERANS ATAMASI YAPILDI");
            Console.WriteLine("---World kart---");
            Console.WriteLine("Kart no= " + worldkart.KartNo);
            Console.WriteLine("Bakiye= " + worldkart.Bakiye);
            Console.WriteLine("---Bonus kart---");
            Console.WriteLine("Kart no= " + bonuskart.KartNo);
            Console.WriteLine("Bakiye= " + bonuskart.Bakiye);

            bonuskart.Bakiye = 12000;
            worldkart.KartNo = "48954165";
            Console.WriteLine("---World kart---");
            Console.WriteLine("Kart no= " + worldkart.KartNo);
            Console.WriteLine("Bakiye= " + worldkart.Bakiye);
            Console.WriteLine("---Bonus kart---");
            Console.WriteLine("Kart no= " + bonuskart.KartNo);
            Console.WriteLine("Bakiye= " + bonuskart.Bakiye);
        }
    }
    class bankaKarti
    {
        public string KartNo;
        public double Bakiye;
    }
}
