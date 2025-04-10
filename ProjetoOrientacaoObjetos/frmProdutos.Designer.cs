namespace ProjetoOrientacaoObjetos
{
    partial class frmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.lblSaida = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoR = new System.Windows.Forms.Label();
            this.txtCodiReg = new System.Windows.Forms.TextBox();
            this.txtQuantReg = new System.Windows.Forms.TextBox();
            this.lblQuantidadeR = new System.Windows.Forms.Label();
            this.txtDescReg = new System.Windows.Forms.TextBox();
            this.lblDescricaoR = new System.Windows.Forms.Label();
            this.txtTotReg = new System.Windows.Forms.TextBox();
            this.lblTotalReg = new System.Windows.Forms.Label();
            this.txtValorReg = new System.Windows.Forms.TextBox();
            this.lblValorReg = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(271, 51);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(491, 26);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(185, 54);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 10;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(90, 51);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(72, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 54);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(379, 104);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(93, 26);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(267, 107);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(105, 20);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Valor Unitário";
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(25, 107);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 18;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(133, 104);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(72, 26);
            this.txtQuantidade.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(574, 110);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(637, 107);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 4;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(7, 247);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(127, 20);
            this.lblEntrada.TabIndex = 22;
            this.lblEntrada.Text = "Data de Entrada";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(140, 242);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(118, 26);
            this.dtpEntrada.TabIndex = 5;
            this.dtpEntrada.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpSaida
            // 
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaida.Location = new System.Drawing.Point(140, 288);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(118, 26);
            this.dtpSaida.TabIndex = 6;
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(7, 288);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(111, 20);
            this.lblSaida.TabIndex = 24;
            this.lblSaida.Text = "Data de Saída";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(640, 224);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(122, 81);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(640, 343);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 81);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(640, 450);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 81);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotReg);
            this.groupBox1.Controls.Add(this.lblTotalReg);
            this.groupBox1.Controls.Add(this.txtValorReg);
            this.groupBox1.Controls.Add(this.lblValorReg);
            this.groupBox1.Controls.Add(this.dtpSaida);
            this.groupBox1.Controls.Add(this.txtDescReg);
            this.groupBox1.Controls.Add(this.lblSaida);
            this.groupBox1.Controls.Add(this.dtpEntrada);
            this.groupBox1.Controls.Add(this.lblDescricaoR);
            this.groupBox1.Controls.Add(this.lblEntrada);
            this.groupBox1.Controls.Add(this.txtQuantReg);
            this.groupBox1.Controls.Add(this.lblQuantidadeR);
            this.groupBox1.Controls.Add(this.txtCodiReg);
            this.groupBox1.Controls.Add(this.lblCodigoR);
            this.groupBox1.Location = new System.Drawing.Point(31, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 327);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores Registrados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCodigoR
            // 
            this.lblCodigoR.AutoSize = true;
            this.lblCodigoR.Location = new System.Drawing.Point(19, 32);
            this.lblCodigoR.Name = "lblCodigoR";
            this.lblCodigoR.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoR.TabIndex = 0;
            this.lblCodigoR.Text = "Código";
            // 
            // txtCodiReg
            // 
            this.txtCodiReg.Enabled = false;
            this.txtCodiReg.Location = new System.Drawing.Point(140, 25);
            this.txtCodiReg.Name = "txtCodiReg";
            this.txtCodiReg.Size = new System.Drawing.Size(100, 26);
            this.txtCodiReg.TabIndex = 1;
            // 
            // txtQuantReg
            // 
            this.txtQuantReg.Enabled = false;
            this.txtQuantReg.Location = new System.Drawing.Point(140, 110);
            this.txtQuantReg.Name = "txtQuantReg";
            this.txtQuantReg.Size = new System.Drawing.Size(107, 26);
            this.txtQuantReg.TabIndex = 3;
            this.txtQuantReg.TextChanged += new System.EventHandler(this.txtQuantReg_TextChanged);
            // 
            // lblQuantidadeR
            // 
            this.lblQuantidadeR.AutoSize = true;
            this.lblQuantidadeR.Location = new System.Drawing.Point(15, 116);
            this.lblQuantidadeR.Name = "lblQuantidadeR";
            this.lblQuantidadeR.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidadeR.TabIndex = 2;
            this.lblQuantidadeR.Text = "Quantidade";
            // 
            // txtDescReg
            // 
            this.txtDescReg.Enabled = false;
            this.txtDescReg.Location = new System.Drawing.Point(140, 69);
            this.txtDescReg.MaxLength = 50;
            this.txtDescReg.Name = "txtDescReg";
            this.txtDescReg.Size = new System.Drawing.Size(423, 26);
            this.txtDescReg.TabIndex = 11;
            // 
            // lblDescricaoR
            // 
            this.lblDescricaoR.AutoSize = true;
            this.lblDescricaoR.Location = new System.Drawing.Point(16, 75);
            this.lblDescricaoR.Name = "lblDescricaoR";
            this.lblDescricaoR.Size = new System.Drawing.Size(80, 20);
            this.lblDescricaoR.TabIndex = 12;
            this.lblDescricaoR.Text = "Descrição";
            // 
            // txtTotReg
            // 
            this.txtTotReg.Enabled = false;
            this.txtTotReg.Location = new System.Drawing.Point(138, 201);
            this.txtTotReg.MaxLength = 10;
            this.txtTotReg.Name = "txtTotReg";
            this.txtTotReg.Size = new System.Drawing.Size(107, 26);
            this.txtTotReg.TabIndex = 22;
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.Location = new System.Drawing.Point(13, 201);
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(85, 20);
            this.lblTotalReg.TabIndex = 24;
            this.lblTotalReg.Text = "Valor Total";
            // 
            // txtValorReg
            // 
            this.txtValorReg.Enabled = false;
            this.txtValorReg.Location = new System.Drawing.Point(138, 157);
            this.txtValorReg.MaxLength = 10;
            this.txtValorReg.Name = "txtValorReg";
            this.txtValorReg.Size = new System.Drawing.Size(107, 26);
            this.txtValorReg.TabIndex = 21;
            // 
            // lblValorReg
            // 
            this.lblValorReg.AutoSize = true;
            this.lblValorReg.Location = new System.Drawing.Point(11, 160);
            this.lblValorReg.Name = "lblValorReg";
            this.lblValorReg.Size = new System.Drawing.Size(105, 20);
            this.lblValorReg.TabIndex = 23;
            this.lblValorReg.Text = "Valor Unitário";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(516, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 26);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Data de Saída";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(160, 162);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 26);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Data de Entrada";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigoR;
        private System.Windows.Forms.TextBox txtDescReg;
        private System.Windows.Forms.Label lblDescricaoR;
        private System.Windows.Forms.TextBox txtQuantReg;
        private System.Windows.Forms.Label lblQuantidadeR;
        private System.Windows.Forms.TextBox txtCodiReg;
        private System.Windows.Forms.TextBox txtTotReg;
        private System.Windows.Forms.Label lblTotalReg;
        private System.Windows.Forms.TextBox txtValorReg;
        private System.Windows.Forms.Label lblValorReg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
    }
}