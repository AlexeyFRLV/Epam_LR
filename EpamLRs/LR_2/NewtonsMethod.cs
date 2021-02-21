using System;

namespace LR_2
{
    static class NewtonsMethod
    {
        /// <summary>
        /// Метод возведения числа в степень
        /// </summary>
        /// <param name="number">Число, которое нужно возвести в степень</param>
        /// <param name="degree">Степень, в которую нужно возвести</param>
        /// <returns>Результат возведения числа в степень</returns>
        private static double Power(double number, int pow)
        {
            double result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }

            return result;
        }

        /// <summary>
        /// Метод нахождения корня n-й степени из числа
        /// </summary>
        /// <param name="degre">Число, корень из которого нужно найти</param>
        /// <param name="number">Степень корня</param>
        /// <param name="eps">Точность</param>
        /// <returns>Результат извлечения корня n-й степени из числа</returns>
        public static double SqrtNewton(double number, double degree, double eps = 0.0001)
        {
            var x0 = number / degree;
            var x1 = (1 / degree) * ((degree - 1) * x0 + number / Power(x0, (int)degree - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / degree) * ((degree - 1) * x0 + number / Power(x0, (int)degree - 1));
            }

            return x1;
        }

        /// <summary>
        /// Метод сравнения работы пользовательского метода нахождения корня n-й степени числа с методом из библиотеки классов Math
        /// </summary>
        /// <param name="degre">Число, корень из которого нужно найти</param>
        /// <param name="number">Степень корня</param>
        /// <param name="eps">Точность</param>
        /// <returns>Возвращает true в случае идентичных результатов методов, иначе false</returns>
        public static bool compareMethods(double number, double degree, double eps = 0.0001)
        {
            return Math.Round(Math.Pow(number, 1.0 / degree), 5) == Math.Round(SqrtNewton(number, degree, eps), 5);
        }
    }
}
