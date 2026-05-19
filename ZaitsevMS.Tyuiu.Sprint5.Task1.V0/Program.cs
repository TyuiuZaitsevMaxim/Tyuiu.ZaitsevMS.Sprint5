using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ZaitsevMS.Tyuiu.Sprint5.Task1.V4.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task1.V4 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Зайцев М. С. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Зайцев Максим Сергеевич | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Табулирование F(x)=cos(x)/(x+1) - cos(x)*1.3+3x на [-5;5] с шагом 1.  *");
            Console.WriteLine("* При делении на ноль вернуть 0. Результат сохранить в файл и вывести     *");
            Console.WriteLine("* на консоль.                                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");
            Console.WriteLine();

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");

            string[] lines = File.ReadAllLines(path);
            int x = startValue;
            foreach (string line in lines)
            {
                Console.WriteLine("| {0,5:d}    |  {1,6}  |", x, line);
                x++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadLine();
        }
    }
}