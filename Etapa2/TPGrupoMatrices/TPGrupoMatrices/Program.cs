namespace TPGrupoMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, tipo;
            int nivel, opcion = 0, val = 0, numinves = 0, eleccus, numaum, auxi;
            string[,] matriz = new string[76, 6];
            Random rng = new Random();
            bool comprob = true, par = true;
            string[] vector = new string[6];

            vector[0] = "FILA";
            vector[1] = "NOMBRE";
            vector[2] = "TIPO";
            vector[3] = "NIVEL";
            vector[4] = "ESTADO";
            vector[5] = "NÚMERO DE INVESTIGADOR";


            while (par == true)
            {

                Console.WriteLine("-----------------MENÚ POCHIMON-----------------");
                Console.WriteLine("1)Registrar un Pochimon.");
                Console.WriteLine("2)Asignar investigador a Pochimon.");
                Console.WriteLine("3)Actualizar nivel de Pochimon.");
                Console.WriteLine("4)Marcar Pochimon como investigado.");
                Console.WriteLine("5)Mostrar información de Pochimons.");
                Console.WriteLine("6)Buscar Pochimons por su tipo.");
                Console.WriteLine("7)Mostrar Pochimons por investigador.");
                Console.WriteLine("8)Mostrar Pochimons superiores(nivel mayor a 30)");
                Console.WriteLine("9)Salir.");
                Console.WriteLine("-----------------------------------------------");

                Console.WriteLine("elegi una opcion del menu");
                opcion = int.Parse(Console.ReadLine());

                while (opcion < 1 || opcion > 9)
                {
                    Console.WriteLine("ERROR!!!Elegi una opcion que este en el manu");
                    opcion = int.Parse(Console.ReadLine());
                }
                eleccus = 0;
                comprob = true;
                numinves = 0;
                switch (opcion)
                {


                    case 1:
                        Console.Clear();

                        if (val == 75)
                        {
                            Console.WriteLine("Ya la Pochidex esta llena...");
                            break;
                        }

                        Console.WriteLine("-----------------MENÚ REGISTRO-----------------");

                        Console.Write("Ingrese nombre del Pochimon: ");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el tipo de " + nombre);
                        Console.WriteLine("Tipos:");
                        Console.WriteLine("Fuego / Agua / Tierra / Marino / Eléctrico / Planta / Hada.");
                        Console.WriteLine("(Coloque solo la inicial del tipo).");
                        tipo = (Console.ReadLine()).ToUpper();
                        while (tipo != "F" && tipo != "A" && tipo != "T" && tipo != "M" && tipo != "E" && tipo != "P" && tipo != "H")
                        {
                            Console.WriteLine("Coloque las letras correspondientes para asignar un tipo");
                            tipo = (Console.ReadLine()).ToUpper();
                        }

                        Console.WriteLine(" ");
                        Console.Write("Ingrese el nivel de " + nombre + ": ");
                        nivel = int.Parse(Console.ReadLine());
                        while (nivel < 0 || nivel > 100)
                        {
                            Console.WriteLine("ERROR!!!. Ingrese un número entre el 1 y el 100");
                            nivel = int.Parse(Console.ReadLine());
                        }
                        matriz[val, 0] = (val + 1).ToString();
                        matriz[val, 1] = nombre;
                        if (tipo == "F")
                        {
                            tipo = ("FUEGO");
                        }
                        if (tipo == "A")
                        {
                            tipo = "AGUA";
                        }
                        if (tipo == "T")
                        {
                            tipo = "TIERRA";
                        }
                        if (tipo == "M")
                        {
                            tipo = "MARINO";
                        }
                        if (tipo == "E")
                        {
                            tipo = "ELECTRICO";
                        }
                        if (tipo == "P")
                        {
                            tipo = "planta";
                        }
                        if (tipo == "H")
                        {
                            tipo = "HADA";
                        }
                        matriz[val, 2] = tipo;
                        matriz[val, 3] = nivel.ToString();
                        matriz[val, 4] = "0";
                        matriz[val, 5] = "000";
                        val++;

                        Console.Clear();
                        break;


                    case 2:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                            Console.WriteLine("");
                            break;
                        }


                        Console.WriteLine("-----------------MENÚ ASIGNACION DE INVESTIGADOR-----------------");
                        Console.WriteLine(" ");

                        auxi = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (auxi < matriz[i, 1].Length)
                            {
                                auxi = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(auxi);

                        }


                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(" " + vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        for (int i = 0; i < val; i++)
                        {


                            for (int j = 0; j < 6; j++)
                            {
                                Console.Write(" " + matriz[i, j] + "\t" + "|");

                            }
                            Console.WriteLine();
                        }

                        Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
                        eleccus = int.Parse(Console.ReadLine());
                        while (eleccus < 1 || eleccus > val)
                        {
                            Console.WriteLine("NO SE A ENCONTRADO ESA FILA");
                            Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                            eleccus = int.Parse(Console.ReadLine());

                        }
                        Console.WriteLine("Ingrese el código del Investigador: ");
                        numinves = int.Parse(Console.ReadLine());

                        matriz[eleccus - 1, 4] = "1";
                        matriz[eleccus - 1, 5] = numinves.ToString();
                        Console.Clear();
                        break;


                    case 3:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ ACTUALIZACIÓN DEL NIVEL-----------------");
                        Console.WriteLine(" ");

                        auxi = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (auxi < matriz[i, 1].Length)
                            {
                                auxi = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(auxi);

                        }

                        for (int i = 0; i < 3; i++)
                        {
                            if (i == 2)
                            {
                                i = 3;
                            }
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-------------------------");
                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (j == 2)
                                {
                                    j = 3;
                                }
                                Console.Write(" " + matriz[i, j] + "\t" + "|");
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
                        eleccus = int.Parse(Console.ReadLine());
                        while (eleccus < 1 || eleccus > val)
                        {
                            Console.WriteLine("NO SE A ENCONTRADO ESA FILA");
                            Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                            eleccus = int.Parse(Console.ReadLine());

                        }
                        numaum = rng.Next(1, 3);
                        matriz[eleccus, 3] = (int.Parse(matriz[(eleccus - 1), 3]) + numaum).ToString();
                        Console.WriteLine(matriz[eleccus, 1] + " subió de nivel a " + matriz[eleccus, 3]);
                        break;


                    case 4:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ MARCAR POCHIMON COMO INVESTIGADO-----------------");
                        Console.WriteLine(" ");
                        auxi = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (auxi < matriz[i, 1].Length)
                            {
                                auxi = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(auxi);

                        }

                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");
                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (matriz[i, 4] == "1")
                                {
                                    Console.Write(" " + matriz[i, j] + "\t" + "|");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Ingrese el número de fila del Pochimon a marcar como investigado: ");
                        eleccus = int.Parse(Console.ReadLine());
                        while (eleccus < 1 || eleccus > val)
                        {
                            Console.WriteLine("NO SE A ENCONTRADO ESA FILA");
                            Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                            eleccus = int.Parse(Console.ReadLine());
                        }
                        matriz[eleccus, 4] = "2";
                        break;


                    case 5:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ INFORMACIÓN DE POCHIMONS-----------------");
                        Console.WriteLine(" ");

                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");
                        auxi = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (auxi < matriz[i, 1].Length)
                            {
                                auxi = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(auxi);

                        }
                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                Console.Write(matriz[i, j] + "\t" + "|");
                            }
                            Console.WriteLine();

                        }
                        break;


                    case 6:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("primero registra a un pochimon en la pochidex para asignarle un investigador");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ BUSCAR POCHIMONS POR SU TIPO-----------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingresa el tipo de Pochimon que queres buscar: ");
                        Console.WriteLine("(Coloca el nombre del tipo)");
                        tipo = (Console.ReadLine()).ToUpper();
                        while (tipo != "FUEGO" && tipo != "AGUA" && tipo != "PLANTA" && tipo != "TIERRA" && tipo != "ELECTRICO" && tipo != "NORMAL" && tipo != "HADA")
                        {
                            Console.WriteLine("Escribi la palabra correspondiente para buscar el tipo");
                            tipo = (Console.ReadLine()).ToUpper();
                        }
                        Console.Clear();
                        auxi = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (auxi < matriz[i, 1].Length)
                            {
                                auxi = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(auxi);

                        }

                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (matriz[i, 2] == tipo)
                                {
                                    Console.Write(" " + matriz[i, j] + "\t" + "|");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;


                    case 7:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ BUSCAR POCHIMONS POR INVESTIGADOR-----------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el código del Investigador: ");
                        numinves = int.Parse(Console.ReadLine());
                        auxi = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (auxi < matriz[i, 1].Length)
                            {
                                auxi = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(auxi);

                        }
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 3; j++)

                            {
                                if (matriz[i, 3] == numinves.ToString())
                                {
                                    Console.Write(" " + matriz[i, j] + "\t" + "|");
                                    comprob = false;

                                }
                            }
                            Console.WriteLine();
                        }
                        Console.Clear();
                        if (comprob == true)
                        {
                            Console.WriteLine("No se a encontrado a ningún Pochimon con ese código.");
                        }

                        break;


                    case 8:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ MOSTRAR POCHIMONS SUPERIORES-----------------");
                        Console.WriteLine(" ");
                        auxi = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (auxi < matriz[i, 1].Length)
                            {
                                auxi = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(auxi);

                        }

                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (int.Parse(matriz[i, 3]) >= 30)
                                {
                                    Console.Write(" " + matriz[i, j] + "\t" + "|");
                                    comprob = false;

                                }
                            }
                            Console.WriteLine();
                        }
                        if (comprob == true)
                        {

                            Console.WriteLine("No se encontro a ningún Pochimon superior (ninguno es de nivel 30 o mayor).");
                        }
                        break;


                    case 9:
                        par = false;
                        break;
                }

            }
            Console.WriteLine("chauu");

            Console.ReadKey();
        }
    }
}
