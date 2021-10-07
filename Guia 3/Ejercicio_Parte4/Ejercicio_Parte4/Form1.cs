using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Parte4
{
    public partial class Form1 : Form
    {
        lista listanueva = new lista();

        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
        }

        private void mskInsertarFinal_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listanueva.InsertarI(Int32.Parse(mskInsertarFrente.Text));
                mskInsertarFrente.Text = "";

                listBox1.Items.Clear();
                listanueva.Mostrar(listBox1);
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listanueva.Mostrar(listBox1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                listanueva.InsertarF(Int32.Parse(mskInsertarFinal.Text));
                mskInsertarFinal.Text = "";

                listBox1.Items.Clear();
                listanueva.Mostrar(listBox1);
            }
            catch
            {

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarPosicion_Click(object sender, EventArgs e)
        {
            listanueva.InsertarP( Int32.Parse(mskValor.Text), Int32.Parse(mskPosicion.Text));
           mskValor.Text  = "";
            mskPosicion.Text = "";


            listBox1.Items.Clear();
            listanueva.Mostrar(listBox1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            listanueva.EliminarI();
            listBox1.Items.Clear();
            listanueva.Mostrar(listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listanueva.EliminarF();
            listBox1.Items.Clear();
            listanueva.Mostrar(listBox1);
        }

        private void btnEliminarPosicion_Click(object sender, EventArgs e)
        {
           
        }
    }
}
