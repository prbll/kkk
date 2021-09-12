using System;
using System.IO;

namespace Файлы
{
    class Program
    {
        public static double S { get; set; }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите радиус окружности: ");
               
                try
                {
                    double rad = Convert.ToDouble(Console.ReadLine());
                    if (rad > 0)
                    {
                        S = Math.PI * Math.Pow(rad, 2); //Площадь круга
                        Console.WriteLine($"Площадь круга равна {S} м. кв.");
                    // записать в файл
                        using (var sw = new StreamWriter(@"C:\Users\SONY\Desktop\1.txt", true))
                        {
                            sw.WriteLine($"Радиус окружности: {rad}, Площадь круга: {S} М. Кв. ");
                            sw.Close();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Число не может быть отрицательным");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
        }
    }
}
