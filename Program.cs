using System;
using System.IO;

namespace Файлы
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (var sw = new StreamWriter(@"C:\Users\SONY\Desktop\1.txt",true))
            {
                sw.Write("Hello");  
            }
            
        }
    }
}
