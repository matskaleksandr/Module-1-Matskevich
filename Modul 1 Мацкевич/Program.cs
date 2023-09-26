using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_1_Мацкевич
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iNum;
            int iValue;
            string sNum;
            do
            {
                Console.WriteLine("Введите число которое надо проверить на чётность:");
                sNum = Console.ReadLine();
            }
            while (int.TryParse(sNum, out iValue) != true);
            iNum = Convert.ToInt32(sNum);
            Console.WriteLine(iNum % 2 == 0 ? "Число чётное" : "Число не чётное");
        }
    }
}
