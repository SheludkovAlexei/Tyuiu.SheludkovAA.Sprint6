using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader rdr = new StreamReader(path))
            {
                string[] ln1;
                string line;
                while ((line = rdr.ReadLine()) != null)
                {
                    ln1 = line.Split(' ');
                    for (int i = 0; i < ln1.Length; i++)
                    {
                        if (ln1[i].Contains("n"))
                        {
                            res = res + " " + ln1[i];
                        }
                    }
                }
                
            }
            return res;
        }
    }
}
