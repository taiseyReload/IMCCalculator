using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaração de variáveis:
                double peso, altura, resultado;

                // Obter os valores dos txbs:
                peso = double.Parse(txbPeso.Text);
                altura = double.Parse(txbAltura.Text);
                resultado = peso / (altura * altura);

                // Obter e mostrar o IMC:
                lblResultado.Text = resultado.ToString();

                if ()
                {

                }
            }
            catch
            {
                MessageBox.Show("Dados inválidos informados!");
                txbPeso.Clear();
                txbAltura.Clear();
                lblClassificacao.Text = "";
                lblResultado.Text = "";
            }
        }
    }
}
