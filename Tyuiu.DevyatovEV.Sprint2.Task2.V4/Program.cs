using Tyuiu.DevyatovEV.Sprint2.Task2.V4.Lib;

namespace Tyuiu.DevyatovEV.Sprint2.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#2 | Выполнил: Девятов Е.В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые                        *");
            Console.WriteLine("* значения с клавиатуры и вычисляет находится ли                          *");
            Console.WriteLine("* точка с координатами X,Y в заштрихованной области.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите точку X                                                         *");
            int x;
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* Введите точку Y                                                         *");
            int y;
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckDotInShadedArea(x, y) == true)
            {
                Console.WriteLine("Точка принадлежит области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит области");
            }
            Console.ReadKey();
        }
    }
}
