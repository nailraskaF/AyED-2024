using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Aksarlian_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            Console.WriteLine("escriba un numero q quiera dividir por otro");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escribe el numero x el que quiera dividir el otro");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == 0) {
                Console.WriteLine("se ha producido un error");
            }
            else {
                Console.WriteLine("el resultado es " + num1 / num2);
            }
            Console.ReadKey();
                
        }
    }
}
