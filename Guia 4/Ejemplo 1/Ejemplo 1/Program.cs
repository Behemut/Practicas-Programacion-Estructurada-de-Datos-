using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            cola objCola = new cola();

            Console.WriteLine("Colocando 5 elementos en la cola");

            objCola.Encolar(3);
            objCola.Encolar(27);
            objCola.Encolar(5);
            objCola.Encolar(22);
            objCola.Encolar(24);
            objCola.Mostrar();

            Console.WriteLine("Retirando dos elementos en la cola");


            objCola.Desencolar();
            objCola.Mostrar();
            objCola.Desencolar();
            objCola.Mostrar();


            Console.WriteLine("Se va a retirar un nodo mas, con el valor {0}", objCola.DesencolarValor());


            objCola.Mostrar();

            Console.ReadLine();
        }
    }
}
