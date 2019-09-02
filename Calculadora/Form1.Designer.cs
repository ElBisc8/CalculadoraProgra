namespace Calculadora
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
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPor = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnEntre = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Location = new System.Drawing.Point(12, 57);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.Size = new System.Drawing.Size(214, 20);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(12, 122);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(46, 28);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 156);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 28);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 224);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 28);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 190);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 28);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 258);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(98, 28);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPor
            // 
            this.btnPor.Location = new System.Drawing.Point(64, 122);
            this.btnPor.Name = "btnPor";
            this.btnPor.Size = new System.Drawing.Size(46, 28);
            this.btnPor.TabIndex = 1;
            this.btnPor.Text = "*";
            this.btnPor.UseVisualStyleBackColor = true;
            this.btnPor.Click += new System.EventHandler(this.btnPor_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(64, 156);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 28);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(64, 224);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 28);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(64, 190);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 28);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnEntre
            // 
            this.btnEntre.Location = new System.Drawing.Point(116, 122);
            this.btnEntre.Name = "btnEntre";
            this.btnEntre.Size = new System.Drawing.Size(46, 28);
            this.btnEntre.TabIndex = 1;
            this.btnEntre.Text = "/";
            this.btnEntre.UseVisualStyleBackColor = true;
            this.btnEntre.Click += new System.EventHandler(this.btnEntre_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(116, 156);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 28);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(116, 224);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 28);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(116, 258);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(46, 28);
            this.btnPunto.TabIndex = 1;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(116, 190);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 28);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Location = new System.Drawing.Point(168, 122);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(46, 28);
            this.btnPorcentaje.TabIndex = 1;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(168, 156);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(46, 28);
            this.btnMas.TabIndex = 1;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(168, 224);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(46, 62);
            this.btnIgual.TabIndex = 1;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(168, 190);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(46, 28);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(168, 88);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(58, 28);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CALCULADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnEntre);
            this.Controls.Add(this.btnPor);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPor;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnEntre;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label label1;
    }
}

