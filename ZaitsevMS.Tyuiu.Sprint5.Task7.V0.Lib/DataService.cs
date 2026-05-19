using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace ZaitsevMS.Tyuiu.Sprint5.Task7.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V2.txt");

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string strLine = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsDigit(line[i]))
                        {
                            strLine += '#';
                        }
                        else
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}