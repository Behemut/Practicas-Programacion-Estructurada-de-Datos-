using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Guia_7
{
    class DibujaAVL
    {
        public AVL Raiz;
        public AVL aux;

        public DibujaAVL()
        {
            aux = new AVL();
        }

        public DibujaAVL(AVL RaizNueva)
        {
            Raiz = RaizNueva;
        }

        public void Insertar(int dato)
        {
            if (Raiz == null)
                Raiz = new AVL(dato, null, null, null);
            else
                Raiz = Raiz.Insertar(dato, Raiz);
        }
        
        public void Eliminar(int dato)
        {
            if (Raiz == null)
                Raiz = new AVL(dato, null, null, null);
            else
                Raiz.Eliminar(dato, ref Raiz);
        }

        private const int Radio = 30;
        private const int DistanciaH = 40;
        private const int DistanciaV = 10;

        private int CoordenadaX;
        private int CoordenadaY;

        //Mostrar Datos de Transversas

        public string PreOrden()
        {
            string cadena = "";
            return Transversa_PreOrden(this.Raiz, ref cadena);
        }
        public string Transversa_PreOrden(AVL pNodo, ref string cadena)
        {

            if (pNodo != null)
            {

                if (String.IsNullOrEmpty(cadena) == true)
                {
                    cadena += pNodo.valor;
                }
                else
                {
                    cadena += " -> " + pNodo.valor;
                }
                Transversa_PreOrden(pNodo.nodoIzquierdo , ref cadena);
                Transversa_PreOrden(pNodo.nodoDerecho, ref cadena);
            }

            return cadena;
        }

        public string InOrden()
        {
            string cadena = "";
            return Transversa_InOrden(this.Raiz, ref cadena);
        }
        public string Transversa_InOrden(AVL pNodo, ref string cadena)
        {

            if (pNodo != null)
            {
                Transversa_InOrden(pNodo.nodoIzquierdo, ref cadena);
                if (String.IsNullOrEmpty(cadena) == true)
                {
                    cadena += pNodo.valor;
                }
                else
                {
                    cadena += " -> " + pNodo.valor;
                }

                Transversa_InOrden(pNodo.nodoDerecho, ref cadena);
            }

            return cadena;
        }


        public string PostOrden()
        {
            string cadena = "";
            return Transversa_PostOrden(this.Raiz, ref cadena);
        }
        public string Transversa_PostOrden(AVL pNodo, ref string cadena)
        {

            if (pNodo != null)
            {
                Transversa_PostOrden(pNodo.nodoIzquierdo, ref cadena);
                Transversa_PostOrden(pNodo.nodoDerecho, ref cadena);
                if (String.IsNullOrEmpty(cadena) == true)
                {
                    cadena += pNodo.valor;
                }
                else
                {
                    cadena += " -> " + pNodo.valor;
                }

            }

            return cadena;
        }





        public void PosicionNodoRecorrido(ref int xmin, ref int ymin)
        {
            CoordenadaY = (int)(ymin + Radio / 2);
            CoordenadaX = (int)(xmin + Radio / 2);
            xmin += Radio;
        }

        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, AVL Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if (inor == true)
            {
                if (Raiz != null)
                {
                  
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nodoDerecho, post, inor, preor);
                }
            }
            else if (preor == true)
            {
                if (Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, Brushes.Yellow, Brushes.Blue, Pens.Black);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Brushes.White , Brushes.Black, Pens.Black);
                    colorear(grafo, fuente, Brushes.Blue , RellenoFuente, Lapiz, Raiz.nodoIzquierdo, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nodoDerecho, post, inor, preor);
                }
            }
            else if (post== true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nodoIzquierdo, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nodoDerecho, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    
                }
            }
        }

        public void colorearB(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, AVL Raiz, int busqueda)
        {

            Brush entorno = Brushes.Red;

            if (Raiz != null)
            {
                Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                if (busqueda < Raiz.valor)
                {
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, entorno, Brushes.Blue, Lapiz);
                    colorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nodoIzquierdo, busqueda);
                }
                else
                {
                    if (busqueda > Raiz.valor)
                    {
                        Thread.Sleep(500);
                        Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                        colorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nodoDerecho, busqueda);
                    }
                    else
                    {
                        Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                        Thread.Sleep(500);
                    }
                }
            }
        }

        //Dibujar el arbol

        public void DibujarArbol(Graphics grafo, Font fuente,Brush Relleno, Brush RellenoFuente, Pen Lapiz, int dato, Brush encuentro)
        {
            int x = 100;
            int y = 75;
            if (Raiz==null )
            {
                return;
            }

            Raiz.PosicionNodo(ref x, y);
            Raiz.DibujarRamas(grafo, Lapiz);
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, dato, encuentro);
        }

        public int x1 = 100;
        public int y2 = 75;

        public void restablecer_valores()
        {
            x1 = 100;
            y2 = 75;
        }

        public void buscar(int x)
        {
            if (Raiz == null)
                MessageBox.Show("Arbol AVL Vacio", "Error", MessageBoxButtons.OK);
            else
                Raiz.buscar(x, Raiz);
        }

        }
}
