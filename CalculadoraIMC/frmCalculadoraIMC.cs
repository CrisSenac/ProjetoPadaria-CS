using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class frmCalculadoraIMC : Form
    {
        public frmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtResultado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, idade, resultado = 0;

            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);
            idade = Convert.ToDouble(txtIdade.Text);
            resultado = Convert.ToDouble(txtResultado.Text);

            if ()
            {

            }
          
            txtResultado.Text = resultado.ToString();


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
