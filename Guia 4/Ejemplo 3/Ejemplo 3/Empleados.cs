using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3
{
    class Empleados
    {
        private string carnet;
        private string nombre;
        private decimal salario;
        private DateTime fecha;

        public string Carnet { get => carnet; set => carnet = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Salario { get => salario; set => salario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
