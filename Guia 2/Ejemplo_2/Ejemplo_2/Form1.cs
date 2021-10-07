using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Form1 : Form
    {
        Graphics area;

        public Form1()
        {
            InitializeComponent();

            area = areadibujo.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black);

            switch (cmbColor.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero= new Pen(Color.Red); break;
                case 2: lapicero= new Pen(Color.Blue); break;
                case 3: lapicero= new Pen(Color.Black); break;
               
                
            }

            int iteraciones = int.Parse(txtCantidad.Text);
            int espacio = int.Parse(txtEspaciado.Text);
            area.Clear(Color.White);

            
            int puntoinicio = int.Parse(txtInicio.Text);
            int puntofin = int.Parse(txtTermina.Text);
            
            for (int i = 0; i < iteraciones; i++)
            {
                // area.DrawLine(lapicero, 20, puntoinicio + (espacio * i), 300, puntoinicio + (espacio*i));
                area.DrawLine(lapicero, 20, puntoinicio + (espacio * i), 300, puntofin + (espacio * i));
              
            
            }
        }
    }
}
