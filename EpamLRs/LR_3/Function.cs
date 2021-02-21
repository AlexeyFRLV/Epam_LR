using System;

namespace LR_3
{
    class Function
    {
        const double point_1 = -5.0;
        const double point_2 = -3.0;
        const double point_3 = -1.0;
        const double point_4 = 2.0;
        const double point_5 = 4.0;
        const double point_6 = 5.0;

        const double R = 2.0;

        /// <summary>
        /// Метод вычисляет значение функции заданной в виде графика по введенному значению аргумента
        /// </summary>
        /// <param name="arg">аргумент функции</param>
        /// <returns>значение функции</returns>
        public static double Func(double arg)
        {
            if (arg < point_1 || arg > point_6)
            {
                throw new ArgumentOutOfRangeException($"Аргументы функции должне лежать в диапазоне [-5; 5] {nameof(arg)}");
            }
            else if (arg >= point_1 && arg <= point_2)
            {
                return 1.0;
            }
            else if (arg > point_2 && arg <= point_3)
            {
                return -Math.Sqrt(Math.Pow(R, 2) - Math.Pow(arg + 1, 2));
            }
            else if (arg > point_3 && arg <= point_4)
            {
                return -2.0;
            }
            else if (arg > point_4 && arg < point_5)
            {
                return arg - 4.0;
            }
            else if (arg == point_5)
            {
                return 0.0;
            }
            else
            {
                return arg - 4.0;
            }
        }
    }
}
