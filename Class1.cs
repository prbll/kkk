using System;
using System.Linq;


namespace BANKI_DZ
{
    class Class1
    {
        private string[] NameMas { get; set; }  // передать сюда массив имен
        private int[] MoneyMas { get; set; } 
        private int RazmerMas { get; set; } // размер массива
        public void DataAboutPerson()
        {
            while (true)// бесконечный цикл
            {
                try // обрабатываем исключения
                {
                    Console.WriteLine("Введите количество людей");
                    RazmerMas = Convert.ToInt32(Console.ReadLine());// количество имен.
                    string name;// для записи имени.
                    int money;// для записи кол-ва денег.

                    NameMas = new string[RazmerMas]; // задаем размеры массивов
                    MoneyMas = new int[RazmerMas];

                    for (int i = 0; i < RazmerMas; i++)
                    {
                        Console.WriteLine($"Введите Ф.И. {i + 1} человека");
                        name = Console.ReadLine();// ввод имени с консоли.
                        Console.Write(i + 1 + " Перечисленные деньги - ");
                        money = Convert.ToInt32(Console.ReadLine());
                        NameMas[i] = name; //запись в массив имен.
                        MoneyMas[i] = money; // запись.
                    }
                    //вывод
                    Console.WriteLine();
                    for (int i = 0; i < RazmerMas; i++)
                    {
                        Console.WriteLine($"{i + 1} Перевели на имя: {NameMas[i]}, {MoneyMas[i]} руб.");
                    }
                    //1 задача
                    Console.WriteLine(NameMas.Select((x, i) => (x, MoneyMas[i])).GroupBy(g => g.x).Where(g => g.Count() == 1).Select(x => x.First()).OrderBy(x => x.Item2).FirstOrDefault());
                    //2 задача
                    var res = NameMas.GroupBy(x => x?.ToLower()).OrderByDescending(x => x?.Count());
                    Console.WriteLine($" На счет {res.First().Key}  транзакции {res.First().Count()} раз(а)");
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный ввод данных");
                }
                Console.WriteLine();
            }
        }
    }
}

