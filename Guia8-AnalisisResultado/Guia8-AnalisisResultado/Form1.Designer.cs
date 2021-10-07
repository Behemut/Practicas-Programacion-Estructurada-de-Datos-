namespace Guia8_AnalisisResultado
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabañadir = new System.Windows.Forms.TabPage();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.txtDefinicion = new System.Windows.Forms.TextBox();
            this.richtxtAgregar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richtxtBuscar = new System.Windows.Forms.RichTextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.btbEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTxtEliminar = new System.Windows.Forms.RichTextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.tabExistentes = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.richtxtExistentes = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabañadir.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.tabExistentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabañadir);
            this.tabControl.Controls.Add(this.tabBuscar);
            this.tabControl.Controls.Add(this.tabEliminar);
            this.tabControl.Controls.Add(this.tabExistentes);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 469);
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabañadir
            // 
            this.tabañadir.Controls.Add(this.btnAgregar);
            this.tabañadir.Controls.Add(this.label2);
            this.tabañadir.Controls.Add(this.label1);
            this.tabañadir.Controls.Add(this.richtxtAgregar);
            this.tabañadir.Controls.Add(this.txtDefinicion);
            this.tabañadir.Location = new System.Drawing.Point(4, 37);
            this.tabañadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabañadir.Name = "tabañadir";
            this.tabañadir.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabañadir.Size = new System.Drawing.Size(767, 428);
            this.tabañadir.TabIndex = 0;
            this.tabañadir.Text = "Añadir definición";
            this.tabañadir.UseVisualStyleBackColor = true;
            this.tabañadir.Click += new System.EventHandler(this.tabañadir_Click);
            // 
            // tabBuscar
            // 
            this.tabBuscar.Controls.Add(this.btnBuscar);
            this.tabBuscar.Controls.Add(this.label3);
            this.tabBuscar.Controls.Add(this.label4);
            this.tabBuscar.Controls.Add(this.richtxtBuscar);
            this.tabBuscar.Controls.Add(this.txtBuscar);
            this.tabBuscar.Location = new System.Drawing.Point(4, 37);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBuscar.Size = new System.Drawing.Size(767, 428);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar definición";
            this.tabBuscar.UseVisualStyleBackColor = true;
            this.tabBuscar.Click += new System.EventHandler(this.tabBuscar_Click);
            // 
            // txtDefinicion
            // 
            this.txtDefinicion.Location = new System.Drawing.Point(223, 54);
            this.txtDefinicion.Name = "txtDefinicion";
            this.txtDefinicion.Size = new System.Drawing.Size(304, 34);
            this.txtDefinicion.TabIndex = 0;
            // 
            // richtxtAgregar
            // 
            this.richtxtAgregar.Location = new System.Drawing.Point(223, 142);
            this.richtxtAgregar.Name = "richtxtAgregar";
            this.richtxtAgregar.Size = new System.Drawing.Size(304, 203);
            this.richtxtAgregar.TabIndex = 1;
            this.richtxtAgregar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Definición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Concepto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(569, 300);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 45);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(545, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 49);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Concepto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Definición";
            // 
            // richtxtBuscar
            // 
            this.richtxtBuscar.Location = new System.Drawing.Point(203, 157);
            this.richtxtBuscar.Name = "richtxtBuscar";
            this.richtxtBuscar.Size = new System.Drawing.Size(304, 203);
            this.richtxtBuscar.TabIndex = 6;
            this.richtxtBuscar.Text = "";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(203, 69);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(304, 34);
            this.txtBuscar.TabIndex = 5;
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.btbEliminar);
            this.tabEliminar.Controls.Add(this.label5);
            this.tabEliminar.Controls.Add(this.label6);
            this.tabEliminar.Controls.Add(this.richTxtEliminar);
            this.tabEliminar.Controls.Add(this.txtEliminar);
            this.tabEliminar.Location = new System.Drawing.Point(4, 37);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(767, 428);
            this.tabEliminar.TabIndex = 2;
            this.tabEliminar.Text = "Eliminar definición";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // btbEliminar
            // 
            this.btbEliminar.Location = new System.Drawing.Point(576, 64);
            this.btbEliminar.Name = "btbEliminar";
            this.btbEliminar.Size = new System.Drawing.Size(107, 49);
            this.btbEliminar.TabIndex = 14;
            this.btbEliminar.Text = "Eliminar";
            this.btbEliminar.UseVisualStyleBackColor = true;
            this.btbEliminar.Click += new System.EventHandler(this.btbEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Concepto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Definición";
            // 
            // richTxtEliminar
            // 
            this.richTxtEliminar.Location = new System.Drawing.Point(234, 162);
            this.richTxtEliminar.Name = "richTxtEliminar";
            this.richTxtEliminar.Size = new System.Drawing.Size(304, 203);
            this.richTxtEliminar.TabIndex = 11;
            this.richTxtEliminar.Text = "";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(234, 74);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(304, 34);
            this.txtEliminar.TabIndex = 10;
            // 
            // tabExistentes
            // 
            this.tabExistentes.Controls.Add(this.richtxtExistentes);
            this.tabExistentes.Controls.Add(this.flowLayoutPanel1);
            this.tabExistentes.Location = new System.Drawing.Point(4, 37);
            this.tabExistentes.Name = "tabExistentes";
            this.tabExistentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabExistentes.Size = new System.Drawing.Size(767, 428);
            this.tabExistentes.TabIndex = 3;
            this.tabExistentes.Text = "Conceptos existentes";
            this.tabExistentes.UseVisualStyleBackColor = true;
            this.tabExistentes.Click += new System.EventHandler(this.tabExistentes_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(242, 369);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // richtxtExistentes
            // 
            this.richtxtExistentes.Location = new System.Drawing.Point(406, 22);
            this.richtxtExistentes.Name = "richtxtExistentes";
            this.richtxtExistentes.Size = new System.Drawing.Size(304, 203);
            this.richtxtExistentes.TabIndex = 12;
            this.richtxtExistentes.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 469);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabañadir.ResumeLayout(false);
            this.tabañadir.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            this.tabEliminar.ResumeLayout(false);
            this.tabEliminar.PerformLayout();
            this.tabExistentes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabañadir;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.RichTextBox richtxtAgregar;
        private System.Windows.Forms.TextBox txtDefinicion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richtxtBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.Button btbEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTxtEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TabPage tabExistentes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox richtxtExistentes;
    }
}

