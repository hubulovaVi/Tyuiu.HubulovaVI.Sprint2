using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HubulovaVI.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool isAboveParabola = y >= x * x - 2;
            bool isBelowLine = y <= -x;
            bool isRightOfYEqualsX = x >= y;

            return isAboveParabola && isBelowLine && isRightOfYEqualsX;
        }
    }
}