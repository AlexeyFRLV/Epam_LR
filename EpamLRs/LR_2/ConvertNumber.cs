using System;
using System.Collections.Generic;

namespace LR_2
{
    static class ConvertNumber
    {
        /// <summary>
        /// Метод для перевода положительного числа из десятичной системы счисления в двоичную
        /// </summary>
        /// <param name="number">число, которое необходимо перевести</param>
        /// <returns>двоичный код числа</returns>
        public static string ConvTo(int number)
        {
            if (number < 0)
            {
                return "Некорректный ввод. Число должно быть положительное!";
            }
            else
            {
                return Convert.ToString(number, 2);
            }
        }

        /// <summary>
        /// Метод для перевода положительного числа из десятичной системы счисления в двоичную
        /// </summary>
        /// <param name="number">число, которое необходимо перевести</param>
        /// <returns>двоичный код числа</returns>
        public static string ConvTo2(int number)
        {
            if (number < 0)
            {
                return "Некорректный ввод. Число должно быть положительное!";
            }
            else if (number == 0)
            {
                return "0";
            }
            else if (number == 1)
            {
                return "1";
            }
            else
            {
                Stack<byte> digits = new Stack<byte>();               //хранилище для битов
                byte temp = 0;                                        //переменная для записи остатка от деления
                string binaryCode = "";

                while (true)
                {
                    temp = (byte)(number % 2);
                    number /= 2;
                    digits.Push(temp);

                    if (number == 1 || number == 0)
                    {
                        digits.Push((byte)number);
                        break;
                    }
                }

                foreach (byte digit in digits)
                {
                    binaryCode += digit.ToString();
                }

                return binaryCode;
            }
        }
    }
}
