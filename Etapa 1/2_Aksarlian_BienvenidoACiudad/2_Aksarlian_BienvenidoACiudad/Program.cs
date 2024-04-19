using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Aksarlian_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string ciudad;
            Console.WriteLine("como es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("decime una ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine("hola " + nombre + " bienvenido a " + ciudad);

            Console.ReadKey();
        }
    }
}
