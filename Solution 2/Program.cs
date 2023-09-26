using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;//Переменная для хранения радиуса круга
            string radiusInput;//Строковая переменная для хранения введенного радиуса
            double area = 0;//Переменная для хранения площади круга
            try
            {
                do
                {
                    Console.Write("Введите радиус круга: ");
                    radiusInput = Console.ReadLine();//Запрос радиуса у пользователя
                    //Повторять ввод, пока не будет введено корректное число
                }
                while (!double.TryParse(radiusInput, out radius));
                if (radius >= 0)
                {
                    area = Math.PI * radius * radius;//Вычисление площади круга
                    //Вывод площади круга с заданным радиусом
                    Console.WriteLine($"Площадь круга с радиусом {radius} равна: {area}");
                }
                else
                {
                    Console.WriteLine("Радиус не может быть отрицательным");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());//Перехват и вывод сообщений об ошибках, если они возникают во время выполнения
            }
        }
    }
}
