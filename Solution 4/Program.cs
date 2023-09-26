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
            try
            {
                int maxValue = 0;
                int minValue = 0;
                Random random = new Random();
                int[] randomArray = new int[20];
                Console.WriteLine("Массив:");
                for (int i = 0; i < randomArray.Length; i++)
                {
                    randomArray[i] = random.Next(-100, 100);
                    Console.WriteLine(randomArray[i]);
                }
                for (int i = 1; i < randomArray.Length; i++)
                {
                    if (randomArray[i] < minValue)
                        minValue = randomArray[i];

                    if (randomArray[i] > maxValue)
                        maxValue = randomArray[i];
                }
                Console.WriteLine($"Максимальный элемент массива:{maxValue}");
                Console.WriteLine($"Минимальный элемент массива:{minValue}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

