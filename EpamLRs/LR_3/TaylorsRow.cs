using System;

namespace LR_3
{
    class TaylorsRow
    {
        static int count = 0;

        /// <summary>
        /// Рекурсивный метод вычисления функции
        /// </summary>
        /// <param name="num">значение аргумента</param>
        /// <param name="degree">степень</param>
        /// <param name="eps">погрешность</param>
        /// <returns>значение функции</returns>
        static double Lnx(double num, int degree = 0, double eps = 0.0001)
        {
            double current = Math.Pow(num - 1, degree + 1) / ((degree + 1) * Math.Pow(num, degree + 1));
            count++;

            if (Math.Abs(current) < eps)
            {
                return current;
            }

            return current + Lnx(num, degree + 1, eps);
        }

        /// <summary>
        /// Метод вычисления функции заданной с помощью ряда Тейлора
        /// </summary>
        /// <param name="xn">начальное значение аргумента</param>
        /// <param name="xk">конечное значение аргумента</param>
        /// <param name="dx">шаг</param>
        /// <param name="eps">погрешность</param>
        public static void TRow(double xn, double xk, double dx, double eps = 0.0001)
        {
            if (xn <= 0.5)
            {
                throw new ArgumentOutOfRangeException(nameof(xn));
            }

            for (double i = xn; i < xk; i += dx)
            {
                string s = "|{0,-" + Table.widthCol1.ToString() + "}|{1,-" + Table.widthCol2.ToString() + "}|{2,-" + Table.widthCol3.ToString() + "}|";
                Console.WriteLine(s, i, Lnx(i), count);
                count = 0;
            }
        }
    }
}
