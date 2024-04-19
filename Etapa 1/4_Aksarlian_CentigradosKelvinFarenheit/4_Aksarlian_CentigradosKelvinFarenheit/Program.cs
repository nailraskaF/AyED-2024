using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Aksarlian_CentigradosKelvinFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius;
            double farenheit;
            double kelvin;

            Console.WriteLine("decime una cantidad de grados celsius para pasarlos a farenheit y kelvin");
            celsius = int.Parse(Console.ReadLine());
            Console.WriteLine(celsius + "°C es igual a " + (celsius + 273) + "°K");
            Console.WriteLine(celsius + "°C es igual a " + (celsius*18/10+32) + "°F");

            Console.ReadKey();
        }
    }
}
