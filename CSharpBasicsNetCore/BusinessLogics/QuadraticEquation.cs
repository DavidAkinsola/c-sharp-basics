using System;

namespace C_Basics.BusinessLogics
{
    public class QuadraticEquation
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        private double determinant { get; set; }


        public QuadraticEquation(int a, int b, int c)
        {
            if (a == 0)
                throw new ArgumentException("Not a Quadratic equation");

            this.A = a;
            this.B = b;
            this.C = c;
        }

        private double GetDeterminant()
        {
            return (B * B) - (4 * A * C);
        }

        public double[] Solve()
        {
            
            determinant = GetDeterminant();

            if (determinant > 0)
            {
                return [(-B + Math.Sqrt(determinant)) / (2.0 * A),(B + Math.Sqrt(determinant)) / (2.0 * A)];
            }
            else if (determinant == 0)
            {
                return [-B / (2.0 * A)];
            }
            else //determinant < 0
            {
                return [];
            }
            
        }
    }
}
