using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            // old
            Console.WriteLine($"Приветствую тебя,{Properties.Settings.Default.UserName}");
            Console.WriteLine($"Возраст - {Properties.Settings.Default.Age}");
            Console.WriteLine($"Профессия - {Properties.Settings.Default.Occupation}");

            Console.WriteLine("Введите имя нового пользователя:");
            Properties.Settings.Default.UserName = Console.ReadLine();

            Console.WriteLine("Введите возраст нового пользователя:");
            Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите профессию нового пользователя:");
            Properties.Settings.Default.Occupation = Console.ReadLine();

            Properties.Settings.Default.Save();

            // new
            Console.WriteLine($"Приветствую тебя,{Properties.Settings.Default.UserName}");
            Console.WriteLine($"Возраст - {Properties.Settings.Default.Age}");
            Console.WriteLine($"Профессия - {Properties.Settings.Default.Occupation}");

            Console.ReadKey();
        }
    }
}
