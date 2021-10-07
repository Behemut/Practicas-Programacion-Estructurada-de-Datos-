using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia10
{
    class CGrafo
    {
        public List<CVertice> nodos;

        private CVertice aVertice;
        private CLista aLista;
        private CGrafo aSiguiente;
        public int ValorCosto = 0;

        public CGrafo()
        {
            nodos = new List<CVertice>();

            aVertice = null;
            aLista = null;
            aSiguiente = null;
        }


        public CGrafo(CVertice pVertice, CLista pLista, CGrafo pSiguiente)
        {
            aVertice = pVertice;
            aLista = pLista;
            aSiguiente = pSiguiente;
        }


        public CVertice Vertice
        {
            get
            {
                return aVertice;
            }
            set
            {
                aVertice = value;
            }
        }

        public CLista Lista 
        {
            get
            {
                return aLista;
            }
            set
            {
                aLista = value;
            }
        }

        public CGrafo Siguiente
        {
            get
            {
                return aSiguiente;
            }
            set
            {
                aSiguiente = value;
            }
        }



        public CVertice AgregarVertice(string valor)
        {
            CVertice nodo = new CVertice(valor);
            nodos.Add(nodo);
            return nodo;
        }

        public void AgregarVertice(CVertice nuevodo)
        {
            nodos.Add(nuevodo);
        }



        public CVertice BuscarVertice(string valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }

        public bool AgregarArco(string origen, string nDestino, int peso = 1)
        {
            CVertice vOrigen, vnDestino;

            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
                throw new Exception("El nodo" + origen + " no existe dentro del grafo");

            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
                throw new Exception("El nodo" + nDestino + "  no existe dentro del grado");

            return AgregarArco(vOrigen, vnDestino);
        }

        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso = 1)
        {
            if (origen.ListaAdyacencia.Find(v=> v.nDestino ==nDestino)== null)
            {
                origen.ListaAdyacencia.Add(new CArco(nDestino, peso));
                return true;
            }
            return false;
        }

        public void DibujarGrafo(Graphics g)
        {
            foreach(CVertice nodo in nodos)
                nodo.DibujarArco(g);
         
            foreach (CVertice nodo in nodos)
                nodo.DibujarVertice(g);
        }

        public CVertice DetectarPunto(Point posicionMouse)
        {
            foreach (CVertice nodoActual in nodos)
                if (nodoActual.DetectarPunto(posicionMouse))
                    return nodoActual;

            return null;
        }

        public void ReestablecerGrafo(Graphics g)
        {
            foreach(CVertice nodo in nodos)
            {
                nodo.Color = Color.White;
                nodo.FontColor = Color.Black;
                foreach(CArco arco in nodo.ListaAdyacencia)
                {
                    arco.grosor_flecha = 1;
                    arco.color = Color.Black;
                }
            }
            DibujarGrafo(g);
        }



        public void ColorArista(string o, string d)
        {
            foreach (CVertice nodo in nodos)
            {
                foreach (CArco a in nodo.ListaAdyacencia)
                {
                    if (nodo.ListaAdyacencia != null && nodo.Valor == o && a.nDestino.Valor == d)
                    {
                        a.color = Color.Red;
                        a.grosor_flecha = 4;
                    }
                }
            }
        }

        public void Colorear(CVertice nodo)
        {
            nodo.FontColor = Color.Black;
            nodo.Color = Color.AliceBlue;
        }


        public CVertice nododistanciaminima()
        {
            int min = int.MaxValue;
            CVertice temp = null;
            foreach (CVertice origen in nodos)
            {
                if (origen.Visitado)
                {
                    foreach (CVertice destino in nodos)
                    {
                        if (!destino.Visitado)
                        {
                            foreach (CArco a in origen.ListaAdyacencia)
                            {
                                if (a.nDestino == destino && min > a.peso)
                                {
                                    min = a.peso;
                                    temp = destino;
                                    
                                }
                            }
                        }
                    }
                }
            }
            return temp;
        }

        public int posicionNodo(string Nodo)
        {
            for (int i = 0; i < nodos.Count; i++)
            {
                if (String.Compare(nodos[i].Valor, Nodo) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public void DibujarEntrantes(CVertice nDestino)
        {
            foreach (CVertice nodo in nodos)
            {
                foreach (CArco a in nodo.ListaAdyacencia)
                {
                    if (nodo.ListaAdyacencia != null && nodo != nDestino)
                    {
                        if (a.nDestino == nDestino)
                        {
                            a.color = Color.Black;
                            a.grosor_flecha = 2;
                            break;
                        }
                    }
                }
            }
        }

        public void Desmarcar()
        {
            foreach (CVertice n in nodos)
            {
                n.Visitado = false;
                n.Padre = null;
                n.Distancianodo = int.MaxValue;
                n.pesoasignado = false;
            }
        }


        //CAMBIO DESDE AQUI

       public void AgregarVertice_Nuevo(CVertice vertice)
       {
            if((vertice!=null) && (!ExisteVertice(vertice)))
            {
                if (aVertice != null)
                {
                    if (vertice.Valor.CompareTo(aVertice.Valor) < 0)
                    {
                        CGrafo aux = new CGrafo(aVertice, aLista, aSiguiente);
                        aVertice = new CVertice(vertice.Valor);
                        aSiguiente = aux;
                    }
                    else
                    {
                        aSiguiente.AgregarVertice_Nuevo(vertice);
                    }
                }
                else
                {
                    aVertice = new CVertice(vertice.Valor);
                    aLista = new CLista();
                    aSiguiente = new CGrafo();
                }
            }
       }

        public void AgregarArcoNuevo(CVertice pVerticeOrigen, CVertice pVerticeDestino, int pDistancia)
        {
            if(ExisteVertice(pVerticeOrigen) && ExisteVertice(pVerticeDestino))
                agregarArco(pVerticeOrigen, pVerticeDestino, pDistancia);
            else
            Console.WriteLine("Error no se agrego arco");
        }
        public void agregarArco(CVertice pVerticeOrigen, CVertice pVerticeDestino, int pDistancia)
        {
            if(ExisteVertice(pVerticeOrigen))
            {
                if(aVertice.Equals(pVerticeOrigen))
                {
                    if ((!aLista.ExisteElemento(pVerticeDestino)))
                        aLista.Agregar(pVerticeDestino, pDistancia);
                }else 
                if (aSiguiente != null) {
                    aSiguiente.agregarArco(pVerticeOrigen, pVerticeDestino, pDistancia);
                }
            }
        }

        public bool EstaVacio()
        {
            return (aVertice == null);
        }

        public void MostrarVertices()
        {
            if (aVertice != null)
            {
                Console.WriteLine(aVertice.Valor);
                aSiguiente.MostrarVertices();
            }
        }

        public void MostrarGrafo()
        {
            if (aVertice != null)
            {
                for (int i = 0; i < aLista.NroElementos(); i++)
                {
                    Console.WriteLine(aVertice.Valor + " ==> " + aLista.IesimoElemento(i) + "  Con peso >>>(" + aLista.IesimoElementoPeso(i) + " )");
                    aSiguiente.MostrarGrafo();
                }
            }
        }

        public int NumeroVertices()
        {
            if (aVertice == null)
                return 0;
            else
                return 1 + aSiguiente.NumeroVertices();
        }


        public int PosicionVertice(CVertice pVertice)
        {
            if ((aVertice == null) || (pVertice == null))
                return 0;
            else
            {
                if (!ExisteVertice(pVertice))
                    return 0;
                else
                {
                    if (aVertice.Valor.Equals(pVertice.Valor))
                        return 1;
                    else
                        return 1 + aSiguiente.PosicionVertice(pVertice);
                }

            }
        }

       
        public int GradoSaliente(CVertice pVertice)
        {
            if (!ExisteVertice(pVertice))
                return 0;
            else
            {
                if (aVertice.Equals(pVertice))
                    return aLista.NroElementos();
                else
                    return aSiguiente.GradoSaliente(pVertice);
            }
        }


        public CVertice IesimoVertice(int posicion)
        {
            if ((posicion > 0))
            {
                if (posicion == 1)
                {
                    return aVertice;
                }
                else
                    return aSiguiente.IesimoVertice(posicion - 1);
            }
            else
            {
                return null;
            }
        }

        public bool ExisteVertice(CVertice vertice)
        {
            if ((aVertice==null) || (vertice==null))
            {
                return false;
            }
            else
            {
                if (aVertice.Valor.Equals(vertice.Valor))
                    return true;
                else
                    return aSiguiente.ExisteVertice(vertice);
            }
        }

        private void EliminarDeLlegadas(CVertice pVertice)
        {
            if (aVertice != null)
            {
                aLista.Eliminar(pVertice);
                aSiguiente.EliminarDeLlegadas(pVertice);
            }
        }


        public CVertice IesimoSucesor(CVertice pVertice, int posicion)
        {
            if (ExisteVertice(pVertice))
            {
                if (aVertice.Equals(pVertice))
                {
                    return ((posicion > 0) && (posicion <= aLista.NroElementos()) ? (aLista.IesimoElemento(posicion) as CVertice) : null);
                }
                else
                {
                    return aSiguiente.IesimoSucesor(pVertice, posicion);
                }
            }
            else
            {
                return null;
            }
        }


        public void RecorridoEnProfundidad()
        {
            int NroVertices = NumeroVertices();

            string[] ArregloVisitados = new string[NroVertices];

            for (int i = 0; i <= NroVertices - 1; i++)
            {
                ArregloVisitados[i] = "F";
            }

            for (int i = 0; i <= NroVertices - 1; i++)
            {
                if (ArregloVisitados[i] == "F")
                    RecorrerVerticeProfundidad(IesimoVertice(i + 1), ArregloVisitados);

            }
        }

        private void RecorrerVerticeProfundidad(CVertice pVertice, string[] ArregloVisitados)
        {
            int posicion = PosicionVertice(pVertice);
            ArregloVisitados[posicion - 1] = "T";

            Console.WriteLine(" " + pVertice.Valor + ",");
            for (int i = 0; i <= GradoSaliente(pVertice) - 1; i++)
            {
                CVertice nuevovertice = IesimoSucesor(pVertice, i + 1);
                int j = PosicionVertice(nuevovertice);
                if (ArregloVisitados[j - 1] == "F")
                {
                    RecorrerVerticeProfundidad(nuevovertice, ArregloVisitados);
                }
            }
        }

        public void RecorridoAncho()
        {
            int NroVertices = NumeroVertices();
            string[] ArregloVisitados = new string[NroVertices];

            for (int i = 0; i <= NroVertices - 1; i++)
            {
                ArregloVisitados[i] = "F";
            }

            for (int i = 0; i <= NroVertices - 1; i++)
            {
                if (ArregloVisitados[i] == "F")

                    RecorrerVerticeAncho(IesimoVertice(i + 1), ArregloVisitados);
            }
        }

   
        private void RecorrerVerticeAncho(CVertice pVertice, string[] ArregloVisitados)
        {
            int Posicion = PosicionVertice(pVertice);
            ArregloVisitados[Posicion - 1] = "T";
          Console.WriteLine(" " + pVertice.Valor + " , ");
          
            for (int i = 0; i <= GradoSaliente(pVertice) - 1; i++)
            {
                CVertice NuevoVertice = IesimoSucesor(pVertice, i + 1);


                int j = PosicionVertice(NuevoVertice);
                if (ArregloVisitados[j - 1] == "F")
                {
                   Console.Write(NuevoVertice.Valor + "");
      
                    ArregloVisitados[j - 1] = "T";
                }
            }
        }
    }
}
