using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Program
    {
        private static string art;

        static void Main(string[] args, object Integer)
        {
            int menu = 0;
            do
            {
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("\n 1-Artículos" +
                "\n 2-Facturación" +
                "\n 3-Reporte" +
                "\n 4- Salir");
                Console.WriteLine("Digite una opcion ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Selecciones una opcion");
                        Console.WriteLine("\n 1- Agregar" +
                        "\n 2- Borrar" +
                        "\n 3- consultar");
                        menu = Convert.ToInt32(Console.ReadLine());
                        switch (menu)
                        {
                            case 1:
                                Console.WriteLine("Ingrese nuevo articulo");
                                String art = Console.ReadLine();
                                Console.WriteLine("Ingrese el id del artuculo");
                                String id = Console.ReadLine();
                                


                                break;


                        }

                        break;
                    case 2:
                        Console.WriteLine("Articulo es: " + art);
                        break;
                        break;
                    case 3:
                        Console.WriteLine("");
                        break;

                }
            } while (menu != 4);
        }

    }
    }

