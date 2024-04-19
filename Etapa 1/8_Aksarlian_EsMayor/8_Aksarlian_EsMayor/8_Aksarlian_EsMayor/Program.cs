using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Aksarlian_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("escribe tu edad");
            edad = int.Parse(Console.ReadLine());
            if (edad < 18)
                Console.WriteLine("sos menor papu");
            else if (edad >= 18)
                Console.WriteLine("ya sos mayorcito");
            Console.ReadKey();
        }
    }
}
