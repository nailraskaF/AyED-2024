using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Aksarlian_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            palabra = "";
            while (palabra != "SI")
            {
                Console.WriteLine("desea terminar este programa?");
                palabra = Console.ReadLine();
            }
            if (palabra == "SI")
            {
                Console.Clear();
                Console.WriteLine("Hasta luego");
            }
            Console.ReadKey();
        }
    }
}
