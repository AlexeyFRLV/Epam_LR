using System;

namespace LR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Данные для тестирования
            double number = 25.0;
            double degree = 3.0;
            double eps = 0.0000001;

            //Эта часть кода сработает только в случае возврата одинаковых результатов пользовательского метода и метода Pow() класса Math
            if (NewtonsMethod.compareMethods(number, degree, eps))
            {
                Console.WriteLine($"Корень {degree} степени из числа {number} = {NewtonsMethod.SqrtNewton(number, degree, eps)}");
            }

            //результаты работы методов по отдельности (для тестирования)
            //Console.WriteLine(Math.Pow(number, 1.0 / degree));
            //Console.WriteLine(NewtonsMethod.SqrtNewton(number, degree, eps));
            Console.WriteLine();

            //Конвертируем число n из десятичной системы счисления в двоичную
            int n = 2;
            Console.WriteLine($"Число {n} в двоичной системе счисления (Convert.ToString())= {ConvertNumber.ConvTo(n)}");
            Console.WriteLine($"Число {n} в двоичной системе счисления (пользовательский метод)= {ConvertNumber.ConvTo2(n)}");
        }
    }
}
