﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChepurnykhSR.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V15.txt";

            FileInfo fileinfo = new FileInfo(pathSaveFile);

            if (fileinfo.Exists)
            {
                File.Delete(pathSaveFile);
            }



            string text = File.ReadAllText(path);
            List<string> list = new List<string>();
            foreach (string word in text.Split(' '))
            {
                if (word.Length != 2)
                {
                    list.Add(word);
                }
                else
                {
                    list.Add("");
                }
            }

            File.AppendAllText(pathSaveFile, string.Join(" ", list));
            return pathSaveFile;
        }
    }
}
