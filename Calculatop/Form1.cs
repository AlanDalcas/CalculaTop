using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatop
{
   
   
    public partial class Form1 : Form
    {
         Calculadora calc = new Calculadora();
         public bool operador = false;
         public double valor1;
        string operacao;
        public Form1()
        {
            InitializeComponent();            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button1);
            operador = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button2);
            operador = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button3);
            operador = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button4);
            operador = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button5);
            operador = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button6);
            operador = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button7);
            operador = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button8);
            operador = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button9);
            operador = false;
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            operacao = "-";
            operador = true;
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " - ";
            }
            else
            {
               
                valor1 = valor1 - Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " - ";
            }
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = true;
            operacao = "*";
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " * ";
            }
            else if(valor1 == 0)
            {                
                valor1 = Convert.ToDouble(textBox1.Text);
                label1.Text = Convert.ToString(valor1) + " * ";
                textBox1.Text = "";
            }
            else
            {        
                valor1 = valor1 * Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " * ";
            }
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            operacao = "/";
            operador = true;
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " / ";
            }
            else if (textBox1.Text == "0")
            {
                MessageBox.Show("Não é possível fazer uma divisão por zero");
            }
            else if (valor1 == 0)
            {            
                valor1 = Convert.ToDouble(textBox1.Text);
                label1.Text = Convert.ToString(valor1) + " / ";
                textBox1.Text = "";
            }
            else
            {
                operacao = "/";
                valor1 = valor1 / Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " / ";
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            label1.Text = "";
            valor1 = 0;            
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
            {
                MessageBox.Show("Escolha a operação!");
            }
            else if(textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else if (operacao == "+")
            {
                operacao = "+";
                valor1 = valor1 + Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " + ";
            }else if(operacao == "-"){
                operacao = "-";
                valor1 = valor1 - Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " - ";
            }
            else if (operacao == "*")
            {
                operacao = "*";
                valor1 = valor1 * Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " * ";
            }
            else if (operacao == "/")
            {
                if (Convert.ToDouble(textBox1.Text) == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero");
                }
                else
                {
                    operacao = "/";
                    valor1 = valor1 / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    label1.Text = Convert.ToString(valor1) + " / ";
                }

            }

            else
            {
                MessageBox.Show("Erro muito louco");
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "" && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Digite um valor numérico para começar!");
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                    MessageBox.Show("este campo aceita somente numero e virgula");
                }
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                    MessageBox.Show("este campo aceita somente uma virgula");
                }                     
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + calc.adicionaNumero(button10);
            operador = false;
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            operacao = "+";
            operador = true;
           
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " + ";
            }
            else
            {
           
                valor1 = valor1 + Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label1.Text = Convert.ToString(valor1) + " + ";
            }

            /*
           var valor = calc.somaNumero(valor1, double.Parse(textBox1.Text));

           textBox1.Text = string.Empty;
           label1.Text = valor.ToString() + " + ";
           */

        }
    }
}
