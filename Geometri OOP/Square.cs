using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    public class Square
    {
        public int SideA { get; set; }

        public Square(int sideA)
        {
            SideA = sideA;
        }

        public Square()
        {
        }

        public int Perimeter(int sideA)
        {
            return sideA * 4;
        }

        public int Areal(int sideA)
        {
            return sideA * 2;
        }
    }
}
