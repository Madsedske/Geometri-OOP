using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    public class Parallelogram : Square
    {
        private int hældning;

        public int Hældning
        {
            get { return hældning; }
            set { hældning = value; }
        }

        private int sideB;

        public int SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public Parallelogram(int sideA, int sideB, int hældning)
        {
            Hældning = hældning;
            SideB = sideB;
        }

        public override double Areal()
        {
            double radians = hældning * (Math.PI / 180);
            double areal = (SideA * SideB * Math.Sin(radians));
            return areal;
        }
    }
}
