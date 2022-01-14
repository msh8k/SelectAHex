using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace SelectAHex
{
    class Hex3
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public double row { get; set; }
        public double col { get; set; }


        public Hex3 (PointF hexagon)
        {
            // 1. Adjust row/col from (0, 0) top left to (0, 0) dead center
            col = (hexagon.Y + 5) - (hexagon.Y * 2);
            row = hexagon.X - 5;

            // 1.1. Adjust row value left 0.5 for even rows
            if (hexagon.Y % 2 == 0)
                row -= 0.5;

            // 2. Convert adjusted default value to HCS.  Ax = b, solve for x.
            var A = Matrix<double>.Build.DenseOfArray(new double[,] {
                { 1, 1 },
                { 1, -1 }
            });

            var b = Vector<double>.Build.Dense (new double[ ] { row * 2.0, col });
            var x = A.Solve (b);

            // 2.1. Store HCS coordinates.  x[0] == y, x[1] == x.
            this.x = (int)x[1];
            y = (int)x[0];
            z = (int)col;

            // 3.  Account for Sqrt(3) in col (30-60-90 triangle)
            // Divide by 2.0:  col = 2 / 3 * sqrt (3)   
            col /= 2.0;
            col *= Math.Sqrt (3);
        }

        public Hex3 (int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            row = (x + y) / 2.0;
            col = z / 2.0 * Math.Sqrt (3);
        }
    }// end Hex3
}
