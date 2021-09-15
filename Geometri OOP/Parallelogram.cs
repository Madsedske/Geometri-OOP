using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    public class Parallelogram : Square
    {
        public int Hældning { get; private set; }
        public int SideB { get; set; }

        public Parallelogram(int sideA, int sideB, int hældning) : base(sideA)
        {
            Hældning = hældning;
            SideB = sideB;
        }

        public Parallelogram()
        {
        }

        public int Areal(int sideA, int sideB, int hældning)
        {
            double radians = hældning * (Math.PI / 180);
            return (int)(sideA * sideB * Math.Sin(radians));
        }
    }
}
