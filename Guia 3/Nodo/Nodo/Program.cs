using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodo
{
    class Program
    {
        static void Main(string[] args)
        {
            lista listanueva = new lista();
            listanueva.InsertarI(40);
            listanueva.InsertarI(30);
            listanueva.InsertarI(20);
            listanueva.InsertarI(10);

            listanueva.Mostrar();


            listanueva.InsertarP(220, 3);
            listanueva.Mostrar();

            Console.ReadKey();

        }
    }
}
