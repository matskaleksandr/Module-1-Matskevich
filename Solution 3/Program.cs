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
            string surname = "";//Переменная для хранения фамилии
            string name = "";//Переменная для хранения имени
            string pattern = @"^[А-ЯЁ][а-яё]*$";//Шаблон для проверки ввода: начинается с заглавной буквы, остальные маленькие
            try
            {
                Console.WriteLine("Введите фамилию");
                do
                {
                    surname = Console.ReadLine();//Чтение фамилии
                    //Повторять ввод, пока не будет введена корректная фамилия
                }
                while (!Regex.IsMatch(surname, pattern));//Проверка ввода по шаблону
                Console.WriteLine("Введите имя");
                do
                {
                    name = Console.ReadLine();//Чтение имени
                    //Повторять ввод, пока не будет введено корректное имя
                }
                while (!Regex.IsMatch(name, pattern));//Проверка ввода по шаблону
                Console.WriteLine();
                Console.WriteLine($"{surname}, {name}");//Вывод фамилии и имени
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);//Перехват и вывод сообщений об ошибках, если они возникают во время выполнения
            }
        }
    }
}
