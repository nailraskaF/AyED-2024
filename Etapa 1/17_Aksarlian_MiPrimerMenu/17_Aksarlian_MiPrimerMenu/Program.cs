using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Aksarlian_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc;
            Console.WriteLine("---menu---");
            Console.WriteLine("que comida es mejor? (escriba el numero de la opcion");
            Console.WriteLine("opcion 1: milanesa");
            Console.WriteLine("opcion 2: pizza");
            Console.WriteLine("opcion 3: hamburguesa");
            opc = Console.ReadLine();
            if ((opc == "1"))
            {
                Console.Clear();
                Console.WriteLine("milanesa con pure mejor pero si te banco");
            }
            else if ((opc == "2"))
            {
                Console.Clear();
                Console.WriteLine("pizza con cebolla mejor pero si que ricoo");
            }
            else if ((opc == "3"))
            {
                Console.Clear();
                Console.WriteLine("la hamburguesa es la mejor creacion del humano");
            }
            Console.ReadKey();


        }
    }
}
