using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Aksarlian_TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("escribe un numero el cual quieras saber su tabla de multiplicar");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("1x" + num + "= " + num * 1);
            Console.WriteLine("2x" + num + "= " + num * 2);
            Console.WriteLine("3x" + num + "= " + num * 3);
            Console.WriteLine("4x" + num + "= " + num * 4);
            Console.WriteLine("5x" + num + "= " + num * 5);
            Console.WriteLine("6x" + num + "= " + num * 6);
            Console.WriteLine("7x" + num + "= " + num * 7);
            Console.WriteLine("8x" + num + "= " + num * 8);
            Console.WriteLine("9x" + num + "= " + num * 9);
            Console.WriteLine("10x" + num + "= " + num * 10);
            Console.ReadKey();

        }
    }
}
