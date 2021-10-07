using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Binarios
{
    class CNodo
    {
        private string dato;
        private CNodo hijo;
        private CNodo hermano;

        public string Dato { get => dato; set => dato = value; }
        internal CNodo Hijo { get => hijo; set => hijo = value; }
        internal CNodo Hermano { get => hermano; set => hermano = value; }

        public CNodo()
        {
            dato = "";
            hermano = null;
            hijo = null;
        }

   
    }
}
