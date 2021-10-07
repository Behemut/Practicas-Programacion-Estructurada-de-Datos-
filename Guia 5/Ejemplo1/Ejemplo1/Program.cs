using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            char caracter;

            pila mipila = new pila();
            pila pilafrase = new pila();





            Console.WriteLine("\t\t----PARTE I-----");
            mipila.Push('p');
            mipila.Push('b');
            mipila.Push('z');
            mipila.Push('s');
            mipila.Mostrar();
            Console.ReadLine();



            Console.WriteLine("\t\t----PARTE II-----");

            Console.WriteLine("Ingrese la palabra: ");
            cadena = Console.ReadLine();

            for (int i = 0; i < cadena.Length; i++)
            {
                caracter = char.Parse(cadena.Substring(i, 1));
                pilafrase.Push(caracter);
            }
            pilafrase.Mostrar();
            Console.ReadLine();
        }
    }
}
