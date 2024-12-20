﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static string nuevopj(int compr)
        {
            string nombre;
            string serie;
            int fuerza, defensa;
            string aux;
            bool heroe;

            Console.Clear();
            Console.WriteLine("---------------------Nuevo PJ---------------------");
            Console.WriteLine();

            if (compr == 0)
            {
                Console.WriteLine("Nombre: ");
                nombre = Console.ReadLine();
                return nombre;
            }
            else if (compr == 1)
            {
                Console.WriteLine("Serie: ");
                serie = Console.ReadLine();
                return serie;
            }
            else if (compr == 2)
            {
                Console.WriteLine("Fuerza: ");
                fuerza = int.Parse(Console.ReadLine());
                return fuerza.ToString();
            }
            else if (compr == 3)
            {
                Console.WriteLine("Defensa");
                defensa = int.Parse(Console.ReadLine());
                return defensa.ToString();
            }
            else if (compr == 4)
            {
                Console.WriteLine("Es un heroe? (si o no)");
                aux = Console.ReadLine();

                while (aux != "si" && aux != "no")
                {
                    Console.WriteLine("si o no");
                    aux = Console.ReadLine();
                }

                if (aux == "si")
                {
                    heroe = true;
                }
                else
                {
                    heroe = false;
                }
                return heroe.ToString();
            }
            else
            {
                return "error";
            }
        }

        static void Main(string[] args)
        {

            bool siempre = true;
            int eleccion;
            string buscador;
            int num = 1;
            int cambiar;
            int buscarnum;
            int camb;
            int compro = 0;

            string[,] matriz = new string[20, 5];
            while (siempre)
            {
                Console.Clear();
                Console.WriteLine("---------------------MENU---------------------");
                Console.WriteLine();
                Console.WriteLine("1. Nuevo Personaje.");
                Console.WriteLine("2. Consulta Personaje Segun.");
                Console.WriteLine("3. Cambiar Estadisticas Personaje.");
                Console.WriteLine("4. Mostrar Personajes");
                Console.WriteLine("5. Eliminar Personajes");

                eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        if (compro > 0)
                        {
                            for (int j = 0; j < num; j++)
                            {
                                if (matriz[j, 0] == "null")
                                {
                                    for (int i = 0; i < 5; i++)
                                    {
                                        matriz[j, i] = nuevopj(i);
                                    }
                                }

                            }
                        }
                        else
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                matriz[num, i] = nuevopj(i);
                            }
                            num += 1;
                        }


                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("---------------------BUSCADOR---------------------");
                        Console.WriteLine();
                        Console.WriteLine("Nombre del PJ buscado");
                        buscador = Console.ReadLine();
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine();
                            if (matriz[i, 0] == buscador)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    Console.Write(matriz[i, j] + "|\t");
                                }

                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("---------------------MODIFICADOR---------------------");
                        Console.WriteLine();
                        Console.WriteLine("1. Cambiar Defensa");
                        Console.WriteLine("2. Cambiar Fuerza");
                        cambiar = int.Parse(Console.ReadLine());

                        if (cambiar == 1)
                        {
                            Console.WriteLine("Que pj queres cambiarle la defensa (seleccione la posicion)?");
                            buscarnum = int.Parse(Console.ReadLine());
                            Console.WriteLine("a que numero lo queres cambiar");
                            camb = int.Parse(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                if (i == buscarnum)
                                {
                                    matriz[i, 3] = camb.ToString();
                                }
                            }
                        }
                        if (cambiar == 2)
                        {
                            Console.WriteLine("Que pj queres cambiarle la ataque (seleccione la posicion)?");
                            buscarnum = int.Parse(Console.ReadLine());
                            Console.WriteLine("a que numero lo queres cambiar");
                            camb = int.Parse(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                Console.WriteLine();
                                if (i == buscarnum)
                                {
                                    matriz[i, 2] = camb.ToString();
                                }
                            }
                        }

                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("---------------------ELIMINACION---------------------");
                        Console.WriteLine();
                        Console.WriteLine("Fila que desea eliminar");
                        camb = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 5; i++)
                        {
                            matriz[camb, i] = "null";
                        }
                        compro += 1;
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("---------------------MOSTRADOR---------------------");
                        Console.WriteLine();
                        for (int i = 0; i < num; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write(matriz[i, j] + "|\t");
                            }
                        }
                        break;

                }

            }
        }
    }
}