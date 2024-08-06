using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Aksarlian_CobrarBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, ingresos;
            Console.WriteLine("cual es tu edad?");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("cuales son tus ingresos?");
            ingresos = int.Parse(Console.ReadLine());
            if (edad >= 19 & ingresos >= 100000){
                Console.WriteLine("podes cobrar la beca");
            }
            else
            {
                Console.WriteLine("no podes cobrar la beca");
            }
            Console.ReadKey();

        }
    }
}
