using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaitsevMS.Tyuiu.Sprint5.Task7.V2.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Зайцев М. С. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Итоговый проект по спринту                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Зайцев Максим Сергеевич | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с набором символьных данных. Заменить все цифры на символ \"#\".*");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V2.txt.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V2.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат находится в файле: " + pathSaveFile);

            string[] lines = File.ReadAllLines(pathSaveFile);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}