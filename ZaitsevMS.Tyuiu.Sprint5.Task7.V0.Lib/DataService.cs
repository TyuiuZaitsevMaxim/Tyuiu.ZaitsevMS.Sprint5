using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace ZaitsevMS.Tyuiu.Sprint5.Task7.V0.Lib
{
    public class DataService : ISprint5Task7V0
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutputFileTask7.txt";

            FileInfo fI = new FileInfo(pathSaveFile);
            bool fEx = fI.Exists;

            if (fEx)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string Line;
                while ((Line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < Line.Length; i++)
                    {
                        if ((Line[i] != '*') && (Line[i] != '/') && (Line[i] != '+') && (Line[i] != '-'))
                        {
                            strLine = strLine + Line[i];
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }

            return pathSaveFile;
        }
    }
}
