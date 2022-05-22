namespace Libreria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLibreria = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnSalirPrincipal = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLibreria);
            this.groupBox1.Controls.Add(this.btnLibros);
            this.groupBox1.Controls.Add(this.btnAutores);
            this.groupBox1.Location = new System.Drawing.Point(230, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de las tablas";
            // 
            // btnLibreria
            // 
            this.btnLibreria.Location = new System.Drawing.Point(159, 180);
            this.btnLibreria.Name = "btnLibreria";
            this.btnLibreria.Size = new System.Drawing.Size(75, 23);
            this.btnLibreria.TabIndex = 2;
            this.btnLibreria.Text = "Libreria";
            this.btnLibreria.UseVisualStyleBackColor = true;
            this.btnLibreria.Click += new System.EventHandler(this.btnLibreria_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Location = new System.Drawing.Point(159, 128);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(75, 23);
            this.btnLibros.TabIndex = 1;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Location = new System.Drawing.Point(159, 71);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(75, 23);
            this.btnAutores.TabIndex = 0;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnSalirPrincipal
            // 
            this.btnSalirPrincipal.Location = new System.Drawing.Point(389, 355);
            this.btnSalirPrincipal.Name = "btnSalirPrincipal";
            this.btnSalirPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnSalirPrincipal.TabIndex = 1;
            this.btnSalirPrincipal.Text = "Salir";
            this.btnSalirPrincipal.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLibreria;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnSalirPrincipal;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

