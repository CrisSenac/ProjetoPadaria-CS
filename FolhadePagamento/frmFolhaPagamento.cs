using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            double num1, num2, resp;

            num1 = Convert.ToDouble(txbSalario.Text);
            num2 = Convert.ToDouble(txtImposto.Text);

            if (num1 <= 2259.20)
            {
                resp = num1
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbSalario.Text = "";
            ckbPlanoSaude.Text = "";
            cbxClube.Text = "";
            txbSalarioFolha.Text = "";
            txtImposto.Text = "";
            txbSalarioLiquido.Text = "";

           /* rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;

            txtNumero1.Focus(); */
        }

        private void txbSalario_TextChanged(object sender, EventArgs e)
        {
           txbSalarioFolha.Text = txbSalario.Text;
        }
    }
    }
//}
