using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Guia_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable thash1 = new Hashtable();

            thash1.Add("txt", "Programa notepad.exe");
            thash1.Add("bmp", "Programa paint.exe");
            thash1.Add("dib", "Programa paint.exe");
            thash1.Add("rtf", "Programa wordpad.exe");

            try
            {
                thash1.Add("txt", "Programa winword.exe");
            }
            catch (Exception)
            {

                Console.WriteLine("Un elemento con la clave = \"txt\" Ya existe");
            }

            //PODEMOS OBTENER EL VALOR UTILIZANDO LA VLACE
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Imprimimos un valor de la tabla usando la clave");
            Console.WriteLine("Para la Clave = \"rtf\", valor = {0}", thash1["rtf"] + "\n");

            //TAMBIEN  PODEMOS CAMBIAR EL VALOR UTILIZANDO LA CLAVE
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Cambiando valor asociado a clave rtf");
            Console.WriteLine("Para la Clave = \"rtf\", valor = {0}", thash1["rtf"]);
            Console.WriteLine("----------------------------------------------");

            //SI LA CLAVE NO EXISTE, AL UTILIZAR ESTA SINTAXIS TAMBIEN SE PUEDE AGREGAR IGUAL QUE ADD

            thash1["doc"] = "winword.exe";

            //ContainsKey puede ser usada para probar 
            //Si una clave ya existe

            if (!thash1.Contains("ht"))
            {
                thash1.Add("ht", "hypertrm.exe");
                Console.WriteLine("Valor agregado para =\"ht\": {0}", thash1["ht"]);
                Console.WriteLine("----------------------------------------------");
            }

            //PARA OBTENER SOLO VALORES, UTILICE LA PROPIEDAD VALUES
            //UTILIZAMOS ICollection PARA FORMAR UNA NUEVA COLECCION A PARTIR DE LOS VALORES DE LA TABLA HASH

            ICollection valueCol1 = thash1.Values;

            //IMPRIMIENDO SOLO VALORES

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("IMPRIMIENDO SOLO VALORES DE LA TABLA");

            foreach (string  item in valueCol1 )
            {
                Console.WriteLine("Value = {0}", item);
            }
            //PARA OBTENER SOLO LAS CLAVE UTILICE LA PROPIEDAD Keys, UTILIZAMOS ICollection PARA FORMAR UNA NUEVA COLECCION
            //A PARTIR DE LAS CLAVES DE LA TABLA HASH


            ICollection keyCol1 = thash1.Keys;
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("IMPRIMIENDO SOLO LAS LLAVES DE LA TABLA HASH");

            foreach (string item in keyCol1)
            {
                Console.WriteLine("Clave = {0}", item);
            }


            //REMOVIENDO ELEMENTOS DE LA TABLA HASH

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("REMOVER CLAVES");
            Console.WriteLine("Primero se remueve la clave .doc");
            Console.WriteLine("\nRemover (\"doc\")");  thash1.Remove("doc");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\n DESPUES VERIFICAMOS SI LA CLAVE AUN EXISTE EN LA TABLA");

            if (!thash1.Contains("doc"))
            {
                Console.WriteLine("----------------------------------------------"+ "\n");
                Console.WriteLine("Clave \"doc\" no encontrada");
                Console.WriteLine("----------------------------------------------");
            }

            Console.ReadLine();


        }
    }
}
