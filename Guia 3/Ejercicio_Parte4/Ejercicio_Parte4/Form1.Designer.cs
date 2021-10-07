namespace Ejercicio_Parte4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mskInsertarFrente = new System.Windows.Forms.MaskedTextBox();
            this.mskInsertarFinal = new System.Windows.Forms.MaskedTextBox();
            this.btnIngresarFrente = new System.Windows.Forms.Button();
            this.btnIngresarFinal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.mskPosicion = new System.Windows.Forms.MaskedTextBox();
            this.btnIngresarPosicion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarFrente = new System.Windows.Forms.Button();
            this.btnEliminarFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(24, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 356);
            this.listBox1.TabIndex = 0;
            // 
            // mskInsertarFrente
            // 
            this.mskInsertarFrente.Location = new System.Drawing.Point(189, 48);
            this.mskInsertarFrente.Mask = "00000";
            this.mskInsertarFrente.Name = "mskInsertarFrente";
            this.mskInsertarFrente.Size = new System.Drawing.Size(100, 22);
            this.mskInsertarFrente.TabIndex = 2;
            this.mskInsertarFrente.Enter += new System.EventHandler(this.maskedTextBox1_Enter);
            // 
            // mskInsertarFinal
            // 
            this.mskInsertarFinal.Location = new System.Drawing.Point(189, 156);
            this.mskInsertarFinal.Mask = "00000";
            this.mskInsertarFinal.Name = "mskInsertarFinal";
            this.mskInsertarFinal.Size = new System.Drawing.Size(100, 22);
            this.mskInsertarFinal.TabIndex = 3;
            this.mskInsertarFinal.Enter += new System.EventHandler(this.mskInsertarFinal_Enter);
            // 
            // btnIngresarFrente
            // 
            this.btnIngresarFrente.Location = new System.Drawing.Point(353, 28);
            this.btnIngresarFrente.Name = "btnIngresarFrente";
            this.btnIngresarFrente.Size = new System.Drawing.Size(119, 62);
            this.btnIngresarFrente.TabIndex = 5;
            this.btnIngresarFrente.Text = "Ingresar valor de frente";
            this.btnIngresarFrente.UseVisualStyleBackColor = true;
            this.btnIngresarFrente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngresarFinal
            // 
            this.btnIngresarFinal.Location = new System.Drawing.Point(353, 147);
            this.btnIngresarFinal.Name = "btnIngresarFinal";
            this.btnIngresarFinal.Size = new System.Drawing.Size(119, 62);
            this.btnIngresarFinal.TabIndex = 7;
            this.btnIngresarFinal.Text = "Ingresar valor al final";
            this.btnIngresarFinal.UseVisualStyleBackColor = true;
            this.btnIngresarFinal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpiar Listbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(189, 274);
            this.mskValor.Mask = "00000";
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(100, 22);
            this.mskValor.TabIndex = 9;
            // 
            // mskPosicion
            // 
            this.mskPosicion.Location = new System.Drawing.Point(337, 274);
            this.mskPosicion.Mask = "00000";
            this.mskPosicion.Name = "mskPosicion";
            this.mskPosicion.Size = new System.Drawing.Size(100, 22);
            this.mskPosicion.TabIndex = 10;
            // 
            // btnIngresarPosicion
            // 
            this.btnIngresarPosicion.Location = new System.Drawing.Point(486, 254);
            this.btnIngresarPosicion.Name = "btnIngresarPosicion";
            this.btnIngresarPosicion.Size = new System.Drawing.Size(119, 62);
            this.btnIngresarPosicion.TabIndex = 11;
            this.btnIngresarPosicion.Text = "Ingresar valor por posicion";
            this.btnIngresarPosicion.UseVisualStyleBackColor = true;
            this.btnIngresarPosicion.Click += new System.EventHandler(this.btnIngresarPosicion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Posicion";
            // 
            // btnEliminarFrente
            // 
            this.btnEliminarFrente.Location = new System.Drawing.Point(486, 28);
            this.btnEliminarFrente.Name = "btnEliminarFrente";
            this.btnEliminarFrente.Size = new System.Drawing.Size(119, 62);
            this.btnEliminarFrente.TabIndex = 19;
            this.btnEliminarFrente.Text = "Eliminar valor de frente";
            this.btnEliminarFrente.UseVisualStyleBackColor = true;
            this.btnEliminarFrente.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnEliminarFinal
            // 
            this.btnEliminarFinal.Location = new System.Drawing.Point(486, 147);
            this.btnEliminarFinal.Name = "btnEliminarFinal";
            this.btnEliminarFinal.Size = new System.Drawing.Size(119, 62);
            this.btnEliminarFinal.TabIndex = 20;
            this.btnEliminarFinal.Text = "Eliminar valor al final";
            this.btnEliminarFinal.UseVisualStyleBackColor = true;
            this.btnEliminarFinal.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.btnEliminarFinal);
            this.Controls.Add(this.btnEliminarFrente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresarPosicion);
            this.Controls.Add(this.mskPosicion);
            this.Controls.Add(this.mskValor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIngresarFinal);
            this.Controls.Add(this.btnIngresarFrente);
            this.Controls.Add(this.mskInsertarFinal);
            this.Controls.Add(this.mskInsertarFrente);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox mskInsertarFrente;
        private System.Windows.Forms.MaskedTextBox mskInsertarFinal;
        private System.Windows.Forms.Button btnIngresarFrente;
        private System.Windows.Forms.Button btnIngresarFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.MaskedTextBox mskPosicion;
        private System.Windows.Forms.Button btnIngresarPosicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarFrente;
        private System.Windows.Forms.Button btnEliminarFinal;
    }
}

