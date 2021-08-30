using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv din a side ");
            int side = Convert.ToInt32(Console.ReadLine());

            Square sqauree = new Square(side);

            Console.WriteLine("Omkreds " + sqauree.Perimeter(side) + " Areal " + sqauree.Area(side));
            











            Console.ReadKey();
        }
    }
}
