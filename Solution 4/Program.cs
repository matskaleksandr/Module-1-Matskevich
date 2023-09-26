using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 0;//Максимальное значение в массиве
            int minValue = 0;//Минимальное значение в массиве
            try
            {
                Random random = new Random();//Создание объекта Random для генерации случайных чисел
                int[] randomArray = new int[20];//Создание массива для хранения 20 целых чисел
                Console.WriteLine("Массив:");
                //Заполнение массива случайными числами и вывод каждого элемента
                for (int i = 0; i < randomArray.Length; i++)
                {
                    randomArray[i] = random.Next(-100, 100);
                    Console.WriteLine(randomArray[i]);
                }
                //Поиск максимального и минимального значений в массиве
                for (int i = 1; i < randomArray.Length; i++)
                {
                    if (randomArray[i] < minValue)
                        minValue = randomArray[i];//Обновление minValue при обнаружении меньшего значения
                    if (randomArray[i] > maxValue)
                        maxValue = randomArray[i];//Обновление maxValue при обнаружении большего значения
                }
                Console.WriteLine($"Максимальный элемент массива:{maxValue}");//Вывод максимального значения
                Console.WriteLine($"Минимальный элемент массива:{minValue}");//Вывод минимального значения
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);//Перехват и вывод сообщений об ошибках, если они возникают во время выполнения
            }
        }
    }
}


