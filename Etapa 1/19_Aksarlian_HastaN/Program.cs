using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Aksarlian_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, N;
            Console.WriteLine("decime un numero");
            N = int.Parse(Console.ReadLine());
            num = 0;
            while (N > num)
            {
                Console.WriteLine(num);
                num=num+2;
            }
            Console.WriteLine(N);
            Console.ReadKey();
        }
    }
}
