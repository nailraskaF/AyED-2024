using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Aksarlian_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("decime un numero  y te digo si es par o impar");
            num = int.Parse(Console.ReadLine());
            if ((num % 2) == 0)
                Console.WriteLine("es par");
            else
                Console.WriteLine("es impar");
            Console.ReadKey();
        }
    }
}
