﻿using Tyuiu.DevyatovEV.Sprint2.Task6.V9.Lib;
namespace Tyuiu.DevyatovEV.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Девятов Е.В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Девятов Е.В. | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* дату следующего дня по заданным натуральными числами:                   *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число) (n и m не характеризуют         *");
            Console.WriteLine("* 31 декабря).                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Дата следующего дня: " + res);
            Console.ReadKey();
        }
    }
}