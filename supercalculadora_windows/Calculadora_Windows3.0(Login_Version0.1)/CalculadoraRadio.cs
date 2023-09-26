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
    public partial class CalculadoraRadio : Form
    {
        decimal num1, num2, result;

        public CalculadoraRadio()
        {
            InitializeComponent();
        }

        private void Caixa1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Caixa2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operacao_Click(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void Soma_CheckedChanged(object sender, EventArgs e)
        {
            Operacao.Text = "+";
            if(Result.Text != "_")
            {
                Result.Text = "_";
            }
        }

        private void Subtracao_CheckedChanged(object sender, EventArgs e)
        {
            Operacao.Text = "-";
            if (Result.Text != "_")
            {
                Result.Text = "_";
            }
        }

        private void Multiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            Operacao.Text = "x";
            if (Result.Text != "_")
            {
                Result.Text = "_";
            }
        }

        private void Divisao_CheckedChanged(object sender, EventArgs e)
        {
            Operacao.Text = "÷";
            if (Result.Text != "_")
            {
                Result.Text = "_";
            }
        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();

            this.Visible = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            Operacao.Text = "?";
            Result.Text = "_";
            Caixa1.Text = "";
            Caixa2.Text = "";
        }

        private void BotaoCalcular_Click(object sender, EventArgs e)
        {
            if(Caixa1.Text != "" && Caixa2.Text != "")
            {
                if(Operacao.Text == "+")
                {
                    num1 = decimal.Parse(Caixa1.Text, CultureInfo.InvariantCulture);
                    num2 = decimal.Parse(Caixa2.Text, CultureInfo.InvariantCulture);
                    result = num1 + num2;

                    Result.Text = result.ToString();
                }

                else if (Operacao.Text == "-")
                {
                    num1 = decimal.Parse(Caixa1.Text, CultureInfo.InvariantCulture);
                    num2 = decimal.Parse(Caixa2.Text, CultureInfo.InvariantCulture);
                    result = num1 - num2;

                    Result.Text = result.ToString();
                }

                else if (Operacao.Text == "x")
                {
                    num1 = decimal.Parse(Caixa1.Text, CultureInfo.InvariantCulture);
                    num2 = decimal.Parse(Caixa2.Text, CultureInfo.InvariantCulture);
                    result = num1 * num2;

                    Result.Text = result.ToString();
                }

                else if (Operacao.Text == "÷")
                {
                    num1 = decimal.Parse(Caixa1.Text, CultureInfo.InvariantCulture);
                    num2 = decimal.Parse(Caixa2.Text, CultureInfo.InvariantCulture);
                    result = num1 / num2;

                    Result.Text = result.ToString();
                }
            }
        }
    }
}
