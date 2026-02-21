using System;

namespace C_Basics
{
    public class QuadraticEquation
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        private double determinant { get; set; }
        public double[] xValues { get; private set; }


        public QuadraticEquation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.xValues = new double[2];
        }

        public double GetDeterminant()
        {
            return (b * b) - (4 * a * c);
        }

        public double[] GetTwoSolutions()
        {
            xValues[0] = (-b + Math.Sqrt(determinant)) / (2.0 * a);
            xValues[1] = (-b - Math.Sqrt(determinant)) / (2.0 * a);
            return xValues;
        }

        public double[] GetOneSolution()
        {
            xValues[0] = -b / (2.0 * a);
            return xValues;
        }

        public double[] Solve()
        {
            if (a == 0)
                return null;


            determinant = GetDeterminant();
            if(determinant > 0)
            {
                return GetTwoSolutions();
            }
            if(determinant == 0)
            {
                return GetOneSolution();
            }
            
            return null;
        }

        public string Solutions()
        {
            var solutions = Solve();

            if (solutions == null)
            {
                return "No real solutions";
            }

            if (determinant == 0)
            {
                return $"One solution: {solutions[0]}";
            }
                
            return $"Two solutions: {solutions[0]}, {solutions[1]}";
        }
    }
}
