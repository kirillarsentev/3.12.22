using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "note1.txt";
            //using (StreamWriter writer = new StreamWriter(path, true))
            //{
            //    writer.WriteLineAsync("Addition");
            //    writer.WriteAsync("4,5");
            //}

            string path1 = "note1.txt";
            // асинхронное чтение
            using (StreamReader reader = new StreamReader(path1))
            {
                string text = reader.ReadToEnd();
                Console.WriteLine(text);
            }
        }
    }
}
