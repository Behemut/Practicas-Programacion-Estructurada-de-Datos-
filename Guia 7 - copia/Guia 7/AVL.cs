using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Guia_7
{
    class AVL
    {
        public int valor;
        public AVL nodoIzquierdo;
        public AVL nodoDerecho;
        public AVL nodoPadre;
        public int altura;
        public Rectangle prueba;
        private DibujaAVL arbol;
        public AVL() { }


        private const int Radio = 30;
        private const int DistanciaH = 40;
        private const int DistanciaV = 10;
        private int CoordenadaX;
        private int CoordenadaY;

        public DibujaAVL Arbol { get => arbol; set => arbol = value; }

        private static int max(int lhs, int rhs)
        {
            return lhs > rhs ? lhs : rhs;
        }

        private static AVL RotacionIzquierdaSimple(AVL k2)
        {
            AVL k1 = k2.nodoIzquierdo;
            k2.nodoIzquierdo = k1.nodoDerecho;
            k1.nodoDerecho = k2;
            k2.altura = max(Alturas(k2.nodoIzquierdo), Alturas(k2.nodoDerecho)) + 1;
            k1.altura = max(Alturas(k1.nodoIzquierdo), k2.altura ) + 1;
            return k1;
        }

        private static AVL RotacionDerechaSimple(AVL k1)
        {
            AVL k2 = k1.nodoDerecho;
            k1.nodoDerecho = k2.nodoIzquierdo;
            k2.nodoIzquierdo = k1;
            k1.altura = max(Alturas(k1.nodoIzquierdo), Alturas(k1.nodoDerecho)) + 1;
            k2.altura = max(Alturas(k2.nodoDerecho), k1.altura) + 1;
            return k2;
        }

        private static AVL RotacionIzquierdaDoble(AVL k3)
        {
            k3.nodoIzquierdo = RotacionDerechaSimple(k3.nodoIzquierdo);
            return RotacionIzquierdaSimple(k3);
        }

        private static AVL RotacionDerechaDoble(AVL k1)
        {
            k1.nodoDerecho = RotacionIzquierdaSimple(k1.nodoDerecho);
            return RotacionIzquierdaSimple(k1);
        }
         public int getAltura(AVL nodoActual)
        {
            if (nodoActual == null)
                return 0;
            else
                return 1 + Math.Max(getAltura(nodoActual.nodoIzquierdo), getAltura(nodoActual.nodoDerecho));
        }


        private static int Alturas(AVL Raiz)
        {
            return Raiz == null ? -1 : Raiz.altura;
        }

        AVL nodoE, nodoP;
        
        public AVL(int valorNuevo, AVL izquierdo, AVL derecho, AVL padre)
        {
            valor = valorNuevo;
            nodoIzquierdo = izquierdo;
            nodoDerecho = derecho;
            nodoPadre = padre;
            altura = 0;
        }

        public AVL Insertar(int valorNuevo, AVL Raiz)
        {
            if (Raiz == null)
                Raiz = new AVL(valorNuevo, null, null, null);
            else if (valorNuevo < Raiz.valor)
            {
                Raiz.nodoIzquierdo = Insertar(valorNuevo, Raiz.nodoIzquierdo);
            }
            else if (valorNuevo > Raiz.valor)
            {
                Raiz.nodoDerecho = Insertar(valorNuevo, Raiz.nodoDerecho);
            }
            else
                MessageBox.Show("Valor existente en el Arbol", "Error", MessageBoxButtons.OK);

            //Realiza las rotaciones simples o dobles segun el caso
            if (Alturas(Raiz.nodoIzquierdo) - Alturas(Raiz.nodoDerecho)==2)
            {
                if (valorNuevo < Raiz.nodoIzquierdo.valor)
                    Raiz = RotacionIzquierdaSimple(Raiz);
                else
                    Raiz = RotacionIzquierdaDoble(Raiz);
            }
            if (Alturas(Raiz.nodoDerecho) - Alturas(Raiz.nodoIzquierdo) == 2)
            {
                if (valorNuevo > Raiz.nodoDerecho.valor)
                    Raiz = RotacionDerechaSimple(Raiz);
                else
                    Raiz = RotacionDerechaDoble(Raiz);
            }
            Raiz.altura = max(Alturas(Raiz.nodoIzquierdo), Alturas(Raiz.nodoDerecho)) + 1;
            return Raiz;

        }

        //GUIA 7 COPIA codigo original

     public AVL Eliminar (int valorEliminar, ref AVL raiz)
        {
            if (raiz != null)
            {
                if (valorEliminar < raiz.valor)
                {
                    nodoE = raiz;
                    Eliminar(valorEliminar, ref raiz.nodoIzquierdo);
                }
                else
                {
                    if (valorEliminar > raiz.valor)
                    {
                        nodoE = raiz;
                        Eliminar(valorEliminar, ref raiz.nodoDerecho);
                    }
                    else
                    {
                        AVL NodoEliminar = raiz;
                        if (NodoEliminar.nodoDerecho == null)
                        {
                            raiz = NodoEliminar.nodoIzquierdo;
                            if (Alturas(nodoE.nodoIzquierdo) - Alturas(nodoE.nodoDerecho) == 2)
                            {
                                //MessageBox.Show("nodoE" + nodoE.valor.ToString());
                                if (valorEliminar < nodoE.valor)
                                    nodoP = RotacionIzquierdaSimple(nodoE);
                                else
                                    nodoE = RotacionDerechaSimple(nodoE);
                            }
                            if (Alturas(nodoE.nodoDerecho) - Alturas(nodoE.nodoIzquierdo) == 2)
                            {
                                if (valorEliminar > nodoE.nodoDerecho.valor)
                                    nodoE = RotacionDerechaSimple(nodoE);
                                else
                                    nodoE = RotacionDerechaDoble(nodoE);
                                nodoP = RotacionDerechaSimple(nodoE);
                            }
                        }
                        else
                        {
                            if (NodoEliminar.nodoIzquierdo == null)
                            {
                                raiz = NodoEliminar.nodoDerecho;
                            }
                            else
                            {
                                if (Alturas(raiz.nodoIzquierdo) - Alturas(raiz.nodoDerecho) > 0)
                                {
                                    AVL AuxiliarNodo = null;
                                    AVL Auxiliar = raiz.nodoIzquierdo;
                                    bool Bandera = false;
                                    while (Auxiliar.nodoDerecho != null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.nodoDerecho;
                                        Bandera = true;
                                    }
                                    raiz.valor = Auxiliar.valor;
                                    NodoEliminar = Auxiliar;
                                    if (Bandera == true)
                                    {
                                        AuxiliarNodo.nodoDerecho = Auxiliar.nodoIzquierdo;

                                    }
                                    else
                                    {
                                        raiz.nodoIzquierdo = Auxiliar.nodoIzquierdo;
                                    }
                                }

                                else
                                {
                                    if (Alturas(raiz.nodoDerecho) - Alturas(raiz.nodoIzquierdo) == 0)
                                    {
                                        AVL AuxiliarNodo = null;
                                        AVL Auxiliar = raiz.nodoDerecho;
                                        bool Bandera = false;

                                        while (Auxiliar.nodoIzquierdo != null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.nodoIzquierdo;
                                            Bandera = true;
                                        }
                                        raiz.valor = Auxiliar.valor;
                                        NodoEliminar = Auxiliar;

                                        if (Bandera == true)
                                        {
                                            AuxiliarNodo.nodoIzquierdo = Auxiliar.nodoDerecho;
                                        }
                                        else
                                        {
                                            raiz.nodoDerecho = Auxiliar.nodoDerecho;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo inexistente en el arbol", "Error", MessageBoxButtons.OK);
            }
            return nodoP;
        }
       
        public void buscar(int valorBuscar, AVL Raiz)
        {
            if (Raiz != null)
            {
                if (valorBuscar < Raiz.valor)
                    buscar(valorBuscar, Raiz.nodoIzquierdo);
                else if (valorBuscar > Raiz.valor)
                    buscar(valorBuscar, Raiz.nodoDerecho);
            }
            else
                MessageBox.Show("Valor no encontrado", "Error", MessageBoxButtons.OK);
        }

        //FUNCIONES PARA DIBUJAR EL ARBOL

        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;

            CoordenadaY = (int)(ymin + Radio / 2);
            if (nodoIzquierdo != null)
                nodoIzquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);


            if ((nodoIzquierdo != null) && (nodoDerecho != null))
                xmin += DistanciaH;

            if (nodoIzquierdo != null && nodoDerecho != null)
                CoordenadaX = (int)((nodoIzquierdo.CoordenadaX + nodoDerecho.CoordenadaX) / 2);

            if (nodoDerecho != null)
                nodoDerecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);

            if (nodoIzquierdo != null)
            {
                if (nodoDerecho != null)
                {
                    CoordenadaX = (int)((nodoIzquierdo.CoordenadaX + nodoDerecho.CoordenadaX) / 2);
                }

                else
                {
                    aux1 = nodoIzquierdo.CoordenadaX;
                    nodoIzquierdo.CoordenadaX = CoordenadaX - 40;
                    CoordenadaX = aux1;
                }
            }
            else if (nodoDerecho != null)
            {
                aux2 = nodoDerecho.CoordenadaX;
                nodoDerecho.CoordenadaX = CoordenadaX + 40;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + Radio / 2); xmin += Radio;
            }
        }


        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if (nodoIzquierdo!=null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, nodoIzquierdo.CoordenadaX, nodoIzquierdo.CoordenadaY);
                nodoIzquierdo.DibujarRamas(grafo, Lapiz);
            }
            if (nodoDerecho!= null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, nodoDerecho.CoordenadaX, nodoDerecho.CoordenadaY);
                nodoDerecho.DibujarRamas(grafo, Lapiz);
            }
        }
       
        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, int dato,Brush encuentro)
        {
            //Dibuja el contorno del nodo

            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio/2),(int)(CoordenadaY-Radio/2), Radio, Radio);

            if (valor == dato)
                grafo.FillEllipse(encuentro, rect);
            else
            {
                grafo.FillEllipse(encuentro, rect);
                grafo.FillEllipse(Relleno, rect);
            }
            grafo.DrawEllipse(Lapiz, rect);

            StringFormat formato = new StringFormat();

            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(valor.ToString(), fuente, Brushes.Black, CoordenadaX, CoordenadaX, formato);

            if (nodoIzquierdo != null)
                nodoIzquierdo.DibujarNodo(grafo, fuente, Brushes.YellowGreen, RellenoFuente, Lapiz, dato, encuentro);
            if (nodoDerecho != null)
                nodoDerecho.DibujarNodo(grafo, fuente, Brushes.Yellow, RellenoFuente, Lapiz, dato, encuentro);
        }


        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            grafo.DrawEllipse(Lapiz, rect);
            grafo.FillEllipse(Brushes.PaleVioletRed, rect);
            grafo.DrawString(valor.ToString(), fuente, Brushes.Black, CoordenadaX, CoordenadaY, formato);

        }
    }
}
