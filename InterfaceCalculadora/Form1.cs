using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TesteTdd;

namespace InterfaceCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            var c = new Calculadora();
            int num1, num2;
            num1 = Convert.ToInt32(txtNumero1.Text);
            num2 = Convert.ToInt32(txtNumero2.Text);
            lblResultado.Text = c.Soma(num1,num2).ToString();
        }
    }
}
