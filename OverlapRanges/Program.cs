using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlapRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Geef een getal a (ondergrens bereik 1)");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef een getal b (bovengrens bereik 1)");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef een getal c (ondergrens bereik 2)");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef een getal d (bovengrens bereik 2)");
            d = int.Parse(Console.ReadLine());
            if (c >= a && d <= b)
                Console.WriteLine("Het bereik gaande van c tot d ligt binnen het bereik gaande van a tot b");
            else
                Console.WriteLine("Het bereik gaande van c tot d ligt niet binnen het bereik gaande van a tot b");

            Console.ReadLine();

        }
    }
}
