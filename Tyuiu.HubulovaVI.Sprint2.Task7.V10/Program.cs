using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.HubulovaVI.Sprint2.Task7.V10.Lib;

namespace Tyuiu.HubulovaVI.Sprint2.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Хубулова В. И. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Хубулова Валерия Игоревна | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной     *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координату X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService dataService = new DataService();
            bool isInShadedRegion = dataService.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (isInShadedRegion)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка находится вне заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}