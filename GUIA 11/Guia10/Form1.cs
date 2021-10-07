using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Guia10
{
    public partial class Simulador : Form
    {
    


        //Variables para el uso de las clases para los nodos y las aristas
        private CGrafo grafo;


        List<string> LVertices = new List<string>();
        private int totalNodos;
        int[] parent;
        string[] ListaVertices;
        bool[] visitados;
        List<int> filaDistancia = new List<int>();
        int[,] mat;

        private CVertice nuevoNodo;

        private CLista nuevaLista;
        private CVertice NodoOrigen;

        private CVertice NodoDestino;
        private int var_control = 0;

        //Variables para los objetos del manejo de los siguientes formularios
        private Vertice ventanaVertice;
        private Arco ventanaArco;



        List<CVertice> nodosRuta;
        List<CVertice> nodosOrdenados;
        bool buscarRuta = false;
        private int numeronodos = 0;
        bool profundidad = false, anchura = false, nodoEncontrado = false, costo = false;
        Queue cola = new Queue();
        private string destino = "", origen = "";
        private string destino_sel = "", origen_sel = "";
        private int distancia = 0;


        //Variables para el estado del uso de los formularios 
        bool nuevoVertice = false, nuevoArco = false;


        bool Reestablecer = true;

        public Simulador()
        {
            InitializeComponent();
            grafo = new CGrafo();

            nuevoNodo = null;
            var_control = 0;
            ventanaVertice = new Vertice();
            ventanaArco = new Arco();
            nodosRuta = new List<CVertice>();
            nodosOrdenados = new List<CVertice>();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pizarra_Paint(object sender, PaintEventArgs e)
        {
            //Por medio del evento Paint dentro de la pizarra se ira autorellenando los Combobox con los valores y la posicion de cada uno de los vertices y sus aristas tambien
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                grafo.DibujarGrafo(e.Graphics);

                if (nuevoVertice == true)
                {
                    CBVertice.Items.Clear();
                    CBVertice.SelectedIndex = -1;

                    CBNodoPartida.Items.Clear();
                    CBNodoPartida.SelectedIndex = -1;

                    CBVerticeOrigen.Items.Clear();
                    CBVerticeOrigen.SelectedIndex = -1;

             
                    
                    foreach (CVertice nodo in grafo.nodos)
                    {
                        CBVertice.Items.Add(nodo.Valor);
                        CBNodoPartida.Items.Add(nodo.Valor);
                        CBVerticeOrigen.Items.Add(nodo.Valor);
                  

                        calcularMatricesIniciales();



                       if(! LVertices.Contains(nodo.Valor))
                           LVertices.Add(nodo.Valor);
                    }
                    nuevoVertice = false;

                }

                if (nuevoArco == true)
                {
                    CBArco.Items.Clear();
                    CBArco.SelectedIndex = -1;

                    foreach (CVertice nodo in grafo.nodos)
                    {
                        foreach (CArco arco in nodo.ListaAdyacencia)
                            CBArco.Items.Add("(" + nodo.Valor + "," + arco.nDestino.Valor + ") peso: " + arco.peso);
                        //Calcular la Matriz de relaciones cada ves que se añade relacion entre los vectores
                        calcularMatricesIniciales();
                    }
                    nuevoArco = false;
                }

                if (costo == true)
                {



                    foreach (CVertice nodo in grafo.nodos)
                    {
                        foreach (CArco arco in nodo.ListaAdyacencia)
                        {
                            grafo.ValorCosto += arco.peso;
                

                            // CBArco.Items.Add("(" + nodo.Valor + "," + arco.nDestino.Valor + ") peso: " + arco.peso);
                        }
                    }
                    costo = false;
                }

                if (buscarRuta)
                {
                    foreach (CVertice nodo in nodosRuta)
                    {
                        nodo.colorear(e.Graphics);
                        Thread.Sleep(1000);
                        nodo.DibujarVertice(e.Graphics);
                    }
                    buscarRuta = false;
                }


                if (profundidad)
                {
                    ordenarNodos();
                    foreach (CVertice nodo in nodosOrdenados)
                    {
                        if (!nodo.Visitado)
                        {
                            recorridoProfundidad(nodo, e.Graphics);
                            //Console.WriteLine("Recorrido en profundidad");

                        }
                    }
                    profundidad = false;
                    foreach (CVertice nodo in grafo.nodos)
                        nodo.Visitado = false;
                }

                if (anchura)
                {
                    distancia = 0;
                    cola = new Queue();

                    ordenarNodos();
                    foreach (CVertice nodo in nodosOrdenados)
                    {
                        if (!nodo.Visitado && !nodoEncontrado)
                        {
                            recorridoAnchura(nodo, e.Graphics, destino);
                            //Console.WriteLine("Recorrido en profundidad");

                        }
                    }
                    anchura = false;
                    nodoEncontrado = false;
                    foreach (CVertice nodo in grafo.nodos)
                        nodo.Visitado = false;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Pizarra_MouseLeave(object sender, EventArgs e)
        {
            Pizarra.Refresh();
        }

        private void nuevoVerticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CREAR NODO NUEVO
            nuevoNodo = new CVertice();
            var_control = 2;
        }

        //Funcion para agregar valores del peso en las aristas
        private void Pizarra_MouseUp(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 1:

                    if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && NodoOrigen != NodoDestino)
                    {
                        ventanaArco.Visible = false;
                        ventanaArco.control = false;
                        ventanaArco.ShowDialog();
                        if (ventanaArco.control == true)
                        {
                            if (grafo.AgregarArco(NodoOrigen, NodoDestino, ventanaArco.dato))
                            {
                                int distancia = ventanaArco.dato;
                                //Agregar arco del modo consola
                                // grafo.AgregarArcoNuevo(NodoOrigen, NodoDestino, distancia) ;



                                //int distancia = ventanaArco.dato;
                                NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = distancia;
                            }
                            nuevoArco = true;
                        }
                    }
                    var_control = 0;
                    NodoOrigen = null;
                    NodoDestino = null;
                    Pizarra.Refresh();
                    break;

            }
        }

        //Funcion encargada de recoger los valores de posicion del mouse para colocarlos en la Pizarra
        private void Pizarra_MouseMove(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 2:
                    if (nuevoNodo != null)
                    {
                        int posX = e.Location.X;
                        int posY = e.Location.Y;

                        if (posX < nuevoNodo.Dimensiones.Width / 2)
                            posX = nuevoNodo.Dimensiones.Width / 2;
                        else if (posX > Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2)
                            posX = Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2;

                        if (posY < nuevoNodo.Dimensiones.Height / 2)
                            posY = nuevoNodo.Dimensiones.Height / 2;
                        else if (posY > Pizarra.Height - nuevoNodo.Dimensiones.Width / 2)
                            posY = Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2;

                        nuevoNodo.Posicion = new Point(posX, posY);
                        Pizarra.Refresh();
                        nuevoNodo.DibujarVertice(Pizarra.CreateGraphics());
                    }
                    break;

                case 1:  //Dibujar Arco
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
                    bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    Pizarra.Refresh();
                    Pizarra.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2)
                    {
                        CustomEndCap = bigArrow
                    }, NodoOrigen.Posicion, e.Location);
                    break;

                case 3:

                    break;
            }
        }

        //Funcion encargada de recoger los valores obtenidos de la ventana Vertices para darle el valor al nodo
        private void Pizarra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                {
                    var_control = 1;
                }
                if (nuevoNodo != null && NodoOrigen == null)
                {
                    ventanaVertice.Visible = false;
                    ventanaVertice.control = false;
                    ventanaVertice.ShowDialog();
                    numeronodos = grafo.nodos.Count;
                    //grafo.AgregarVertice(nuevoNodo);

                    if (ventanaVertice.control)
                    {
                        if (grafo.BuscarVertice(ventanaVertice.txtVertice.Text) == null)
                        {
                            nuevoNodo.Valor = ventanaVertice.txtVertice.Text;
                            grafo.AgregarVertice(nuevoNodo);

                        }
                        else
                        {
                            lblRespuesta.Text = "El nodo " + ventanaVertice.txtVertice.Text + " ya existe en el grafo";
                            lblRespuesta.ForeColor = Color.Red;
                        }
                    }
                    nuevoNodo = null;
                    nuevoVertice = true;
                    var_control = 0;
                    Pizarra.Refresh();
                }
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (var_control == 0)
                {
                    if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                    {
                        CMSCrearVertice.Text = "Nodo " + NodoOrigen.Valor;
                    }
                    else
                        Pizarra.ContextMenuStrip = this.CMSCrearVertice;
                }
            }
        }

        private void Simulador_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void eliminarVerticeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarVertice_Click(object sender, EventArgs e)
        {
            calcularMatricesIniciales();

            if (CBVertice.SelectedIndex > -1)
            {
                foreach (CVertice nodo in grafo.nodos)
                {
                    if (nodo.Valor == CBVertice.SelectedItem.ToString())
                    {
                        grafo.nodos.Remove(nodo);
                        LVertices.Remove(nodo.Valor);
                        nodo.ListaAdyacencia = new List<CArco>();
                        break;
                    }
                }

                foreach (CVertice nodo in grafo.nodos)
                {
                    foreach (CArco arco in nodo.ListaAdyacencia)
                    {
                        if (arco.nDestino.Valor == CBVertice.SelectedItem.ToString())
                        {
                            nodo.ListaAdyacencia.Remove(arco);
                        
                            break;
                        }
                    }
                }
                nuevoArco = true;
                nuevoVertice = true;
                CBVertice.SelectedIndex = -1;
                Pizarra.Refresh();
            }
            else
            {
                lblRespuesta.Text = "Seleccione un nodo de partida";
                lblRespuesta.ForeColor = Color.Red;
            }
        }

        private void btnEliminarArco_Click(object sender, EventArgs e)
        {
            if (CBArco.SelectedIndex > -1)
            {
                foreach (CVertice nodo in grafo.nodos)
                {
                    foreach (CArco arco in nodo.ListaAdyacencia)
                    {
                        if ("(" + nodo.Valor + "," + arco.nDestino.Valor + ") peso: " + arco.peso == CBArco.SelectedItem.ToString() )
                        {
                            //insert(nodo.Valor, arco.nDestino.Valor, arco.peso);
                            nodo.ListaAdyacencia.Remove(arco);
                            break;
                        }
                    }

                }
                nuevoArco = true;
                nuevoVertice = true;
                CBArco.SelectedIndex = -1;
                Pizarra.Refresh();
            }
            else
            {
                lblRespuesta.Text = "Seleccione un arco";
                lblRespuesta.ForeColor = Color.Red;
            }
        }

        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            calcularMatricesIniciales();

            lblCamino.Text = "";



            if (CBNodoPartida.SelectedIndex > -1)
            {
                profundidad = true;
                origen = CBNodoPartida.SelectedItem.ToString();

                Pizarra.Refresh();
                CBNodoPartida.SelectedIndex = -1;
            }
            else
            {
                lblRespuesta.Text = "Seleccione un nodo de partida";
                lblRespuesta.ForeColor = Color.Red;
            }
        }

        private void btnAnchura_Click(object sender, EventArgs e)
        {
            lblCamino.Text = "";

            calcularMatricesIniciales();
            if (CBNodoPartida.SelectedIndex > -1)
            {
                origen = CBNodoPartida.SelectedItem.ToString();
                anchura = true;
                Pizarra.Refresh();
                CBNodoPartida.SelectedIndex = -1;

            }
            else
            {
                lblRespuesta.Text = "Seleccione un nodo de partida";
                lblRespuesta.ForeColor = Color.Red;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() != "")
            {
                if (grafo.BuscarVertice(txtBuscar.Text) != null)
                {
                    lblRespuesta.Text = "Si se encuentra el vertice:  " + txtBuscar.Text;
                    lblRespuesta.ForeColor = Color.Blue;
                }
                else
                {
                    lblRespuesta.Text = "No se encuentra el vertice:  " + txtBuscar.Text;
                    lblRespuesta.ForeColor = Color.Red;
                }
            }
        }

        private void btnDistancia_Click(object sender, EventArgs e)
        {

          
        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void ordenarNodos()
        {
            nodosOrdenados = new List<CVertice>();
            bool est = false;
            foreach (CVertice nodo in grafo.nodos)
            {
                if (nodo.Valor == origen)
                {
                    nodosOrdenados.Add(nodo);
                    est = true;
                    return;

                }
                else if (est)
                {
                    nodosOrdenados.Add(nodo);
                }
            }
            foreach (CVertice nodo in grafo.nodos)
            {
                if (nodo.Valor == origen)
                {
                    est = false;
                    break;
                }
                else if (est)
                {
                    nodosOrdenados.Add(nodo);

                }
            }
        }


        private void recorridoProfundidad(CVertice vertice, Graphics g)
        {

            vertice.Visitado = true;
            vertice.colorear(g);
            Thread.Sleep(1000);
            vertice.DibujarVertice(g);
            //IMPRIMIR PARA LOS NODOS EN MODO PREORDEN 
            if (vertice.Visitado)
            {
                lblCamino.Text += vertice.Valor + "->";

            }
            foreach (CArco adya in vertice.ListaAdyacencia)
            {

                if (!adya.nDestino.Visitado)
                {
                    recorridoProfundidad(adya.nDestino, g);
                }

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                //Limpiar para cada recorrido
                richTextBox1.Clear();
                CDijkstra prueba = new CDijkstra((int)Math.Sqrt(mat.Length), mat);
                prueba.CorrerDijkstra();

                Console.WriteLine("La solucion de la ruta mas corta desde nodo 1 es: ");
                string nodo = CBVerticeOrigen.SelectedItem.ToString();

                int contador = 0;
                foreach (int i in prueba.D)
                {
                    richTextBox1.Text += ("Distancia minima a nodo " + LVertices[contador] + " es: " + i + "\n");
                    contador++;
                }
            }
            catch (Exception)
            {

            }

        }

        private void recorridoAnchura(CVertice vertice, Graphics g, string destino)
        {
            vertice.Visitado = true;
            cola.Enqueue(vertice);
            vertice.colorear(g);
            Thread.Sleep(1000);
            vertice.DibujarVertice(g);
            if (vertice.Valor == destino)
            {
                nodoEncontrado = true;
                return;
            }
            //IMPRIMIR EL VALOR DEL NODO DE PARTIDA
            if (vertice.Visitado)
            {
                lblCamino.Text += vertice.Valor + "->";
            }
            while (cola.Count > 0)
            {
                CVertice aux = (CVertice)cola.Dequeue();
                foreach (CArco adya in aux.ListaAdyacencia)
                {
                    if (!adya.nDestino.Visitado)
                    {

                        //MODIFICACION PARA MOSTRAR EL RESTO DEL RECORRIDO
                        if (vertice.Visitado)
                        {
                            lblCamino.Text += adya.nDestino.Valor + "->";
                        }
                        if (!nodoEncontrado)
                        {
                            adya.nDestino.Visitado = true;

                            adya.nDestino.colorear(g);
                            Thread.Sleep(1000);
                            adya.nDestino.DibujarVertice(g);
                            if (destino != "")
                            {
                                distancia += adya.peso;

                            }

                            cola.Enqueue(adya.nDestino);
                            if (adya.nDestino.Valor == destino)
                            {
                                nodoEncontrado = true;
                                return;
                            }
                        }
                    }
                }
            }
        }

      
        private void CBVerticeOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reestablecer = true;
        }

        private void CBArco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reestablecerGrafoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void calcularMatricesIniciales()
        {
            filaDistancia.Clear();
            nodosRuta = new List<CVertice>();
            totalNodos = grafo.nodos.Count;
            ListaVertices = new string[totalNodos];

            parent = new int[totalNodos];
            mat = new int[totalNodos, totalNodos];

            visitados = new bool[totalNodos];
            for (int i = 0; i < totalNodos; i++)
            {


                //FORMA DE AÑADIR LA MATRIZ DE FORMA DIRIGIDA
                for (int j = 0; j < totalNodos; j++)
                {
                    //Llenando todo primero con -1 
                    if (i == j)
                    {
                        filaDistancia.Add(0);
                        mat[j,i] = -1;
                    }
                else
                    {
                        int distancia = -1;
                        mat[i,j] = -1;

                        for (int k = 0; k < grafo.nodos[i].ListaAdyacencia.Count; k++)
                        {
                            if (grafo.nodos[i].ListaAdyacencia[k].nDestino == grafo.nodos[j])
                            {
                                distancia = grafo.nodos[i].ListaAdyacencia[k].peso;
                                //AÑADIR MATRIZ FORMA NO DIRIGIDA
                                mat[i, j] = grafo.nodos[i].ListaAdyacencia[k].peso;
                                // mat[j,i] = grafo.nodos[i].ListaAdyacencia[k].peso;


                            }

                            filaDistancia.Add(distancia);
                          
                        }

                    }
                    
                }

            }
            //Console.Write("   ");

            //for (int i = 0; i < LVertices.Count(); i++)
            //{
            //    Console.Write(LVertices[i].ToString() + " ");
            //}
            //Console.WriteLine("\n");
            //for (int i = 0; i < LVertices.Count(); i++)
            //{
            //    Console.Write(LVertices[i].ToString() + " ");
            //    for (int j = 0; j < LVertices.Count(); j++)
            //    {
            //        Console.Write(mat[i, j] + " | ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------LISTA MATRIZ ADYA---------------------------------");
        }
    }
 }
