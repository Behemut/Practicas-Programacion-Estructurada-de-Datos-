namespace Ejercicio_2_BANCO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMontoCliente = new System.Windows.Forms.TextBox();
            this.dgvCajero1 = new System.Windows.Forms.DataGridView();
            this.bntAgregarCaj1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCajero2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCajero3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCajero4 = new System.Windows.Forms.DataGridView();
            this.dtpFechaCliente = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtClientesCaj1 = new System.Windows.Forms.TextBox();
            this.txtClientesCaj2 = new System.Windows.Forms.TextBox();
            this.txtClientesCaj3 = new System.Windows.Forms.TextBox();
            this.txtClientesCaj4 = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(1180, 44);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 22);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCajero1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cajero 1";
            // 
            // txtMontoCliente
            // 
            this.txtMontoCliente.Location = new System.Drawing.Point(1180, 96);
            this.txtMontoCliente.Name = "txtMontoCliente";
            this.txtMontoCliente.Size = new System.Drawing.Size(100, 22);
            this.txtMontoCliente.TabIndex = 1;
            // 
            // dgvCajero1
            // 
            this.dgvCajero1.AllowUserToAddRows = false;
            this.dgvCajero1.AllowUserToDeleteRows = false;
            this.dgvCajero1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajero1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCajero1.Location = new System.Drawing.Point(3, 18);
            this.dgvCajero1.Name = "dgvCajero1";
            this.dgvCajero1.ReadOnly = true;
            this.dgvCajero1.RowTemplate.Height = 24;
            this.dgvCajero1.Size = new System.Drawing.Size(356, 297);
            this.dgvCajero1.TabIndex = 2;
            // 
            // bntAgregarCaj1
            // 
            this.bntAgregarCaj1.Location = new System.Drawing.Point(1032, 212);
            this.bntAgregarCaj1.Name = "bntAgregarCaj1";
            this.bntAgregarCaj1.Size = new System.Drawing.Size(98, 47);
            this.bntAgregarCaj1.TabIndex = 3;
            this.bntAgregarCaj1.Text = "Agregar a cola";
            this.bntAgregarCaj1.UseVisualStyleBackColor = true;
            this.bntAgregarCaj1.Click += new System.EventHandler(this.bntAgregarCaj1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1216, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Despachar de cola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCajero2);
            this.groupBox2.Location = new System.Drawing.Point(400, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 318);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cajero 2";
            // 
            // dgvCajero2
            // 
            this.dgvCajero2.AllowUserToAddRows = false;
            this.dgvCajero2.AllowUserToDeleteRows = false;
            this.dgvCajero2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajero2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCajero2.Location = new System.Drawing.Point(3, 18);
            this.dgvCajero2.Name = "dgvCajero2";
            this.dgvCajero2.ReadOnly = true;
            this.dgvCajero2.RowTemplate.Height = 24;
            this.dgvCajero2.Size = new System.Drawing.Size(356, 297);
            this.dgvCajero2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cajero 1",
            "Cajero 2",
            "Cajero 3",
            "Cajero 4"});
            this.comboBox1.Location = new System.Drawing.Point(834, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCajero3);
            this.groupBox3.Location = new System.Drawing.Point(12, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 318);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cajero 3";
            // 
            // dgvCajero3
            // 
            this.dgvCajero3.AllowUserToAddRows = false;
            this.dgvCajero3.AllowUserToDeleteRows = false;
            this.dgvCajero3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajero3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCajero3.Location = new System.Drawing.Point(3, 18);
            this.dgvCajero3.Name = "dgvCajero3";
            this.dgvCajero3.ReadOnly = true;
            this.dgvCajero3.RowTemplate.Height = 24;
            this.dgvCajero3.Size = new System.Drawing.Size(356, 297);
            this.dgvCajero3.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCajero4);
            this.groupBox4.Location = new System.Drawing.Point(400, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 318);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cajero 4";
            // 
            // dgvCajero4
            // 
            this.dgvCajero4.AllowUserToAddRows = false;
            this.dgvCajero4.AllowUserToDeleteRows = false;
            this.dgvCajero4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajero4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCajero4.Location = new System.Drawing.Point(3, 18);
            this.dgvCajero4.Name = "dgvCajero4";
            this.dgvCajero4.ReadOnly = true;
            this.dgvCajero4.RowTemplate.Height = 24;
            this.dgvCajero4.Size = new System.Drawing.Size(356, 297);
            this.dgvCajero4.TabIndex = 2;
            // 
            // dtpFechaCliente
            // 
            this.dtpFechaCliente.Location = new System.Drawing.Point(1111, 159);
            this.dtpFechaCliente.Name = "dtpFechaCliente";
            this.dtpFechaCliente.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaCliente.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1216, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ordenar cajeros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(907, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(907, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clientes cajero 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(907, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Clientes cajero 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(907, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Clientes cajero 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(907, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clientes cajero 4";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1092, 431);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 13;
            // 
            // txtClientesCaj1
            // 
            this.txtClientesCaj1.Enabled = false;
            this.txtClientesCaj1.Location = new System.Drawing.Point(1092, 472);
            this.txtClientesCaj1.Name = "txtClientesCaj1";
            this.txtClientesCaj1.Size = new System.Drawing.Size(100, 22);
            this.txtClientesCaj1.TabIndex = 14;
            // 
            // txtClientesCaj2
            // 
            this.txtClientesCaj2.Enabled = false;
            this.txtClientesCaj2.Location = new System.Drawing.Point(1092, 512);
            this.txtClientesCaj2.Name = "txtClientesCaj2";
            this.txtClientesCaj2.Size = new System.Drawing.Size(100, 22);
            this.txtClientesCaj2.TabIndex = 15;
            // 
            // txtClientesCaj3
            // 
            this.txtClientesCaj3.Enabled = false;
            this.txtClientesCaj3.Location = new System.Drawing.Point(1092, 557);
            this.txtClientesCaj3.Name = "txtClientesCaj3";
            this.txtClientesCaj3.Size = new System.Drawing.Size(100, 22);
            this.txtClientesCaj3.TabIndex = 16;
            // 
            // txtClientesCaj4
            // 
            this.txtClientesCaj4.Enabled = false;
            this.txtClientesCaj4.Location = new System.Drawing.Point(1092, 598);
            this.txtClientesCaj4.Name = "txtClientesCaj4";
            this.txtClientesCaj4.Size = new System.Drawing.Size(100, 22);
            this.txtClientesCaj4.TabIndex = 17;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Enabled = false;
            this.txtMensaje.Location = new System.Drawing.Point(935, 643);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(399, 108);
            this.txtMensaje.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(813, 661);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cajero mas vacio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1038, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nombre cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1038, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Monto de cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(824, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cajeros disponibles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 763);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClientesCaj4);
            this.Controls.Add(this.txtClientesCaj3);
            this.Controls.Add(this.txtClientesCaj2);
            this.Controls.Add(this.txtClientesCaj1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpFechaCliente);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntAgregarCaj1);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtMontoCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntAgregarCaj1;
        private System.Windows.Forms.DataGridView dgvCajero1;
        private System.Windows.Forms.TextBox txtMontoCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCajero2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCajero3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCajero4;
        private System.Windows.Forms.DateTimePicker dtpFechaCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtClientesCaj1;
        private System.Windows.Forms.TextBox txtClientesCaj2;
        private System.Windows.Forms.TextBox txtClientesCaj3;
        private System.Windows.Forms.TextBox txtClientesCaj4;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

