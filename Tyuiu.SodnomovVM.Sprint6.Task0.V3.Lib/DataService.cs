using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SodnomovVM.Sprint6.Task0.V3.Lib
{
    public class DataService : ISprint6Task0V3
    {
        public double Calculate(int x)
        {
            int result = (4 * x * x * x) / (x * x * x - 1);
            return result;
        }
    }
}
