using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Parentesis
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        public void Palindromo(string Expresion)
        {
            string  rev;
            char[] ch = Expresion.ToCharArray();

            Array.Reverse(ch);
            rev = new string(ch);

            bool b = Expresion.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                MessageBox.Show("" + Expresion + " es palindromo");
            }
            else
            {
               MessageBox.Show(" " + Expresion + " No es palindromo");
            }
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (BalancedParentheses.Check(textBox1.Text))
                MessageBox.Show("Su expresion " + textBox1.Text + "  esta bien formada");
            else
                MessageBox.Show("Su expresion " + textBox1.Text + "  esta desbalanceada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Palindromo(textBox2.Text);
        }
    }
}

