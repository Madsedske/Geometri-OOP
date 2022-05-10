using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    public class Square
    {
        private int sideA;

        public int SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public Square(int sideA)
        {
            SideA = sideA;
        }

        public Square()
        {

        }

        public virtual double Perimeter()
        {
            double perimeter  = sideA * 4;
            return perimeter;
        }

        public virtual double Areal()
        {
            int areal = sideA * sideA;
            return areal;
        }
    }
}
