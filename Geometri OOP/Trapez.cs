using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    public class Trapez : Square
    {
        private int sideC;

        public int SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        private int paralelSider;

        public int ParalelSider 
        {
            get { return paralelSider; }
            set { paralelSider = value; }
        }

        public Trapez(int sideA, int sideC, int paralelSider)
        {
            SideC = sideC;
            ParalelSider = paralelSider;
        }

        public override double Areal()
        {
            int s = (SideA + paralelSider - sideC + paralelSider) / 2;
            double højde = (2 / (SideA - sideC)) * Math.Sqrt(s * (s - SideA + sideC) * (s - paralelSider) * (s - paralelSider));
            double areal = (0.5 * (SideA + sideC) * højde);
            return areal;
        }
    }
}
