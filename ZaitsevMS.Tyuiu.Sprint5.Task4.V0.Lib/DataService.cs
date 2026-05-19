using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace ZaitsevMS.Tyuiu.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();
            double x = Convert.ToDouble(strX);
            double y = 1.0 / Math.Cos(x) + 2.2 * x * x;
            return Math.Round(y, 3);
        }
    }
}