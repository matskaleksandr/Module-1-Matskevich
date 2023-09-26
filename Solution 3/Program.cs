using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Solution_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string surname = "";
                string name = "";
                string pattern = @"^[А-ЯЁ][а-яё]*$";
                Console.WriteLine("Введите фамилию");
                do
                {
                    surname = Console.ReadLine();
                }
                while (!Regex.IsMatch(surname, pattern));
                Console.WriteLine("Введите имя");
                do
                {
                    name = Console.ReadLine();
                }
                while (!Regex.IsMatch(name, pattern));
                Console.WriteLine();
                Console.WriteLine($"{surname}, {name}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
