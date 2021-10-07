using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Binarios_Estudio
{
    class Program
    {
        static void Main(string[] args)
        {
            CArbolBinarioBusqueda arbol = new CArbolBinarioBusqueda();

            //Crear la raiz siempre debe ser acompañada con valor null
            CNodo raiz;
            raiz= arbol.Insertar(6, null);

            //Indicar el valor de insercion junto a dicha raiz
            arbol.Insertar(2, raiz);
            arbol.Insertar(11, raiz);
            arbol.Insertar(4, raiz);
            arbol.Insertar(5, raiz);
            arbol.Insertar(6, raiz);
            arbol.Insertar(7, raiz);
            arbol.Insertar(9, raiz);
            arbol.Insertar(12, raiz);
            arbol.Insertar(3, raiz);
            arbol.Insertar(20, raiz);

            Console.WriteLine("----------------------");
            arbol.Transversa_PreOrden(raiz);
            Console.WriteLine("----------------------");
           // Console.WriteLine("El valor minimo del arbol es: {0}", arbol.EncontrarMinimo(raiz));
           /// Console.WriteLine("El valor maximo del arbol es: {0}", arbol.EncontrarMaximo(raiz));

           // Console.WriteLine("----------------------");
           // arbol.Transversa_InOrden(raiz);
           // Console.WriteLine("----------------------");

           // arbol.Transversa_PostOrden(raiz);
           // Console.WriteLine("----------------------");

  


            Console.WriteLine("----------------------");
            arbol.EliminarNodo(11, raiz);
            Console.WriteLine("----------------------");

            arbol.Transversa_PreOrden(raiz);


            Console.WriteLine("----------------------");
            CNodo padre = arbol.BuscarPadre(12, raiz);
            Console.WriteLine("El valor del padre es: {0}", padre.Dato);
            Console.ReadLine();


       
        }
    }
}
