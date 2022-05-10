using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    public class Triangle : Square
    {
        private int sideB;

        public int SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }


        public Triangle(int sideA, int sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override double Areal()
        {
            double areal = 0.5 * SideB * SideA;
            return areal;
        }

        public override int Perimeter()
        {
            int perimeter = SideA + SideB - 180;
            return perimeter;
        }
    }
}
