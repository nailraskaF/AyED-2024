using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Aksarlian_DimensionesDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            double superficie;
            double vol;
            float pi;
            pi = 3.14f;
            Console.WriteLine("decime el radio de una esfera para calcular su volumen y superficie");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("la superficie es " + (4 * pi * (radio * radio)));
            Console.WriteLine("el volumen es " + (4 / 3 * pi * (radio * radio * radio)));
            Console.ReadKey();
        }
    }
}
