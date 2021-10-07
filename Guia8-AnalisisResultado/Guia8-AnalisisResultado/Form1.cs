using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Guia8_AnalisisResultado
{
    public partial class Form1 : Form
    {
        Hashtable conceptos = new Hashtable();

        public Form1()
        {
            InitializeComponent();

        }

        private void tabañadir_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conceptos.Add(txtDefinicion.Text, richtxtAgregar.Text );

            LimpiarPantalla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conceptos.Contains(txtBuscar.Text))
            {

                richtxtBuscar.Text = conceptos[txtBuscar.Text].ToString();  
            }
            else
            {
                MessageBox.Show("Concepto no encontrado", "Buscar definición", MessageBoxButtons.OK);
                LimpiarPantalla();
            }
        }


        void LimpiarPantalla()
        {
            txtDefinicion.Clear();
            richtxtAgregar.Clear();

            txtEliminar.Clear();
            richTxtEliminar.Clear();
        }

        private void btbEliminar_Click(object sender, EventArgs e)
        {
            if (conceptos.Contains(txtEliminar.Text))
            {

                richTxtEliminar.Text = conceptos[txtEliminar.Text].ToString();

                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar el concepto?", "Eliminar definición", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conceptos.Remove(txtEliminar.Text);
                    LimpiarPantalla();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else { 
            MessageBox.Show("Concepto no encontrado", "Eliminar definición", MessageBoxButtons.OK);
                LimpiarPantalla();
                  }

        }

        private void tabExistentes_Click(object sender, EventArgs e)
        {
            CrearLabels();
        }


        private void CrearLabels()
        {
            ICollection keyCol1 = conceptos.Keys;
            flowLayoutPanel1.Controls.Clear();
         
            foreach (string item in keyCol1)
            {
                
                Label l = new Label();
                l.Name = "lbl" + item;
                l.Text = item;
                l.AutoSize = true;
                l.Click += new EventHandler(l_Click);
                flowLayoutPanel1.Controls.Add(l);
                
            }    
        }

        void l_Click( object sender, EventArgs e)
        {
            Label l = sender as Label;
            richtxtExistentes.Text = conceptos[l.Text].ToString();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            CrearLabels();
        }

        private void tabBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
