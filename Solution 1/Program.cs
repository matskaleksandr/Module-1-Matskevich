using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iNum;//Переменная для хранения введенного числа
            int iValue;//Переменная для проверки успешного преобразования строки в число
            string sNum;//Строковая переменная для хранения введенного числа
            try
            {
                do
                {
                    Console.WriteLine("Введите число, которое надо проверить на чётность:");
                    sNum = Console.ReadLine();//Запрос числа у пользователя
                    //Повторять ввод, пока не будет введено корректное число
                }
                while (!int.TryParse(sNum, out iValue));

                iNum = Convert.ToInt32(sNum);//Преобразование строки в целое число
                //Проверка числа на четность и вывод соответствующего сообщения
                Console.WriteLine(iNum % 2 == 0 ? "Число чётное" : "Число не чётное");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);//Перехват и вывод сообщений об ошибках, если они возникают во время выполнения
            }
        }
    }
}

