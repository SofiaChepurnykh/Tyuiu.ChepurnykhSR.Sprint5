using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChepurnykhSR.Sprint5.Task3.V3.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint5.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнила: Чепурных С. Р. | ИСТНб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #5                                                  *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл           *");
            Console.WriteLine("* Задание #3                                                 *");
            Console.WriteLine("* Вариант #3                                                 *");
            Console.WriteLine("* Выполнила: Чепурных Софья Романовна | ИСТНб-23-1           *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат *");
            Console.WriteLine("* сохранить в бинарный файл OutPutFileTask0.bin и            *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.*");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int x = 3;
            Console.WriteLine("x =" + x);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");


            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
