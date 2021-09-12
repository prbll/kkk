using System;
using System.Linq;

namespace Banki
{
    public class DataAboutPerson
    {
        private string Name { get; set; }
        private string LastName { get; set; }
        private int Money { get; set; }

        private string DataAboutPerson1(string name, string lastname)
        {
            Name = name; // имя на которые были перечислены деньги
            LastName = lastname; // фамилия на которые были перечислены деньги
            // Money = money; перечисленные деньги
            return name + " " + lastname;
        }
        private int DataAboutMoney(int Money)
        {
            this.Money = Money;
            return Money;
        }
       public void DataInputandOutput() 
       {
         while (true)
         {
            try
            {
                Console.WriteLine("Введите количество транзакций");
                int n = Convert.ToInt32(Console.ReadLine()); // количество транзакций
                string[] nameMas = new string[n]; // задаем размер массива (имя фамилия)
                int[] moneyMas = new int[n];// задаем размер массива (деньги)
                string name;
                string lastname;
                int money;
                for (int i = 0; i < n; i++)
                {
                    //Ввод данных
                    Console.Write(i + 1 + " Введите Имя - ");
                    name = Console.ReadLine();
                    Console.Write(i + 1 + " Введите Фамилию - ");
                    lastname = Console.ReadLine();
                    Console.Write(i + 1 + " Перечисленные деньги - ");
                    money = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    // конец ввода данных

                    nameMas[i] = DataAboutPerson1(name, lastname); // запись в массив
                    moneyMas[i] = DataAboutMoney(money);
                    //вывод данных в ранее записанный массив
                    
                   
                }
                    for (int i = 0; i < nameMas.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} Перевели на имя: {nameMas[i]}, {moneyMas[i]} руб.");
                    }
                    //1 задача
                    Console.WriteLine(nameMas.Select((x, i) => (x, moneyMas[i])).GroupBy(g => g.x).Where(g => g.Count() == 1).Select(x => x.First()).OrderBy(x => x.Item2).FirstOrDefault());
                    //2 задача
                    var res = nameMas.GroupBy(x => x?.ToLower()).OrderByDescending(x => x?.Count());
                    Console.WriteLine($" На счет {res.First().Key}  транзакции {res.First().Count()} раз(а)");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при вводе данных!");
            }
         }
       }
     #region 1
            //int[] moneyMas1 = moneyMas.Distinct().ToArray();// Убираем одинаковые
            //Array.Sort(moneyMas1);
            //Console.WriteLine();
            //Console.WriteLine($"min value {moneyMas1[0]}");
            //Array.Sort(nameMas,moneyMas);
            //for (int i = 0; i < moneyMas.Length; i++)
            //{
            //    Console.WriteLine($"{nameMas[i]}, {moneyMas[i]}");
            //}
            #endregion
    }
}

