using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjetos
{
    public partial class frmEstrututaRepeticao : Form
    {
        public frmEstrututaRepeticao()
        {
            InitializeComponent();
        }

        private void ltbListaDeDesejos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Executando o método carrega combo
            carregaCombo();
        }
        public void carregaCombo() { 
        
            cbbEstado.Items.Clear();
            cbbEstado.Items.Add("Capão Redondo");
            cbbEstado.Items.Add("São Luiz");
            cbbEstado.Items.Add("Campo Grande");
            cbbEstado.Items.Add("Piraporinha");
            cbbEstado.Items.Add("Jardim Ângela");
            cbbEstado.Items.Add("Vila Remo");
            cbbEstado.Items.Add("Capelinha");
            cbbEstado.Items.Add("Campo Limpo");
            cbbEstado.Items.Add("Jardim Nakamura");
            cbbEstado.Items.Add("Jardim Icarai");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserirEstado_Click(object sender, EventArgs e)
        {
            ltbListaDeEstados.Text = txtInserirEstado.Text;
            
            
        }

        private void btnLimparEstado_Click(object sender, EventArgs e)
        {
            ltbListaDeEstados.Items.Clear();
        }

        private void btnLimpaItem_Click(object sender, EventArgs e)
        {
            ltbListaDeEstados.Items.RemoveAt(ltbListaDeEstados.SelectedIndex);
        }
    }
}
