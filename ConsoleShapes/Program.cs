using System;
using ClassLibraryShapes;
using System.Diagnostics;

namespace ConsoleShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            testcircle1();
            testsquare1();
            testtriangle1();
            testrectangle1();
            testrhombus();
            testcircle2();
            Console.WriteLine("stray");
            Console.WriteLine("ss");
            
        }
        static void testcircle1()
        {
            double p = 10;
            double s = ClassShapes.CircleSquare(p);
            Console.WriteLine("Площадь круга:"+ s);
        }
        static void testcircle2()
        {
            double p = 10;
            double s = ClassShapes.CircleSquare(p);
            p = 20;
            double s1 = ClassShapes.CircleSquare(p);
            double eps = 1e-7;
            Debug.Assert(Math.Abs(s1 - 4 * s) < eps);
            Console.WriteLine("Testing is OK");

            
        }
        static void testsquare1()
        {
            double p = 10;
            double s = ClassShapes.SquareArea(p);
            Console.WriteLine("Площадь квадрата:"+s);
        }
        static void testtriangle1()
        {
            double p = 10;
            double s = ClassShapes.TriangleSquare(p);
            Console.WriteLine("Площадь треугольника:"+s);
        }
        static void testrectangle1()
        {
            double p = 10;
            double s = ClassShapes.RectangleSquare(p);
            Console.WriteLine("Площадь прямоугольника:" + s);
        }
        static void testrhombus()
        {
            double p = 10;
            double s = ClassShapes.RhombusSquare(p);
            Console.WriteLine("Площадь ромба:" + s);
        }
    }
}
