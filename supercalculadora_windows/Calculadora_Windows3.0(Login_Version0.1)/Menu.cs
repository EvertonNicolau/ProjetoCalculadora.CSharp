using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Windows3._0_Login_Version0._1_
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Botao01_Click(object sender, EventArgs e)
        {
            var calculadora_basica = new CalculadoraSimples();
            calculadora_basica.Show();

            this.Visible = false;
        }

        private void Botao02_Click(object sender, EventArgs e)
        {
            var calculator3 = new Calculadora3();
            calculator3.Show();

            this.Visible = false;
        }

        private void Botao03_Click(object sender, EventArgs e)
        {
            var calculadoraorientada = new CalculadoraComplexada();
            calculadoraorientada.Show();
            this.Visible = false;
        }

        private void Botao04_Click(object sender, EventArgs e)
        {
            var loginMenu = new Login();
            loginMenu.Show();

            this.Visible = false;
        }

        private void Botao05_Click(object sender, EventArgs e)
        {
            var radio = new CalculadoraRadio();
            radio.Show();

            this.Visible = false;
        }
    }
}
