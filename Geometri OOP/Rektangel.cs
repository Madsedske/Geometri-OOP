using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    internal class Rektangel : Square
    {
        private int sideB;

        public int SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public Rektangel(int sideB, int sideA)
        {
            SideB = sideB;
            SideA = sideA;
        }

        public override double Areal()
        {
            double areal = SideA * SideB;
            return areal;
        }

        public override double Perimeter()
        {
            int perimeter = 2 * (SideA + SideB);
            return perimeter;
        }
    }
}
