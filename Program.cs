using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorsAndAngles
{
    class Vector
    {
        int x;
        int y;
        int n = 3;

        public Vector(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public Vector()
        {

        }

        public double Magnitude(int X, int Y)
        {
            double CalculoMagnitud;
            CalculoMagnitud = Math.Sqrt((X ^ 2 + Y ^ 2));
            return CalculoMagnitud;
        }


        static void Main(string[] args)
        {
        }
    }
}
