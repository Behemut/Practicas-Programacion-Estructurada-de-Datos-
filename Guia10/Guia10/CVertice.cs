using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;



namespace Guia10
{
    class CVertice
    {
        public string Valor;
      
        public List<CArco> ListaAdyacencia;


        /* Identificar el tipo de estructura utilizada para el manejo del grafo
        El tipo de grado manejado en esta guia es la del tipo de Grafo  Dirigido ya que hace uso de una lista de Lista de Adyacencia que 
        es una representacion de todas las aristas o arcos mediantes una lista enlazada cuyos nodos, a su vez, representan los arcos con vertice 
        origen el del nodo de la lista directorio.

              */


        Dictionary<string, short> _banderas;
        Dictionary<string, short> _banderas_predeterminado;
        /*Uso de diccionarios para la coleccion de los estados que se tienen segun la clase que ira acumulandose */

        static int size = 35;//Tamaño del nodo
        Size dimensiones;
        Color color_nodo;
        Color color_fuente;
        Point _posicion;
        int radio;




        public int distancianodo;
        public Boolean Visitado;
        public CVertice Padre;
        public Boolean pesoasignado;

        //Encapsulamiento de las distintas variables de la clase Vertice 
        public Color Color
        {
            get { return color_nodo; }
            set { color_nodo = value;}
        }

        public Color FontColor
        {
            get { return color_fuente; }
            set { color_fuente = value; }
        }

        public Point Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }

        public Size Dimensiones
        {
            get { return dimensiones; }
            set { radio = value.Width / 2;
                dimensiones = value;
            }
        }

        //Constructor de la clase Vertice donde recibira el valor que encerrara el nodo para el grafo
        public CVertice(string Valor)
        {
            this.Valor = Valor;
            this.ListaAdyacencia = new List<CArco>();
            this._banderas = new Dictionary<string, short>();
            this._banderas_predeterminado = new Dictionary<string, short>();
            this.Color = Color.Green;
            this.Dimensiones = new Size(size, size);
            this.FontColor = Color.White;


            this.Color = Color.FromArgb(51, 204, 255);
            this.FontColor = Color.Black;
            this.Visitado = false;
        }

        public CVertice (): this("") { } //Constructor por defecto

        //Metodos para dibujado de los Vertices y arcos
        public void DibujarVertice(Graphics g)
        {
            SolidBrush b = new SolidBrush(this.color_nodo);
            Rectangle areaNodo = new Rectangle(this._posicion.X - radio, this._posicion.Y - radio, this.dimensiones.Width, this.dimensiones.Height);
            g.FillEllipse(b, areaNodo);
            g.DrawString(this.Valor, new Font("Times New Roman", 14), new SolidBrush(color_fuente), this._posicion.X, this._posicion.Y, new StringFormat()
            {
              Alignment = StringAlignment.Center,
              LineAlignment = StringAlignment.Center
            });
            g.DrawEllipse(new Pen(Brushes.Black, (float)1.0), areaNodo);
            b.Dispose();
        }

        public void DibujarArco(Graphics g)
        {
            float distancia;
            int difY, difX;

            foreach (CArco arco in ListaAdyacencia)
            {
                difX = this.Posicion.X - arco.nDestino.Posicion.X;
                difY = this.Posicion.Y - arco.nDestino.Posicion.Y;

                distancia = (float) Math.Sqrt((difX*difX+ difY*difY));

                // AdjustableArrowCap  es un metodo dentro de la libreria Drawing2D que nos permite crear lineas con señalizacion dentro de C#
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
                bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;

       g.DrawLine(new Pen (new SolidBrush(arco.color), arco.grosor_flecha) { CustomEndCap = bigArrow, Alignment = PenAlignment.Center},
           _posicion, new Point(arco.nDestino.Posicion.X + (int) (radio*difX/distancia), arco.nDestino.Posicion.Y + (int)(radio * difY / distancia)));


                g.DrawString(arco.peso.ToString(), new Font("Time New Roman", 12), new SolidBrush(Color.White), this._posicion.X - (int) ((difX/3)), this._posicion.Y-(int)((difY/3)),
                new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Far
                });
            }
        }

        //Metodo para detectar la posicion del raton dentro de la pizarra 
        public bool DetectarPunto(Point p)
        {
         GraphicsPath posicion = new GraphicsPath();
         posicion.AddEllipse(new Rectangle(this._posicion.X-this.dimensiones.Width/2, this._posicion.Y- this.dimensiones.Height/2,this.dimensiones.Width, this.dimensiones.Height));

            bool retval = posicion.IsVisible(p);
            posicion.Dispose();
            return retval;
        }

        //Este metodo en especifico hace referencia a un comportamiento Override que permite cambiar el comportamiento estatico de la variable
        //Valor y siempre devolviendo un valor del tipo string, esto permite que podamos llamarlo desde cualquier lado.
        public string ToString()
        {
            return this.Valor;
        }


        public void colorear(Graphics g)
        {
            SolidBrush b = new SolidBrush(Color.YellowGreen);
            //Definimos donde dibujaremos el nodo
            Rectangle areaNodo = new Rectangle(this._posicion.X - radio, this._posicion.Y - radio, this.dimensiones.Width, this.dimensiones.Height);
            g.FillEllipse(b, areaNodo);
            g.DrawString(this.Valor, new Font("Times New Roman", 14), new SolidBrush(color_fuente), this._posicion.X, this._posicion.Y,
                new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                }
                );
            g.DrawEllipse(new Pen(Brushes.Black, (float)1.0), areaNodo);
            b.Dispose();
        }
    }
}
