namespace _13_Aksarlian_ObtenerDiagonalPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Indicar el tamaño del vector y de la matriz (solo un número): ");
            num = int.Parse(Console.ReadLine());
            int[,] matriz = new int[num, num];
            int[] vector = new int[num];
            Random rndm = new Random();

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    matriz[i, j] = rndm.Next(1, 10);
                }
            }
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < num; i++)
            {
                vector[i] = matriz[i, i];
            }
            for (int i = 0; i < num; i++)
            {
                Console.Write(vector[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}
