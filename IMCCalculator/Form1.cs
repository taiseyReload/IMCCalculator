﻿using System;
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
                lblResultado.Text = Math.Round(resultado, 2).ToString();

                // Organizar as classificações: 
                if (resultado <= 18.5 )
                {
                    lblClassificacao.ForeColor = Color.LightGreen;
                    lblClassificacao.Text = "Abaixo do Peso.";
                }
                else if (resultado > 18.5 && resultado <= 24.9)
                {
                    lblClassificacao.Text = "Peso Ideal(Parabéns)";
                }
                else if (resultado >24.9 && resultado <= 29.9)
                {
                    lblClassificacao.ForeColor = Color.DarkBlue;
                    lblClassificacao.Text = "Levemente Acima do Peso.";
                }
                else if (resultado > 29.9 && resultado <= 34.9)
                {
                    lblClassificacao.Text = "Obesidade Grau I";
                }
                else if (resultado > 34.9 && resultado <= 39.9)
                {
                    lblClassificacao.ForeColor = Color.OrangeRed;
                    lblClassificacao.Text = "Obesidade Grau II (Severa)";
                }
                else
                {
                    lblClassificacao.ForeColor = Color.Red;
                    lblClassificacao.Text = "Obesidade III (Mórbida)";
                }

                // Impedir que a altura ou peso colocado sejam "0":
                if (altura <= 0 || peso <= 0)
                {
                    txbPeso.Clear();
                    txbAltura.Clear();
                    lblClassificacao.Text = "";
                    lblResultado.Text = "";
                    MessageBox.Show("Altura ou Peso Inválidos!");
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
