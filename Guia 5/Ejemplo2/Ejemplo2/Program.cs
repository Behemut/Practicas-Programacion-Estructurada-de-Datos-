using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mipila = new Stack();
            int opcion;

            do
            {
                Console.Clear();
                opcion = menu();

                switch (opcion)
                {


                    case 1:
                        agregar(ref mipila);
                        break;
                    case 2:
                        eliminar(ref mipila);
                        break;
                    case 3:
                        limpiar(ref mipila);
                        break;
                    case 4:
                        imprimir(mipila);
                        break;
                    case 5: break;
                    default:
                        mensaje("ERROR: la opcion no es valida. Intente de nuevo");
                        break;
                        
                }
            } while (opcion != 5);


            mensaje("El programa ha finalizado");

        }
        static void agregar(ref Stack pila)
        {
            Console.Write("\n >Ingrese valor: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor > 99 || valor <=0)
                {
                    mensaje("Solo numeros del 1 al 99");
                }
                else
                {
                    pila.Push(valor);
                    imprimir(pila);
                }
            }
            catch
            {
                mensaje("Error solo numeros del 1 al 99");
            }
        }

        static void eliminar(ref Stack pila)
        {
            if (pila.Count>0)
            {
                int valor = (int)pila.Pop();
                mensaje("Elemento " + valor + "  eliminado");
            }
            else
            {
                imprimir(pila);
            }
        }

        static void limpiar(ref Stack pila)
        {
            pila.Clear();
            imprimir(pila);
        }

        static int menu()
        {
            //Console.Clear();
            Console.WriteLine("\n       Stack Menu \n");
            Console.WriteLine(" 1. - Agregar elemento");
            Console.WriteLine(" 2. - Eliminar elemento");
            Console.WriteLine(" 3. - Vaciar Pila");
            Console.WriteLine(" 4. - Ver pila");
            Console.WriteLine(" 5. -Terminar programa");
            Console.WriteLine("  >  Ingresa tu opcion:  ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {

                return 0;
            }
        }

        static void mensaje(string texto)
        {
            if (texto.Length > 0)
            {
                Console.WriteLine("\n ==============================================");
                Console.WriteLine(" > {0}", texto );
                Console.WriteLine("\n ==============================================");
                Console.WriteLine("\n   >Presiones cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void imprimir(Stack pila)
        {
            if (pila.Count > 0)
            {
                Console.WriteLine("");
                foreach (int dato in pila)
                {
                    Console.WriteLine("|       |");
                  
                    if (dato < 10)
                    
                       Console.WriteLine("|  0{0}   |", dato);
                    
                    else
                    
                        Console.WriteLine("|  {0}   |", dato);

                    Console.WriteLine("|_______|");
                }
                Console.WriteLine(">Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                mensaje("La pila esta vacia");
            }
        }
    }
}
