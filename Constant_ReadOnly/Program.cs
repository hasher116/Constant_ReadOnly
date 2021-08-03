using System;

namespace Constant_ReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathLib.PI);

            MathLib abc = new MathLib();
            Console.WriteLine(abc.PI2);

            Console.WriteLine(abc.MathLib2());
        }
    }

     class MathLib
    {
        private decimal squad;
        private double area;
        public const double PI = 3.1;
        public readonly double PI2 = 3.14;
        public MathLib()
        {
            PI2 = 5;
            area = PI2;
        }
        public decimal MathLib2()
        {
            return squad = (decimal) (Math.Pow(PI, 2) / 2);
        }
    }
}
