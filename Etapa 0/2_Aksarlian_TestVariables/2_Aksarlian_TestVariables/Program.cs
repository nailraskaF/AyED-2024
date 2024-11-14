using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Aksarlian_TestVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int entero;
            bool boolean;
            float flotante;
            double doble;
            char caracter;

            cadena = "15.557294";
            entero = 15;
            boolean = false;
            flotante = 15.557294f;
            doble = 15.557294;
            caracter = '1';

            Console.WriteLine("string: " + cadena);
            entero = int.Parse(Console.ReadLine());
            Console.WriteLine("int: "+ entero);
            Console.WriteLine("bool: " + boolean);
            Console.WriteLine("float: " + flotante);
            Console.WriteLine("double: " + doble);
            Console.WriteLine("char: " + caracter);

            Console.ReadKey();
        }
    }
}
