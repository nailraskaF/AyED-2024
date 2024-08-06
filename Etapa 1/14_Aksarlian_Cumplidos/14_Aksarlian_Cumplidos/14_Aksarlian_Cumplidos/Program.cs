using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Aksarlian_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int año;
            Console.WriteLine("cuantos años tenes?");
            edad = int.Parse(Console.ReadLine());
            año = 2025 - edad;
            edad = 1;
            while (año <= 2024)
            { 
                Console.WriteLine("en " + (año) + " cumpliste " + (edad) + " años");
                año++;
                edad++;
            }
            Console.ReadKey();
        }
    }
}
