using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Aksarlian_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña;
            string intento;
            contraseña = "pablito";
            Console.WriteLine("ingrese la contraseña");
            intento = Console.ReadLine();
            if (intento == contraseña)
            {
                Console.WriteLine("contraseña correcta");
            }
            else
                Console.WriteLine("la contraseña es incorrecta");
            Console.ReadKey();
        }
    }
}
