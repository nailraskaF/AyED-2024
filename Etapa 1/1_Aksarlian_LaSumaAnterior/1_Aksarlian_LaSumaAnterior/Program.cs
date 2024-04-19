using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Aksarlian_LaSumaAnterior
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int result;

            Console.WriteLine("escriba un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("otro numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("un ultimo numero");
            num3 = int.Parse(Console.ReadLine());
            result = num1 + num2 + num3;
            Console.WriteLine("el resultado de la suma de los tres valores dados anteriormente es: " + result);

            Console.ReadKey();
        }
    }
}
