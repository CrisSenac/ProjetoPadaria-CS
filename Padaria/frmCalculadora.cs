using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando variaveis
            //tipo de variavel e o nome da variavel

            //int valor1, valor4, resp;
            //double valor2;
            //float valor3;
            //bool flag;
            //string nome;
            //char sexo;

            //inicializar as variaveis
            //valor1 = 10;
            //valor4 = 10;

            // resp = valor1 + valor4;
            //declarando as variaveis
            //declarando as variaveis
            double num1, num2, resp = 0;

            try
            {
                //inicializar as variaveis
                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                Operacoes op = new Operacoes();

                if (
                    rdbSomar.Checked == false &&
                    rdbSubtrair.Checked == false &&
                    rdbMultiplicar.Checked == false &&
                    rdbDividir.Checked == false)


                if (rdbSomar.Checked)
                {
                        resp = op.somarValor(num1 , num2);
                }
                if (rdbSubtrair.Checked)
                {
                    resp = op.subtracaoValor(num1 , num2);
                }
                if (rdbMultiplicar.Checked)
                {
                    resp = op.multiplicacaoValor(num1 , num2);
                }
                if (rdbDividir.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossível dividir por zero",
                            "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);

                        resp = 0;
                    }
                    else
                    {
                        resp = num1 / num2;
                    }

                }
                txtResposta.Text = resp.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir somente números",
                    "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
            }


        }
        //criando o método limpar campos
        public void limparCampos()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executando método desabilitar e limpar
            limparCamposDesabilitar();

        }
        //limpar campos e desabilitar botões
        public void limparCamposDesabilitar()
        {
            //limpar os campos
            txtNumero1.Text = "";
            txtResposta.Clear();

            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //sair do sistema e encerrar todos os processos
            Application.Exit();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}