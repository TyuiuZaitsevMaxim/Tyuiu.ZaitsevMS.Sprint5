using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace ZaitsevMS.Tyuiu.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                double denom = x + 1;

                if (denom == 0)
                {
                    y = 0.0;
                }
                else
                {
                    y = Math.Cos(x) / denom - Math.Cos(x) * 1.3 + 3 * x;
                }

                string strY = Math.Round(y, 2).ToString();

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}