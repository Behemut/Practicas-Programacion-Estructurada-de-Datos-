using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_3
{
    public partial class Form1 : Form
    {
//Creacion de la cola para Empleados
        Stack<Empleados> Trabajadores = new Stack<Empleados>();



            public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            decimal sal;
            try
            {
                if (Decimal.Parse(txtSalario.Text) < 0)
                {
                    errorProvider1.SetError(txtSalario, "Valores negativos no se admiten");
                }
                else
                {
                    if (this.ValidateChildren(ValidationConstraints.Enabled))
                    {

                        Empleados empleado = new Empleados();
                        empleado.Carnet = txtCarnet.Text;
                        empleado.Nombre = txtNombre.Text;
                        //empleado.Salario = Decimal.Parse(txtSalario.Text);
                        empleado.Salario = Decimal.Parse(txtSalario.Text);

                        empleado.Fecha = dtpFecha.Value;
                        Trabajadores.Push(empleado);
                        dgvCola.DataSource = null;
                        dgvCola.DataSource = Trabajadores.ToArray();
                        Limpiar();
                        txtCarnet.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Faltan campos por rellenar", "Formulario de Cola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException ex)
            {
          
                    errorProvider1.SetError(txtSalario, "Caracteres en campo salario");
              
                MessageBox.Show(ex.Message, "Formulario de Cola", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

                
     
        public void Limpiar() { txtCarnet.Clear(); txtNombre.Clear(); txtSalario.Clear(); }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Trabajadores.Count!=0)
            {
                Empleados empleado = new Empleados();
                empleado = Trabajadores.Pop();

                txtCarnet.Text = empleado.Carnet;
                txtNombre.Text = empleado.Nombre;
                txtSalario.Text = empleado.Salario.ToString();
                dtpFecha.Value = empleado.Fecha;

                dgvCola.DataSource = Trabajadores.ToList();
                MessageBox.Show("Se elimino el registro en cola", "Aviso");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No hay empleados en cola","Aviso");
                Limpiar();
            }
            txtCarnet.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCarnet_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCarnet, "");
        }

        private void txtCarnet_Validating(object sender, CancelEventArgs e)
        {
            if (txtCarnet.Text == "")
            {
                e.Cancel = true;
                txtCarnet.Select(0, txtCarnet.Text.Length);
                errorProvider1.SetError(txtCarnet, "Campo de carnet vacio");
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombre, "");
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                e.Cancel = true;
                txtNombre.Select(0, txtNombre.Text.Length);
                errorProvider1.SetError(txtNombre, "Campo de Nombre vacio");
            }
        }

        private void txtSalario_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSalario, "");
        }

        private void txtSalario_Validating(object sender, CancelEventArgs e)
        {
            if (txtSalario.Text == "")
            {
                e.Cancel = true;
                txtSalario.Select(0, txtSalario.Text.Length);
                errorProvider1.SetError(txtSalario, "Campo de Salario vacio");
            }
        }
    }
}
