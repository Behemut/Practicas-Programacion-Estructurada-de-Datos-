using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Binarios_Estudio
{
    class CNodo
    {
        private int dato;

        private CNodo izq;
        private CNodo der;

        public int Dato { get => dato; set => dato = value; }
        internal CNodo Izq { get => izq; set => izq = value; }
        internal CNodo Der { get => der; set => der = value; }


        public CNodo()
        {
            dato = 0;
            izq = null;
            der = null;
        }
    }
}
