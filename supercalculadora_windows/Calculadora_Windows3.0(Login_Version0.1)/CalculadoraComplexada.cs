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
    public partial class CalculadoraComplexada : Form
    {
        public CalculadoraComplexada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();

            this.Visible = false;
        }
    }
}
