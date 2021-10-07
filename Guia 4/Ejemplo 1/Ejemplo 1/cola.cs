using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    class cola
    {
        public nodo primero;
        public nodo ultimo;


        public cola()
        {
            primero = ultimo = null;
        }

        public void Encolar(int valor)
        {
            nodo aux = new nodo();
            aux.info = valor;

            if (primero==null)
            {
                primero = ultimo = aux;
                aux.sgte = null;
            }
            else
            {
                ultimo.sgte = aux;
                aux.sgte = null;
                ultimo = aux;
            }
        }


        public void Desencolar()
        {
            if (primero == null)
            {
                Console.WriteLine("Cola vacia");
            }
            else
            {
                primero = primero.sgte;
            }
        }


        public int DesencolarValor()
        {
            int valor = 0;

            if (primero==null)
            {
                Console.WriteLine("Cola vacia");
            }
            else
            {
                valor = primero.info;
                primero = primero.sgte;
            }

            return valor;
        }

        public void Mostrar()
        {
            if (primero==null)
            {
                Console.WriteLine("Cola vacia");
            }
            else
            {
                nodo puntero;
                puntero = primero;
                do
                {
                    Console.WriteLine("{0}\t", puntero.info);
                    puntero = puntero.sgte;
                } while (puntero != null);
            }
            Console.WriteLine("\n");
        }


    }
}
