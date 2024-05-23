
namespace figurageometrica
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
            this.CALCULAR = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.EXPORTAR = new System.Windows.Forms.Button();
            this.DIBUJAR = new System.Windows.Forms.Button();
            this.INFORMACION = new System.Windows.Forms.Button();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.CAJA_TEXTO = new System.Windows.Forms.TextBox();
            this.INGRESA = new System.Windows.Forms.Label();
            this.Esfera = new System.Windows.Forms.RadioButton();
            this.Prisma = new System.Windows.Forms.RadioButton();
            this.Cubo = new System.Windows.Forms.RadioButton();
            this.Circulo = new System.Windows.Forms.RadioButton();
            this.Poligonoirregular = new System.Windows.Forms.RadioButton();
            this.Poligonoregular = new System.Windows.Forms.RadioButton();
            this.Rectangulo = new System.Windows.Forms.RadioButton();
            this.Triangulo = new System.Windows.Forms.RadioButton();
            this.Cuadrado = new System.Windows.Forms.RadioButton();
            this.CONSTRUCTOR = new System.Windows.Forms.Label();
            this.INF = new System.Windows.Forms.RichTextBox();
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Controls.Add(this.CALCULAR);
            this.groupBox1.Controls.Add(this.LIMPIAR);
            this.groupBox1.Controls.Add(this.EXPORTAR);
            this.groupBox1.Controls.Add(this.DIBUJAR);
            this.groupBox1.Controls.Add(this.INFORMACION);
            this.groupBox1.Controls.Add(this.GUARDAR);
            this.groupBox1.Controls.Add(this.CAJA_TEXTO);
            this.groupBox1.Controls.Add(this.INGRESA);
            this.groupBox1.Controls.Add(this.Esfera);
            this.groupBox1.Controls.Add(this.Prisma);
            this.groupBox1.Controls.Add(this.Cubo);
            this.groupBox1.Controls.Add(this.Circulo);
            this.groupBox1.Controls.Add(this.Poligonoirregular);
            this.groupBox1.Controls.Add(this.Poligonoregular);
            this.groupBox1.Controls.Add(this.Rectangulo);
            this.groupBox1.Controls.Add(this.Triangulo);
            this.groupBox1.Controls.Add(this.Cuadrado);
            this.groupBox1.Controls.Add(this.CONSTRUCTOR);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(728, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CALCULAR
            // 
            this.CALCULAR.BackColor = System.Drawing.Color.SlateBlue;
            this.CALCULAR.Location = new System.Drawing.Point(543, 199);
            this.CALCULAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(111, 27);
            this.CALCULAR.TabIndex = 17;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = false;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.BackColor = System.Drawing.Color.Aquamarine;
            this.LIMPIAR.Location = new System.Drawing.Point(431, 212);
            this.LIMPIAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(87, 27);
            this.LIMPIAR.TabIndex = 16;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = false;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // EXPORTAR
            // 
            this.EXPORTAR.BackColor = System.Drawing.Color.BurlyWood;
            this.EXPORTAR.Location = new System.Drawing.Point(283, 209);
            this.EXPORTAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EXPORTAR.Name = "EXPORTAR";
            this.EXPORTAR.Size = new System.Drawing.Size(100, 27);
            this.EXPORTAR.TabIndex = 15;
            this.EXPORTAR.Text = "EXPORTAR";
            this.EXPORTAR.UseVisualStyleBackColor = false;
            // 
            // DIBUJAR
            // 
            this.DIBUJAR.BackColor = System.Drawing.Color.Chartreuse;
            this.DIBUJAR.Location = new System.Drawing.Point(160, 209);
            this.DIBUJAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DIBUJAR.Name = "DIBUJAR";
            this.DIBUJAR.Size = new System.Drawing.Size(87, 27);
            this.DIBUJAR.TabIndex = 14;
            this.DIBUJAR.Text = "DIBUJAR";
            this.DIBUJAR.UseVisualStyleBackColor = false;
            // 
            // INFORMACION
            // 
            this.INFORMACION.BackColor = System.Drawing.Color.Coral;
            this.INFORMACION.Location = new System.Drawing.Point(4, 209);
            this.INFORMACION.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.INFORMACION.Name = "INFORMACION";
            this.INFORMACION.Size = new System.Drawing.Size(128, 27);
            this.INFORMACION.TabIndex = 13;
            this.INFORMACION.Text = "INFORMACION";
            this.INFORMACION.UseVisualStyleBackColor = false;
            // 
            // GUARDAR
            // 
            this.GUARDAR.BackColor = System.Drawing.Color.Crimson;
            this.GUARDAR.Location = new System.Drawing.Point(564, 162);
            this.GUARDAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(111, 27);
            this.GUARDAR.TabIndex = 12;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = false;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // CAJA_TEXTO
            // 
            this.CAJA_TEXTO.Location = new System.Drawing.Point(437, 170);
            this.CAJA_TEXTO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CAJA_TEXTO.Name = "CAJA_TEXTO";
            this.CAJA_TEXTO.Size = new System.Drawing.Size(119, 22);
            this.CAJA_TEXTO.TabIndex = 11;
            // 
            // INGRESA
            // 
            this.INGRESA.AutoSize = true;
            this.INGRESA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGRESA.Location = new System.Drawing.Point(0, 169);
            this.INGRESA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.INGRESA.Name = "INGRESA";
            this.INGRESA.Size = new System.Drawing.Size(442, 20);
            this.INGRESA.TabIndex = 10;
            this.INGRESA.Text = "INGRESA MEDIDA DEL LADO,ARISTA,RADIO,ETC";
            // 
            // Esfera
            // 
            this.Esfera.AutoSize = true;
            this.Esfera.Location = new System.Drawing.Point(279, 133);
            this.Esfera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Esfera.Name = "Esfera";
            this.Esfera.Size = new System.Drawing.Size(82, 20);
            this.Esfera.TabIndex = 9;
            this.Esfera.TabStop = true;
            this.Esfera.Text = "ESFERA";
            this.Esfera.UseVisualStyleBackColor = true;
            this.Esfera.CheckedChanged += new System.EventHandler(this.ESPERA_CheckedChanged);
            // 
            // Prisma
            // 
            this.Prisma.AutoSize = true;
            this.Prisma.Location = new System.Drawing.Point(472, 105);
            this.Prisma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prisma.Name = "Prisma";
            this.Prisma.Size = new System.Drawing.Size(79, 20);
            this.Prisma.TabIndex = 8;
            this.Prisma.TabStop = true;
            this.Prisma.Text = "PRISMA";
            this.Prisma.UseVisualStyleBackColor = true;
            this.Prisma.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // Cubo
            // 
            this.Cubo.AutoSize = true;
            this.Cubo.Location = new System.Drawing.Point(359, 105);
            this.Cubo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cubo.Name = "Cubo";
            this.Cubo.Size = new System.Drawing.Size(66, 20);
            this.Cubo.TabIndex = 7;
            this.Cubo.TabStop = true;
            this.Cubo.Text = "CUBO";
            this.Cubo.UseVisualStyleBackColor = true;
            this.Cubo.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // Circulo
            // 
            this.Circulo.AutoSize = true;
            this.Circulo.Location = new System.Drawing.Point(217, 105);
            this.Circulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Circulo.Name = "Circulo";
            this.Circulo.Size = new System.Drawing.Size(86, 20);
            this.Circulo.TabIndex = 6;
            this.Circulo.TabStop = true;
            this.Circulo.Text = "CIRCULO";
            this.Circulo.UseVisualStyleBackColor = true;
            // 
            // Poligonoirregular
            // 
            this.Poligonoirregular.AutoSize = true;
            this.Poligonoirregular.Location = new System.Drawing.Point(4, 105);
            this.Poligonoirregular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Poligonoirregular.Name = "Poligonoirregular";
            this.Poligonoirregular.Size = new System.Drawing.Size(178, 20);
            this.Poligonoirregular.TabIndex = 5;
            this.Poligonoirregular.TabStop = true;
            this.Poligonoirregular.Text = "POLIGONO IRREGULAR";
            this.Poligonoirregular.UseVisualStyleBackColor = true;
            // 
            // Poligonoregular
            // 
            this.Poligonoregular.AutoSize = true;
            this.Poligonoregular.Location = new System.Drawing.Point(391, 64);
            this.Poligonoregular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Poligonoregular.Name = "Poligonoregular";
            this.Poligonoregular.Size = new System.Drawing.Size(165, 20);
            this.Poligonoregular.TabIndex = 4;
            this.Poligonoregular.TabStop = true;
            this.Poligonoregular.Text = "POLIGONO REGULAR";
            this.Poligonoregular.UseVisualStyleBackColor = true;
            this.Poligonoregular.CheckedChanged += new System.EventHandler(this.POLIGONOREGULAR_CheckedChanged);
            // 
            // Rectangulo
            // 
            this.Rectangulo.AutoSize = true;
            this.Rectangulo.Location = new System.Drawing.Point(251, 64);
            this.Rectangulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rectangulo.Name = "Rectangulo";
            this.Rectangulo.Size = new System.Drawing.Size(121, 20);
            this.Rectangulo.TabIndex = 3;
            this.Rectangulo.TabStop = true;
            this.Rectangulo.Text = "RECTANGULO";
            this.Rectangulo.UseVisualStyleBackColor = true;
            // 
            // Triangulo
            // 
            this.Triangulo.AutoSize = true;
            this.Triangulo.Location = new System.Drawing.Point(129, 64);
            this.Triangulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Triangulo.Name = "Triangulo";
            this.Triangulo.Size = new System.Drawing.Size(106, 20);
            this.Triangulo.TabIndex = 2;
            this.Triangulo.TabStop = true;
            this.Triangulo.Text = "TRIANGULO";
            this.Triangulo.UseVisualStyleBackColor = true;
            // 
            // Cuadrado
            // 
            this.Cuadrado.AutoSize = true;
            this.Cuadrado.Location = new System.Drawing.Point(8, 64);
            this.Cuadrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(105, 20);
            this.Cuadrado.TabIndex = 1;
            this.Cuadrado.TabStop = true;
            this.Cuadrado.Text = "CUADRADO";
            this.Cuadrado.UseVisualStyleBackColor = true;
            this.Cuadrado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CONSTRUCTOR
            // 
            this.CONSTRUCTOR.AutoSize = true;
            this.CONSTRUCTOR.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONSTRUCTOR.Location = new System.Drawing.Point(20, 27);
            this.CONSTRUCTOR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CONSTRUCTOR.Name = "CONSTRUCTOR";
            this.CONSTRUCTOR.Size = new System.Drawing.Size(452, 21);
            this.CONSTRUCTOR.TabIndex = 0;
            this.CONSTRUCTOR.Text = "CONSTRUCTOR DE FIGURAS GEOMETRICAS";
            // 
            // INF
            // 
            this.INF.Location = new System.Drawing.Point(403, 288);
            this.INF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.INF.Name = "INF";
            this.INF.Size = new System.Drawing.Size(239, 240);
            this.INF.TabIndex = 1;
            this.INF.Text = "";
            this.INF.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // IMAGEN
            // 
            this.IMAGEN.Location = new System.Drawing.Point(48, 288);
            this.IMAGEN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(312, 241);
            this.IMAGEN.TabIndex = 2;
            this.IMAGEN.TabStop = false;
            this.IMAGEN.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 554);
            this.Controls.Add(this.IMAGEN);
            this.Controls.Add(this.INF);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Esfera;
        private System.Windows.Forms.RadioButton Prisma;
        private System.Windows.Forms.RadioButton Cubo;
        private System.Windows.Forms.RadioButton Circulo;
        private System.Windows.Forms.RadioButton Poligonoirregular;
        private System.Windows.Forms.RadioButton Poligonoregular;
        private System.Windows.Forms.RadioButton Rectangulo;
        private System.Windows.Forms.RadioButton Triangulo;
        private System.Windows.Forms.RadioButton Cuadrado;
        private System.Windows.Forms.Label CONSTRUCTOR;
        private System.Windows.Forms.Label INGRESA;
        private System.Windows.Forms.RichTextBox INF;
        private System.Windows.Forms.PictureBox IMAGEN;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button EXPORTAR;
        private System.Windows.Forms.Button DIBUJAR;
        private System.Windows.Forms.Button INFORMACION;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.TextBox CAJA_TEXTO;
    }
}

