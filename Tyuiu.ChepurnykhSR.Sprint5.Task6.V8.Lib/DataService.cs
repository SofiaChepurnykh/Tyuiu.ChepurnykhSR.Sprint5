using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChepurnykhSR.Sprint5.Task6.V8.Lib
{
    public class DataService : ISprint5Task6V8
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0, res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ' ')
                    {
                        if (count == 2)
                        {
                            res++;
                            count = 0;
                        }
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            return res; //Я вижу небо. Оно не  голубое, но похожее.
        }
    }
}
