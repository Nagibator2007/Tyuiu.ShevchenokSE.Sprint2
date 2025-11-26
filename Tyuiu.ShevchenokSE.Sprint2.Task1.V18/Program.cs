using Tyuiu.ShevchenokSE.Sprint2.Task1.V18.Lib;
namespace Tyuiu.ShevchenokSE.Sprint2.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Шевченок С.Е. | СМАРТб-25-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #18                                                                 *");
            Console.WriteLine("* Выполнил Шевченок Сергей Евгеньевич  | СМАРТб-25-1                          *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,             *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую                 *");
            Console.WriteLine("* последовательность(массив)                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int a = 155;
            int b = 696;
            int c = 242;
            int d = 541;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}