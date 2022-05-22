namespace Libreria
{
    partial class Libros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNILibros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreLibros = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido1Libros = new System.Windows.Forms.TextBox();
            this.txtApellido2Libros = new System.Windows.Forms.TextBox();
            this.btnAgregarLibros = new System.Windows.Forms.Button();
            this.btnBuscarLibros = new System.Windows.Forms.Button();
            this.btnModificarLibros = new System.Windows.Forms.Button();
            this.btnEliminarLibros = new System.Windows.Forms.Button();
            this.btnLimpiarLibros = new System.Windows.Forms.Button();
            this.btnSalirLibros = new System.Windows.Forms.Button();
            this.dataGridLibros = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalirLibros);
            this.groupBox1.Controls.Add(this.btnLimpiarLibros);
            this.groupBox1.Controls.Add(this.btnEliminarLibros);
            this.groupBox1.Controls.Add(this.btnModificarLibros);
            this.groupBox1.Controls.Add(this.btnBuscarLibros);
            this.groupBox1.Controls.Add(this.btnAgregarLibros);
            this.groupBox1.Controls.Add(this.txtApellido2Libros);
            this.groupBox1.Controls.Add(this.txtApellido1Libros);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreLibros);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDNILibros);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEditorial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtIsbn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(56, 17);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(122, 20);
            this.txtIsbn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(56, 109);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(164, 20);
            this.txtEditorial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DNI";
            // 
            // txtDNILibros
            // 
            this.txtDNILibros.Location = new System.Drawing.Point(392, 17);
            this.txtDNILibros.Name = "txtDNILibros";
            this.txtDNILibros.Size = new System.Drawing.Size(100, 20);
            this.txtDNILibros.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // txtNombreLibros
            // 
            this.txtNombreLibros.Location = new System.Drawing.Point(409, 51);
            this.txtNombreLibros.Name = "txtNombreLibros";
            this.txtNombreLibros.Size = new System.Drawing.Size(117, 20);
            this.txtNombreLibros.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Primer Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Segundo Apellido";
            // 
            // txtApellido1Libros
            // 
            this.txtApellido1Libros.Location = new System.Drawing.Point(445, 83);
            this.txtApellido1Libros.Name = "txtApellido1Libros";
            this.txtApellido1Libros.Size = new System.Drawing.Size(109, 20);
            this.txtApellido1Libros.TabIndex = 12;
            // 
            // txtApellido2Libros
            // 
            this.txtApellido2Libros.Location = new System.Drawing.Point(459, 109);
            this.txtApellido2Libros.Name = "txtApellido2Libros";
            this.txtApellido2Libros.Size = new System.Drawing.Size(108, 20);
            this.txtApellido2Libros.TabIndex = 13;
            // 
            // btnAgregarLibros
            // 
            this.btnAgregarLibros.Location = new System.Drawing.Point(648, 20);
            this.btnAgregarLibros.Name = "btnAgregarLibros";
            this.btnAgregarLibros.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarLibros.TabIndex = 14;
            this.btnAgregarLibros.Text = "Agregar";
            this.btnAgregarLibros.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLibros
            // 
            this.btnBuscarLibros.Location = new System.Drawing.Point(648, 54);
            this.btnBuscarLibros.Name = "btnBuscarLibros";
            this.btnBuscarLibros.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLibros.TabIndex = 15;
            this.btnBuscarLibros.Text = "Buscar";
            this.btnBuscarLibros.UseVisualStyleBackColor = true;
            // 
            // btnModificarLibros
            // 
            this.btnModificarLibros.Location = new System.Drawing.Point(648, 83);
            this.btnModificarLibros.Name = "btnModificarLibros";
            this.btnModificarLibros.Size = new System.Drawing.Size(75, 23);
            this.btnModificarLibros.TabIndex = 16;
            this.btnModificarLibros.Text = "Modificar";
            this.btnModificarLibros.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLibros
            // 
            this.btnEliminarLibros.Location = new System.Drawing.Point(648, 113);
            this.btnEliminarLibros.Name = "btnEliminarLibros";
            this.btnEliminarLibros.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLibros.TabIndex = 17;
            this.btnEliminarLibros.Text = "Eliminar";
            this.btnEliminarLibros.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarLibros
            // 
            this.btnLimpiarLibros.Location = new System.Drawing.Point(648, 143);
            this.btnLimpiarLibros.Name = "btnLimpiarLibros";
            this.btnLimpiarLibros.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarLibros.TabIndex = 18;
            this.btnLimpiarLibros.Text = "Limpiar";
            this.btnLimpiarLibros.UseVisualStyleBackColor = true;
            // 
            // btnSalirLibros
            // 
            this.btnSalirLibros.Location = new System.Drawing.Point(648, 173);
            this.btnSalirLibros.Name = "btnSalirLibros";
            this.btnSalirLibros.Size = new System.Drawing.Size(75, 23);
            this.btnSalirLibros.TabIndex = 19;
            this.btnSalirLibros.Text = "Salir";
            this.btnSalirLibros.UseVisualStyleBackColor = true;
            // 
            // dataGridLibros
            // 
            this.dataGridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLibros.Location = new System.Drawing.Point(28, 249);
            this.dataGridLibros.Name = "dataGridLibros";
            this.dataGridLibros.Size = new System.Drawing.Size(749, 185);
            this.dataGridLibros.TabIndex = 1;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridLibros);
            this.Controls.Add(this.groupBox1);
            this.Name = "Libros";
            this.Text = "Libros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirLibros;
        private System.Windows.Forms.Button btnLimpiarLibros;
        private System.Windows.Forms.Button btnEliminarLibros;
        private System.Windows.Forms.Button btnModificarLibros;
        private System.Windows.Forms.Button btnBuscarLibros;
        private System.Windows.Forms.Button btnAgregarLibros;
        private System.Windows.Forms.TextBox txtApellido2Libros;
        private System.Windows.Forms.TextBox txtApellido1Libros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreLibros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNILibros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridLibros;
    }
}