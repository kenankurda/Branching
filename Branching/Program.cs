using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het x-coördinaat van de linker bovenhoek van de rechthoek");
            int xPos = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef het y-coördinaat van de linker bovenhoek van de rechthoek");
            int yPos = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef de breedte van de rechthoek");
            int breedte = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef de hoogte van de rechthoek");
            int hoogte = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef de x-coördinaat van het te testen punt");
            int puntX = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef de y-coördinaat van het te testen punt");
            int puntY = int.Parse(Console.ReadLine());
            if (puntX > xPos && puntX < puntX + breedte && puntY > yPos && puntY < puntY + hoogte)
            {
                Console.WriteLine("Het punt ligt binnen de gegeven rechthoek");
            }
            else {
                Console.WriteLine("Het punt ligt niet binnen de gegeven rechthoek");
            }
            Console.ReadLine();

        }
    }
}
