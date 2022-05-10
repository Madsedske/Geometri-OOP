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
            Square square = new Square(5);
            Parallelogram paralellogram = new Parallelogram(3,5,20);
            Trapez trapez = new Trapez(10, 8, 9);
            Rektangel rektangel = new Rektangel(5, 10);
            Triangle triangle = new Triangle(3, 4);
            List<Square> list = new List<Square>() { square, paralellogram, trapez, rektangel, triangle };

            foreach (Square n in list)
            {
                Console.WriteLine(n.Perimeter());
                Console.WriteLine(n.Areal());
            }



            //Console.WriteLine("1. Square?\n2. Parallelogram?\n3. Trapez?");
            //int answer = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Skriv din a side ");
            //int sideAinput = Convert.ToInt32(Console.ReadLine());
            //if (answer == 1)
            //{
            //    Console.WriteLine("Skriv din b side");
            //    int sideBinput = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Areal af parallelogram er: " + square.Areal());
            //}
            //else if (answer == 2)
            //{
            //    Console.WriteLine("Skriv din b side");
            //    int sideBinput = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Skriv hældning");
            //    int hældninginput = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Areal af parallelogram er: " + paralellogram.Areal());
            //}
            //else if (answer == 3)
            //{               
            //    Console.WriteLine("Skriv din c side ");
            //    int sideCinput = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Skriv paralelsiden");
            //    int paralelSider = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Areal af trapez er: " + trapez.Areal());
            //}      
            Console.ReadKey();
        }
    }
}
