using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace ZaitsevMS.Tyuiu.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            string content = File.ReadAllText(path).Trim();
            string[] tokens = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                double val = Convert.ToDouble(token.Replace('.', ','));
                if (val == Math.Floor(val) && IsPrime((int)val))
                {
                    sum += val;
                }
            }

            return sum;
        }
    }
}