using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form
    {
        int x, y;


        Random rnd = new Random();  //Creacion de orden random para tamaños
        Random rndColor = new Random(); //Creacion de orden random para los colores
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();

        }

        // Obtiene, en este ejemplo, un número natural (incluye el 0)
        // aleatorio entre 4 (inclusive ) y 10.
        // int numeroConDosCotas = rnd.Next(4, 10);

        Color[] colors = { Color.Green, Color.Red, Color.White, Color.Blue, Color.Yellow, Color.Black };
        //Lista de colores en un Array
        void Elipses(int opcion, int tam, Pen lap, Graphics g)
        {
            SolidBrush sb = new SolidBrush(colors[opcion]);
            g.DrawEllipse(lap, x - 50, y - 500, tam, tam);
            g.FillEllipse(sb, x - 50, y - 50, tam, tam);         
        }


        void Rectangulos(int opcion, int tam, Pen lap, Graphics g)
        {
            SolidBrush sb = new SolidBrush(colors[opcion]);
            g.DrawRectangle(lap, x - 50, y - 50, tam, tam);
            g.FillRectangle(sb, x - 50, y - 50, tam, tam);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
     
            if (listBox1.SelectedIndex == 0)
            {
                Elipses(rndColor.Next(0,5), rnd.Next(100, 200),lapiz,g);
          
            }
            if (listBox1.SelectedIndex == 1)
            {
                Rectangulos(rndColor.Next(0, 5), rnd.Next(100, 200), lapiz, g);
            }
        }
    }
}
