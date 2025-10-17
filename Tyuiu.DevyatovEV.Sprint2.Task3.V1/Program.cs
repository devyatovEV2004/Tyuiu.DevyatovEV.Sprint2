using Tyuiu.DevyatovEV.Sprint2.Task3.V1.Lib;

namespace Tyuiu.DevyatovEV.Sprint2.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            DataService ds = new DataService();
            Console.Title = "Спринт#2 | Выполнил: Девятов Е.В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
            Console.WriteLine("* функции Y с использованием вложенных оператор if-else, где пользователь *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры. Округлить полученное         *");
            Console.WriteLine("* значение до трех знаков после запятой;                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x));
            Console.ReadKey();
        }
    }
}