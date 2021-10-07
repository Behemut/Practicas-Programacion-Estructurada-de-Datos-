using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ejemplo1
{
    public partial class Ejemplo1 : Form
    {
        public double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_Op;
        int Operacion;

        public Ejemplo1()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 0;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operadores");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 1;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operadores");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 2;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operadores");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 3;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operadores");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operacion == 0)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "+").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }



                if (Operacion == 1)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "-").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }




                if (Operacion == 2)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "x").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }


                if (Operacion == 3)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "/").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }

                if (Operacion == 4)
                {
                    if (Is1)
                    {
                        actualizar_pantalla(trigonometricas(Num1,"sin").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }


                if (Operacion == 5)
                {
                    if (Is1)
                    {
                        actualizar_pantalla(trigonometricas(Num1, "cos").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }

                if (Operacion == 6)
                {
                    if (Is1)
                    {
                        actualizar_pantalla(trigonometricas(Num1, "tan").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }

                if (Operacion == 7)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "x^n").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }

                if (Operacion == 8)
                {
                    if (Is1)
                    {
                        actualizar_pantalla(trigonometricas(Num1, "log").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
                if (Operacion == 9)
                {
                    if (Is1)
                    {
                        actualizar_pantalla(trigonometricas(Num1, "ln").ToString());
                        Is1 = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }

            }
            catch 
            {
                MessageBox.Show("Esta operacion requiere dos operadores");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 4;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un valor");
            }
        }

        public void limpiar_pantalla()
        {
            Pantalla.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 5;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un valor");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 6;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un valor");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 7;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operadores");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 8;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un valor");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = obtener_valor();
                    Is1 = true;
                    Operacion = 9;
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere un valor");
            }
        }

        public double obtener_valor()
        {
            double valor = Convert.ToDouble(Pantalla.Text);
            limpiar_pantalla();
            return valor;
        }

        public void actualizar_pantalla(String texto)
        {
            Pantalla.Text = Pantalla.Text + texto;
        }

        public double operar(double operador1, double operador2, String signo)
        {
            double Resultado = 0.0;
            switch (signo)
            {
                case "+":
                    Resultado = operador1 + operador2;
                    break;

                case "-":
                    Resultado = operador1 - operador2;
                    break;

                case "x":
                    Resultado = operador1 *  operador2;
                    break;

                case "/":
                    try
                    {
                        Resultado = operador1 / operador2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case "x^n":
                    try
                    {
                        Resultado = Math.Pow(operador1, operador2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                default:
                    break;
            }

            return Resultado;
        }


        public double trigonometricas (double operador1, string funcion)
        {
            double Resultado = 0.0;
            switch (funcion)
            {
                case "sin":
                    Resultado = Math.Sin(operador1);
                    break;

                case "cos":
                    Resultado = Math.Cos(operador1);
                   
                    break;

                case "tan":
                    Resultado = Math.Tan(operador1);
                    break;

                case "log":
                    Resultado = Math.Log10(operador1);
                    break;

                case "ln":
                    Resultado = Math.Log(operador1);
                    break;

                default:
                    break;
            }
            return Resultado;
        }




    }
}

