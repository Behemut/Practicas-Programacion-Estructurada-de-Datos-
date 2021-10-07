using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_BANCO
{
    public partial class Form1 : Form
    {
        Queue<Clientes> Clientes_Cajero1 = new Queue<Clientes>();
        Queue<Clientes> Clientes_Cajero2 = new Queue<Clientes>();
        Queue<Clientes> Clientes_Cajero3 = new Queue<Clientes>();
        Queue<Clientes> Clientes_Cajero4 = new Queue<Clientes>();

        int[] contador = new int[4];
     

        public Form1()
        {
            InitializeComponent();
        }

        private void bntAgregarCaj1_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            cliente.Nombre = txtNombreCliente.Text;

            cliente.Monto = Double.Parse(txtMontoCliente.Text);
            cliente.Fecha = dtpFechaCliente.Value;

            switch (comboBox1.SelectedItem)
            {
                case "Cajero 1":

                    Clientes_Cajero1.Enqueue(cliente);
                    dgvCajero1.DataSource = null;
                    dgvCajero1.DataSource = Clientes_Cajero1.ToArray();


                    Limpiar();
                    break;

                case "Cajero 2":
                    Clientes_Cajero2.Enqueue(cliente);
                    dgvCajero2.DataSource = null;
                    dgvCajero2.DataSource = Clientes_Cajero2.ToArray();
                    Limpiar();
                    break;

                case "Cajero 3":
                    Clientes_Cajero3.Enqueue(cliente);
                    dgvCajero3.DataSource = null;
                    dgvCajero3.DataSource = Clientes_Cajero3.ToArray();
                    Limpiar();
                    break;

                case "Cajero 4":
                    Clientes_Cajero4.Enqueue(cliente);
                    dgvCajero4.DataSource = null;
                    dgvCajero4.DataSource = Clientes_Cajero4.ToArray();
                    Limpiar();
                    break;

                default:
                    break;
            }
        }


        void Limpiar()
        {
            txtMontoCliente.Clear();
            txtNombreCliente.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();


            switch (comboBox1.SelectedItem)
            {

                case "Cajero 1":
                    if (Clientes_Cajero1.Count != 0)
                    {
                        cli = Clientes_Cajero1.Dequeue();
                        dgvCajero1.DataSource = Clientes_Cajero1.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No hay clientes en cola", "Aviso");
                    }
                    Limpiar();
                    break;

                case "Cajero 2":
                    if (Clientes_Cajero2.Count != 0)
                    {
                        cli = Clientes_Cajero2.Dequeue();
                        dgvCajero2.DataSource = Clientes_Cajero2.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No hay clientes en cola", "Aviso");
                    }
                    Limpiar();
                    break;

                case "Cajero 3":

                    if (Clientes_Cajero3.Count != 0)
                    {
                        cli = Clientes_Cajero3.Dequeue();
                        dgvCajero3.DataSource = Clientes_Cajero3.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No hay clientes en cola", "Aviso");
                    }
                    Limpiar();
                    break;

                case "Cajero 4":

                    if (Clientes_Cajero4.Count != 0)
                    {
                        cli = Clientes_Cajero4.Dequeue();
                        dgvCajero4.DataSource = Clientes_Cajero4.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No hay clientes en cola", "Aviso");
                    }
                    Limpiar();
                    break;

                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            ContadorCajeros();
       
        }

        public void ContadorCajeros()
        {
            contador[0] = Clientes_Cajero1.Count();
            contador[1] = Clientes_Cajero2.Count();
            contador[2] = Clientes_Cajero3.Count();
            contador[3] = Clientes_Cajero4.Count();

            
            //Sumatoria total del vector para contar a los clientes actuales en el sistema
            txtTotal.Text = (contador.Sum().ToString());
            txtClientesCaj1.Text = contador[0].ToString();
            txtClientesCaj2.Text = contador[1].ToString();
            txtClientesCaj3.Text = contador[2].ToString();
            txtClientesCaj4.Text = contador[3].ToString();




            for (int i = 0; i < contador.Length; i++)
            {
                if (contador.Min() == contador[i] && contador[i] != 0)
                {
                    txtMensaje.Text +=("Cajero N° " + (i+1) + "   con cantidad " + contador[i] +  "  clientes esperando" + Environment.NewLine);
                }
            
              
            } 
            
            contador.Min();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}