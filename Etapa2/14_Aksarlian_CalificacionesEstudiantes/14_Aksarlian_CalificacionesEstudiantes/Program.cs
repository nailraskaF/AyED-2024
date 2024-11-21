namespace _14_Aksarlian_CalificacionesEstudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int estudiantes;

            Console.Write("Ingrese la cantidad de estudiantes: ");
            estudiantes = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            string[,] matriz = new string[3, estudiantes];

            for (int i = 0; i < estudiantes; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Colocar el nombre, edad y calificacion (en ese orden y cada vez que escriba un dato pulse enter): ");
                    matriz[j, i] = Console.ReadLine();

                    Console.Clear();
                }
                Console.WriteLine();
            }
            for (int i = 0; i < estudiantes; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[j, i] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
