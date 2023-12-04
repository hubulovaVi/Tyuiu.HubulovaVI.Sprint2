using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HubulovaVI.Sprint2.Task3.V7.Lib
{
    public class DataService : ISprint2Task3V7
    {
        public double Calculate(double x)
        {
            double res;
            if (x > 1) res = x * Math.Pow(((x * x + 1) / (x - 1)), x);
            else if (x == 0) res = (x * x - Math.Pow(Math.Cos(x), 2) + 10) / (x * x - Math.Pow(Math.Sin(x), 2) + 12);
            else if (x < 2 && x > -11) res = Math.Pow(7 + (1) / (x * x), 2);
            else if (x < -11) res = Math.Pow(x, 4) - (3 / x);
            else
            {
                res = -1;
                Console.WriteLine("X не подошло ни под одно условие");
            }
            return Math.Round(res, 3);
        }
    }
}