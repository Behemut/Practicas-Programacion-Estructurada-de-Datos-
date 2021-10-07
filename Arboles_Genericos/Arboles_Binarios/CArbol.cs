using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Binarios
{
    class CArbol
    {
        private CNodo raiz;
        private CNodo trabajo;
        private int i = 0;

        public CArbol()
        {
            raiz = new CNodo();

        }

        public CNodo Insertar(string pDato, CNodo pNodo)
        {

            if (pNodo==null)
            {
                raiz = new CNodo();
                raiz.Dato = pDato;
                raiz.Hijo = null;
                raiz.Hermano = null;
                return raiz;
            }
            if (pNodo.Hijo==null)
            {
                CNodo temp = new CNodo();
                temp.Dato = pDato;
                pNodo.Hijo = temp;
                return temp;
            }
            else
            {
                trabajo = pNodo.Hijo;
                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }
                CNodo temp = new CNodo();
                temp.Dato = pDato;
                trabajo.Hermano = temp;
                return temp;
            }
        }


        public void TransversaPreOrden(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);

            if (pNodo.Hijo!=null)
            {
                i++;
                TransversaPreOrden(pNodo.Hijo);
                i--;
            }

            if (pNodo.Hermano!=null)
             TransversaPreOrden(pNodo.Hermano);
        }

        public void TransversaPostOrden(CNodo pNodo)
        {
            if (pNodo == null)
                return;


            if (pNodo.Hijo!=null )
            {
                i++;
                TransversaPostOrden(pNodo.Hijo);
                i--;
            }
            if (pNodo.Hermano != null)
                TransversaPostOrden(pNodo.Hermano);

            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);
        }

        public CNodo Buscar(string pDato, CNodo pNodo)
        {
            CNodo encontrado = null;

            if (pNodo==null)
                return encontrado;


            if (pNodo.Dato.CompareTo(pDato)==0)
            {
                encontrado = pNodo;
                return encontrado;
            }

            if (pNodo.Hijo!=null)
            {
                encontrado = Buscar(pDato, pNodo.Hijo);

                if (encontrado!=null)
                    return encontrado;
                
            }

            if (pNodo.Hermano!=null)
            {
                encontrado = Buscar(pDato, pNodo.Hermano);
                if (encontrado != null)
                    return encontrado;
            }
            return encontrado;
           
           
        }

    }
}
