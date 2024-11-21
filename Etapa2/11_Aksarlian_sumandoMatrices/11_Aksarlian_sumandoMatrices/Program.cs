namespace _11_Aksarlian_SumandoMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;


            Console.WriteLine("columnas");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("filas");
            m = int.Parse(Console.ReadLine());


            int[,] matriz = new int[n, m];

            int[,] zirtam = new int[n, m];

            int[,] resultado = new int[n, m];

            Random rng = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rng.Next(1, 10);
                    zirtam[i, j] = rng.Next(1, 10);
                }
            }
            Console.WriteLine("-------matriz 1-------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.Write(matriz[i, j] + "\t");

                }
                Console.WriteLine("");
            }
            Console.WriteLine("-------2da matriz-------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.Write(zirtam[i, j] + "\t");

                }
                Console.WriteLine("");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    resultado[i, j] = zirtam[i, j] + matriz[i, j];
                }
            }
            Console.WriteLine("-------suma de las dos anteriores-------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(resultado[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
