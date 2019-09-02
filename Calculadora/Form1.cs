using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero=0;
        double segundo=0;
        double resultado=0;
            string operacion;
  
    
        public Form1()
        {
            InitializeComponent();
        }

        //Numeros

        private void btn0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }


        //Signos y Operaciones

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnEntre_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            operacion = "%";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "%":
                    resultado = primero % segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            
            string a = Pantalla.Text;
            a = a.Remove(a.Length - 1);
            Pantalla.Text = a;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!Pantalla.Text.Contains('.'))
            {
                Pantalla.Text = Pantalla.Text + ".";
            
            }

        }
    }
}
