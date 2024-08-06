using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Aksarlian_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int contador;
            contador = 0;
            Console.WriteLine("escribe una palabra para repetirla 10 veces");
            palabra = Console.ReadLine();
            while (contador < 10)
            {
                contador ++;
                Console.WriteLine(palabra);
            }
            Console.ReadKey();

        }
    }
}
