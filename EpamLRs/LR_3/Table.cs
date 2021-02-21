using System;

namespace LR_3
{
    static class Table
    {
        static public int widthCol1 { get; set; }
        static public int widthCol2 { get; set; }
        static public int widthCol3 { get; set; }

        static private string nameCols1;
        static private string nameCols2;
        static private string nameCols3;

        static Table()
        {
            nameCols1 = "Значение аргумента x";
            nameCols2 = "Значение функции f(x)";
            nameCols3 = "Количество просуммированных членов ряда";


            widthCol1 = nameCols1.Length;
            widthCol2 = nameCols2.Length;
            widthCol3 = nameCols3.Length;
        }
        public static void Head()     //Вывод шапки
        {
            Console.Write("┌");
            Console.Write(new string('─', widthCol1));
            Console.Write("┬");
            Console.Write(new string('─', widthCol2));
            Console.Write("┬");
            Console.Write(new string('─', widthCol3));
            Console.WriteLine("┐");

            string s = "|{0,-" + widthCol1.ToString() + "}|{1,-" + widthCol2.ToString() + "}|{2,-" + widthCol3.ToString() + "}|";
            Console.WriteLine(s, nameCols1, nameCols2, nameCols3);

            Console.Write("├");
            Console.Write(new string('─', widthCol1));
            Console.Write("┼");
            Console.Write(new string('─', widthCol2));
            Console.Write("┼");
            Console.Write(new string('─', widthCol3));
            Console.WriteLine("┤");
        }

        public static void End()              //Вывод основания
        {
            Console.Write("└");
            Console.Write(new string('─', widthCol1));
            Console.Write("┴");
            Console.Write(new string('─', widthCol2));
            Console.Write("┴");
            Console.Write(new string('─', widthCol3));
            Console.WriteLine("┘");
        }
    }
}
