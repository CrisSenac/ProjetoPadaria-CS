using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FolhadePagamento
{
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        private void dtpDataFolha_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, ir = 0;
            
            salario = Convert.ToDouble(txtSalario.Text);

            if ( salario <= 2259.20)
            {
                ir = 0;
                salario = salario - 0;
                

            } else if ( salario >= 2259.21 &&  salario <= 2826.65)
            {
                ir = salario * 7.5 / 100;
                salario = salario - ir;
                 
            } else if ( salario >= 2826.66 && salario <= 3751.05)
            {
                ir = salario * 15 / 100;
                salario = salario - ir;
                
            } else if ( salario >= 3751.06 && salario <= 4664.68)
            {
                ir = salario * 22.5 / 100;
                salario = salario - ir;
                
            } else if ( salario >= 4664.69)
            {
                ir = salario * 27.5 / 100;
                salario = salario - ir;
                
            }
            if (ckbPlanoSaude.Checked)
            {
                salario = salario - 400;
            }

            // verificar clube
            if (cbbClube.SelectedIndex == 0)
            {
                salario = salario - 100;
            }
            if (cbbClube.SelectedIndex == 1)
            {
                salario = salario - 50;
            }
            if (cbbClube.SelectedIndex == 2)
            {
                salario = salario - 30;
            }

            txtSalarioLiquido.Text = salario.ToString();
            txtImposto.Text = ir.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalario.Text = "";
            ckbPlanoSaude.Text = "";
            cbbClube.Text = "";
            txtSalarioFolha.Text = "";
            txtImposto.Text = "";
            txtSalarioLiquido.Text = "";

        }

        private void txbSalario_TextChanged(object sender, EventArgs e)
        {
           txtSalarioFolha.Text = txtSalario.Text;
        }
    }
    }
//}
