using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_BANCO
{
    class Clientes
    {
        private string nombre;
        private double monto;
        private DateTime fecha;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
