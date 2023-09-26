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
                int iAge = 0;
                string sAge = "";
                int iValue;
                do
                {
                    Console.WriteLine("Сколько вам лет");
                    sAge = Console.ReadLine();
                }
                while (int.TryParse(sAge, out iValue) != true);
                iAge = Convert.ToInt32(sAge);
                if (iAge > 18)
                    Console.WriteLine("Вы можете получить водительские права");
                else
                    Console.WriteLine("Вы не можете получить водительские права");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
