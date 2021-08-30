using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    public class Square
    {
        private int side;

        public int Side
        {
            get { return this.side; }
            set { this.side = value; }
        }

        public Square(int Side)
        {
            side = Side;
        }

        public int Perimeter(int side)
        {
            return side * 4;
        }

        public int Area(int side)
        {
            return side * 2;
        }
    }
}
