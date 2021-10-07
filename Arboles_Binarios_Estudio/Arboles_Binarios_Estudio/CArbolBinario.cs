using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Binarios_Estudio
{
    class CArbolBinarioBusqueda
    {
        private CNodo raiz;
        private CNodo trabajo;

        private int i = 0;

        public CArbolBinarioBusqueda()
        {
            raiz = null;
        }

        internal CNodo Raiz { get => raiz; set => raiz = value; }


        public CNodo Insertar(int pDato, CNodo pNodo)
        {
            CNodo temp = null;

            if (pNodo == null)
            {
                temp = new CNodo();
                temp.Dato = pDato;

                return temp;
            }

            if(pDato < pNodo.Dato)
                pNodo.Izq = Insertar(pDato, pNodo.Izq);
        
            if (pDato> pNodo.Dato )
             pNodo.Der = Insertar(pDato, pNodo.Der);
            

            return pNodo;
        }

        public void Transversa_PreOrden(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);

            if (pNodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                Transversa_PreOrden(pNodo.Izq);
                i--;
            }

            if (pNodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa_PreOrden(pNodo.Der);
                i--;
            }
        }

        public void Transversa_InOrden(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            if (pNodo.Izq!=null)
            {
                i++;
                Transversa_InOrden(pNodo.Izq);
                i--;
            }

            Console.Write("{0}, ", pNodo.Dato);

            if (pNodo.Der != null)
            {
                i++;
                Transversa_InOrden(pNodo.Der);
                i--;
            }
        }

        public void Transversa_PostOrden(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            if (pNodo.Der != null)
            {
                i++;
                Transversa_InOrden(pNodo.Der);
                i--;
            }

      

            if (pNodo.Izq != null)
            {
                i++;
                Transversa_InOrden(pNodo.Izq);
                i--;
            }
            Console.Write("{0}, ", pNodo.Dato);
        }



        public int EncontrarMinimo(CNodo pNodo)
        {

            if (pNodo == null)
                return 0;

            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq!=null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;

            }
            return minimo;
        }


        public int EncontrarMaximo(CNodo pNodo)
        {

            if (pNodo == null)
                return 0;

            trabajo = pNodo;
            int maximo = trabajo.Dato;

            while (trabajo.Der!= null)
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;

            }
            return maximo;
        }

        public int BuscarPadre(int pDato, CNodo pNodo)
        {
            CNodo temp = null;
            if (pNodo == null)
                return 0;

            if (pNodo.Izq != null)
                if (pNodo.Izq.Dato == pDato)
                    return pNodo.Dato;

            if (pNodo.Der != null)
                if (pNodo.Der.Dato == pDato)
                    return pNodo;

            if (pNodo.Izq !=null && pDato < pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Izq);
            }

            if (pNodo.Der != null && pDato > pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Der);
            }
            return temp;
        }

    public CNodo EliminarNodo(int pDato, CNodo pNodo)
    {
            CNodo padre;
            

            if (pNodo == null)
                return null;
            else if (pDato < pNodo.Dato)
                    pNodo.Izq = EliminarNodo(pDato, pNodo.Izq);

           else  if (pDato > pNodo.Dato)
                    pNodo.Der = EliminarNodo(pDato, pNodo.Der);

                else
                {
                    //Casos
                    //Caso sin hijos
                if (pNodo.Izq == null && pNodo.Der == null)
                    {
                        pNodo = null;
                        return pNodo;
                    }

                    //Caso con un hijo
                else if (pNodo.Izq == null)
                    {

                        padre = BuscarPadre(pDato, pNodo);
                        padre.Der = pNodo.Der;
                        return pNodo;
                    }
                    else
                    {

                    pNodo.Dato = EncontrarMinimo(pNodo);
                    pNodo.Der = EliminarNodo(EncontrarMinimo(pNodo), pNodo.Der);

                    }
                }
            return pNodo;
            }
  
     

    }
}
