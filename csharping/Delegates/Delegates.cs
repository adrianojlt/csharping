namespace csharpTT.Delegates
{
    using System;

    public class Delegates
    {
        public delegate void Del(string message);

        public delegate double PerformCalculation(double x, double y);

        public static void Start()
        {
            Del handler = DelegateMethod;
            handler("cenas");
        }

        public static double Addition(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }

        public static double Calc(double a, double b)
        {
            PerformCalculation perfAdd = Addition;
            PerformCalculation perfSub = Subtraction;
            PerformCalculation perfDiv = Division;

            PerformCalculation multiCalc = perfAdd + perfSub;

            multiCalc += Division;

            var calc = Sqr(5);

            Func<int, int> square = Sqr;
            calc = square(10);

            var raizQuadrada = square;
            raizQuadrada(6);

            return multiCalc(a, b);
        }

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static int Square(int number)
        {
            return number * number;
        }

        public static Func<int,int> Sqr = (number) => number * number;
    }

}
