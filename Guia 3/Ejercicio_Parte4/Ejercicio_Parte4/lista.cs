using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Parte4
{
    class lista
    {
        public nodo inicio; //Cabeza de la lista

        public lista() { inicio = null; }  //Constructor por defecto

        //Metodo para insertar al final de la lista, como lo hace ArrayList


        public void EliminarI()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacia, no se puede eliminar elemento");
            }
            else
            {
                inicio = inicio.siguiente;
            }
        }

        public void EliminarF()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacia, no se puede eliminar elemento");
            }
            else
            {
                nodo punteroant, punteropost;
                punteroant = inicio;
                punteropost = inicio;

                while (punteropost.siguiente != null)
                {
                    punteroant = punteropost;
                    punteropost = punteropost.siguiente;
                }
                punteroant.siguiente = null;

            }
        }

        public void InsertarI(int item)
        {

            nodo auxiliar = new nodo(); //Nodo temporal que despues se agrega a la Lista

            auxiliar.dato = item; //Almacena valor en el atributo dato
            auxiliar.siguiente = null; //Hacemos que puntero siguiente señale a Null
            if (inicio == null)
            {
                inicio = auxiliar;  //Al estar vacia la cola lo hacemos la Cabeza
            }
            else
            {
                nodo puntero;  //Para recorrer lista
                puntero = inicio; //Dos apuntadores señalando al mismo nodo
                inicio = auxiliar;  //Asignamos como cabeza el nodo auxiliar
                auxiliar.siguiente = puntero;  //El puntero de auxiliar que ahora es cabeza se enlaza con
                //El nodo que anters era la cabeza y que tiene apuntador   a  puntero

            }
        }

        public void InsertarF(int item)
        {
            nodo auxiliar = new nodo();  //Nodo temporal que todavia no pertenece a la lista
            auxiliar.dato = item; //Almacena en el atributo dato el valor recibido en el parametro
            auxiliar.siguiente = null; //Hace que el apuntador señale a Null

            if (inicio == null) //Verificar si la lista esta vacia
            {
                inicio = auxiliar; //Hacer que el nodo sea parte de la lista, se convierte en la Cabeza
            }
            else
            {
                nodo puntero; //Utilizamos este nodo para recorrer la lista, asi no se mueve la cabeza
                puntero = inicio; //Situamos a puntero señalando al mismo que inicio
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; //Se desplaza por todos los nodos de la lista diferentes a NULL
                }
                puntero.siguiente = auxiliar; //Hacemos que ultimo nodo ahora señale al auxiliar

            }
        }

        //Metodo para insertar al inicio (Insertar en la cabeza)


        public void InsertarP(int item, int pos)
        {
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            nodo puntero;
            puntero = inicio;

            if (inicio == null)
            {
              //  Console.WriteLine("Esa posicion no existe, el valor sera movida a ultima posicion");
                inicio = auxiliar;
            }

            else if (inicio == null)
            {
                puntero = inicio; //Situamos a puntero señalando al mismo que inicio

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; //Se desplaza por todos los nodos de la lista diferentes a NULL
                }
                puntero.siguiente = auxiliar; //Hacemos que ultimo nodo ahora señale al auxiliar


            }
            else
            {
                puntero = inicio;
                if (pos == 1)
                {
                    inicio = auxiliar;
                    auxiliar.siguiente = puntero;
                }
                else
                {
                    for (int i = 1; i < pos - 1; i++)
                    {
                        puntero = puntero.siguiente;
                        if (puntero.siguiente == null)
                            break;
                    }
                    nodo punteronext;
                    punteronext = puntero.siguiente;
                    puntero.siguiente = auxiliar;
                    auxiliar.siguiente = punteronext;
                }
            }
        }

        public void OrdenarLista()
        {
            nodo current = new nodo();
            nodo next;

            int count = 0;
            nodo LinkNode;
            LinkNode = inicio;
            //calculate the number of the link list node

            while (LinkNode.siguiente != null)
            {
                count++;
                LinkNode = LinkNode.siguiente;
            }

            //sort the linked list
            for (int i = 0; i < count; i++)
            {
                current = inicio;
                while (current.siguiente != null)
                {
                    next = new nodo();
                    next = current.siguiente;

                    if (current.dato > next.dato)
                    {
                        int temp = current.dato;
                        current.dato = next.dato;
                        next.dato = temp;
                    }
                    current = current.siguiente;
                }
            }
        }

        public void Mostrar(ListBox lista )
        {
            if (inicio == null)
            {
           
            }
            else
            {
                nodo puntero;
                puntero = inicio;
              
                lista.Items.Add(puntero.dato);
              

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    lista.Items.Add(puntero.dato);
                   
                }
           
            }
        }

    }
}
