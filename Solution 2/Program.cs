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
            double radius;
            string radiusInput;
            double area = 0;
            try
            {
                do
                {
                    Console.Write("Введите радиус круга: ");
                    radiusInput = Console.ReadLine();
                }
                while (!double.TryParse(radiusInput, out radius));
                if (radius >= 0)
                {
                    area = Math.PI * radius * radius;
                    Console.WriteLine($"Площадь круга с радиусом {radius} равна: {area}");
                }
                else
                {
                    Console.WriteLine("Радиус не может быть отрицательным");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
