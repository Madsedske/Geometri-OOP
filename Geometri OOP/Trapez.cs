using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_OOP
{
    public class Trapez : Square
    {
        public int SideC { get; set; }
        public int ParalelSider { get; set; }
        public Trapez()
        {
        }

        public Trapez(int sideA, int sideC, int paralelSider) : base(sideA)
        {
            SideC = sideC;
            ParalelSider = paralelSider;
        }

        public int Areal(int sideA, int paralelSider, int sideC)
        {
            int s = (sideA + paralelSider - sideC + paralelSider) / 2;
            double højde = (2 / (sideA - sideC)) * Math.Sqrt(s * (s - sideA + sideC) * (s - paralelSider) * (s - paralelSider));
            return (int)(0.5 * (sideA + sideC) * højde);
        }
    }
}
