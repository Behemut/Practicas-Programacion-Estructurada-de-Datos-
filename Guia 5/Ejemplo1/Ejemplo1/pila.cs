using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class pila
    {
        public nodo tope;
        public pila(){tope = null;}

        public void Push(char valor)
        {
            nodo aux = new nodo();
            aux.info = valor;
            if (tope == null)
            {
                tope = aux;
                aux.sgte = null;
            }
            else
            {
                aux.sgte = tope;
                tope = aux;
            }
        }




        public void Mostrar()
        {
            nodo puntero;
            puntero = tope;

            Console.WriteLine("{0}", puntero.info);
            while (puntero.sgte!=null)
            {
                puntero = puntero.sgte;
                Console.WriteLine("{0}", puntero.info);
            }
        }

        public char Pop() {
            char valor = ' ';
            if (tope == null)
            {
                Console.WriteLine("Pila vacia");
            }
            else
            {
                valor = tope.info;
                tope = tope.sgte;
            }
            return valor;
        }





    }
}
