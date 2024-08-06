using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Aksarlian_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("excribe un numero para hacer su cuenta regresiva");
            num = int.Parse(Console.ReadLine());
            while (num > -1)
            {
                Console.WriteLine(num);
                num--;
            }
            Console.ReadKey();
        }
    }
}
