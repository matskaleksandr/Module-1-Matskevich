using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int iAge = 0;//Переменная для хранения возраста
                string sAge = "";//Строковая переменная для хранения возраста
                int iValue;//Переменная для проверки успешного преобразования строки в число
                do
                {
                    Console.WriteLine("Сколько вам лет");
                    sAge = Console.ReadLine();//Запрос возраста у пользователя
                    //Повторять ввод, пока не будет введено корректное число
                }
                while (!int.TryParse(sAge, out iValue));
                iAge = Convert.ToInt32(sAge);//Преобразование строки в целое число
                //Проверка возраста и вывод соответствующего сообщения
                if (iAge > 18)
                    Console.WriteLine("Вы можете получить водительские права");
                else
                    Console.WriteLine("Вы не можете получить водительские права");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());//Перехват и вывод сообщений об ошибках, если они возникают во время выполнения
            }
        }
    }
}
