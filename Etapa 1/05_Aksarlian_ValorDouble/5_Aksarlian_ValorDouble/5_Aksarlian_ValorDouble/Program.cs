using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Aksarlian_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double ancho;
            double alto;
            double diagonal;

            Console.WriteLine("escriba un ancho para el rectangulo");
            ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba un alto para el rectangulo");
            alto = int.Parse(Console.ReadLine());
            Console.WriteLine("el perimetro del rectangulo es " + ((ancho * 2) + (alto * 2)));
            Console.WriteLine("el area del rectangulo es " + (ancho * alto));
            Console.WriteLine("la diagonal del rectangulo es " + (Math.Sqrt((ancho * ancho) + (alto * alto))));
            Console.ReadKey();
        }
    }
}
