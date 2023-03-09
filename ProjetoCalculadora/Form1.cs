using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        private decimal valor1 = 0, valor2 = 0;
        private string operacao;
        public Form1()
        {
            InitializeComponent();
        }
        // Numeros
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text += ".";
        }

        // Operacoes

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtCampoResultado.Text != "")
            {
                valor1 = decimal.Parse(txtCampoResultado.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                operacao = "SOMA";
                lblOperacao.Text = "+";
                txtCampoResultado.Text = "";
            }
            

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtCampoResultado.Text != "")
            {
                valor1 = decimal.Parse(txtCampoResultado.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
                txtCampoResultado.Text = "";
            }
            
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if(txtCampoResultado.Text != "")
            {
                valor1 = decimal.Parse(txtCampoResultado.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "*";
                txtCampoResultado.Text = "";
            }
            
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if(txtCampoResultado.Text != "")
            {
                valor1 = decimal.Parse(txtCampoResultado.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                operacao = "DIVISAO";
                lblOperacao.Text = "/";
                txtCampoResultado.Text = "";
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCampoResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            lblOperacao.Text = "";
        }

        
        private void btnResultado_Click(object sender, EventArgs e)
        {
            if ( txtCampoResultado.Text != "")
            {
                valor2 = decimal.Parse(txtCampoResultado.Text.Replace(",", "."), CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtCampoResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "SUBTRACAO")
                {
                    txtCampoResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULTIPLICACAO")
                {
                    txtCampoResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "DIVISAO")
                {
                    txtCampoResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
            


        }


    }
}
