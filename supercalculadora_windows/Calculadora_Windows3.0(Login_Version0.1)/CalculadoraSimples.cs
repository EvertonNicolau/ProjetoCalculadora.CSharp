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
    public partial class CalculadoraSimples : Form
    {
        decimal num1, num2, result;

        public CalculadoraSimples()
        {
            InitializeComponent();
        }       

        private void BotaoSomar_Click(object sender, EventArgs e)
        {
            if(Caixa_de_Texto1.Text != "" && Caixa_de_Texto2.Text != "")
            {
                Operador.Text = "+";
                num1 = decimal.Parse(Caixa_de_Texto1.Text, CultureInfo.InvariantCulture);
                num2 = decimal.Parse(Caixa_de_Texto2.Text, CultureInfo.InvariantCulture);
                result = num1 + num2;

                Resultado.Text = result.ToString();
            }
            
        }

        private void BotaoSubtrair_Click(object sender, EventArgs e)
        {
            if (Caixa_de_Texto1.Text != "" && Caixa_de_Texto2.Text != "")
            {
                Operador.Text = "-";
                num1 = decimal.Parse(Caixa_de_Texto1.Text, CultureInfo.InvariantCulture);
                num2 = decimal.Parse(Caixa_de_Texto2.Text, CultureInfo.InvariantCulture);
                result = num1 - num2;

                Resultado.Text = result.ToString();
            }
        }

        private void BotaoMultiplicar_Click(object sender, EventArgs e)
        {
            if (Caixa_de_Texto1.Text != "" && Caixa_de_Texto2.Text != "")
            {
                Operador.Text = "x";
                num1 = decimal.Parse(Caixa_de_Texto1.Text, CultureInfo.InvariantCulture);
                num2 = decimal.Parse(Caixa_de_Texto2.Text, CultureInfo.InvariantCulture);
                result = num1 * num2;

                Resultado.Text = result.ToString();
            }
        }

        private void BotaoDividir_Click(object sender, EventArgs e)
        {
            if (Caixa_de_Texto1.Text != "" && Caixa_de_Texto2.Text != "")
            {
                Operador.Text = "÷";
                num1 = decimal.Parse(Caixa_de_Texto1.Text, CultureInfo.InvariantCulture);
                num2 = decimal.Parse(Caixa_de_Texto2.Text, CultureInfo.InvariantCulture);
                result = num1 / num2;

                Resultado.Text = result.ToString();
            }
        }

        private void Caixa_de_Texto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Caixa_de_Texto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operador_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();

            this.Visible = false;
        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            Caixa_de_Texto1.Text = "";
            Caixa_de_Texto2.Text = "";
            Operador.Text = "?";
            Resultado.Text = "_";
        }
    }
}
