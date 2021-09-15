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
            Square square = new Square();
            Parallelogram parallelogram = new Parallelogram();
            Trapez trapez = new Trapez();

            Console.WriteLine("1. Square?\n2. Parallelogram?\n3. Trapez?");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv din a side ");
            int sideAinput = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)                            
                Console.WriteLine("Omkreds er " + square.Perimeter(sideAinput) + "\nAreal er " + square.Areal(sideAinput));            
            else if (answer == 2)
            {
                Console.WriteLine("Skriv din b side");
                int sideBinput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv hældning");
                int hældninginput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Areal af parallelogram er: " + parallelogram.Areal(sideAinput, sideBinput, hældninginput));
            }
            else if (answer == 3)
            {               
                Console.WriteLine("Skriv din c side ");
                int sideCinput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv paralelsiden");
                int paralelSider = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Areal af trapez er: " + trapez.Areal(sideAinput, paralelSider, sideCinput));
            }      
            Console.ReadKey();
        }
    }
}
