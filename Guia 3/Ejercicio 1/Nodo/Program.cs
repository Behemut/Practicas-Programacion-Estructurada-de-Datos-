using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodo
{
    class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;

            int valor, posicion;

            lista listanueva = new lista();
            //listanueva.InsertarI(40);
            //listanueva.InsertarI(30);
            //listanueva.InsertarI(20);
            //listanueva.InsertarI(10);
            //listanueva.Mostrar();
            //  listanueva.InsertarP(220, 3);
            // listanueva.Mostrar();
            while (salir == false)
            {
           
                Console.WriteLine("---------------FUNCIONES DE NODO---------------");
                Console.WriteLine(" a.Insertar al Frente");
                Console.WriteLine(" b.Insertar al Final");
                Console.WriteLine(" c.Insertar en una posición específica");
                Console.WriteLine(" d.Eliminar al Frente");
                Console.WriteLine(" e.Eliminar al Final");
                Console.WriteLine(" f.Mostrar lista");
                Console.WriteLine(" g.Salir");
                Console.Write("   ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "a":
                        Console.Write("Inserte el valor que se insertara de Frente en el nodo: ");
                        valor = Int32.Parse(Console.ReadLine());
                        listanueva.InsertarI(valor);
                        listanueva.OrdenarLista();
                        Console.ReadKey();
                        break;
                    case "b":
                        Console.Write("Inserte el valor que se insertara de Final en el nodo: ");
                        valor = Int32.Parse(Console.ReadLine());
                        listanueva.InsertarF(valor);
                        listanueva.OrdenarLista();
                        Console.ReadKey();
                        break;

                    case "c":
                        Console.Write("Inserte el valor que se insertara en el nodo: ");
                        valor = Int32.Parse(Console.ReadLine());
                        Console.Write("Inserte la posicion que se insertara en el nodo: ");
                        posicion = Int32.Parse(Console.ReadLine());
                        listanueva.InsertarP(valor, posicion);
                        listanueva.OrdenarLista();
                        Console.ReadKey();
                        break;

                    case "d":
                        Console.WriteLine("Eliminar nodo al Frente");
                        listanueva.EliminarI();

                        Console.ReadKey();
                        break;

                    case "e":
                        Console.WriteLine("Eliminar nodo al Final");
                        listanueva.EliminarF();
                        Console.ReadKey();
                        break;

                    case "f":
                        listanueva.Mostrar();
                        Console.WriteLine("~~~~~~~~~~~~~");
                        Console.ReadKey();
                        break;

                

                    case "g":
                        Console.WriteLine("SALIENDO DEL PROGRAMA!!");

                        Console.ReadKey();
                        salir= true;
                        break;

                    default:
                        break;
                }

   
                Console.Clear();
            }
  
             


        }
    }
}
