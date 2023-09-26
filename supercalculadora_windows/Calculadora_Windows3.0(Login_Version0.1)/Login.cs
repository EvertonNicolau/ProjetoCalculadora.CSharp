using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Feito por Vinícius & Emerson

namespace Calculadora_Windows3._0_Login_Version0._1_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CaixaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaixaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CaixaUsuario.Text.Equals("everton nicolau") && CaixaSenha.Text.Equals("roane"))        {
                    var menu = new Menu();
                    menu.Show();

                    this.Visible = false;
                }

                else if (CaixaUsuario.Text.Equals("everton nicolau") && CaixaSenha.Text != ("roane") && CaixaSenha.Text != (""))
                {
                    MessageBox.Show("tem alguma coisa incorreta na sua senha, mano (a)" + MessageBoxButtons.OK);
                    CaixaSenha.Text = "";
                }

                else if (CaixaUsuario.Text.Equals("") && CaixaSenha.Text.Equals(""))
                {
                    MessageBox.Show("digite suas informações aí, por favor!" + MessageBoxButtons.OK);
                    CaixaUsuario.Text = "";
                    CaixaSenha.Text = "";
                }

                else
                {
                    MessageBox.Show("usuáre e senha incorretos" +  MessageBoxButtons.OK);
                    CaixaUsuario.Text = "";
                    CaixaSenha.Text = "";
                }
            }

            catch (Exception)
            {
                
            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
