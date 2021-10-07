using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia10
{
    class CLista
    {
        private CVertice aElemento;
        private CLista aSubLista;
        private int aPeso;

        public CLista()
        {
            aElemento = null;
            aSubLista = null;
            aPeso = 0;
        }

        public CLista(CLista pLista)
        {
            if (pLista != null)
            {
                aElemento = pLista.aElemento;
                aSubLista = pLista.aSubLista;
                aPeso = pLista.aPeso;
            }

        }

        public CLista(CVertice pElemento, CLista pSubLista, int pPeso)
        {
            aElemento = pElemento;
            aSubLista = pSubLista;
            aPeso = pPeso;
        }

        //Propiedades

        public CVertice Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }

        public CLista SubLista
        {
            get { return aSubLista; }
            set { aSubLista = value; }
        }

        public int Peso
        {
            get { return aPeso; }
            set { aPeso = value; }
        }

        //Metodos
        public bool EsVacia()
        {
            return aElemento == null;
        }
        //Ya que nuestro grafo es del tipo dirigido esta es la sintaxis de la Lista Enlazada que estaremos utilizando

            //Metodo de agregar los elementos a Lista Enlazada 
        public void Agregar(CVertice pElemento, int pPeso)
        {
            if (pElemento != null)
            {
                if (aElemento == null)
                {
                    aElemento = new CVertice(pElemento.Valor);
                    aPeso = pPeso;
                    aSubLista = new CLista();
                }
                else
                {
                    if (!ExisteElemento(pElemento))
                        aSubLista.Agregar(pElemento, pPeso);

                }
            }
        }

        public void Eliminar(CVertice pElemento)
        {
            if (aElemento !=null )
            {
                if (aElemento.Equals(pElemento))
                {
                    aElemento = aSubLista.aElemento;
                    aSubLista = aSubLista.SubLista;
                }
                else {
                    aSubLista.Eliminar(pElemento);
                }    
            }
        }

        public int NroElementos()
        {
            if (aElemento != null)
                return 1 + aSubLista.NroElementos();
            else
                return 0;
        }

        public object IesimoElemento(int posicion)
        {
            if ((posicion > 0) && (posicion <= NroElementos()))
            {
                if (posicion == 1)
                {
                    return aElemento;
                }
                else
                    return aSubLista.IesimoElemento(posicion - 1);
            }
            else
                return null;
        }

        public object IesimoElementoPeso(int posicion)
        {
            if ((posicion>0) && (posicion<=NroElementos()))
            {
                if (posicion==1)
                {
                    return aPeso;
                }
                else
                    return aSubLista.IesimoElementoPeso(posicion - 1);
            }
            else
                return 0;
        }
        //Verificar si un elemento en el grafo ya existe
        public bool ExisteElemento(CVertice pElemento)
        {
            if ((aElemento != null) && (pElemento != null))
            {
                //Return con decision del tipo OR  que regresa un valor del tipo CVertice dentro del objeto aElemento con Interfaces
                //o tambien la devolucion del valor pElemento dentro de la aSubLista  haciendo saber que los encontro regresando un valor tipo Bool
                return (aElemento.Equals(pElemento) || (aSubLista.ExisteElemento(pElemento)));

            }
            else
                return false;
        }

        public int PosicionElemento(CVertice pElemento)
        {
            if ((aElemento != null) || (ExisteElemento(pElemento)))
            {
                if (aElemento.Equals(pElemento))
                    return 1;
                else
                    return 1 + aSubLista.PosicionElemento(pElemento);
            }
            else
                return 0;
        }

        public void Mostrar1()
        {
            if (aElemento != null)
            {
                Console.WriteLine(aElemento.Valor + ":");
                aSubLista.Mostrar1();
            }
        }



      
    }
}
