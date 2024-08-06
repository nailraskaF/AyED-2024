using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Aksarlian_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("escribe un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escribe otro numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
            Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
            Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
            Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
            Console.WriteLine("el resto de " + num1 + "/" + num2 + " es igual a " + (num1 % num2));

            Console.ReadKey();
        }
    }
}
