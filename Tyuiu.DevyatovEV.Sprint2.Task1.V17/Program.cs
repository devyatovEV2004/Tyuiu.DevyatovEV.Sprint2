using Tyuiu.DevyatovEV.Sprint2.Task1.V17.Lib;

namespace Tyuiu.DevyatovEV.Sprint2.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#2 | Выполнил: Девятов Е.В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операциии                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую                     *");
            Console.WriteLine("* последовательность(массив): (True, False, True, True, True, False),     *");
            Console.WriteLine("* при a = 135, b = 123, c = 455, d = 321                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 135, b = 123, c = 455, d = 321                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
