using System;
using System.Globalization;

namespace LR_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------    LR_3 Task 1    -----------------------------------------

            try
            {
                Console.Write("Введите значение аргумента функции в диапазоне [-5, 5]: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"f(x) = {Function.Func(x)}");
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }

            //------------------------------------    LR_3 Task 2    -----------------------------------------
            double xn;
            double xk;
            double dx;

            try
            {
                Console.Write("Введите начальное значение аргумента xn > 0.5: ");
                xn = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите конечное значение аргумента xk > xn: ");
                xk = Convert.ToDouble(Console.ReadLine());

                if (xk <= xn)
                {
                    throw new ArgumentException($"Введено некорректное значение. Конечное значение аргумента {nameof(xk)} не может быть меньше или равно начальному!");
                }
                Console.Write("Введите шаг dx: ");

                dx = Convert.ToDouble(Console.ReadLine());
                if (dx <= 0)
                {
                    throw new ArgumentException($"Введено некорректное значение. Шаг {nameof(dx)} не может быть отрицательным или равным 0!");
                }

                Console.WriteLine();
                Console.WriteLine("\t\tВычисление значения функции с помощью ряда Тейлора");
                Table.Head();
                TaylorsRow.TRow(xn, xk, dx);
                Table.End();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " Измените язык ввода данных на RU!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
