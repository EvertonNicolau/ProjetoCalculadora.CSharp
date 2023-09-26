using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;



namespace Calculadora_Windows3._0_Login_Version0._1_
{
    public partial class Calculadora3 : Form
    {
        decimal valor1 = 0, valor2 = 0, result = 0;
        int ValorConvertido;
        string operacao = "";

        public Calculadora3()
        {
            InitializeComponent();
            CaixaDeTexto.Text = "0";
        }

        private void CaixaDeTexto_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void Btn0_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "0";
            }

            else
            {
                CaixaDeTexto.Text += "0";
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "1";
            }

            else
            {
                CaixaDeTexto.Text = "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "2";
            }

            else
            {
                CaixaDeTexto.Text += "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "3";
            }

            else
            {
                CaixaDeTexto.Text += "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "4";
            }

            else
            {
                CaixaDeTexto.Text += "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "5";
            }

            else
            {
                CaixaDeTexto.Text += "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "6";
            }

            else
            {
                CaixaDeTexto.Text += "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "7";
            }

            else
            {
                CaixaDeTexto.Text += "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "8";
            }

            else
            {
                CaixaDeTexto.Text += "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "9";
            }

            else
            {
                CaixaDeTexto.Text += "9";
            }
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {            

            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "0";
            }

            else
            {
                valor1 = decimal.Parse(CaixaDeTexto.Text, CultureInfo.InvariantCulture);
                CaixaDeTexto.Text = "0";
                operacao = "Soma";
                string num1 = valor1.ToString();
                Label.Text = num1 + " +";
            }
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "-";               
            }

            else
            {
                valor1 = decimal.Parse(CaixaDeTexto.Text, CultureInfo.InvariantCulture);
                CaixaDeTexto.Text = "0";
                operacao = "Subtracao";
                string num1 = valor1.ToString();
                Label.Text = num1 + " -";
            }
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "0";
            }

            else
            {
                valor1 = decimal.Parse(CaixaDeTexto.Text, CultureInfo.InvariantCulture);
                CaixaDeTexto.Text = "0";
                operacao = "Multiplicacao";
                string num1 = valor1.ToString();
                Label.Text = num1 + " x";
            }
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text == "0")
            {
                CaixaDeTexto.Text = "0";
            }

            else
            {
                valor1 = decimal.Parse(CaixaDeTexto.Text, CultureInfo.InvariantCulture);
                CaixaDeTexto.Text = "0";
                operacao = "Divisao";
                string num1 = valor1.ToString();
                Label.Text = num1 + " ÷";
            }
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            CaixaDeTexto.Text += ".";
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            Label.Text = "";
            valor2 = decimal.Parse(CaixaDeTexto.Text, CultureInfo.InvariantCulture);

            if (operacao == "Soma")
            {
                result = valor1 + valor2;

                if (result % 1 == 0)
                {
                    ValorConvertido = Convert.ToInt32(result);
                    CaixaDeTexto.Text = Convert.ToString(ValorConvertido);
                }

                else
                {
                    CaixaDeTexto.Text = Convert.ToString(result);
                }
            }

            else if (operacao == "Subtracao")
            {
                result = valor1 - valor2;

                if (result % 1 == 0)
                {
                    ValorConvertido = Convert.ToInt32(result);
                    CaixaDeTexto.Text = Convert.ToString(ValorConvertido);
                }

                else
                {
                    CaixaDeTexto.Text = Convert.ToString(result);
                }
            }

            else if (operacao == "Multiplicacao")
            {
                result = valor1 * valor2;

                if (result % 1 == 0)
                {
                    ValorConvertido = Convert.ToInt32(result);
                    CaixaDeTexto.Text = Convert.ToString(ValorConvertido);
                }

                else
                {
                    CaixaDeTexto.Text = Convert.ToString(result);
                }
            }

            else if (operacao == "Divisao")
            {
                result = valor1 / valor2;

                if (result % 1 == 0)
                {
                    ValorConvertido = Convert.ToInt32(result);
                    CaixaDeTexto.Text = Convert.ToString(ValorConvertido);
                }

                else
                {
                    CaixaDeTexto.Text = Convert.ToString(result);
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (CaixaDeTexto.Text.Length > 0)
            {
                CaixaDeTexto.Text = CaixaDeTexto.Text.Remove(CaixaDeTexto.Text.Length - 1);
            }

            if (CaixaDeTexto.Text == "")
            {
                CaixaDeTexto.Text = "0";
            }
        }

        private void BtnLimparTudo_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            CaixaDeTexto.Text = "0";
            Label.Text = "";
        }

        private void Calculadora3_Load(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();

            this.Visible = false;
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
    }
}
