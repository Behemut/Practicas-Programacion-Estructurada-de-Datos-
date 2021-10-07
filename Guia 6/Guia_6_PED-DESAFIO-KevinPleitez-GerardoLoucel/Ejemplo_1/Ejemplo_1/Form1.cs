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


        public Form1()
        {
            InitializeComponent();
        }
        //Declaración de variables a utilizar 
        int Dato = 0;
        int cont = 0;
        Arbol_binario  mi_Arbol = new Arbol_binario (null); //Creación del objeto Árbol 
        Graphics g; //Definición del objeto gráfico
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Green, Brushes.Yellow, Pens.Black, Brushes.White);
        }

        /*Evento que permitirá insertar un nodo al árbol (código de botón “Insertar Nodo” del formulario mostrado en la figura) */
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "") {
                MessageBox.Show("Debe Ingresar un Valor");
            } else {
                Dato = int.Parse(txtDato.Text);
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else {
                    mi_Arbol.Insertar(Dato);//Llamamos el metodo insertar
                    txtDato.Clear();
                    txtDato.Focus();
                    cont++;
                    Refresh();
                    Refresh();
                }
            }
        }

        /*Evento que permitirá eliminar un nodo del árbol (código de botón “Eliminar Nodo” del formulario mostrado en la figura) */
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text == "") {
                MessageBox.Show("Debe ingresar el valor a eliminar");
            } else {
                Dato = Convert.ToInt32(txtEliminar.Text);
                if (Dato <= 0 || Dato >= 100) {
                    MessageBox.Show("Sólo se adminten valores entre 1 y 99", "Error de Ingreso");
                } else {
                    mi_Arbol.Eliminar(Dato);
                    txtEliminar.Clear();
                    txtEliminar.Focus();
                    cont--;
                    Refresh();
                    Refresh(); } }
        }

        /*Evento que permitirá buscar un nodo en el árbol (código de botón “Buscar Nodo” del formulario mostrado en la figura) */

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor a buscar");
            }
            else {
                Dato = Convert.ToInt32(txtBuscar.Text);
                if (Dato <= 0 || Dato >= 100) {
                    MessageBox.Show("Sólo se admiten valores entre 1 y 99", "Error de Ingreso");
                } else {
                    mi_Arbol.Buscar(Dato);
                    txtBuscar.Clear();
                    txtBuscar.Focus();
                    Refresh();
                    Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<int> inOrden = new List<int>();
            //inOrden.AddRange(mi_Arbol.Transversa_PreOrden(mi_Arbol.Raiz));
            //foreach (int data in inOrden)
            //{
            //    label2.Text += data;
            //    if (inOrden.Last()!=data )
            //    {
            //        label2.Text += " -> ";
            //    }
            //}


            label2.Text = mi_Arbol.PreOrden();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = mi_Arbol.InOrden();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = mi_Arbol.PostOrden();
        }
    }
}
