using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
/// <summary>
/// Дает площадь геометрической фигуры 
/// при заданных параметрах
/// </summary>
    public static class ClassShapes
    {
        /// <summary>
        /// Высчитывает площадь круга при заданном периметре
        /// </summary>
        /// <param name="perimeter">периметр круга</param>
        /// <returns>площадь круга</returns>
        public static double CircleSquare(double perimeter)
        {
            double radius = perimeter / (2 * Math.PI);
            double square =Math.PI*radius*radius*radius;
            return square;
        }
        /// <summary>
        /// Высчитывает площадь квадрата при заданном периметре
        /// </summary>
        /// <param name="perimeter">периметр</param>
        /// <returns>площадь</returns>
        public static double SquareArea(double perimeter)
        {
            double side = perimeter / 4;
            double square = side * side;
            return square;
        }
        /// <summary>
        /// Высчитывает площадь равностороннего треугольника при заданном периметре
        ///
        /// </summary>
        /// <param name="perimeter">периметр треугольника</param>
        /// <returns>площадь треугольника</returns>
        public static double  TriangleSquare(double perimeter)
        {
            double side = perimeter / 3;
            double square = (side * side * Math.Sqrt(3)) / 4;
            return square;
        }
        /// <summary>
        /// высчитывает площадь прямоугольника где одна сторона в 2 раза больше другой
        /// </summary>
        /// <param name="perimeter">периметр прямоугольника</param>
        /// <returns>площадь прямоугольника</returns>
        public static double RectangleSquare(double perimeter)
        {
            double bsibe = perimeter/3;
            double aside = perimeter/6;
            double square = aside * bsibe;
            return square;
        }
        /// <summary>
        /// высчитывает площадь ромба из 2-х равносторонних треугольников
        /// </summary>
        /// <param name="perimeter">периметр ромба</param>
        /// <returns>площадь ромба</returns>
        public static double RhombusSquare(double perimeter)
        {
            double side = perimeter / 4;
            double square= (side * side * Math.Sqrt(3)) / 2;
            return square;
        }

    }
}
